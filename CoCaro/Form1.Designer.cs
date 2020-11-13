namespace CoCaro
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.battleFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorChessbroadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rb_Caro = new System.Windows.Forms.RadioButton();
            this.rb_Gomoku = new System.Windows.Forms.RadioButton();
            this.bt_PVP = new System.Windows.Forms.Button();
            this.bt_BF = new System.Windows.Forms.Button();
            this.bt_PVC = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.lb_P2Win = new System.Windows.Forms.Label();
            this.lb_P1Win = new System.Windows.Forms.Label();
            this.lb_Level = new System.Windows.Forms.Label();
            this.pn_Banco = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerVsPlayerToolStripMenuItem,
            this.battleFillToolStripMenuItem,
            this.playerVsComputerToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // playerVsPlayerToolStripMenuItem
            // 
            this.playerVsPlayerToolStripMenuItem.Name = "playerVsPlayerToolStripMenuItem";
            this.playerVsPlayerToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.playerVsPlayerToolStripMenuItem.Text = "Player vs Player";
            this.playerVsPlayerToolStripMenuItem.Click += new System.EventHandler(this.playerVsPlayerToolStripMenuItem_Click);
            // 
            // battleFillToolStripMenuItem
            // 
            this.battleFillToolStripMenuItem.Name = "battleFillToolStripMenuItem";
            this.battleFillToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.battleFillToolStripMenuItem.Text = "Battle Fill";
            // 
            // playerVsComputerToolStripMenuItem
            // 
            this.playerVsComputerToolStripMenuItem.Name = "playerVsComputerToolStripMenuItem";
            this.playerVsComputerToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.playerVsComputerToolStripMenuItem.Text = "Player vs Computer";
            this.playerVsComputerToolStripMenuItem.Click += new System.EventHandler(this.playerVsComputerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.colorFormToolStripMenuItem,
            this.colorChessbroadToolStripMenuItem,
            this.colorLineToolStripMenuItem,
            this.colorXToolStripMenuItem,
            this.colorOToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click_1);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click_1);
            // 
            // colorFormToolStripMenuItem
            // 
            this.colorFormToolStripMenuItem.Name = "colorFormToolStripMenuItem";
            this.colorFormToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.colorFormToolStripMenuItem.Text = "Color Form";
            this.colorFormToolStripMenuItem.Click += new System.EventHandler(this.colorFormToolStripMenuItem_Click);
            // 
            // colorChessbroadToolStripMenuItem
            // 
            this.colorChessbroadToolStripMenuItem.Name = "colorChessbroadToolStripMenuItem";
            this.colorChessbroadToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.colorChessbroadToolStripMenuItem.Text = "Color Chessboard";
            this.colorChessbroadToolStripMenuItem.Click += new System.EventHandler(this.colorChessbroadToolStripMenuItem_Click);
            // 
            // colorLineToolStripMenuItem
            // 
            this.colorLineToolStripMenuItem.Name = "colorLineToolStripMenuItem";
            this.colorLineToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.colorLineToolStripMenuItem.Text = "Color Line";
            this.colorLineToolStripMenuItem.Click += new System.EventHandler(this.colorLineToolStripMenuItem_Click);
            // 
            // colorXToolStripMenuItem
            // 
            this.colorXToolStripMenuItem.Name = "colorXToolStripMenuItem";
            this.colorXToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.colorXToolStripMenuItem.Text = "Color X";
            this.colorXToolStripMenuItem.Click += new System.EventHandler(this.colorXToolStripMenuItem_Click);
            // 
            // colorOToolStripMenuItem
            // 
            this.colorOToolStripMenuItem.Name = "colorOToolStripMenuItem";
            this.colorOToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.colorOToolStripMenuItem.Text = "Color O";
            this.colorOToolStripMenuItem.Click += new System.EventHandler(this.colorOToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.howToPlayToolStripMenuItem.Text = "How To Play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CoCaro.Properties.Resources.Caro;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(575, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 205);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // rb_Caro
            // 
            this.rb_Caro.AutoSize = true;
            this.rb_Caro.BackColor = System.Drawing.Color.Transparent;
            this.rb_Caro.Font = new System.Drawing.Font("Segoe Script", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Caro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rb_Caro.Location = new System.Drawing.Point(585, 279);
            this.rb_Caro.Name = "rb_Caro";
            this.rb_Caro.Size = new System.Drawing.Size(71, 32);
            this.rb_Caro.TabIndex = 3;
            this.rb_Caro.TabStop = true;
            this.rb_Caro.Text = "Caro";
            this.rb_Caro.UseVisualStyleBackColor = false;
            this.rb_Caro.CheckedChanged += new System.EventHandler(this.rb_Caro_CheckedChanged);
            // 
            // rb_Gomoku
            // 
            this.rb_Gomoku.AutoSize = true;
            this.rb_Gomoku.BackColor = System.Drawing.Color.Transparent;
            this.rb_Gomoku.Font = new System.Drawing.Font("Segoe Script", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Gomoku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rb_Gomoku.Location = new System.Drawing.Point(671, 280);
            this.rb_Gomoku.Name = "rb_Gomoku";
            this.rb_Gomoku.Size = new System.Drawing.Size(102, 32);
            this.rb_Gomoku.TabIndex = 4;
            this.rb_Gomoku.TabStop = true;
            this.rb_Gomoku.Text = "Gomoku";
            this.rb_Gomoku.UseVisualStyleBackColor = false;
            this.rb_Gomoku.CheckedChanged += new System.EventHandler(this.rb_Gomoku_CheckedChanged);
            // 
            // bt_PVP
            // 
            this.bt_PVP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_PVP.Font = new System.Drawing.Font("Segoe Script", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_PVP.ForeColor = System.Drawing.Color.White;
            this.bt_PVP.Location = new System.Drawing.Point(575, 337);
            this.bt_PVP.Name = "bt_PVP";
            this.bt_PVP.Size = new System.Drawing.Size(205, 50);
            this.bt_PVP.TabIndex = 5;
            this.bt_PVP.Text = "Player vs Player";
            this.bt_PVP.UseVisualStyleBackColor = false;
            this.bt_PVP.Click += new System.EventHandler(this.bt_PVP_Click);
            // 
            // bt_BF
            // 
            this.bt_BF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_BF.Font = new System.Drawing.Font("Segoe Script", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_BF.ForeColor = System.Drawing.Color.White;
            this.bt_BF.Location = new System.Drawing.Point(575, 393);
            this.bt_BF.Name = "bt_BF";
            this.bt_BF.Size = new System.Drawing.Size(205, 50);
            this.bt_BF.TabIndex = 6;
            this.bt_BF.Text = "Battle Fill";
            this.bt_BF.UseVisualStyleBackColor = false;
            this.bt_BF.Click += new System.EventHandler(this.bt_BF_Click);
            // 
            // bt_PVC
            // 
            this.bt_PVC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_PVC.Font = new System.Drawing.Font("Segoe Script", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_PVC.ForeColor = System.Drawing.Color.White;
            this.bt_PVC.Location = new System.Drawing.Point(575, 449);
            this.bt_PVC.Name = "bt_PVC";
            this.bt_PVC.Size = new System.Drawing.Size(205, 50);
            this.bt_PVC.TabIndex = 7;
            this.bt_PVC.Text = "Player vs Computer";
            this.bt_PVC.UseVisualStyleBackColor = false;
            this.bt_PVC.Click += new System.EventHandler(this.bt_PVC_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_Exit.Font = new System.Drawing.Font("Segoe Script", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.ForeColor = System.Drawing.Color.White;
            this.bt_Exit.Location = new System.Drawing.Point(575, 505);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(205, 50);
            this.bt_Exit.TabIndex = 8;
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // lb_P2Win
            // 
            this.lb_P2Win.AutoSize = true;
            this.lb_P2Win.BackColor = System.Drawing.Color.Transparent;
            this.lb_P2Win.Font = new System.Drawing.Font("Segoe Script", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_P2Win.ForeColor = System.Drawing.Color.Red;
            this.lb_P2Win.Location = new System.Drawing.Point(680, 30);
            this.lb_P2Win.Name = "lb_P2Win";
            this.lb_P2Win.Size = new System.Drawing.Size(108, 28);
            this.lb_P2Win.TabIndex = 14;
            this.lb_P2Win.Text = "Player2: 0";
            // 
            // lb_P1Win
            // 
            this.lb_P1Win.AutoSize = true;
            this.lb_P1Win.BackColor = System.Drawing.Color.Transparent;
            this.lb_P1Win.Font = new System.Drawing.Font("Segoe Script", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_P1Win.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_P1Win.Location = new System.Drawing.Point(566, 30);
            this.lb_P1Win.Name = "lb_P1Win";
            this.lb_P1Win.Size = new System.Drawing.Size(108, 28);
            this.lb_P1Win.TabIndex = 15;
            this.lb_P1Win.Text = "Player1: 0";
            // 
            // lb_Level
            // 
            this.lb_Level.AutoSize = true;
            this.lb_Level.BackColor = System.Drawing.Color.Transparent;
            this.lb_Level.Font = new System.Drawing.Font("Segoe Script", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lb_Level.Location = new System.Drawing.Point(606, 306);
            this.lb_Level.Name = "lb_Level";
            this.lb_Level.Size = new System.Drawing.Size(142, 28);
            this.lb_Level.TabIndex = 17;
            this.lb_Level.Text = "Level: Normal";
            // 
            // pn_Banco
            // 
            this.pn_Banco.Location = new System.Drawing.Point(45, 19);
            this.pn_Banco.Name = "pn_Banco";
            this.pn_Banco.Size = new System.Drawing.Size(501, 501);
            this.pn_Banco.TabIndex = 18;
            this.pn_Banco.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Banco_Paint);
            this.pn_Banco.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pn_Banco_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CoCaro.Properties.Resources.ChessBoard;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pn_Banco);
            this.panel1.Location = new System.Drawing.Point(6, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 539);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(799, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_Level);
            this.Controls.Add(this.lb_P1Win);
            this.Controls.Add(this.lb_P2Win);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_PVC);
            this.Controls.Add(this.bt_BF);
            this.Controls.Add(this.bt_PVP);
            this.Controls.Add(this.rb_Gomoku);
            this.Controls.Add(this.rb_Caro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Caro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem battleFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colorLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorOToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rb_Caro;
        private System.Windows.Forms.RadioButton rb_Gomoku;
        private System.Windows.Forms.Button bt_PVP;
        private System.Windows.Forms.Button bt_BF;
        private System.Windows.Forms.Button bt_PVC;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Label lb_P2Win;
        private System.Windows.Forms.Label lb_P1Win;
        private System.Windows.Forms.Label lb_Level;
        private System.Windows.Forms.Panel pn_Banco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem colorChessbroadToolStripMenuItem;
    }
}

