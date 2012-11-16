namespace CubicClock.View
{
    partial class CubicClockForm
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
            this._shortcutMenu = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._secondCubic = new CubicClock.View.CubicControl();
            this._minuteCubic = new CubicClock.View.CubicControl();
            this._hourCubic = new CubicClock.View.CubicControl();
            this._shortcutMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _shortcutMenu
            // 
            this._shortcutMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._shortcutMenu.Dock = System.Windows.Forms.DockStyle.None;
            this._shortcutMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this._shortcutMenu.Location = new System.Drawing.Point(0, 0);
            this._shortcutMenu.Name = "_shortcutMenu";
            this._shortcutMenu.Size = new System.Drawing.Size(137, 24);
            this._shortcutMenu.TabIndex = 3;
            this._shortcutMenu.Text = "_shortcutMenu";
            this._shortcutMenu.Visible = false;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
            // 
            // _secondCubic
            // 
            this._secondCubic.BackColor = System.Drawing.Color.LightGray;
            this._secondCubic.Location = new System.Drawing.Point(33, 135);
            this._secondCubic.Max = 0;
            this._secondCubic.Name = "_secondCubic";
            this._secondCubic.Size = new System.Drawing.Size(183, 45);
            this._secondCubic.TabIndex = 2;
            this._secondCubic.Value = 56;
            // 
            // _minuteCubic
            // 
            this._minuteCubic.BackColor = System.Drawing.Color.LightGray;
            this._minuteCubic.Location = new System.Drawing.Point(33, 84);
            this._minuteCubic.Max = 0;
            this._minuteCubic.Name = "_minuteCubic";
            this._minuteCubic.Size = new System.Drawing.Size(183, 45);
            this._minuteCubic.TabIndex = 1;
            this._minuteCubic.Value = 38;
            // 
            // _hourCubic
            // 
            this._hourCubic.BackColor = System.Drawing.Color.LightGray;
            this._hourCubic.Location = new System.Drawing.Point(33, 33);
            this._hourCubic.Max = 24;
            this._hourCubic.Name = "_hourCubic";
            this._hourCubic.Size = new System.Drawing.Size(183, 45);
            this._hourCubic.TabIndex = 0;
            this._hourCubic.Value = 10;
            // 
            // CubicClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 232);
            this.Controls.Add(this._secondCubic);
            this.Controls.Add(this._minuteCubic);
            this.Controls.Add(this._hourCubic);
            this.Controls.Add(this._shortcutMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this._shortcutMenu;
            this.Name = "CubicClockForm";
            this.Text = "Form1";
            this._shortcutMenu.ResumeLayout(false);
            this._shortcutMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CubicControl _hourCubic;
        private CubicControl _minuteCubic;
        private CubicControl _secondCubic;
        private System.Windows.Forms.MenuStrip _shortcutMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

    }
}

