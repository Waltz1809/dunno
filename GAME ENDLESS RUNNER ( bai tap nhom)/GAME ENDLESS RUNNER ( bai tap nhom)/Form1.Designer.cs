namespace InuWayBackHome
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
            this.components = new System.ComponentModel.Container();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.inu = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.inu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(50, 68);
            this.txtScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(112, 30);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Score : 0";
            this.txtScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimeEvent);
            // 
            // inu
            // 
            this.inu.BackColor = System.Drawing.Color.Transparent;
            this.inu.Image = global::InuWayBackHome.Properties.Resources.shibasmall;
            this.inu.Location = new System.Drawing.Point(150, 331);
            this.inu.Margin = new System.Windows.Forms.Padding(2);
            this.inu.Name = "inu";
            this.inu.Size = new System.Drawing.Size(40, 43);
            this.inu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.inu.TabIndex = 0;
            this.inu.TabStop = false;
            this.inu.Click += new System.EventHandler(this.inu_Click);
            // 
            // obstacle1
            // 
            this.obstacle1.Image = global::InuWayBackHome.Properties.Resources.wolf;
            this.obstacle1.Location = new System.Drawing.Point(454, 329);
            this.obstacle1.Margin = new System.Windows.Forms.Padding(2);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(40, 45);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle1.TabIndex = 3;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "obstacle";
            this.obstacle1.Click += new System.EventHandler(this.obstacle1_Click);
            // 
            // obstacle2
            // 
            this.obstacle2.Image = global::InuWayBackHome.Properties.Resources.thief1;
            this.obstacle2.Location = new System.Drawing.Point(355, 324);
            this.obstacle2.Margin = new System.Windows.Forms.Padding(2);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(50, 50);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle2.TabIndex = 2;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle";
            this.obstacle2.Click += new System.EventHandler(this.obstacle2_Click);
            // 
            // background
            // 
            this.background.Image = global::InuWayBackHome.Properties.Resources.background;
            this.background.Location = new System.Drawing.Point(-1, -5);
            this.background.Margin = new System.Windows.Forms.Padding(2);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(625, 457);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 1;
            this.background.TabStop = false;
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 453);
            this.Controls.Add(this.inu);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.background);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Inu\'s Way Back Home";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.inu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox inu;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

