using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace HostEditor
{
    public partial class MainForm : Form
    {
        HostEditor editor = new HostEditor();
        WebRequest request;
        WebResponse response;



        public MainForm()
        {
            InitializeComponent();
            UpdateDataFromList();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIndexIsValid())
            {
                Adress_textBox.Text = editor.GetItems()[listBox.SelectedIndex].IPAdress;  // GetItems[listBox.SelectedIndex].IP;
                Name_textBox.Text = editor.GetItems()[listBox.SelectedIndex].HostName;

                if (Auto_checkBox.Checked)
                {
                    if (IsActive())
                        Connection_pictureBox.BackColor = System.Drawing.Color.Lime;
                    else
                        Connection_pictureBox.BackColor = System.Drawing.Color.Red;
                }
                else Connection_pictureBox.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            editor.UpdateListsFromFile();
            UpdateDataFromList();
        }

        private void UpdateDataFromList()
        {
            listBox.Items.Clear();
            foreach (Item item in editor.GetItems())
            {
                listBox.Items.Add((listBox.Items.Count + 1) + ". "+ item.ToString());
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (SelectedIndexIsValid())
                editor.RemoveItemAt(listBox.SelectedIndex);
            UpdateDataFromList();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Item temp = new Item
            (
                ip: Adress_textBox.Text,
                host: Name_textBox.Text
            );
            editor.AddItem(temp);
            ClearTextBoxes();
            UpdateDataFromList();
        }

        private void ClearTextBoxes()
        {
            Adress_textBox.Text = "";
            Name_textBox.Text = "";
        }

        private bool SelectedIndexIsValid()
        {
            if (listBox.SelectedIndex >= 0 && listBox.SelectedIndex < listBox.Items.Count)
                return true;
            return false;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            editor.SaveToFile();
        }

        private void Request_button_Click(object sender, EventArgs e)
        {
            if (IsActive())
                MessageBox.Show("OK");
            else MessageBox.Show("No connection");
        }

        private bool IsActive()
        {
            if (SelectedIndexIsValid())
            {
                string HostName;
                if (editor.IsContainsHost(Name_textBox.Text))
                    HostName = editor.NormalizeURL(Name_textBox.Text);
                else 
                    return false;

                try
                {
                    request = WebRequest.Create(HostName);
                    response = request.GetResponse();
                    response.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }

        private void About_toolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("https://github.com/qlulp");
        }

        private void Save_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.SaveToFile();
        }

        private void CopyPath_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(editor.Path);
        }
    }
}
