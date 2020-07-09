using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Net;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HostEditor
{
    class HostEditor
    {
        private List<string> FileList { get; set; } // Файл по пути path
        private List<Item> Items { get; set; } // Элементы с IP и хостом

        readonly Regex ipAdressPattern = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b"); // Регулярное выражение для нахождения IP
        readonly Regex HostNamePattern = new Regex(@"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$");
        public string Path { get; set; } // Путь
        public HostEditor(string path = @"C:\Windows\System32\drivers\etc\hosts")
        {
            FileList = new List<string>();
            Items = new List<Item>();
            Path = path;

            UpdateListsFromFile();
        }

        public void UpdateListsFromFile()
        {
            FileList.Clear();
            FileList = File.ReadAllLines(Path).ToList();
            Items.Clear();
            Items = FindItems();
        }

        public List<string> GetFileList() // Получить лист файла
        {
            return FileList;
        }

        public List<Item> GetItems() // Получить элементы
        {
            return Items;
        }

        private List<Item> FindItems() // Получить отфильтроваванный список элементов
        {
            List<Item> ItemsList = new List<Item>();
            foreach (string str in FileList)
                if (!str.StartsWith("#") && IsContainsIp(str))
                {
                    string ip = GetIp(str); // ip в строке
                    string host = str.Replace(ip, "").Replace(" ", ""); // хост в той же строке
                    ItemsList.Add(new Item(ip, host));
                }
            return ItemsList;
        }

        public bool IsContainsIp(string str)
        {
            if (ipAdressPattern.IsMatch(str))
                return true;
            return false;
        }

        public bool IsContainsHost(string str)
        {
            if (HostNamePattern.IsMatch(str))
                return true;
            return false;
        }

        public string GetIp(string str) // Получить первый попавшийся IP из строки
        {
            return ipAdressPattern.Matches(str)[0].Value;
        }

        public void SaveToFile() // Запись в файл
        {
            string temp = "";
            foreach (Item item in Items)
                temp += item.IPAdress + " " + item.HostName + "\n";
            File.WriteAllText(Path, temp);
        }

        public Item GetItemAt(int index)
        {
            if (index >= 0 && index < Items.Count)
                return Items[index];
            return new Item(null, null);
        }

        public void AddItem(Item item) // Добавить элемент
        {
            string defaultIp = "127.0.0.1";
            if (!Exists(item))
            {
                if (!IsContainsIp(item.IPAdress))
                    item.IPAdress = defaultIp;
                if (IsContainsHost(item.HostName))
                    Items.Add(item);
                else
                    MessageBox.Show("Uncorrect data!");
            }
            else
                MessageBox.Show(item.ToString() + " is already exists!");
        }

        public bool Exists(Item item) // Существует ли такой же элемент
        {
            foreach (Item itm in Items)
                if (itm.ToString() == item.ToString())
                    return true;
            return false;
        }

        public void RemoveItemAt(int index)
        {
            Items.RemoveAt(index);
        }

        public string NormalizeURL(string url)
        {
            if (!IsContainsProtocol(url))
                url = "http://" + url;
            return url;
        }

        public bool IsContainsProtocol(string url)
        {
            if (url.ToLower().StartsWith("http://") || url.ToLower().StartsWith("https://"))
                return true;
            return false;
        }
    }
}
