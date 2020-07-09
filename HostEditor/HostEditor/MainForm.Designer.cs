namespace HostEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Name_label = new System.Windows.Forms.Label();
            this.Adress_label = new System.Windows.Forms.Label();
            this.Adress_textBox = new System.Windows.Forms.TextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.Request_button = new System.Windows.Forms.Button();
            this.Status_label = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.Auto_checkBox = new System.Windows.Forms.CheckBox();
            this.Connection_pictureBox = new System.Windows.Forms.PictureBox();
            this.Connection_groupBox = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Open_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyPath_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.File_toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.About_toolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.Connection_pictureBox)).BeginInit();
            this.Connection_groupBox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name_textBox
            // 
            this.Name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_textBox.Location = new System.Drawing.Point(394, 49);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(167, 20);
            this.Name_textBox.TabIndex = 1;
            // 
            // Name_label
            // 
            this.Name_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(349, 51);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(38, 13);
            this.Name_label.TabIndex = 2;
            this.Name_label.Text = "Name:";
            // 
            // Adress_label
            // 
            this.Adress_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Adress_label.AutoSize = true;
            this.Adress_label.Location = new System.Drawing.Point(349, 28);
            this.Adress_label.Name = "Adress_label";
            this.Adress_label.Size = new System.Drawing.Size(42, 13);
            this.Adress_label.TabIndex = 4;
            this.Adress_label.Text = "Adress:";
            // 
            // Adress_textBox
            // 
            this.Adress_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Adress_textBox.Location = new System.Drawing.Point(394, 26);
            this.Adress_textBox.Name = "Adress_textBox";
            this.Adress_textBox.Size = new System.Drawing.Size(167, 20);
            this.Adress_textBox.TabIndex = 3;
            // 
            // Save_button
            // 
            this.Save_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_button.Location = new System.Drawing.Point(355, 187);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(100, 26);
            this.Save_button.TabIndex = 9;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_button.Location = new System.Drawing.Point(428, 155);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(63, 26);
            this.Add_button.TabIndex = 10;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_button.Location = new System.Drawing.Point(355, 155);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(63, 26);
            this.Delete_button.TabIndex = 11;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Update_button.Location = new System.Drawing.Point(498, 155);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(63, 26);
            this.Update_button.TabIndex = 13;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 28);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(332, 186);
            this.listBox.TabIndex = 14;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // Request_button
            // 
            this.Request_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Request_button.Location = new System.Drawing.Point(461, 187);
            this.Request_button.Name = "Request_button";
            this.Request_button.Size = new System.Drawing.Size(100, 26);
            this.Request_button.TabIndex = 15;
            this.Request_button.Text = "Request";
            this.Request_button.UseVisualStyleBackColor = true;
            this.Request_button.Click += new System.EventHandler(this.Request_button_Click);
            // 
            // Status_label
            // 
            this.Status_label.AutoSize = true;
            this.Status_label.Location = new System.Drawing.Point(6, 50);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(40, 13);
            this.Status_label.TabIndex = 16;
            this.Status_label.Text = "Status:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(164, 13);
            this.label.TabIndex = 17;
            this.label.Text = "Check connection automatically: ";
            // 
            // Auto_checkBox
            // 
            this.Auto_checkBox.AutoSize = true;
            this.Auto_checkBox.Location = new System.Drawing.Point(170, 25);
            this.Auto_checkBox.Name = "Auto_checkBox";
            this.Auto_checkBox.Size = new System.Drawing.Size(15, 14);
            this.Auto_checkBox.TabIndex = 18;
            this.Auto_checkBox.UseVisualStyleBackColor = true;
            // 
            // Connection_pictureBox
            // 
            this.Connection_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Connection_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Connection_pictureBox.Location = new System.Drawing.Point(52, 50);
            this.Connection_pictureBox.Name = "Connection_pictureBox";
            this.Connection_pictureBox.Size = new System.Drawing.Size(15, 15);
            this.Connection_pictureBox.TabIndex = 19;
            this.Connection_pictureBox.TabStop = false;
            // 
            // Connection_groupBox
            // 
            this.Connection_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Connection_groupBox.Controls.Add(this.label);
            this.Connection_groupBox.Controls.Add(this.Connection_pictureBox);
            this.Connection_groupBox.Controls.Add(this.Status_label);
            this.Connection_groupBox.Controls.Add(this.Auto_checkBox);
            this.Connection_groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connection_groupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Connection_groupBox.Location = new System.Drawing.Point(355, 75);
            this.Connection_groupBox.Name = "Connection_groupBox";
            this.Connection_groupBox.Size = new System.Drawing.Size(206, 74);
            this.Connection_groupBox.TabIndex = 20;
            this.Connection_groupBox.TabStop = false;
            this.Connection_groupBox.Text = "Connection";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_toolStripDropDownButton1,
            this.About_toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(569, 25);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Open_ToolStripMenuItem
            // 
            this.Open_ToolStripMenuItem.Name = "Open_ToolStripMenuItem";
            this.Open_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Open_ToolStripMenuItem.Text = "Open";
            // 
            // Save_ToolStripMenuItem
            // 
            this.Save_ToolStripMenuItem.Name = "Save_ToolStripMenuItem";
            this.Save_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Save_ToolStripMenuItem.Text = "Save";
            this.Save_ToolStripMenuItem.Click += new System.EventHandler(this.Save_ToolStripMenuItem_Click);
            // 
            // CopyPath_ToolStripMenuItem
            // 
            this.CopyPath_ToolStripMenuItem.Name = "CopyPath_ToolStripMenuItem";
            this.CopyPath_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CopyPath_ToolStripMenuItem.Text = "Copy path";
            this.CopyPath_ToolStripMenuItem.Click += new System.EventHandler(this.CopyPath_ToolStripMenuItem_Click);
            // 
            // File_toolStripDropDownButton1
            // 
            this.File_toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.File_toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_ToolStripMenuItem,
            this.Save_ToolStripMenuItem,
            this.CopyPath_ToolStripMenuItem});
            this.File_toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("File_toolStripDropDownButton1.Image")));
            this.File_toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.File_toolStripDropDownButton1.Name = "File_toolStripDropDownButton1";
            this.File_toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.File_toolStripDropDownButton1.Text = "File";
            // 
            // About_toolStripButton
            // 
            this.About_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.About_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("About_toolStripButton.Image")));
            this.About_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.About_toolStripButton.Name = "About_toolStripButton";
            this.About_toolStripButton.Size = new System.Drawing.Size(44, 22);
            this.About_toolStripButton.Text = "About";
            this.About_toolStripButton.Click += new System.EventHandler(this.About_toolStripButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(569, 221);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Connection_groupBox);
            this.Controls.Add(this.Request_button);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Adress_label);
            this.Controls.Add(this.Adress_textBox);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(560, 250);
            this.Name = "MainForm";
            this.Text = "HostEditor: Black List";
            ((System.ComponentModel.ISupportInitialize)(this.Connection_pictureBox)).EndInit();
            this.Connection_groupBox.ResumeLayout(false);
            this.Connection_groupBox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Adress_label;
        private System.Windows.Forms.TextBox Adress_textBox;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button Request_button;
        private System.Windows.Forms.Label Status_label;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox Auto_checkBox;
        private System.Windows.Forms.PictureBox Connection_pictureBox;
        private System.Windows.Forms.GroupBox Connection_groupBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton File_toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem Open_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyPath_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton About_toolStripButton;
    }
}

