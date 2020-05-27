namespace TicTacToe
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.xWinCount = new System.Windows.Forms.Label();
            this.drawCount = new System.Windows.Forms.Label();
            this.oWinCount = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.setPlayerDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.resetWinsToolStripMenuItem,
            this.setPlayerDefaultsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
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
            // resetWinsToolStripMenuItem
            // 
            this.resetWinsToolStripMenuItem.Name = "resetWinsToolStripMenuItem";
            this.resetWinsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.resetWinsToolStripMenuItem.Text = "Reset Wins";
            this.resetWinsToolStripMenuItem.Click += new System.EventHandler(this.resetWinsToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.menuToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // a1
            // 
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.a1.Location = new System.Drawing.Point(12, 38);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(75, 75);
            this.a1.TabIndex = 1;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.buttonClick);
            this.a1.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.a1.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // a2
            // 
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.a2.Location = new System.Drawing.Point(93, 38);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(75, 75);
            this.a2.TabIndex = 1;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.buttonClick);
            this.a2.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.a2.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // a3
            // 
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.a3.Location = new System.Drawing.Point(174, 38);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(75, 75);
            this.a3.TabIndex = 1;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.buttonClick);
            this.a3.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.a3.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.b1.Location = new System.Drawing.Point(12, 119);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 75);
            this.b1.TabIndex = 1;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.buttonClick);
            this.b1.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.b1.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.b2.Location = new System.Drawing.Point(93, 119);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 75);
            this.b2.TabIndex = 1;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.buttonClick);
            this.b2.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.b2.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.b3.Location = new System.Drawing.Point(174, 119);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 75);
            this.b3.TabIndex = 1;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.buttonClick);
            this.b3.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.b3.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // c1
            // 
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.c1.Location = new System.Drawing.Point(12, 200);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(75, 75);
            this.c1.TabIndex = 1;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.buttonClick);
            this.c1.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.c1.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // c2
            // 
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.c2.Location = new System.Drawing.Point(93, 200);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(75, 75);
            this.c2.TabIndex = 1;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.buttonClick);
            this.c2.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.c2.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // c3
            // 
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.c3.Location = new System.Drawing.Point(174, 200);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(75, 75);
            this.c3.TabIndex = 1;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.buttonClick);
            this.c3.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.c3.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 287);
            this.label2.MaximumSize = new System.Drawing.Size(63, 13);
            this.label2.MinimumSize = new System.Drawing.Size(63, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Draw Count";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xWinCount
            // 
            this.xWinCount.AutoSize = true;
            this.xWinCount.Location = new System.Drawing.Point(43, 304);
            this.xWinCount.Name = "xWinCount";
            this.xWinCount.Size = new System.Drawing.Size(13, 13);
            this.xWinCount.TabIndex = 5;
            this.xWinCount.Text = "0";
            // 
            // drawCount
            // 
            this.drawCount.AutoSize = true;
            this.drawCount.Location = new System.Drawing.Point(120, 304);
            this.drawCount.Name = "drawCount";
            this.drawCount.Size = new System.Drawing.Size(13, 13);
            this.drawCount.TabIndex = 6;
            this.drawCount.Text = "0";
            // 
            // oWinCount
            // 
            this.oWinCount.AutoSize = true;
            this.oWinCount.Location = new System.Drawing.Point(204, 304);
            this.oWinCount.Name = "oWinCount";
            this.oWinCount.Size = new System.Drawing.Size(13, 13);
            this.oWinCount.TabIndex = 7;
            this.oWinCount.Text = "0";
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(12, 281);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(74, 20);
            this.p1.TabIndex = 8;
            this.p1.Text = "Player 1";
            this.p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(174, 281);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(74, 20);
            this.p2.TabIndex = 8;
            this.p2.Text = "Player 2";
            this.p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p2.TextChanged += new System.EventHandler(this.p2_TextChanged);
            // 
            // setPlayerDefaultsToolStripMenuItem
            // 
            this.setPlayerDefaultsToolStripMenuItem.Name = "setPlayerDefaultsToolStripMenuItem";
            this.setPlayerDefaultsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setPlayerDefaultsToolStripMenuItem.Text = "Set Player Defaults";
            this.setPlayerDefaultsToolStripMenuItem.Click += new System.EventHandler(this.setPlayerDefaultsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 343);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.oWinCount);
            this.Controls.Add(this.drawCount);
            this.Controls.Add(this.xWinCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 365);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label xWinCount;
        private System.Windows.Forms.Label drawCount;
        private System.Windows.Forms.Label oWinCount;
        private System.Windows.Forms.ToolStripMenuItem resetWinsToolStripMenuItem;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.ToolStripMenuItem setPlayerDefaultsToolStripMenuItem;
    }
}

