namespace SpaceShooter
{
    partial class startscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startscreen));
            this.MoveBgTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.RightMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.DownMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.UpMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.MoveMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveEnemiesTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemiesMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.Replaybtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scorelbl = new System.Windows.Forms.Label();
            this.levellbl = new System.Windows.Forms.Label();
            this.labels = new System.Windows.Forms.Label();
            this.labell = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBgTimer
            // 
            this.MoveBgTimer.Enabled = true;
            this.MoveBgTimer.Interval = 10;
            this.MoveBgTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LeftMoveTimer
            // 
            this.LeftMoveTimer.Interval = 5;
            this.LeftMoveTimer.Tick += new System.EventHandler(this.LeftMoveTimer_Tick);
            // 
            // RightMoveTimer
            // 
            this.RightMoveTimer.Interval = 5;
            this.RightMoveTimer.Tick += new System.EventHandler(this.RightMoveTimer_Tick);
            // 
            // DownMoveTimer
            // 
            this.DownMoveTimer.Interval = 5;
            this.DownMoveTimer.Tick += new System.EventHandler(this.DownMoveTimer_Tick);
            // 
            // UpMoveTimer
            // 
            this.UpMoveTimer.Interval = 5;
            this.UpMoveTimer.Tick += new System.EventHandler(this.UpMoveTimer_Tick);
            // 
            // Player
            // 
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(260, 400);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(40, 40);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // MoveMunitionTimer
            // 
            this.MoveMunitionTimer.Enabled = true;
            this.MoveMunitionTimer.Interval = 20;
            this.MoveMunitionTimer.Tick += new System.EventHandler(this.MoveMunitionTimer_Tick);
            // 
            // MoveEnemiesTimer
            // 
            this.MoveEnemiesTimer.Enabled = true;
            this.MoveEnemiesTimer.Tick += new System.EventHandler(this.MoveEnemiesTimer_Tick);
            // 
            // EnemiesMunitionTimer
            // 
            this.EnemiesMunitionTimer.Enabled = true;
            this.EnemiesMunitionTimer.Interval = 20;
            this.EnemiesMunitionTimer.Tick += new System.EventHandler(this.EnemiesMunitionTimer_Tick);
            // 
            // Replaybtn
            // 
            this.Replaybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replaybtn.ForeColor = System.Drawing.Color.Black;
            this.Replaybtn.Location = new System.Drawing.Point(207, 214);
            this.Replaybtn.Name = "Replaybtn";
            this.Replaybtn.Size = new System.Drawing.Size(150, 50);
            this.Replaybtn.TabIndex = 1;
            this.Replaybtn.Text = "Replay";
            this.Replaybtn.UseVisualStyleBackColor = true;
            this.Replaybtn.Visible = false;
            this.Replaybtn.Click += new System.EventHandler(this.Replaybtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.ForeColor = System.Drawing.Color.Black;
            this.Exitbtn.Location = new System.Drawing.Point(207, 297);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(150, 50);
            this.Exitbtn.TabIndex = 2;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Visible = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(196, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.ForeColor = System.Drawing.Color.DarkKhaki;
            this.scorelbl.Location = new System.Drawing.Point(82, 13);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(36, 26);
            this.scorelbl.TabIndex = 4;
            this.scorelbl.Text = "01";
            // 
            // levellbl
            // 
            this.levellbl.AutoSize = true;
            this.levellbl.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levellbl.ForeColor = System.Drawing.Color.DarkKhaki;
            this.levellbl.Location = new System.Drawing.Point(539, 13);
            this.levellbl.Name = "levellbl";
            this.levellbl.Size = new System.Drawing.Size(42, 26);
            this.levellbl.TabIndex = 5;
            this.levellbl.Text = "00";
            // 
            // labels
            // 
            this.labels.AutoSize = true;
            this.labels.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labels.ForeColor = System.Drawing.Color.DarkKhaki;
            this.labels.Location = new System.Drawing.Point(0, 13);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(76, 26);
            this.labels.TabIndex = 6;
            this.labels.Text = "Score:";
            this.labels.Click += new System.EventHandler(this.labels_Click);
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labell.ForeColor = System.Drawing.Color.DarkKhaki;
            this.labell.Location = new System.Drawing.Point(468, 13);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(65, 26);
            this.labell.TabIndex = 7;
            this.labell.Text = "level:";
            // 
            // startscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.labell);
            this.Controls.Add(this.labels);
            this.Controls.Add(this.levellbl);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Replaybtn);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "startscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "startscreen";
            this.Load += new System.EventHandler(this.startscreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startscreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.startscreen_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer MoveBgTimer;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer RightMoveTimer;
        private System.Windows.Forms.Timer DownMoveTimer;
        private System.Windows.Forms.Timer UpMoveTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer MoveMunitionTimer;
        private System.Windows.Forms.Timer MoveEnemiesTimer;
        private System.Windows.Forms.Timer EnemiesMunitionTimer;
        private System.Windows.Forms.Button Replaybtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label levellbl;
        private System.Windows.Forms.Label labels;
        private System.Windows.Forms.Label labell;
    }
}