namespace Racetrack_Simulator
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.bettingParlor = new System.Windows.Forms.GroupBox();
            this.raceButton = new System.Windows.Forms.Button();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.placeBetButton = new System.Windows.Forms.Button();
            this.betsLabel = new System.Windows.Forms.Label();
            this.dogBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.dogPicture4 = new System.Windows.Forms.PictureBox();
            this.dogPicture3 = new System.Windows.Forms.PictureBox();
            this.dogPicture2 = new System.Windows.Forms.PictureBox();
            this.dogPicture1 = new System.Windows.Forms.PictureBox();
            this.raceTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            this.bettingParlor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrack
            // 
            this.raceTrack.Dock = System.Windows.Forms.DockStyle.Top;
            this.raceTrack.Image = ((System.Drawing.Image)(resources.GetObject("raceTrack.Image")));
            this.raceTrack.Location = new System.Drawing.Point(0, 0);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(883, 358);
            this.raceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrack.TabIndex = 0;
            this.raceTrack.TabStop = false;
            // 
            // bettingParlor
            // 
            this.bettingParlor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bettingParlor.Controls.Add(this.raceButton);
            this.bettingParlor.Controls.Add(this.alBetLabel);
            this.bettingParlor.Controls.Add(this.bobBetLabel);
            this.bettingParlor.Controls.Add(this.joeBetLabel);
            this.bettingParlor.Controls.Add(this.placeBetButton);
            this.bettingParlor.Controls.Add(this.betsLabel);
            this.bettingParlor.Controls.Add(this.dogBox);
            this.bettingParlor.Controls.Add(this.label2);
            this.bettingParlor.Controls.Add(this.amountBox);
            this.bettingParlor.Controls.Add(this.nameLabel);
            this.bettingParlor.Controls.Add(this.alRadioButton);
            this.bettingParlor.Controls.Add(this.bobRadioButton);
            this.bettingParlor.Controls.Add(this.joeRadioButton);
            this.bettingParlor.Controls.Add(this.minimumBetLabel);
            this.bettingParlor.Location = new System.Drawing.Point(11, 365);
            this.bettingParlor.Name = "bettingParlor";
            this.bettingParlor.Size = new System.Drawing.Size(859, 189);
            this.bettingParlor.TabIndex = 1;
            this.bettingParlor.TabStop = false;
            this.bettingParlor.Text = "Betting Parlor";
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(680, 51);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(155, 99);
            this.raceButton.TabIndex = 13;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.RaceButton_Click);
            // 
            // alBetLabel
            // 
            this.alBetLabel.Location = new System.Drawing.Point(387, 112);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(253, 23);
            this.alBetLabel.TabIndex = 12;
            this.alBetLabel.Text = "Al hasn\'t placed a bet";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.Location = new System.Drawing.Point(387, 83);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(253, 23);
            this.bobBetLabel.TabIndex = 11;
            this.bobBetLabel.Text = "Bob hasn\'t placed a bet";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.Location = new System.Drawing.Point(387, 54);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(253, 23);
            this.joeBetLabel.TabIndex = 10;
            this.joeBetLabel.Text = "Joe hasn\'t placed a bet";
            // 
            // placeBetButton
            // 
            this.placeBetButton.AutoSize = true;
            this.placeBetButton.Location = new System.Drawing.Point(323, 143);
            this.placeBetButton.Name = "placeBetButton";
            this.placeBetButton.Size = new System.Drawing.Size(78, 27);
            this.placeBetButton.TabIndex = 9;
            this.placeBetButton.Text = "Place Bet";
            this.placeBetButton.UseVisualStyleBackColor = true;
            this.placeBetButton.Click += new System.EventHandler(this.PlaceBetButton_Click);
            // 
            // betsLabel
            // 
            this.betsLabel.AutoSize = true;
            this.betsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betsLabel.Location = new System.Drawing.Point(386, 24);
            this.betsLabel.Name = "betsLabel";
            this.betsLabel.Size = new System.Drawing.Size(40, 17);
            this.betsLabel.TabIndex = 8;
            this.betsLabel.Text = "Bets";
            // 
            // dogBox
            // 
            this.dogBox.Location = new System.Drawing.Point(262, 145);
            this.dogBox.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogBox.Name = "dogBox";
            this.dogBox.Size = new System.Drawing.Size(46, 22);
            this.dogBox.TabIndex = 7;
            this.dogBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "on dog number";
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(85, 145);
            this.amountBox.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(67, 22);
            this.amountBox.TabIndex = 5;
            this.amountBox.Tag = "";
            this.amountBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 147);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 17);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Joe bets $";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(10, 111);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(96, 21);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.Text = "Al has $45";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.AlRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(10, 81);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(109, 21);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.Text = "Bob has $75";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.BobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Checked = true;
            this.joeRadioButton.Location = new System.Drawing.Point(10, 51);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(107, 21);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "Joe has $50";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.JoeRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(7, 24);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(127, 17);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "Minimum Bet: $5";
            // 
            // dogPicture4
            // 
            this.dogPicture4.Image = ((System.Drawing.Image)(resources.GetObject("dogPicture4.Image")));
            this.dogPicture4.Location = new System.Drawing.Point(14, 290);
            this.dogPicture4.Name = "dogPicture4";
            this.dogPicture4.Size = new System.Drawing.Size(75, 49);
            this.dogPicture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPicture4.TabIndex = 0;
            this.dogPicture4.TabStop = false;
            // 
            // dogPicture3
            // 
            this.dogPicture3.Image = ((System.Drawing.Image)(resources.GetObject("dogPicture3.Image")));
            this.dogPicture3.Location = new System.Drawing.Point(14, 199);
            this.dogPicture3.Name = "dogPicture3";
            this.dogPicture3.Size = new System.Drawing.Size(75, 49);
            this.dogPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPicture3.TabIndex = 1;
            this.dogPicture3.TabStop = false;
            // 
            // dogPicture2
            // 
            this.dogPicture2.Image = ((System.Drawing.Image)(resources.GetObject("dogPicture2.Image")));
            this.dogPicture2.Location = new System.Drawing.Point(14, 107);
            this.dogPicture2.Name = "dogPicture2";
            this.dogPicture2.Size = new System.Drawing.Size(75, 49);
            this.dogPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPicture2.TabIndex = 2;
            this.dogPicture2.TabStop = false;
            // 
            // dogPicture1
            // 
            this.dogPicture1.BackColor = System.Drawing.SystemColors.Control;
            this.dogPicture1.Image = ((System.Drawing.Image)(resources.GetObject("dogPicture1.Image")));
            this.dogPicture1.Location = new System.Drawing.Point(14, 17);
            this.dogPicture1.Name = "dogPicture1";
            this.dogPicture1.Size = new System.Drawing.Size(75, 49);
            this.dogPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPicture1.TabIndex = 3;
            this.dogPicture1.TabStop = false;
            // 
            // raceTimer
            // 
            this.raceTimer.Tick += new System.EventHandler(this.RaceTimer_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(883, 566);
            this.Controls.Add(this.dogPicture4);
            this.Controls.Add(this.dogPicture3);
            this.Controls.Add(this.dogPicture2);
            this.Controls.Add(this.dogPicture1);
            this.Controls.Add(this.bettingParlor);
            this.Controls.Add(this.raceTrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "Puppy races";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            this.bettingParlor.ResumeLayout(false);
            this.bettingParlor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.GroupBox bettingParlor;
        private System.Windows.Forms.PictureBox dogPicture4;
        private System.Windows.Forms.PictureBox dogPicture3;
        private System.Windows.Forms.PictureBox dogPicture2;
        private System.Windows.Forms.PictureBox dogPicture1;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.NumericUpDown dogBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown amountBox;
        private System.Windows.Forms.Button placeBetButton;
        private System.Windows.Forms.Label betsLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Timer raceTimer;
    }
}

