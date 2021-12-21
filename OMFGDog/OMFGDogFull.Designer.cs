namespace OMFGDog
{
    partial class OMFGDogFull
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OMFGDogFull));
            this.wbOMFGDog = new System.Windows.Forms.WebBrowser();
            this.timerTopMost = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // wbOMFGDog
            // 
            this.wbOMFGDog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbOMFGDog.IsWebBrowserContextMenuEnabled = false;
            this.wbOMFGDog.Location = new System.Drawing.Point(0, 0);
            this.wbOMFGDog.Name = "wbOMFGDog";
            this.wbOMFGDog.ScrollBarsEnabled = false;
            this.wbOMFGDog.Size = new System.Drawing.Size(0, 0);
            this.wbOMFGDog.TabIndex = 0;
            this.wbOMFGDog.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.wbOMFGDog_PreviewKeyDown);
            // 
            // timerTopMost
            // 
            this.timerTopMost.Enabled = true;
            this.timerTopMost.Interval = 1000;
            this.timerTopMost.Tick += new System.EventHandler(this.timerTopMost_Tick);
            // 
            // OMFGDogFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(0, 0);
            this.Controls.Add(this.wbOMFGDog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OMFGDogFull";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OMFGDogFull";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OMFGDogFull_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbOMFGDog;
        private System.Windows.Forms.Timer timerTopMost;
    }
}