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
    /// Replace window
    /// </summary>
    public partial class Replace_Dialog_Box : Form
    {
        public EditOption edit_option = new EditOption();
        public Replace_Dialog_Box(Mainform main_form)
        {
            InitializeComponent();
            buttonRep_findnext.Enabled = false;
            buttonRep_replace.Enabled = false;
            buttonRep_replaceall.Enabled = false;
            notepad_Contents = main_form;
        }
        Mainform notepad_Contents;

        private void buttonRep_findnext_Click(object sender, EventArgs e)
        {
            edit_option.Find_Next(notepad_Contents, this);
        }

        private void buttonRep_replace_Click(object sender, EventArgs e)
        {
            edit_option.Replace(notepad_Contents, this);
        }

        private void buttonRep_replaceall_Click(object sender, EventArgs e)
        {
            edit_option.Replace_All(notepad_Contents, this);
        }

        private void Replace_textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Replace_textBox1.Text != string.Empty)
            {
                buttonRep_findnext.Enabled = true;
                buttonRep_replace.Enabled = true;
                buttonRep_replaceall.Enabled = true;
            }
            else
            {
                buttonRep_findnext.Enabled = false;
                buttonRep_replace.Enabled = false;
                buttonRep_replaceall.Enabled = false;
            }
        }

        private void buttonRep_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
