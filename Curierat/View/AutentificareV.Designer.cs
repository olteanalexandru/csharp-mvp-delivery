namespace Curierat.View
{
    partial class AutentificareV
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
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserAutentificare = new System.Windows.Forms.TextBox();
            this.txtParolaAutentificare = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.Location = new System.Drawing.Point(107, 178);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(147, 37);
            this.btnAutentificare.TabIndex = 0;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.UseVisualStyleBackColor = true;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "USER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PAROLA";
            // 
            // txtUserAutentificare
            // 
            this.txtUserAutentificare.Location = new System.Drawing.Point(107, 72);
            this.txtUserAutentificare.Name = "txtUserAutentificare";
            this.txtUserAutentificare.Size = new System.Drawing.Size(147, 20);
            this.txtUserAutentificare.TabIndex = 3;
            // 
            // txtParolaAutentificare
            // 
            this.txtParolaAutentificare.Location = new System.Drawing.Point(107, 119);
            this.txtParolaAutentificare.Name = "txtParolaAutentificare";
            this.txtParolaAutentificare.PasswordChar = '*';
            this.txtParolaAutentificare.Size = new System.Drawing.Size(147, 20);
            this.txtParolaAutentificare.TabIndex = 4;
            // 
            // AutentificareV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 259);
            this.Controls.Add(this.txtParolaAutentificare);
            this.Controls.Add(this.txtUserAutentificare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAutentificare);
            this.Name = "AutentificareV";
            this.Text = "AutentificareV";
            this.Load += new System.EventHandler(this.AutentificareV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserAutentificare;
        private System.Windows.Forms.TextBox txtParolaAutentificare;
    }
}