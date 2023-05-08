namespace Winform_task_Notepad_
{
    partial class Find_Dialog_Box
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
            this.Find_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkB_Match = new System.Windows.Forms.CheckBox();
            this.checkB_Wrap = new System.Windows.Forms.CheckBox();
            this.radioButton_Up = new System.Windows.Forms.RadioButton();
            this.radioButton_Down = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button_findcancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Find_textbox
            // 
            this.Find_textbox.Location = new System.Drawing.Point(86, 54);
            this.Find_textbox.MaxLength = 127;
            this.Find_textbox.Name = "Find_textbox";
            this.Find_textbox.Size = new System.Drawing.Size(322, 21);
            this.Find_textbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find what:";
            // 
            // checkB_Match
            // 
            this.checkB_Match.AutoSize = true;
            this.checkB_Match.Location = new System.Drawing.Point(17, 137);
            this.checkB_Match.Name = "checkB_Match";
            this.checkB_Match.Size = new System.Drawing.Size(89, 19);
            this.checkB_Match.TabIndex = 2;
            this.checkB_Match.Text = "Match case";
            this.checkB_Match.UseVisualStyleBackColor = true;
            // 
            // checkB_Wrap
            // 
            this.checkB_Wrap.AutoSize = true;
            this.checkB_Wrap.Location = new System.Drawing.Point(17, 163);
            this.checkB_Wrap.Name = "checkB_Wrap";
            this.checkB_Wrap.Size = new System.Drawing.Size(97, 19);
            this.checkB_Wrap.TabIndex = 3;
            this.checkB_Wrap.Text = "Wrap around";
            this.checkB_Wrap.UseVisualStyleBackColor = true;
            // 
            // radioButton_Up
            // 
            this.radioButton_Up.AutoSize = true;
            this.radioButton_Up.Location = new System.Drawing.Point(6, 17);
            this.radioButton_Up.Name = "radioButton_Up";
            this.radioButton_Up.Size = new System.Drawing.Size(41, 19);
            this.radioButton_Up.TabIndex = 4;
            this.radioButton_Up.Text = "Up";
            this.radioButton_Up.UseVisualStyleBackColor = true;
            this.radioButton_Up.CheckedChanged += new System.EventHandler(this.radioButton_Up_CheckedChanged);
            // 
            // radioButton_Down
            // 
            this.radioButton_Down.AutoSize = true;
            this.radioButton_Down.Checked = true;
            this.radioButton_Down.Location = new System.Drawing.Point(59, 17);
            this.radioButton_Down.Name = "radioButton_Down";
            this.radioButton_Down.Size = new System.Drawing.Size(57, 19);
            this.radioButton_Down.TabIndex = 5;
            this.radioButton_Down.TabStop = true;
            this.radioButton_Down.Text = "Down";
            this.radioButton_Down.UseVisualStyleBackColor = true;
            this.radioButton_Down.CheckedChanged += new System.EventHandler(this.radioButton_Down_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Find Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_FindNext);
            // 
            // button_findcancel
            // 
            this.button_findcancel.Location = new System.Drawing.Point(450, 90);
            this.button_findcancel.Name = "button_findcancel";
            this.button_findcancel.Size = new System.Drawing.Size(75, 23);
            this.button_findcancel.TabIndex = 8;
            this.button_findcancel.Text = "Cancel";
            this.button_findcancel.UseVisualStyleBackColor = true;
            this.button_findcancel.Click += new System.EventHandler(this.button_findcancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Up);
            this.groupBox1.Controls.Add(this.radioButton_Down);
            this.groupBox1.Location = new System.Drawing.Point(286, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 45);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // Find_Dialog_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 197);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_findcancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkB_Wrap);
            this.Controls.Add(this.checkB_Match);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Find_textbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Find_Dialog_Box";
            this.Text = "Find_Dialog_Box";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox Find_textbox;
        internal System.Windows.Forms.RadioButton radioButton_Up;
        internal System.Windows.Forms.RadioButton radioButton_Down;
        internal System.Windows.Forms.CheckBox checkB_Wrap;
        internal System.Windows.Forms.CheckBox checkB_Match;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button_findcancel;
    }
}