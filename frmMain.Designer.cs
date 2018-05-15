namespace HomerGUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNorth = new System.Windows.Forms.Label();
            this.lblSouth = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pbWin = new System.Windows.Forms.PictureBox();
            this.pbLose = new System.Windows.Forms.PictureBox();
            this.pbDogS = new System.Windows.Forms.PictureBox();
            this.pbPoisonS = new System.Windows.Forms.PictureBox();
            this.pbMaggieS = new System.Windows.Forms.PictureBox();
            this.pbDogN = new System.Windows.Forms.PictureBox();
            this.pbMaggieN = new System.Windows.Forms.PictureBox();
            this.pbPoisonN = new System.Windows.Forms.PictureBox();
            this.pbRiver = new System.Windows.Forms.PictureBox();
            this.pbHomerN = new System.Windows.Forms.PictureBox();
            this.pbHomerS = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoisonS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaggieS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaggieN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoisonN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomerN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomerS)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Goal: Get following to the South Bank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;            
            // 
            // lblNorth
            // 
            this.lblNorth.AutoSize = true;
            this.lblNorth.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblNorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNorth.Location = new System.Drawing.Point(23, 59);
            this.lblNorth.Name = "lblNorth";
            this.lblNorth.Size = new System.Drawing.Size(84, 16);
            this.lblNorth.TabIndex = 4;
            this.lblNorth.Text = "North Bank";
            // 
            // lblSouth
            // 
            this.lblSouth.AutoSize = true;
            this.lblSouth.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblSouth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSouth.Location = new System.Drawing.Point(614, 59);
            this.lblSouth.Name = "lblSouth";
            this.lblSouth.Size = new System.Drawing.Size(86, 16);
            this.lblSouth.TabIndex = 5;
            this.lblSouth.Text = "South Bank";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblDescription.Location = new System.Drawing.Point(417, 169);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(34, 13);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "         ";
            // 
            // pbWin
            // 
            this.pbWin.Image = global::HomerGUI.Properties.Resources.GameOver_Won;
            this.pbWin.Location = new System.Drawing.Point(311, 148);
            this.pbWin.Name = "pbWin";
            this.pbWin.Size = new System.Drawing.Size(100, 103);
            this.pbWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWin.TabIndex = 13;
            this.pbWin.TabStop = false;
            // 
            // pbLose
            // 
            this.pbLose.Image = global::HomerGUI.Properties.Resources.GameOver_Lose;
            this.pbLose.Location = new System.Drawing.Point(311, 148);
            this.pbLose.Name = "pbLose";
            this.pbLose.Size = new System.Drawing.Size(98, 103);
            this.pbLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLose.TabIndex = 12;
            this.pbLose.TabStop = false;
            // 
            // pbDogS
            // 
            this.pbDogS.Image = global::HomerGUI.Properties.Resources.Dog;
            this.pbDogS.Location = new System.Drawing.Point(619, 384);
            this.pbDogS.Name = "pbDogS";
            this.pbDogS.Size = new System.Drawing.Size(81, 73);
            this.pbDogS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDogS.TabIndex = 11;
            this.pbDogS.TabStop = false;
            this.pbDogS.Click += new System.EventHandler(this.pbDogS_Click);
            // 
            // pbPoisonS
            // 
            this.pbPoisonS.Image = ((System.Drawing.Image)(resources.GetObject("pbPoisonS.Image")));
            this.pbPoisonS.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbPoisonS.InitialImage")));
            this.pbPoisonS.Location = new System.Drawing.Point(639, 280);
            this.pbPoisonS.Name = "pbPoisonS";
            this.pbPoisonS.Size = new System.Drawing.Size(43, 98);
            this.pbPoisonS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPoisonS.TabIndex = 10;
            this.pbPoisonS.TabStop = false;
            this.pbPoisonS.Click += new System.EventHandler(this.pbPoisonS_Click);
            // 
            // pbMaggieS
            // 
            this.pbMaggieS.Image = ((System.Drawing.Image)(resources.GetObject("pbMaggieS.Image")));
            this.pbMaggieS.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMaggieS.InitialImage")));
            this.pbMaggieS.Location = new System.Drawing.Point(619, 195);
            this.pbMaggieS.Name = "pbMaggieS";
            this.pbMaggieS.Size = new System.Drawing.Size(81, 79);
            this.pbMaggieS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaggieS.TabIndex = 9;
            this.pbMaggieS.TabStop = false;
            this.pbMaggieS.Click += new System.EventHandler(this.pbMaggieS_Click);
            // 
            // pbDogN
            // 
            this.pbDogN.Image = global::HomerGUI.Properties.Resources.Dog;
            this.pbDogN.Location = new System.Drawing.Point(26, 384);
            this.pbDogN.Name = "pbDogN";
            this.pbDogN.Size = new System.Drawing.Size(81, 73);
            this.pbDogN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDogN.TabIndex = 7;
            this.pbDogN.TabStop = false;
            this.pbDogN.Click += new System.EventHandler(this.pbDogN_Click);
            // 
            // pbMaggieN
            // 
            this.pbMaggieN.Image = ((System.Drawing.Image)(resources.GetObject("pbMaggieN.Image")));
            this.pbMaggieN.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMaggieN.InitialImage")));
            this.pbMaggieN.Location = new System.Drawing.Point(26, 195);
            this.pbMaggieN.Name = "pbMaggieN";
            this.pbMaggieN.Size = new System.Drawing.Size(81, 79);
            this.pbMaggieN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaggieN.TabIndex = 3;
            this.pbMaggieN.TabStop = false;
            this.pbMaggieN.Click += new System.EventHandler(this.pbMaggieN_Click);
            // 
            // pbPoisonN
            // 
            this.pbPoisonN.Image = ((System.Drawing.Image)(resources.GetObject("pbPoisonN.Image")));
            this.pbPoisonN.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbPoisonN.InitialImage")));
            this.pbPoisonN.Location = new System.Drawing.Point(45, 280);
            this.pbPoisonN.Name = "pbPoisonN";
            this.pbPoisonN.Size = new System.Drawing.Size(43, 98);
            this.pbPoisonN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPoisonN.TabIndex = 2;
            this.pbPoisonN.TabStop = false;
            this.pbPoisonN.Click += new System.EventHandler(this.pbPoisonN_Click);
            // 
            // pbRiver
            // 
            this.pbRiver.Image = global::HomerGUI.Properties.Resources.River;
            this.pbRiver.Location = new System.Drawing.Point(-8, 12);
            this.pbRiver.Name = "pbRiver";
            this.pbRiver.Size = new System.Drawing.Size(766, 476);
            this.pbRiver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRiver.TabIndex = 6;
            this.pbRiver.TabStop = false;
            // 
            // pbHomerN
            // 
            this.pbHomerN.Image = global::HomerGUI.Properties.Resources.Homer1;
            this.pbHomerN.Location = new System.Drawing.Point(26, 96);
            this.pbHomerN.Name = "pbHomerN";
            this.pbHomerN.Size = new System.Drawing.Size(81, 78);
            this.pbHomerN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHomerN.TabIndex = 15;
            this.pbHomerN.TabStop = false;
            this.pbHomerN.Click += new System.EventHandler(this.pbHomerN_Click);
            // 
            // pbHomerS
            // 
            this.pbHomerS.Image = global::HomerGUI.Properties.Resources.Homer1;
            this.pbHomerS.Location = new System.Drawing.Point(617, 96);
            this.pbHomerS.Name = "pbHomerS";
            this.pbHomerS.Size = new System.Drawing.Size(83, 78);
            this.pbHomerS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHomerS.TabIndex = 16;
            this.pbHomerS.TabStop = false;
            this.pbHomerS.Click += new System.EventHandler(this.pbHomerS_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutGameToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutGameToolStripMenuItem
            // 
            this.aboutGameToolStripMenuItem.Name = "aboutGameToolStripMenuItem";
            this.aboutGameToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutGameToolStripMenuItem.Text = "About Game";
            this.aboutGameToolStripMenuItem.Click += new System.EventHandler(this.aboutGameToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(746, 479);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbHomerS);
            this.Controls.Add(this.pbHomerN);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pbWin);
            this.Controls.Add(this.pbLose);
            this.Controls.Add(this.pbDogS);
            this.Controls.Add(this.pbPoisonS);
            this.Controls.Add(this.pbMaggieS);
            this.Controls.Add(this.pbDogN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSouth);
            this.Controls.Add(this.lblNorth);
            this.Controls.Add(this.pbMaggieN);
            this.Controls.Add(this.pbPoisonN);
            this.Controls.Add(this.pbRiver);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Welcome to Homer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoisonS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaggieS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaggieN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoisonN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomerN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomerS)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPoisonN;
        private System.Windows.Forms.PictureBox pbMaggieN;
        private System.Windows.Forms.Label lblNorth;
        private System.Windows.Forms.PictureBox pbDogN;
        private System.Windows.Forms.PictureBox pbMaggieS;
        private System.Windows.Forms.PictureBox pbPoisonS;
        private System.Windows.Forms.PictureBox pbDogS;
        private System.Windows.Forms.Label lblSouth;
        private System.Windows.Forms.PictureBox pbRiver;
        private System.Windows.Forms.PictureBox pbLose;
        private System.Windows.Forms.PictureBox pbWin;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pbHomerN;
        private System.Windows.Forms.PictureBox pbHomerS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutGameToolStripMenuItem;
    }
}

