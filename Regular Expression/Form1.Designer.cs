namespace Regular_Expression
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
            this.labName = new System.Windows.Forms.Label();
            this.labPhone = new System.Windows.Forms.Label();
            this.labMail = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textMail = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(37, 22);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(45, 17);
            this.labName.TabIndex = 0;
            this.labName.Text = "Name";
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Location = new System.Drawing.Point(40, 61);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(49, 17);
            this.labPhone.TabIndex = 1;
            this.labPhone.Text = "Phone";
            // 
            // labMail
            // 
            this.labMail.AutoSize = true;
            this.labMail.Location = new System.Drawing.Point(40, 109);
            this.labMail.Name = "labMail";
            this.labMail.Size = new System.Drawing.Size(47, 17);
            this.labMail.TabIndex = 2;
            this.labMail.Text = "E-mail";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(140, 16);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(143, 22);
            this.textName.TabIndex = 3;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(140, 61);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(143, 22);
            this.textPhone.TabIndex = 4;
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(140, 104);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(143, 22);
            this.textMail.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(140, 163);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(143, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 264);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labMail);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.labName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Label labMail;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.Button buttonSave;
    }
}

