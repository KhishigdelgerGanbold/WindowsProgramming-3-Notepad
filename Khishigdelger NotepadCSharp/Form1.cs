using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

    namespace Khishigdelger_NotepadCSharp
    {
        public partial class Form1 : Form
        {
        private OpenFileDialog openfd;
        private SaveFileDialog savefd;
        private FontDialog fd;
            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

        private void createFile()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            if (!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                  result = MessageBox.Show("Шинэ файл нээхээс өмнө одоогийн файлаа хадгалах уу?\nYes - Хадгалах No - Хадгалахгүй", "Анхааруулга!", buttons);
                if (result == DialogResult.Yes)
                {
                    saveFile();
                }
                else
                {
                    this.richTextBox1.Text = string.Empty;
                    this.Text = "Untitled";
                }
            }
            else
                {
                    this.richTextBox1.Text = string.Empty;
                    this.Text = "Untitled";
                }
        }

        private void saveFile()
        {
            if (string.IsNullOrEmpty(this.richTextBox1.Text))
            {
                MessageBox.Show("Файл хоосон байна!", "Анхааруулга!");
            }
            else
            {
                savefd = new SaveFileDialog();
                savefd.Title = "Save As";
                savefd.Filter = "Text Document|*.txt";     
                savefd.DefaultExt = "txt";

                if(savefd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(savefd.FileName, this.richTextBox1.Text);
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createFile();
        }
    }
    }
