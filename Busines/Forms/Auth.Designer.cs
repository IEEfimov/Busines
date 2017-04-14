namespace Busines.Forms
{
    partial class Auth
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
            this.LoginEdit = new System.Windows.Forms.TextBox();
            this.PassEdit = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginEdit
            // 
            this.LoginEdit.Location = new System.Drawing.Point(48, 24);
            this.LoginEdit.Name = "LoginEdit";
            this.LoginEdit.Size = new System.Drawing.Size(289, 20);
            this.LoginEdit.TabIndex = 0;
            // 
            // PassEdit
            // 
            this.PassEdit.Location = new System.Drawing.Point(48, 60);
            this.PassEdit.Name = "PassEdit";
            this.PassEdit.PasswordChar = '*';
            this.PassEdit.Size = new System.Drawing.Size(289, 20);
            this.PassEdit.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(294, 99);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 2;
            this.Login.Text = "Увійти";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 134);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.PassEdit);
            this.Controls.Add(this.LoginEdit);
            this.Name = "Auth";
            this.Text = "Авторизація";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginEdit;
        private System.Windows.Forms.TextBox PassEdit;
        private System.Windows.Forms.Button Login;
    }
}