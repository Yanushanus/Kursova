using System.ComponentModel;

namespace Kursova
{
    partial class MemberShip
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
            this.GymBut = new System.Windows.Forms.Button();
            this.BoxBut = new System.Windows.Forms.Button();
            this.VolleyballBut = new System.Windows.Forms.Button();
            this.YogaBut = new System.Windows.Forms.Button();
            this.TennisBut = new System.Windows.Forms.Button();
            this.ConfirmBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click on clubs you want to choose into your membership";
            // 
            // GymBut
            // 
            this.GymBut.AutoSize = true;
            this.GymBut.BackColor = System.Drawing.Color.Gold;
            this.GymBut.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.GymBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.GymBut.Location = new System.Drawing.Point(119, 128);
            this.GymBut.Name = "GymBut";
            this.GymBut.Size = new System.Drawing.Size(270, 41);
            this.GymBut.TabIndex = 1;
            this.GymBut.Text = "Gym";
            this.GymBut.UseVisualStyleBackColor = false;
            this.GymBut.UseWaitCursor = true;
            this.GymBut.Click += new System.EventHandler(this.GymBut_Click);
            // 
            // BoxBut
            // 
            this.BoxBut.AutoSize = true;
            this.BoxBut.BackColor = System.Drawing.Color.Gold;
            this.BoxBut.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BoxBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.BoxBut.Location = new System.Drawing.Point(119, 255);
            this.BoxBut.Name = "BoxBut";
            this.BoxBut.Size = new System.Drawing.Size(270, 41);
            this.BoxBut.TabIndex = 2;
            this.BoxBut.Text = "Box";
            this.BoxBut.UseVisualStyleBackColor = false;
            this.BoxBut.UseWaitCursor = true;
            this.BoxBut.Click += new System.EventHandler(this.BoxBut_Click);
            // 
            // VolleyballBut
            // 
            this.VolleyballBut.AutoSize = true;
            this.VolleyballBut.BackColor = System.Drawing.Color.Gold;
            this.VolleyballBut.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.VolleyballBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.VolleyballBut.Location = new System.Drawing.Point(119, 194);
            this.VolleyballBut.Name = "VolleyballBut";
            this.VolleyballBut.Size = new System.Drawing.Size(270, 41);
            this.VolleyballBut.TabIndex = 3;
            this.VolleyballBut.Text = "Volleyball";
            this.VolleyballBut.UseVisualStyleBackColor = false;
            this.VolleyballBut.UseWaitCursor = true;
            this.VolleyballBut.Click += new System.EventHandler(this.VolleyballBut_Click);
            // 
            // YogaBut
            // 
            this.YogaBut.AutoSize = true;
            this.YogaBut.BackColor = System.Drawing.Color.Gold;
            this.YogaBut.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.YogaBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.YogaBut.Location = new System.Drawing.Point(119, 313);
            this.YogaBut.Name = "YogaBut";
            this.YogaBut.Size = new System.Drawing.Size(270, 41);
            this.YogaBut.TabIndex = 4;
            this.YogaBut.Text = "Yoga";
            this.YogaBut.UseVisualStyleBackColor = false;
            this.YogaBut.UseWaitCursor = true;
            this.YogaBut.Click += new System.EventHandler(this.YogaBut_Click);
            // 
            // TennisBut
            // 
            this.TennisBut.AutoSize = true;
            this.TennisBut.BackColor = System.Drawing.Color.Gold;
            this.TennisBut.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.TennisBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.TennisBut.Location = new System.Drawing.Point(119, 373);
            this.TennisBut.Name = "TennisBut";
            this.TennisBut.Size = new System.Drawing.Size(270, 41);
            this.TennisBut.TabIndex = 5;
            this.TennisBut.Text = "Tennis";
            this.TennisBut.UseVisualStyleBackColor = false;
            this.TennisBut.UseWaitCursor = true;
            this.TennisBut.Click += new System.EventHandler(this.TennisBut_Click);
            // 
            // ConfirmBut
            // 
            this.ConfirmBut.BackColor = System.Drawing.Color.Lime;
            this.ConfirmBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ConfirmBut.Location = new System.Drawing.Point(339, 559);
            this.ConfirmBut.Name = "ConfirmBut";
            this.ConfirmBut.Size = new System.Drawing.Size(160, 50);
            this.ConfirmBut.TabIndex = 6;
            this.ConfirmBut.Text = "Confirm";
            this.ConfirmBut.UseVisualStyleBackColor = false;
            this.ConfirmBut.Click += new System.EventHandler(this.ConfirmBut_Click);
            // 
            // MemberShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(521, 646);
            this.Controls.Add(this.ConfirmBut);
            this.Controls.Add(this.TennisBut);
            this.Controls.Add(this.YogaBut);
            this.Controls.Add(this.VolleyballBut);
            this.Controls.Add(this.BoxBut);
            this.Controls.Add(this.GymBut);
            this.Controls.Add(this.label1);
            this.Name = "MemberShip";
            this.Text = "MemberShip";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button ConfirmBut;

        private System.Windows.Forms.Button TennisBut;

        private System.Windows.Forms.Button BoxBut;
        private System.Windows.Forms.Button VolleyballBut;
        private System.Windows.Forms.Button YogaBut;

        private System.Windows.Forms.Button GymBut;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}