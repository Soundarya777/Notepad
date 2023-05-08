using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Winform_task_Notepad_
{
    public class FileOption
    {
        public string file_name; 

        public void Save_Method(Mainform main_form)
        {
            File.WriteAllText(main_form._fileFullName, main_form.richTextBox1.Text);
            main_form.richTextBox1 = main_form.richTextBox1;
            if (main_form.Text.First().ToString().Contains('*'))
            {
              main_form.Text = main_form.Text.Substring(1);
            }
        }


        public string Save_AsMethod(Mainform main_form)
        {
            SaveFileDialog save_fd = new SaveFileDialog();
            save_fd.FileName = "*.txt";
            save_fd.Filter = "Text Documents(*.txt)|*.txt| All Files (*.*)|*.*";
            DialogResult result= save_fd.ShowDialog();
            //string dialog_result = DialogResult.Cancel
            if (result == DialogResult.Cancel)
            {
                main_form.richTextBox1 = main_form.richTextBox1;
                file_name= main_form.Text = main_form.Text;
            }
            else 
            {
                File.WriteAllText(save_fd.FileName, main_form.richTextBox1.Text);
                main_form._fileFullName = save_fd.FileName;
                file_name = main_form.Text = Path.GetFileName(save_fd.FileName); 

            }
            return file_name;
        }

        /// <summary>
        /// Open a doc
        /// </summary>
        /// <param name="main_form"></param>
        public void Open_Method(Mainform main_form)
        {
            OpenFileDialog open_fd = new OpenFileDialog();
            open_fd.Title = "Open"; open_fd.FileName = ""; 
            open_fd.Filter = "Text Documents(*.txt)|*.txt| All Files (*.*)|*.*";
            if (open_fd.ShowDialog()==DialogResult.OK)
            {
                FileStream _file = File.Open(open_fd.FileName, FileMode.Open, FileAccess.ReadWrite);
                _file.Close();
                main_form.richTextBox1.Text= File.ReadAllText(open_fd.FileName);
                main_form.Text = Path.GetFileName(open_fd.FileName);
                main_form._fileFullName = open_fd.FileName;
            }
        }

        public string Textbox_modify(Mainform main_form)
        {
            if (main_form.richTextBox1.Modified==true)
            {
                if (main_form.Text.First().ToString().Contains('*'))
                {
                    return main_form.Text = main_form.Text.Replace('*', '*');
                }
                else
                {
                    return main_form.Text = "*" + main_form.Text;
                }
            }
              return main_form.Text;
        }

        /// <summary>
        /// File exist check
        /// </summary>
        /// <param name="main_form"></param>
        /// <returns></returns>
        public bool File_Check(Mainform main_form)
        {
            if (main_form.Text.First().ToString().Contains('*')&&main_form.Text!= "*Untitled - Notepad")
            {
                string fileName=main_form.Text.Substring(1);
                main_form._fileFullName= Path.GetFullPath(fileName);
                File.Exists(main_form._fileFullName);
                    return true;
            }
            else if (!main_form.Text.First().ToString().Contains('*')&& main_form.Text != "Untitled - Notepad")
            {
                main_form._fileFullName = Path.GetFullPath(main_form.Text);
                if (File.Exists(main_form._fileFullName))
                {
                    return true;
                }
            }
            else
            {
                return false;
            }return false;
        }

    }
}
