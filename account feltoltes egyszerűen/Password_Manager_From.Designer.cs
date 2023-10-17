namespace account_feltoltes_egyszerűen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.pathnev = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mappanev = new System.Windows.Forms.TextBox();
            this.buttonCreateFolder = new System.Windows.Forms.Button();
            this.listBoxFolderContents = new System.Windows.Forms.ListBox();
            this.buttonGdrive = new System.Windows.Forms.Button();
            this.pathnev2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refresh_textbox = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.fileContentTextBox = new System.Windows.Forms.TextBox();
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCreateFile = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.password1 = new System.Windows.Forms.TextBox();
            this.password2 = new System.Windows.Forms.TextBox();
            this.password3 = new System.Windows.Forms.TextBox();
            this.password4 = new System.Windows.Forms.TextBox();
            this.password5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.generaterpassword_button = new System.Windows.Forms.Button();
            this.lenght_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.uppercase_checkbox = new System.Windows.Forms.CheckBox();
            this.lowercase_checkBox = new System.Windows.Forms.CheckBox();
            this.numbers_checkBox = new System.Windows.Forms.CheckBox();
            this.specialchar_checkBox = new System.Windows.Forms.CheckBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listView_folderContents = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lenght_numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(7, 56);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(124, 28);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Válassz";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // pathnev
            // 
            this.pathnev.AutoSize = true;
            this.pathnev.BackColor = System.Drawing.Color.Transparent;
            this.pathnev.ForeColor = System.Drawing.Color.Black;
            this.pathnev.Location = new System.Drawing.Point(139, 28);
            this.pathnev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathnev.Name = "pathnev";
            this.pathnev.Size = new System.Drawing.Size(55, 16);
            this.pathnev.TabIndex = 2;
            this.pathnev.Text = "pathnev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mappa név: ";
            // 
            // mappanev
            // 
            this.mappanev.Location = new System.Drawing.Point(115, 22);
            this.mappanev.Margin = new System.Windows.Forms.Padding(4);
            this.mappanev.Name = "mappanev";
            this.mappanev.Size = new System.Drawing.Size(78, 22);
            this.mappanev.TabIndex = 4;
            this.mappanev.Text = "mappanev";
            // 
            // buttonCreateFolder
            // 
            this.buttonCreateFolder.Location = new System.Drawing.Point(47, 52);
            this.buttonCreateFolder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateFolder.Name = "buttonCreateFolder";
            this.buttonCreateFolder.Size = new System.Drawing.Size(151, 28);
            this.buttonCreateFolder.TabIndex = 6;
            this.buttonCreateFolder.Text = "Mappa létrehozása";
            this.buttonCreateFolder.UseVisualStyleBackColor = true;
            this.buttonCreateFolder.Click += new System.EventHandler(this.buttonCreateFolder_Click);
            // 
            // listBoxFolderContents
            // 
            this.listBoxFolderContents.FormattingEnabled = true;
            this.listBoxFolderContents.ItemHeight = 16;
            this.listBoxFolderContents.Location = new System.Drawing.Point(7, 22);
            this.listBoxFolderContents.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFolderContents.Name = "listBoxFolderContents";
            this.listBoxFolderContents.Size = new System.Drawing.Size(301, 484);
            this.listBoxFolderContents.TabIndex = 8;
            // 
            // buttonGdrive
            // 
            this.buttonGdrive.Location = new System.Drawing.Point(7, 22);
            this.buttonGdrive.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGdrive.Name = "buttonGdrive";
            this.buttonGdrive.Size = new System.Drawing.Size(124, 28);
            this.buttonGdrive.TabIndex = 9;
            this.buttonGdrive.Text = "G:\\ kiválasztása";
            this.buttonGdrive.UseVisualStyleBackColor = true;
            this.buttonGdrive.Click += new System.EventHandler(this.button1_Click);
            // 
            // pathnev2
            // 
            this.pathnev2.AutoSize = true;
            this.pathnev2.Location = new System.Drawing.Point(140, 62);
            this.pathnev2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathnev2.Name = "pathnev2";
            this.pathnev2.Size = new System.Drawing.Size(62, 16);
            this.pathnev2.TabIndex = 10;
            this.pathnev2.Text = "pathnev2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refresh_textbox);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.fileContentTextBox);
            this.groupBox1.Controls.Add(this.LoadFileButton);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.buttonCreateFile);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(13, 225);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(449, 382);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A file tartalma:";
            // 
            // refresh_textbox
            // 
            this.refresh_textbox.Location = new System.Drawing.Point(181, 169);
            this.refresh_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.refresh_textbox.Name = "refresh_textbox";
            this.refresh_textbox.Size = new System.Drawing.Size(76, 28);
            this.refresh_textbox.TabIndex = 23;
            this.refresh_textbox.Text = "Refresh";
            this.refresh_textbox.UseVisualStyleBackColor = true;
            this.refresh_textbox.Click += new System.EventHandler(this.refresh_textbox_Click_1);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(99, 132);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(165, 28);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "File mentése";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "A megnyitott file tartalma:";
            // 
            // fileContentTextBox
            // 
            this.fileContentTextBox.Location = new System.Drawing.Point(7, 220);
            this.fileContentTextBox.Multiline = true;
            this.fileContentTextBox.Name = "fileContentTextBox";
            this.fileContentTextBox.Size = new System.Drawing.Size(408, 155);
            this.fileContentTextBox.TabIndex = 20;
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Location = new System.Drawing.Point(8, 169);
            this.LoadFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(165, 28);
            this.LoadFileButton.TabIndex = 19;
            this.LoadFileButton.Text = "File lekérdezése";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(103, 102);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(328, 22);
            this.password.TabIndex = 18;
            this.password.Text = "password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Password:";
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.Location = new System.Drawing.Point(266, 132);
            this.buttonCreateFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(165, 28);
            this.buttonCreateFile.TabIndex = 13;
            this.buttonCreateFile.Text = "File létrehozása";
            this.buttonCreateFile.UseVisualStyleBackColor = true;
            this.buttonCreateFile.Click += new System.EventHandler(this.buttonCreateFile_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(103, 66);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(328, 22);
            this.username.TabIndex = 16;
            this.username.Text = "username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Username: ";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(103, 34);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(328, 22);
            this.email.TabIndex = 14;
            this.email.Text = "email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 13;
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(8, 218);
            this.password1.Margin = new System.Windows.Forms.Padding(4);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(261, 22);
            this.password1.TabIndex = 14;
            this.password1.Text = "password1";
            // 
            // password2
            // 
            this.password2.Location = new System.Drawing.Point(8, 250);
            this.password2.Margin = new System.Windows.Forms.Padding(4);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(261, 22);
            this.password2.TabIndex = 15;
            this.password2.Text = "password2";
            // 
            // password3
            // 
            this.password3.Location = new System.Drawing.Point(8, 282);
            this.password3.Margin = new System.Windows.Forms.Padding(4);
            this.password3.Name = "password3";
            this.password3.Size = new System.Drawing.Size(261, 22);
            this.password3.TabIndex = 16;
            this.password3.Text = "password3";
            // 
            // password4
            // 
            this.password4.Location = new System.Drawing.Point(8, 314);
            this.password4.Margin = new System.Windows.Forms.Padding(4);
            this.password4.Name = "password4";
            this.password4.Size = new System.Drawing.Size(261, 22);
            this.password4.TabIndex = 17;
            this.password4.Text = "password4";
            // 
            // password5
            // 
            this.password5.Location = new System.Drawing.Point(8, 346);
            this.password5.Margin = new System.Windows.Forms.Padding(4);
            this.password5.Name = "password5";
            this.password5.Size = new System.Drawing.Size(261, 22);
            this.password5.TabIndex = 18;
            this.password5.Text = "password5";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 215);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 19;
            this.button2.Text = "Use this";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(279, 247);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 20;
            this.button3.Text = "Use this";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(279, 279);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 21;
            this.button4.Text = "Use this";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(279, 311);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 22;
            this.button5.Text = "Use this";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(279, 343);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 23;
            this.button6.Text = "Use this";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Length:";
            // 
            // generaterpassword_button
            // 
            this.generaterpassword_button.Location = new System.Drawing.Point(8, 180);
            this.generaterpassword_button.Margin = new System.Windows.Forms.Padding(4);
            this.generaterpassword_button.Name = "generaterpassword_button";
            this.generaterpassword_button.Size = new System.Drawing.Size(211, 28);
            this.generaterpassword_button.TabIndex = 30;
            this.generaterpassword_button.Text = "Generate passwords";
            this.generaterpassword_button.UseVisualStyleBackColor = true;
            this.generaterpassword_button.Click += new System.EventHandler(this.generaterpassword_button_Click);
            // 
            // lenght_numericUpDown1
            // 
            this.lenght_numericUpDown1.Location = new System.Drawing.Point(69, 30);
            this.lenght_numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.lenght_numericUpDown1.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.lenght_numericUpDown1.Name = "lenght_numericUpDown1";
            this.lenght_numericUpDown1.Size = new System.Drawing.Size(56, 22);
            this.lenght_numericUpDown1.TabIndex = 31;
            this.lenght_numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Min:20 Max:100";
            // 
            // uppercase_checkbox
            // 
            this.uppercase_checkbox.AutoSize = true;
            this.uppercase_checkbox.Location = new System.Drawing.Point(9, 60);
            this.uppercase_checkbox.Margin = new System.Windows.Forms.Padding(4);
            this.uppercase_checkbox.Name = "uppercase_checkbox";
            this.uppercase_checkbox.Size = new System.Drawing.Size(133, 20);
            this.uppercase_checkbox.TabIndex = 33;
            this.uppercase_checkbox.Text = "Uppercase letters";
            this.uppercase_checkbox.UseVisualStyleBackColor = true;
            // 
            // lowercase_checkBox
            // 
            this.lowercase_checkBox.AutoSize = true;
            this.lowercase_checkBox.Location = new System.Drawing.Point(9, 89);
            this.lowercase_checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.lowercase_checkBox.Name = "lowercase_checkBox";
            this.lowercase_checkBox.Size = new System.Drawing.Size(131, 20);
            this.lowercase_checkBox.TabIndex = 34;
            this.lowercase_checkBox.Text = "Lowercase letters";
            this.lowercase_checkBox.UseVisualStyleBackColor = true;
            // 
            // numbers_checkBox
            // 
            this.numbers_checkBox.AutoSize = true;
            this.numbers_checkBox.Location = new System.Drawing.Point(9, 117);
            this.numbers_checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.numbers_checkBox.Name = "numbers_checkBox";
            this.numbers_checkBox.Size = new System.Drawing.Size(81, 20);
            this.numbers_checkBox.TabIndex = 35;
            this.numbers_checkBox.Text = "Numbers";
            this.numbers_checkBox.UseVisualStyleBackColor = true;
            // 
            // specialchar_checkBox
            // 
            this.specialchar_checkBox.AutoSize = true;
            this.specialchar_checkBox.Location = new System.Drawing.Point(9, 145);
            this.specialchar_checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.specialchar_checkBox.Name = "specialchar_checkBox";
            this.specialchar_checkBox.Size = new System.Drawing.Size(138, 20);
            this.specialchar_checkBox.TabIndex = 36;
            this.specialchar_checkBox.Text = "Special characters";
            this.specialchar_checkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.generaterpassword_button);
            this.groupBox2.Controls.Add(this.specialchar_checkBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numbers_checkBox);
            this.groupBox2.Controls.Add(this.password1);
            this.groupBox2.Controls.Add(this.lowercase_checkBox);
            this.groupBox2.Controls.Add(this.password2);
            this.groupBox2.Controls.Add(this.uppercase_checkbox);
            this.groupBox2.Controls.Add(this.password3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.password4);
            this.groupBox2.Controls.Add(this.lenght_numericUpDown1);
            this.groupBox2.Controls.Add(this.password5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(470, 225);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(388, 383);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate Password:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonGdrive);
            this.groupBox3.Controls.Add(this.buttonBrowse);
            this.groupBox3.Controls.Add(this.pathnev);
            this.groupBox3.Controls.Add(this.pathnev2);
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(604, 100);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Path:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mappanev);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.buttonCreateFolder);
            this.groupBox4.Location = new System.Drawing.Point(12, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mappa létrehozása:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listView_folderContents);
            this.groupBox5.Controls.Add(this.listBoxFolderContents);
            this.groupBox5.Location = new System.Drawing.Point(875, 95);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(313, 513);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "A megnyitott mappa tartalma::";
            // 
            // listView_folderContents
            // 
            this.listView_folderContents.HideSelection = false;
            this.listView_folderContents.Location = new System.Drawing.Point(7, 22);
            this.listView_folderContents.Name = "listView_folderContents";
            this.listView_folderContents.Size = new System.Drawing.Size(301, 484);
            this.listView_folderContents.TabIndex = 23;
            this.listView_folderContents.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1193, 613);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "PASSWORD MANAGER v.1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lenght_numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label pathnev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mappanev;
        private System.Windows.Forms.Button buttonCreateFolder;
        private System.Windows.Forms.ListBox listBoxFolderContents;
        private System.Windows.Forms.Button buttonGdrive;
        private System.Windows.Forms.Label pathnev2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCreateFile;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.TextBox password3;
        private System.Windows.Forms.TextBox password4;
        private System.Windows.Forms.TextBox password5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button generaterpassword_button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown lenght_numericUpDown1;
        private System.Windows.Forms.CheckBox uppercase_checkbox;
        private System.Windows.Forms.CheckBox lowercase_checkBox;
        private System.Windows.Forms.CheckBox numbers_checkBox;
        private System.Windows.Forms.CheckBox specialchar_checkBox;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fileContentTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button refresh_textbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView listView_folderContents;
    }
}

