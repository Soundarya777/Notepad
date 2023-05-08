namespace Winform_task_Notepad_
{
    partial class Replace_Dialog_Box
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Replace_textBox1 = new System.Windows.Forms.TextBox();
            this.Replace_textBox2 = new System.Windows.Forms.TextBox();
            this.buttonRep_findnext = new System.Windows.Forms.Button();
            this.buttonRep_replace = new System.Windows.Forms.Button();
            this.buttonRep_replaceall = new System.Windows.Forms.Button();
            this.buttonRep_cancel = new System.Windows.Forms.Button();
            this.Rep_checkBMatch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find what:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Replace with:";
            // 
            // Replace_textBox1
            // 
            this.Replace_textBox1.Location = new System.Drawing.Point(112, 40);
            this.Replace_textBox1.Name = "Replace_textBox1";
            this.Replace_textBox1.Size = new System.Drawing.Size(233, 20);
            this.Replace_textBox1.TabIndex = 2;
            this.Replace_textBox1.TextChanged += new System.EventHandler(this.Replace_textBox1_TextChanged);
            // 
            // Replace_textBox2
            // 
            this.Replace_textBox2.Location = new System.Drawing.Point(112, 77);
            this.Replace_textBox2.Name = "Replace_textBox2";
            this.Replace_textBox2.Size = new System.Drawing.Size(233, 20);
            this.Replace_textBox2.TabIndex = 3;
            // 
            // buttonRep_findnext
            // 
            this.buttonRep_findnext.Location = new System.Drawing.Point(382, 35);
            this.buttonRep_findnext.Name = "buttonRep_findnext";
            this.buttonRep_findnext.Size = new System.Drawing.Size(75, 23);
            this.buttonRep_findnext.TabIndex = 4;
            this.buttonRep_findnext.Text = "Find Next";
            this.buttonRep_findnext.UseVisualStyleBackColor = true;
            this.buttonRep_findnext.Click += new System.EventHandler(this.buttonRep_findnext_Click);
            // 
            // buttonRep_replace
            // 
            this.buttonRep_replace.Location = new System.Drawing.Point(382, 66);
            this.buttonRep_replace.Name = "buttonRep_replace";
            this.buttonRep_replace.Size = new System.Drawing.Size(75, 23);
            this.buttonRep_replace.TabIndex = 5;
            this.buttonRep_replace.Text = "Replace";
            this.buttonRep_replace.UseVisualStyleBackColor = true;
            this.buttonRep_replace.Click += new System.EventHandler(this.buttonRep_replace_Click);
            // 
            // buttonRep_replaceall
            // 
            this.buttonRep_replaceall.Location = new System.Drawing.Point(382, 96);
            this.buttonRep_replaceall.Name = "buttonRep_replaceall";
            this.buttonRep_replaceall.Size = new System.Drawing.Size(75, 23);
            this.buttonRep_replaceall.TabIndex = 6;
            this.buttonRep_replaceall.Text = "Replace All";
            this.buttonRep_replaceall.UseVisualStyleBackColor = true;
            this.buttonRep_replaceall.Click += new System.EventHandler(this.buttonRep_replaceall_Click);
            // 
            // buttonRep_cancel
            // 
            this.buttonRep_cancel.Location = new System.Drawing.Point(382, 126);
            this.buttonRep_cancel.Name = "buttonRep_cancel";
            this.buttonRep_cancel.Size = new System.Drawing.Size(75, 23);
            this.buttonRep_cancel.TabIndex = 7;
            this.buttonRep_cancel.Text = "Cancel";
            this.buttonRep_cancel.UseVisualStyleBackColor = true;
            this.buttonRep_cancel.Click += new System.EventHandler(this.buttonRep_cancel_Click);
            // 
            // Rep_checkBMatch
            // 
            this.Rep_checkBMatch.AutoSize = true;
            this.Rep_checkBMatch.Location = new System.Drawing.Point(15, 154);
            this.Rep_checkBMatch.Name = "Rep_checkBMatch";
            this.Rep_checkBMatch.Size = new System.Drawing.Size(82, 17);
            this.Rep_checkBMatch.TabIndex = 8;
            this.Rep_checkBMatch.Text = "Match case";
            this.Rep_checkBMatch.UseVisualStyleBackColor = true;
            // 
            // Replace_Dialog_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 185);
            this.Controls.Add(this.Rep_checkBMatch);
            this.Controls.Add(this.buttonRep_cancel);
            this.Controls.Add(this.buttonRep_replaceall);
            this.Controls.Add(this.buttonRep_replace);
            this.Controls.Add(this.buttonRep_findnext);
            this.Controls.Add(this.Replace_textBox2);
            this.Controls.Add(this.Replace_textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Replace_Dialog_Box";
            this.Text = "Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRep_replace;
        internal System.Windows.Forms.TextBox Replace_textBox1;
        internal System.Windows.Forms.TextBox Replace_textBox2;
        internal System.Windows.Forms.CheckBox Rep_checkBMatch;
        internal System.Windows.Forms.Button buttonRep_findnext;
        internal System.Windows.Forms.Button buttonRep_replaceall;
        internal System.Windows.Forms.Button buttonRep_cancel;
    }
}