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
            this._menu = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._topMostMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._secondCubic = new CubicClock.View.CubicControl();
            this._minuteCubic = new CubicClock.View.CubicControl();
            this._hourCubic = new CubicClock.View.CubicControl();
            this._menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _menu
            // 
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.optionToolStripMenuItem});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._menu.Size = new System.Drawing.Size(271, 24);
            this._menu.TabIndex = 3;
            this._menu.Text = "_menu";
            this._menu.Visible = false;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._topMostMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "&Option";
            // 
            // _topMostMenuItem
            // 
            this._topMostMenuItem.Checked = true;
            this._topMostMenuItem.CheckOnClick = true;
            this._topMostMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this._topMostMenuItem.Name = "_topMostMenuItem";
            this._topMostMenuItem.Size = new System.Drawing.Size(152, 22);
            this._topMostMenuItem.Text = "Top Most";
            this._topMostMenuItem.CheckedChanged += new System.EventHandler(this.OnTopMostToolStripMenuItemClick);
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
            this.Controls.Add(this._menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this._menu;
            this.Name = "CubicClockForm";
            this.Text = "Cubic Clock";
            this.TopMost = true;
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CubicControl _hourCubic;
        private CubicControl _minuteCubic;
        private CubicControl _secondCubic;
        private System.Windows.Forms.MenuStrip _menu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _topMostMenuItem;

    }
}

