namespace SpaceShooter
{
    partial class SpaceShooter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceShooter));
            this.MoveBgTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTittle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MoveBgTimer
            // 
            this.MoveBgTimer.Enabled = true;
            this.MoveBgTimer.Interval = 10;
            this.MoveBgTimer.Tick += new System.EventHandler(this.MoveBgTimer_Tick);
            // 
            // lblTittle
            // 
            this.lblTittle.BackColor = System.Drawing.Color.Black;
            this.lblTittle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTittle.Font = new System.Drawing.Font("ROG Fonts", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTittle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTittle.Location = new System.Drawing.Point(139, 62);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTittle.Size = new System.Drawing.Size(315, 170);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "SPACE SHOOTER";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTittle.Click += new System.EventHandler(this.lblTittle_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(139, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(308, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SpaceShooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTittle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "SpaceShooter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Shooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MoveBgTimer;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

