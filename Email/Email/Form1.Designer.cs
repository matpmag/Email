namespace Email
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
            this.tbxTo = new System.Windows.Forms.TextBox();
            this.tbxSubject = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxBody = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxTo
            // 
            this.tbxTo.Location = new System.Drawing.Point(12, 12);
            this.tbxTo.Name = "tbxTo";
            this.tbxTo.Size = new System.Drawing.Size(260, 20);
            this.tbxTo.TabIndex = 1;
            // 
            // tbxSubject
            // 
            this.tbxSubject.Location = new System.Drawing.Point(12, 40);
            this.tbxSubject.Name = "tbxSubject";
            this.tbxSubject.Size = new System.Drawing.Size(260, 20);
            this.tbxSubject.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSend.Location = new System.Drawing.Point(0, 239);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(284, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxBody
            // 
            this.tbxBody.Location = new System.Drawing.Point(12, 66);
            this.tbxBody.Multiline = true;
            this.tbxBody.Name = "tbxBody";
            this.tbxBody.Size = new System.Drawing.Size(260, 167);
            this.tbxBody.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tbxBody);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxSubject);
            this.Controls.Add(this.tbxTo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTo;
        private System.Windows.Forms.TextBox tbxSubject;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxBody;

    }
}

