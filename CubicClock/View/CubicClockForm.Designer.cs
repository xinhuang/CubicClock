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
            this._minuteCubic = new CubicClock.View.CubicControl();
            this._hourCubic = new CubicClock.View.CubicControl();
            this._secondCubic = new CubicClock.View.CubicControl();
            this.SuspendLayout();
            // 
            // _minuteCubic
            // 
            this._minuteCubic.BackColor = System.Drawing.Color.LightGray;
            this._minuteCubic.Location = new System.Drawing.Point(12, 83);
            this._minuteCubic.Max = 60;
            this._minuteCubic.Name = "_minuteCubic";
            this._minuteCubic.Size = new System.Drawing.Size(183, 45);
            this._minuteCubic.TabIndex = 1;
            this._minuteCubic.Value = 33;
            // 
            // _hourCubic
            // 
            this._hourCubic.BackColor = System.Drawing.Color.LightGray;
            this._hourCubic.Location = new System.Drawing.Point(12, 32);
            this._hourCubic.Max = 60;
            this._hourCubic.Name = "_hourCubic";
            this._hourCubic.Size = new System.Drawing.Size(183, 45);
            this._hourCubic.TabIndex = 0;
            this._hourCubic.Value = 33;
            // 
            // _secondCubic
            // 
            this._secondCubic.BackColor = System.Drawing.Color.LightGray;
            this._secondCubic.Location = new System.Drawing.Point(12, 134);
            this._secondCubic.Max = 60;
            this._secondCubic.Name = "_secondCubic";
            this._secondCubic.Size = new System.Drawing.Size(183, 45);
            this._secondCubic.TabIndex = 2;
            this._secondCubic.Value = 33;
            // 
            // CubicClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this._secondCubic);
            this.Controls.Add(this._minuteCubic);
            this.Controls.Add(this._hourCubic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CubicClockForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CubicControl _hourCubic;
        private CubicControl _minuteCubic;
        private CubicControl _secondCubic;

    }
}

