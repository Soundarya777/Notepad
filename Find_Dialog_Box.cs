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
    public partial class Find_Dialog_Box : Form
    {
        public EditOption edit_option = new EditOption();
        public Find_Dialog_Box(Mainform mainform)
        {
            InitializeComponent();
            notepadContents = mainform;
        }
        Mainform notepadContents;

        /// <summary>
        /// find next button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button_FindNext(object sender, EventArgs e)
        {
            //edit_option.find_string = Find_textbox.Text;
            if (radioButton_Down.Checked == true)
            {
                edit_option.Find_NextDown(notepadContents, this); 
            }
            else
            {
                edit_option.Find_NextUp(notepadContents, this);
            }
        }

        private void radioButton_Down_CheckedChanged(object sender, EventArgs e)
        {
            if (notepadContents.rad_change == false)
            {
                notepadContents.start_index = notepadContents.end_index;
                edit_option.stop = 0; notepadContents.rad_change = true;
            }
        }

        private void radioButton_Up_CheckedChanged(object sender, EventArgs e)
        {
            //if (notepadContents.cursor_change == true)
            //{
            //    notepadContents.end_index= notepadContents.cursor_pos; notepadContents.cursor_change = false;
            //}
             if (notepadContents.rad_change == true)
            {
                notepadContents.end_index = notepadContents.start_index;
                edit_option.stop = 0; notepadContents.rad_change = false;
            }
        }

        private void button_findcancel_Click(object sender, EventArgs e)
        {

        }
    }
}
