using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace account_feltoltes_egyszerűen
{
    public partial class Form1 : Form
    {
        private string _filePathModify;
        private string _selectedFolderPathPrivate;

        // Get the current date and time
        private DateTime _currentDateTime = DateTime.Now;

        public Form1()
        {
            InitializeComponent();



            //disable
            pathnev2.Visible = false;
            pathnev.Visible = false;


            //enable
            buttonGdrive.Visible = true;
            uppercase_checkbox.Checked = true;
            lowercase_checkBox.Checked = true;
            numbers_checkBox.Checked = true;
            specialchar_checkBox.Checked = true;

            //empty string
            mappanev.Text = string.Empty;

            email.Text = string.Empty;
            username.Text = string.Empty;
            password.Text = string.Empty;

            password1.Text = string.Empty;
            password2.Text = string.Empty;
            password3.Text = string.Empty;
            password4.Text = string.Empty;
            password5.Text = string.Empty;

            //listView_folderContents
            listView_folderContents.View = View.Details;
            listView_folderContents.Columns.Add("Name", 150);
            listView_folderContents.Columns.Add("Type", 100);
            listView_folderContents.Columns.Add("Size", 100);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Beállítjuk egy címsort a párbeszédablaknak
            folderBrowserDialog.Description = "Válassz egy célmappát";

            // Megjelenítjük a párbeszédablakot
            DialogResult result = folderBrowserDialog.ShowDialog();

            // Ellenőrizzük, hogy a felhasználó OK-t választott-e
            if (result == DialogResult.OK)
            {
                // A kiválasztott mappa elérési útja
                _selectedFolderPathPrivate = folderBrowserDialog.SelectedPath;
                pathnev.Visible = true;
                pathnev2.Text = pathnev.Text = "Jelenleg kiválasztott: " + "\r" + _selectedFolderPathPrivate;

                //listBox write
                try
                {
                    listView_folderContents.Items.Clear(); // clear

                    //directories
                    string[] directories = Directory.GetDirectories(_selectedFolderPathPrivate);
                    foreach (string directory in directories)
                    {
                        listView_folderContents.Items.Add(Path.GetFileName(directory) + " (Mappa)");
                    }
                    //files
                    string[] files = Directory.GetFiles(_selectedFolderPathPrivate);
                    foreach (string file in files)
                    {
                        listView_folderContents.Items.Add(Path.GetFileName(file));
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt: " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        public void buttonCreateFolder_Click(object sender, EventArgs e)
        {
            try
            {
                // Ellenőrizzük, hogy van-e kiválasztott hely
                if (string.IsNullOrEmpty(_selectedFolderPathPrivate))
                {
                    MessageBox.Show("Először válassz egy célmappát!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Az új mappa neve, amit létre szeretnénk hozni
                string folderName = mappanev.Text;

                // Az új mappa teljes elérési útja
                string folderPath = System.IO.Path.Combine(_selectedFolderPathPrivate, folderName);

                // Ellenőrizzük, hogy a mappa még nem létezik-e
                if (!System.IO.Directory.Exists(folderPath))
                {
                    // Mappa létrehozása
                    System.IO.Directory.CreateDirectory(folderPath);

                    // Sikeres létrehozás
                    MessageBox.Show("Mappa sikeresen létrehozva.", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Már létező mappa esetén hibaüzenet
                    MessageBox.Show("A mappa már létezik.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Hiba esetén hibaüzenet
                MessageBox.Show("Hiba történt: " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _selectedFolderPathPrivate = @"G:\jelszó-fiókok";
            pathnev.Visible = true;
            pathnev.Text = "Jelenleg kiválasztott: " + "\r" + _selectedFolderPathPrivate;


            //listBox write
            try
            {
                listView_folderContents.Items.Clear(); // clear
                                                     //directories
                string[] directories = Directory.GetDirectories(_selectedFolderPathPrivate);
                foreach (string directory in directories)
                {
                    listView_folderContents.Items.Add(Path.GetFileName(directory) + " (Mappa)");
                }
                //files
                string[] files = Directory.GetFiles(_selectedFolderPathPrivate);
                foreach (string file in files)
                {
                    listView_folderContents.Items.Add(Path.GetFileName(file));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt: " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void buttonCreateFile_Click(object sender, EventArgs e)
        {
            try
            {

                // Format the date and time as a string
                string formattedDateTime = _currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");

                // Specify the file path and name (you can change this to your desired location)
                string folderPath = _selectedFolderPathPrivate;

                //create file
                string fileName = "account.txt";
                File.Create(fileName);

                //combine file + filePath
                string filePath = Path.Combine(folderPath, fileName);

                // The content you want to write to the file
                string fileContent =
                    $"Edited/Created: {_currentDateTime}" +
                    $"\remail: {email.Text}" +
                    $"\rusername: {username.Text}" +
                    $"\rpassword: {password.Text}";

                // Create the text file and write the content to it
                File.WriteAllText(filePath, fileContent);

                // Show a success message
                MessageBox.Show("Text file created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any errors that may occur during file creation
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generaterpassword_button_Click(object sender, EventArgs e)
        {
            int passwordCount = 5;

            System.Windows.Forms.TextBox[] passwordTextBoxes = new System.Windows.Forms.TextBox[] { password1, password2, password3, password4, password5 };

            int passwordLength = (int)lenght_numericUpDown1.Value;
            bool includeUppercase = uppercase_checkbox.Checked;
            bool includeLowercase = lowercase_checkBox.Checked;
            bool includeNumbers = numbers_checkBox.Checked;
            bool includeSpecialChars = specialchar_checkBox.Checked;

            Random random = new Random(); // Initialize the random number generator once

            for (int i = 0; i < passwordCount; i++)
            {
                string generatedPassword = GeneratePassword(passwordLength, includeUppercase, includeLowercase, includeNumbers, includeSpecialChars, random);

                passwordTextBoxes[i].Text = generatedPassword;
            }
        }

        private string GeneratePassword(int length, bool includeUppercase, bool includeLowercase, bool includeNumbers, bool includeSpecialChars, Random random)
        {
            const string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            const string numberChars = "0123456789";
            const string specialChars = "!@#$%^&*()_+-=[]{}|;:,.<>?";

            string allChars = "";

            if (includeUppercase)
                allChars += uppercaseChars;
            if (includeLowercase)
                allChars += lowercaseChars;
            if (includeNumbers)
                allChars += numberChars;
            if (includeSpecialChars)
                allChars += specialChars;

            if (string.IsNullOrEmpty(allChars))
            {
                return "No character sets selected.";
            }

            StringBuilder password = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(0, allChars.Length);
                password.Append(allChars[index]);
            }

            return password.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            password.Text = password1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            password.Text = password2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            password.Text = password3.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            password.Text = password4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            password.Text = password5.Text;
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            fileContentTextBox.Clear();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt|All Files|*.*"; // Specify the file types you want to support
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _filePathModify = openFileDialog.FileName;
                    string fileContent = File.ReadAllText(_filePathModify);

                    pathnev.Visible = true;
                    pathnev.Text = "Jelenleg kiválasztott: " + "\r" + _filePathModify;

                    // Display the file content in a TextBox line by line
                    string[] lines = fileContent.Split('\r'); // Split the content into lines
                    foreach (string line in lines)
                    {
                        fileContentTextBox.AppendText(line.Trim() + Environment.NewLine);
                    }
                    MessageBox.Show("File content has been successfully oppened", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error: File does not contain the expected number of lines.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            string filePath = _filePathModify;
            string[] filePathList = File.ReadAllLines(_filePathModify);
            List<string> linesList = filePathList.ToList();

            if (File.Exists(filePath))
            {
                if (linesList.Count.Equals(4))
                {
                    email.Enabled = true;
                    username.Enabled = true;
                    password.Enabled = true;

                    string datetime = linesList[0];
                    string emailLine = linesList[1];
                    string usernameLine = linesList[2];
                    string passwordLine = linesList[3];

                    email.Text = emailLine.Substring(emailLine.IndexOf(":") + 1).Trim();
                    username.Text = usernameLine.Substring(usernameLine.IndexOf(":") + 1).Trim();
                    password.Text = passwordLine.Substring(passwordLine.IndexOf(":") + 1).Trim();
                }

                if (linesList.Count.Equals(3))
                {
                    username.Enabled = false;
                    username.Text = string.Empty;
                    // Assuming the email and password lines are the first and second lines in the file
                    string datetime = linesList[0];
                    string emailLine = linesList[1];
                    string passwordLine = linesList[2];

                    // Split the lines to get the values after the colon (':')
                    string[] emailParts = emailLine.Split(':');
                    string[] passwordParts = passwordLine.Split(':');

                    if (emailParts.Length.Equals(2) && passwordParts.Length.Equals(2))
                    {
                        string emailValue = emailParts[1].Trim();
                        string passwordValue = passwordParts[1].Trim();

                        // Set the values in the email and password textboxes

                        email.Text = emailValue;
                        password.Text = passwordValue;
                    }
                }
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(_filePathModify))
            {
                string filePath = _filePathModify;
                string newFirstLine = "Edited/Created: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                // Olvasd be a fájl tartalmát soronként egy listába
                List<string> lines = File.ReadAllLines(filePath).ToList();

                // Ellenőrizd, hogy a fájl tartalmaz legalább négy sort
                if (lines.Count.Equals(4))
                {
                    lines[0] = newFirstLine;
                    lines[1] = "email: " + email.Text;
                    lines[2] = "username: " + username.Text;
                    lines[3] = "password: " + password.Text;

                    // Mentsd vissza a módosított tartalmat a fájlba
                    File.WriteAllLines(filePath, lines);

                    MessageBox.Show("File content has been successfully edited and saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (lines.Count.Equals(3))
                {
                    username.Enabled = false;
                    // Modify the first line with the new date
                    lines[0] = newFirstLine;

                    // Update the email and password lines
                    lines[1] = "email: " + email.Text;
                    lines[2] = "password: " + password.Text;

                    // Write the modified content back to the file
                    File.WriteAllLines(filePath, lines);

                    MessageBox.Show("File content has been successfully edited and saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void refresh_textbox_Click_1(object sender, EventArgs e)
        {
            string filePath = _filePathModify;
            System.Windows.Forms.TextBox textBox = fileContentTextBox;

            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                textBox.Text = fileContent;
            }
            else
            {
                MessageBox.Show("Error: File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private string _selectedPath = string.Empty;

        private void listView_folderContents_DoubleClick(object sender, EventArgs e)
        {
            if (listView_folderContents.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_folderContents.SelectedItems[0];
                string folderPath = selectedItem.Tag.ToString(); // Az útvonalat az elem Tag tulajdonságából olvassa ki.

                if (System.IO.Directory.Exists(folderPath)) // Ellenőrizze, hogy az útvonal egy mappa.
                {
                    System.Diagnostics.Process.Start(folderPath); // Megnyitja a mappát a rendszer alapértelmezett fájlkezelőjével.
                }
                else
                {
                    MessageBox.Show("A kiválasztott elem nem egy mappa.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Assuming selectedPath is the path of the file you want to display
            DisplayFileContent(_selectedPath);




        }
        private void DisplayFileContent(string filePath)
        { 
            try
            {
                // Read the content of the file
                string fileContent = System.IO.File.ReadAllText(filePath);

                // Set the file content in the TextBox
                fileContentTextBox.Text = fileContent;
            }
            catch (Exception ex)
            {
                // Handle any exceptions, e.g., if the file doesn't exist or there's an issue with
                // the path.
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView_folderContents_ItemActivate(object sender, EventArgs e)
        {
        }
    }
}