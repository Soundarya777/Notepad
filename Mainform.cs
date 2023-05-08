using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_task_Notepad_
{
    public partial class Mainform : Form
    {
        FileOption _fileoption = new FileOption();
        public string _fileName = "Untitled - Notepad"; public string _fileFullName = ""; public bool cancel_check = false; public int cursor_pos;
        public int start_index { get; set; }
        public int end_index { get; set; }
        public bool rad_change { get; set; }
        public bool cursor_change { get; set; }
        public bool find_optn { get; set; }
        public Find_Dialog_Box find_Db { get; set; }
        public Mainform()
        {
            //find_Db = new Find_Dialog_Box(this);
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = _fileoption.File_Check(this);
            Save_Dialog_Box save_db = new Save_Dialog_Box(this);
            if (this.Text.First().ToString().Contains('*'))
            {
                if (check == true)
                {
                    save_db.DisplayTextLabel.Text = "Do you want to save changes to " + _fileFullName;
                }
                else if (check == false && richTextBox1.Text != string.Empty)
                {
                    save_db.DisplayTextLabel.Text = "Do you want to save changes to " + _fileName;
                }
                save_db.ShowDialog();
                if (cancel_check == true)
                {
                    richTextBox1 = richTextBox1;
                    this.Text = this.Text;
                }
                else
                {
                    richTextBox1.Clear();
                    this.Text = "Untitled - Notepad";
                }
            }
            else
            {
                richTextBox1.Clear();
                this.Text = "Untitled - Notepad";
            }
        }

        /// <summary>
        /// Open tool click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = _fileoption.File_Check(this);
            if ((!this.Text.First().ToString().Contains('*') && (check == false || check == true)) || (this.Text.First().ToString().Contains('*')
                && richTextBox1.Text == string.Empty && check == false))
            {
                _fileoption.Open_Method(this);
            }
            else if (this.Text.First().ToString().Contains('*'))
            {
                Save_Dialog_Box save_DB = new Save_Dialog_Box(this);
                if (check == false)
                {
                    save_DB.DisplayTextLabel.Text = "Do you want to save changes to " + _fileName;
                }
                else
                {
                    save_DB.DisplayTextLabel.Text = "Do you want to save changes to " + _fileFullName;
                }
                save_DB.ShowDialog();
                if (cancel_check == false)
                {
                    _fileoption.Open_Method(this);
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            _fileoption.Textbox_modify(this);
            end_index = richTextBox1.Text.Length;
        }

        /// <summary>
        /// Save tool click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = _fileoption.File_Check(this);
            if (check == true)
            {
                _fileoption.Save_Method(this);
            }
            else
            {
                this.Text = _fileoption.Save_AsMethod(this);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileoption.Save_AsMethod(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = _fileoption.File_Check(this);
            Save_Dialog_Box save_DB = new Save_Dialog_Box(this);
            if (this.Text.First().ToString().Contains('*') && check == false)
            {
                save_DB.DisplayTextLabel.Text = "Do you want to save changes to " + _fileName;
            }
            else if (this.Text.First().ToString().Contains('*') && check == true)
            {
                save_DB.DisplayTextLabel.Text = "Do you want to save changes to " + _fileFullName;
            }
            save_DB.ShowDialog();
            Application.Exit();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)
            {
                if (find_Db == null)
                {
                    find_Db = new Find_Dialog_Box(this);
                    if (find_Db.Visible == false)
                        find_Db.Show();
                }
                else if (find_Db != null)
                {
                    if (find_Db.Visible == true)
                    {
                        find_Db.BringToFront();
                        //find_Db.Show();
                    }
                    else
                    {
                        find_Db = new Find_Dialog_Box(this);
                        find_Db.Show();
                    }
                }
                find_optn = true;
            }
        }

        private void Cursor_Position(object sender, EventArgs e)
        {
            cursor_change = true;
            cursor_pos = richTextBox1.SelectionStart;
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (find_optn == true)
            {
                find_Db.button_FindNext(sender, e);
            }
            else
            {
                findToolStripMenuItem_Click(sender, e);
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replace_Dialog_Box replace_DB=new Replace_Dialog_Box(this);
            replace_DB.Show();
        }
    }
}
