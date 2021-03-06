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
    public partial class Notepad : Form
    {
        private OpenFileDialog openfd;
        private SaveFileDialog savefd;
        private FontDialog fd;
        private string file_name;
        public bool checker = false;

        public string GetName()
        {
            return file_name;
        }

        public void SetName(string str)
        {
            file_name = str;
        }

        public Notepad()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
            
                if (richTextBox1.Modified == true)
                {
                    DialogResult result = MessageBox.Show("Гарахаас өмнө одоогийн ажилаа хадгалах уу?\nYes - Хадгалах No - Хадгалахгүй", "Анхааруулга!", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)

                    {
                        saveFile();
                        richTextBox1.Modified = false;
                        Application.Exit();
                    }

                    else

                    {
                        richTextBox1.Modified = false;
                        Application.Exit();
                    }
                }
                else
                {
                    richTextBox1.Modified = false;
                    Application.Exit();
                }
            }
            else
            {
                richTextBox1.Modified = false;
                Application.Exit();
            }


            if (e.CloseReason == CloseReason.WindowsShutDown)
                {
                return;
                }
        
         }

        private void createFile()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            if (richTextBox1.Modified == true)
            {
                result = MessageBox.Show("Шинэ файл нээхээс өмнө одоогийн файлаа хадгалах уу?\nYes - Хадгалах No - Хадгалахгүй", "Анхааруулга!", buttons);
                if (result == DialogResult.Yes)
                {
                    saveFile();
                    this.richTextBox1.Text = string.Empty;
                    this.Text = "Untitled";
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
                savefd.Filter = "Text Files(*.txt) | *.txt | All Files(*.*) | *.*";
                savefd.DefaultExt = "txt";

                if (savefd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(savefd.FileName, this.richTextBox1.Text);
                }
            }
        }

        private void openFile()

        {
            openfd = new OpenFileDialog();
            openfd.Title = "Open Document";
            openfd.Filter = "Text Files|*.txt";
            openfd.FileName = string.Empty;

            if (openfd.ShowDialog() == DialogResult.OK)

            {

                if (openfd.FileName == String.Empty)

                {
                    return;
                }

                else

                {
                    string str = openfd.FileName;
                    richTextBox1.LoadFile(str, RichTextBoxStreamType.PlainText);
                    this.Text = openfd.FileName;
                }

            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Modified == true)

            {
                DialogResult result = MessageBox.Show("Өөр файл нээхээс өмнө одоогийн файлаа хадгалах уу?\nYes - Хадгалах No - Хадгалахгүй", "Анхааруулга!", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)

                {
                    richTextBox1.Modified = false;
                    openFile();
                }

                else

                {
                    saveFile();
                    openFile();
                }

            }
            else

            {
                openFile();
            }
        }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified == true)
            {
                DialogResult result = MessageBox.Show("Гарахаас өмнө одоогийн ажилаа хадгалах уу?\nYes - Хадгалах No - Хадгалахгүй", "Анхааруулга!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)

                {
                    saveFile();
                    richTextBox1.Modified = false;
                    Application.Exit();
                }

                else

                {
                    richTextBox1.Modified = false;
                    Application.Exit();
                }
            }
            else
            {
                richTextBox1.Modified = false;
                Application.Exit();
            }

        }

        

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checker = true;
            saveFile();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)

            {
                richTextBox1.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo)

            {
                richTextBox1.Redo();
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fd = new FontDialog();
            fd.Font = richTextBox1.SelectionFont;
            fd.Color = richTextBox1.SelectionColor;

            if (fd.ShowDialog() == DialogResult.OK)

            {
                richTextBox1.SelectionFont = fd.Font;
                richTextBox1.SelectionColor = fd.Color;
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked == false)

            {
                wordWrapToolStripMenuItem.Checked = true;
                richTextBox1.WordWrap = true;
            }

            else

            {
                wordWrapToolStripMenuItem.Checked = false;
                richTextBox1.WordWrap = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                saveFile();
            }
            else
            {
                File.WriteAllText(savefd.FileName, this.richTextBox1.Text);
            }
        }
    }
}
    
