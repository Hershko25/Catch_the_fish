namespace Hw002
{
    partial class TheGame
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
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LifeTxt = new System.Windows.Forms.Label();
            this.scoreTxt = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.BestScorelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Image = global::Hw002.Properties.Resources.cancer_2;
            this.player.Location = new System.Drawing.Point(284, 579);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 50);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Tag = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hw002.Properties.Resources.Fish;
            this.pictureBox2.Location = new System.Drawing.Point(314, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "fish";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hw002.Properties.Resources.Fish;
            this.pictureBox3.Location = new System.Drawing.Point(492, 72);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "fish";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Hw002.Properties.Resources.Fish;
            this.pictureBox4.Location = new System.Drawing.Point(118, 72);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "fish";
            // 
            // LifeTxt
            // 
            this.LifeTxt.AutoSize = true;
            this.LifeTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LifeTxt.Location = new System.Drawing.Point(510, 13);
            this.LifeTxt.Name = "LifeTxt";
            this.LifeTxt.Size = new System.Drawing.Size(148, 35);
            this.LifeTxt.TabIndex = 1;
            this.LifeTxt.Text = "Life left: 5";
            // 
            // scoreTxt
            // 
            this.scoreTxt.AutoSize = true;
            this.scoreTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.scoreTxt.Location = new System.Drawing.Point(298, 13);
            this.scoreTxt.Name = "scoreTxt";
            this.scoreTxt.Size = new System.Drawing.Size(128, 35);
            this.scoreTxt.TabIndex = 1;
            this.scoreTxt.Text = "Eated : 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // BestScorelbl
            // 
            this.BestScorelbl.AutoSize = true;
            this.BestScorelbl.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BestScorelbl.Location = new System.Drawing.Point(66, 13);
            this.BestScorelbl.Name = "BestScorelbl";
            this.BestScorelbl.Size = new System.Drawing.Size(171, 35);
            this.BestScorelbl.TabIndex = 2;
            this.BestScorelbl.Text = "Best score : ";
            // 
            // TheGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hw002.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 674);
            this.Controls.Add(this.BestScorelbl);
            this.Controls.Add(this.scoreTxt);
            this.Controls.Add(this.LifeTxt);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.player);
            this.Name = "TheGame";
            this.Text = "TheGame";
            this.Load += new System.EventHandler(this.TheGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label LifeTxt;
        private System.Windows.Forms.Label scoreTxt;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label BestScorelbl;
    }
}