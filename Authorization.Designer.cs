using System.ComponentModel;

namespace Kursova
{
    partial class Authorization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.Windows.Forms.Label PassLabel;
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.registrateBut = new System.Windows.Forms.Button();
            this.SignUpBut = new System.Windows.Forms.Button();
            PassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PassLabel
            // 
            PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            PassLabel.Location = new System.Drawing.Point(128, 244);
            PassLabel.Name = "PassLabel";
            PassLabel.Size = new System.Drawing.Size(234, 51);
            PassLabel.TabIndex = 2;
            PassLabel.Text = "Password";
            PassLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.LoginLabel.Location = new System.Drawing.Point(128, 65);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginLabel.Size = new System.Drawing.Size(234, 31);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Login";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.LoginBox.Location = new System.Drawing.Point(128, 124);
            this.LoginBox.Multiline = true;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(234, 50);
            this.LoginBox.TabIndex = 1;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.PasswordBox.Location = new System.Drawing.Point(128, 328);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(234, 38);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // registrateBut
            // 
            this.registrateBut.BackColor = System.Drawing.Color.LawnGreen;
            this.registrateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.registrateBut.ForeColor = System.Drawing.Color.Red;
            this.registrateBut.Location = new System.Drawing.Point(128, 567);
            this.registrateBut.Name = "registrateBut";
            this.registrateBut.Size = new System.Drawing.Size(250, 47);
            this.registrateBut.TabIndex = 4;
            this.registrateBut.Text = "Didn\'t registrate yet?";
            this.registrateBut.UseVisualStyleBackColor = false;
            this.registrateBut.Click += new System.EventHandler(this.registrateBut_Click);
            // 
            // SignUpBut
            // 
            this.SignUpBut.BackColor = System.Drawing.Color.Turquoise;
            this.SignUpBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.SignUpBut.Location = new System.Drawing.Point(148, 425);
            this.SignUpBut.Name = "SignUpBut";
            this.SignUpBut.Size = new System.Drawing.Size(200, 45);
            this.SignUpBut.TabIndex = 5;
            this.SignUpBut.Text = "Sign up";
            this.SignUpBut.UseVisualStyleBackColor = false;
            this.SignUpBut.Click += new System.EventHandler(this.SignUpBut_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(521, 646);
            this.Controls.Add(this.SignUpBut);
            this.Controls.Add(this.registrateBut);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(PassLabel);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.LoginLabel);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button SignUpBut;

        private System.Windows.Forms.Button registrateBut;

        private System.Windows.Forms.TextBox PasswordBox;

        private System.Windows.Forms.Label PassLabel;

        private System.Windows.Forms.TextBox LoginBox;

        private System.Windows.Forms.Label LoginLabel;

        #endregion
    }
}