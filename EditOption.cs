using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace Winform_task_Notepad_
{
    /// <summary>
    /// Edit option tools in Notepad
    /// </summary>
    public class EditOption
    {
        public int stop = 0; public string find_string; 
        public bool find_check;
        public void Find_NextDown(Mainform main_form, Find_Dialog_Box find_dialogbox)
        {
            if (main_form.cursor_change == true)
            {
                main_form.start_index = main_form.cursor_pos;
                stop = 0;
                main_form.cursor_change = false;
            }
            main_form.richTextBox1.Focus();
            string find_string = find_dialogbox.Find_textbox.Text;
            if (main_form.start_index < 0 && find_dialogbox.checkB_Wrap.Checked == false)
            {
                MessageBox.Show($"Cant find {find_string}");
            }
            else
            {
                if (find_dialogbox.checkB_Match.Checked == true && find_dialogbox.checkB_Wrap.Checked == true)
                {
                    main_form.start_index = main_form.richTextBox1.Find(find_string, main_form.start_index, main_form.richTextBox1.Text.Length, RichTextBoxFinds.MatchCase);
                    if (main_form.start_index < 0)
                    {
                        main_form.start_index = 0;
                        main_form.start_index = main_form.richTextBox1.Find(find_string, main_form.start_index, main_form.richTextBox1.Text.Length, RichTextBoxFinds.MatchCase);
                    }
                    main_form.start_index++;
                }
                else if (find_dialogbox.checkB_Wrap.Checked == true && find_dialogbox.checkB_Match.Checked == false)
                {
                    main_form.start_index = main_form.richTextBox1.Find(find_string, main_form.start_index, main_form.richTextBox1.Text.Length, RichTextBoxFinds.None);
                    if (main_form.start_index < 0)
                    {
                        main_form.start_index = 0;
                        main_form.start_index = main_form.richTextBox1.Find(find_string, main_form.start_index, main_form.richTextBox1.Text.Length, RichTextBoxFinds.None);
                    }
                    main_form.start_index++;
                }
                else if (find_dialogbox.checkB_Match.Checked == true && find_dialogbox.checkB_Wrap.Checked == false)
                {
                    if (main_form.start_index < main_form.richTextBox1.Text.Length)
                    {
                        if (find_string.Length > 0 && main_form.start_index >= 0)
                        {
                            main_form.start_index = main_form.richTextBox1.Find(find_string, main_form.start_index, main_form.richTextBox1.Text.Length, RichTextBoxFinds.MatchCase);
                            if (main_form.start_index > 0)
                            {
                                stop = 2;
                            }
                            if (main_form.start_index <= 0 && stop == 2)
                            {
                                main_form.start_index = main_form.richTextBox1.Text.Length + 1;
                            }
                            main_form.start_index = main_form.start_index + find_string.Length;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Cant find {find_string}");
                    }
                }
                else if (find_dialogbox.checkB_Match.Checked == false && find_dialogbox.checkB_Wrap.Checked == false)
                {
                    if (main_form.start_index < main_form.richTextBox1.Text.Length)
                    {
                        if (find_string.Length > 0 && main_form.start_index >= 0)
                        {
                            main_form.start_index = main_form.richTextBox1.Find(find_string, main_form.start_index, main_form.richTextBox1.Text.Length, RichTextBoxFinds.None);
                            if (main_form.start_index > 0)
                            {
                                stop = 1;
                            }
                            if (main_form.start_index <= 0 && stop == 1)
                            {
                                main_form.start_index = main_form.richTextBox1.Text.Length + 1;
                            }
                            main_form.start_index = main_form.start_index + find_string.Length;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Cant find {find_string}");
                    }
                }
            }
        }

        /// <summary>
        /// Find next up
        /// </summary>
        /// <param name="main_form"></param>
        /// <param name="find_dialogbox"></param>
        public void Find_NextUp(Mainform main_form, Find_Dialog_Box find_dialogbox)
        {
            if (main_form.cursor_change == true)
            {
                main_form.end_index = main_form.cursor_pos;
                stop = 0;
                main_form.cursor_change = false;
            }
            main_form.richTextBox1.Focus();
            string find_string = find_dialogbox.Find_textbox.Text;
            if (main_form.end_index < 0 && find_dialogbox.checkB_Wrap.Checked == false)
            {
                MessageBox.Show($"Cant find {find_string}");
            }
            else
            {
                if (find_dialogbox.checkB_Match.Checked == true && find_dialogbox.checkB_Wrap.Checked == true)
                {
                    main_form.end_index = main_form.richTextBox1.Find(find_string, 0, main_form.end_index, RichTextBoxFinds.MatchCase | RichTextBoxFinds.Reverse);
                }
                else if (find_dialogbox.checkB_Wrap.Checked == true && find_dialogbox.checkB_Match.Checked == false)
                {
                    main_form.end_index = main_form.richTextBox1.Find(find_string, 0, main_form.end_index, RichTextBoxFinds.Reverse);
                    main_form.end_index--;
                }
                else if (find_dialogbox.checkB_Match.Checked == true && find_dialogbox.checkB_Wrap.Checked == false)
                {
                    if (main_form.end_index <= main_form.richTextBox1.Text.Length && stop != 1)
                    {
                        main_form.end_index = main_form.richTextBox1.Find(find_string, 0, main_form.end_index, RichTextBoxFinds.MatchCase | RichTextBoxFinds.Reverse);
                        if (main_form.end_index > 0 && stop != 1)
                        {
                            main_form.end_index--;
                        }
                        else if (main_form.end_index == 0)
                        {
                            stop = 1;
                        }
                        else if (main_form.end_index == 0 && stop == 1)
                        {
                            MessageBox.Show($"Cant find {find_string}");
                        }
                        else MessageBox.Show($"Cant find {find_string}");

                    }
                    else if (main_form.end_index < 0)
                    {
                        MessageBox.Show($"Cant find {find_string}");
                    }

                    else
                    {
                        MessageBox.Show($"Cant find {find_string}");
                    }

                }
                else if (find_dialogbox.checkB_Match.Checked == false && find_dialogbox.checkB_Wrap.Checked == false)
                {
                    if (main_form.end_index <= main_form.richTextBox1.Text.Length && stop != 1)
                    {
                        main_form.end_index = main_form.richTextBox1.Find(find_string, 0, main_form.end_index, RichTextBoxFinds.Reverse);
                        if (main_form.end_index > 0 && stop != 1)
                        {
                            main_form.end_index--;
                        }
                        else if (main_form.end_index == 0)
                        {
                            stop = 1;
                        }
                        else if (main_form.end_index == 0 && stop == 1)
                        {
                            MessageBox.Show($"Cant find {find_string}");
                        }
                        else MessageBox.Show($"Cant find {find_string}");

                    }
                    else if (main_form.end_index < 0)
                    {
                        MessageBox.Show($"Cant find {find_string}");
                    }

                    else
                    {
                        MessageBox.Show($"Cant find {find_string}");
                    }
                }
            }
        }

        /// <summary>
        /// Find next
        /// </summary>
        /// <param name="main_form"></param>
        /// <param name="replace_dialogbox"></param>
        public void Find_Next(Mainform main_form, Replace_Dialog_Box replace_dialogbox)
        {
            if (main_form.cursor_change == true)
            {
                main_form.start_index = main_form.cursor_pos;
                stop = 0;
                main_form.cursor_change = false;
            }
            main_form.richTextBox1.Focus();
            string find_string = replace_dialogbox.Replace_textBox1.Text;
            if (main_form.start_index < 0 )
            {
                MessageBox.Show($"Cant find {find_string}");
            }
            else
            {
                if (replace_dialogbox.Rep_checkBMatch.Checked == true )
                {
                    if (main_form.start_index < main_form.richTextBox1.Text.Length)
                    {
                        if (find_string.Length > 0 && main_form.start_index >= 0)
                        {
                            main_form.start_index = main_form.richTextBox1.Find(find_string, main_form.start_index, main_form.richTextBox1.Text.Length, RichTextBoxFinds.MatchCase);
                            if (main_form.start_index > 0)
                            {
                                stop = 2;
                            }
                            if (main_form.start_index <= 0 && stop == 2)
                            {
                                main_form.start_index = main_form.richTextBox1.Text.Length + 1;
                            }
                            main_form.start_index = main_form.start_index + find_string.Length;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Cant find {find_string}");
                    }
                }
                else if (replace_dialogbox.Rep_checkBMatch.Checked == false )
                {
                    if (main_form.start_index < main_form.richTextBox1.Text.Length)
                    {
                        if (find_string.Length > 0 && main_form.start_index >= 0)
                        {
                            main_form.start_index = main_form.richTextBox1.Find(find_string, main_form.start_index, main_form.richTextBox1.Text.Length, RichTextBoxFinds.None);

                            if (main_form.start_index > 0)
                            {
                                stop = 1;
                            }
                            if (main_form.start_index <= 0 && stop == 1)
                            {
                                main_form.start_index = main_form.richTextBox1.Text.Length + 1;
                            }
                            main_form.start_index=main_form.start_index + find_string.Length;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Cant find {find_string}");
                    }
                }
            }
        }

        /// <summary>
        /// Replace method
        /// </summary>
        /// <param name="main_form"></param>
        /// <param name="replace_dialogbox"></param>
        public void Replace(Mainform main_form, Replace_Dialog_Box replace_dialogbox)
        {
            main_form.richTextBox1.Focus();
            if (find_check==true)
            {
                main_form.richTextBox1.SelectedText = main_form.richTextBox1.SelectedText.Replace(replace_dialogbox.Replace_textBox1.Text, replace_dialogbox.Replace_textBox2.Text);
                find_check = false;
            }
            else

            {
                Find_Next(main_form, replace_dialogbox); find_check = true;
            }
        }

        /// <summary>
        /// Replace all method
        /// </summary>
        /// <param name="main_form"></param>
        /// <param name="replace_dialogbox"></param>
        public void Replace_All(Mainform main_form, Replace_Dialog_Box replace_dialogbox)
        {
            main_form.richTextBox1.Focus();
            if (replace_dialogbox.Rep_checkBMatch.Checked == true)
            {
                main_form.richTextBox1.Text = Regex.Replace(main_form.richTextBox1.Text, replace_dialogbox.Replace_textBox1.Text, replace_dialogbox.Replace_textBox2.Text, RegexOptions.CultureInvariant);
            }
            else
            {
                main_form.richTextBox1.Text = Regex.Replace(main_form.richTextBox1.Text, replace_dialogbox.Replace_textBox1.Text, replace_dialogbox.Replace_textBox2.Text, RegexOptions.IgnoreCase);
            }
            main_form.richTextBox1.SelectionStart = main_form.start_index = main_form.richTextBox1.Text.Length;
        }
    }
}

