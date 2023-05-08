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
    /// <summary>
    /// Save window
    /// </summary>
    public partial class Save_Dialog_Box : Form
    {
        public FileOption file_option = new FileOption();
        public Save_Dialog_Box(Mainform mainform)
        {
            InitializeComponent();
            notepad_contents = mainform;
        }
        Mainform notepad_contents;
        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool check = file_option.File_Check(notepad_contents);
            if (check==true)
            {
               file_option.Save_Method(notepad_contents);
                this.Close();
            }
            else
            {
                notepad_contents.Text = file_option.Save_AsMethod(notepad_contents);
                this.Close();
            }
        }

        private void buttonDontSave_Click(object sender, EventArgs e)
        {
            this.Close();
            notepad_contents.richTextBox1 = notepad_contents.richTextBox1;
            notepad_contents.Text = notepad_contents.Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            notepad_contents.cancel_check = true;
            if (notepad_contents.cancel_check == true)
            {
                notepad_contents.richTextBox1 = notepad_contents.richTextBox1;
                notepad_contents.Text = notepad_contents.Text;
            }
            this.Close();
        }

       
    }
}
