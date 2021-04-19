using System.ComponentModel;

namespace Kursova
{
    partial class ClubInfo
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
            this.GymBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VolleyballBut = new System.Windows.Forms.Button();
            this.BoxBut = new System.Windows.Forms.Button();
            this.TennisBut = new System.Windows.Forms.Button();
            this.YogaBut = new System.Windows.Forms.Button();
            this.BackBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GymBut
            // 
            this.GymBut.BackColor = System.Drawing.Color.Orange;
            this.GymBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.GymBut.Location = new System.Drawing.Point(175, 86);
            this.GymBut.Name = "GymBut";
            this.GymBut.Size = new System.Drawing.Size(207, 41);
            this.GymBut.TabIndex = 0;
            this.GymBut.Text = "Gym";
            this.GymBut.UseVisualStyleBackColor = false;
            this.GymBut.Click += new System.EventHandler(this.GymBut_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(145, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose club you want to get info about:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VolleyballBut
            // 
            this.VolleyballBut.BackColor = System.Drawing.Color.Orange;
            this.VolleyballBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.VolleyballBut.Location = new System.Drawing.Point(175, 155);
            this.VolleyballBut.Name = "VolleyballBut";
            this.VolleyballBut.Size = new System.Drawing.Size(207, 41);
            this.VolleyballBut.TabIndex = 2;
            this.VolleyballBut.Text = "Volleyball";
            this.VolleyballBut.UseVisualStyleBackColor = false;
            this.VolleyballBut.Click += new System.EventHandler(this.VolleyballBut_Click);
            // 
            // BoxBut
            // 
            this.BoxBut.BackColor = System.Drawing.Color.Orange;
            this.BoxBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.BoxBut.Location = new System.Drawing.Point(175, 227);
            this.BoxBut.Name = "BoxBut";
            this.BoxBut.Size = new System.Drawing.Size(207, 41);
            this.BoxBut.TabIndex = 3;
            this.BoxBut.Text = "Box";
            this.BoxBut.UseVisualStyleBackColor = false;
            this.BoxBut.Click += new System.EventHandler(this.BoxBut_Click);
            // 
            // TennisBut
            // 
            this.TennisBut.BackColor = System.Drawing.Color.Orange;
            this.TennisBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.TennisBut.Location = new System.Drawing.Point(175, 370);
            this.TennisBut.Name = "TennisBut";
            this.TennisBut.Size = new System.Drawing.Size(207, 41);
            this.TennisBut.TabIndex = 5;
            this.TennisBut.Text = "Tennis";
            this.TennisBut.UseVisualStyleBackColor = false;
            this.TennisBut.Click += new System.EventHandler(this.TennisBut_Click);
            // 
            // YogaBut
            // 
            this.YogaBut.BackColor = System.Drawing.Color.Orange;
            this.YogaBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.YogaBut.Location = new System.Drawing.Point(175, 295);
            this.YogaBut.Name = "YogaBut";
            this.YogaBut.Size = new System.Drawing.Size(207, 41);
            this.YogaBut.TabIndex = 6;
            this.YogaBut.Text = "Yoga";
            this.YogaBut.UseVisualStyleBackColor = false;
            this.YogaBut.Click += new System.EventHandler(this.YogaBut_Click_1);
            // 
            // BackBut
            // 
            this.BackBut.BackColor = System.Drawing.Color.Chartreuse;
            this.BackBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.BackBut.Location = new System.Drawing.Point(17, 573);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(128, 37);
            this.BackBut.TabIndex = 7;
            this.BackBut.Text = "Back";
            this.BackBut.UseVisualStyleBackColor = false;
            this.BackBut.Click += new System.EventHandler(this.BackBut_Click);
            // 
            // ClubInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(567, 646);
            this.Controls.Add(this.BackBut);
            this.Controls.Add(this.YogaBut);
            this.Controls.Add(this.TennisBut);
            this.Controls.Add(this.BoxBut);
            this.Controls.Add(this.VolleyballBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GymBut);
            this.Name = "ClubInfo";
            this.Text = "ClubInfo";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button BackBut;

        private System.Windows.Forms.Button YogaBut;


        private System.Windows.Forms.Button TennisBut;

        private System.Windows.Forms.Button BoxBut;

        private System.Windows.Forms.Button VolleyballBut;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button GymBut;

        #endregion
    }
}