using System.ComponentModel;

namespace Kursova
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.EndRegistrBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(129, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.NameBox.Location = new System.Drawing.Point(130, 110);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(240, 37);
            this.NameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(117, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 69);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your surname";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.SurnameBox.Location = new System.Drawing.Point(131, 231);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(240, 38);
            this.SurnameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.ForeColor = System.Drawing.Color.Chartreuse;
            this.label3.Location = new System.Drawing.Point(121, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "Registration";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(131, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 42);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter your login";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.LoginBox.Location = new System.Drawing.Point(131, 338);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(240, 38);
            this.LoginBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.Location = new System.Drawing.Point(103, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 62);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter your password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassBox
            // 
            this.PassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.PassBox.Location = new System.Drawing.Point(130, 444);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(240, 38);
            this.PassBox.TabIndex = 8;
            this.PassBox.UseSystemPasswordChar = true;
            // 
            // EndRegistrBut
            // 
            this.EndRegistrBut.BackColor = System.Drawing.Color.LawnGreen;
            this.EndRegistrBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.EndRegistrBut.Location = new System.Drawing.Point(103, 532);
            this.EndRegistrBut.Name = "EndRegistrBut";
            this.EndRegistrBut.Size = new System.Drawing.Size(299, 56);
            this.EndRegistrBut.TabIndex = 9;
            this.EndRegistrBut.Text = "End Registration";
            this.EndRegistrBut.UseVisualStyleBackColor = false;
            this.EndRegistrBut.Click += new System.EventHandler(this.EndRegistrBut_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(521, 646);
            this.Controls.Add(this.EndRegistrBut);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button EndRegistrBut;

        private System.Windows.Forms.TextBox PassBox;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SurnameBox;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox NameBox;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}