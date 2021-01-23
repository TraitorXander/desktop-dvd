namespace DVDTest
{
    partial class Main
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
            this.imgMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMain
            // 
            this.imgMain.BackColor = System.Drawing.Color.Transparent;
            this.imgMain.Location = new System.Drawing.Point(12, 12);
            this.imgMain.Name = "imgMain";
            this.imgMain.Size = new System.Drawing.Size(150, 100);
            this.imgMain.TabIndex = 1;
            this.imgMain.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 209);
            this.Controls.Add(this.imgMain);
            this.Name = "Main";
            this.Text = "Main";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMain;
    }
}