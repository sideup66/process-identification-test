namespace process_identification_test
{
    partial class Form1
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
            this.process_searchtxtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.outputlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // process_searchtxtbx
            // 
            this.process_searchtxtbx.Location = new System.Drawing.Point(204, 15);
            this.process_searchtxtbx.Name = "process_searchtxtbx";
            this.process_searchtxtbx.Size = new System.Drawing.Size(100, 20);
            this.process_searchtxtbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the name of a process to check";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputlbl
            // 
            this.outputlbl.AutoSize = true;
            this.outputlbl.Location = new System.Drawing.Point(16, 97);
            this.outputlbl.Name = "outputlbl";
            this.outputlbl.Size = new System.Drawing.Size(109, 13);
            this.outputlbl.TabIndex = 3;
            this.outputlbl.Text = "Owner of process is...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputlbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.process_searchtxtbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox process_searchtxtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label outputlbl;
    }
}

