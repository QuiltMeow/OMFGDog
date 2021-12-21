namespace OMFGDog
{
    partial class OMFGDog
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OMFGDog));
            this.timerRun = new System.Windows.Forms.Timer(this.components);
            this.timerTopMost = new System.Windows.Forms.Timer(this.components);
            this.pbOMFGDog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOMFGDog)).BeginInit();
            this.SuspendLayout();
            // 
            // timerRun
            // 
            this.timerRun.Interval = 1;
            this.timerRun.Tick += new System.EventHandler(this.timerRun_Tick);
            // 
            // timerTopMost
            // 
            this.timerTopMost.Enabled = true;
            this.timerTopMost.Interval = 1000;
            this.timerTopMost.Tick += new System.EventHandler(this.timerTopMost_Tick);
            // 
            // pbOMFGDog
            // 
            this.pbOMFGDog.BackColor = System.Drawing.Color.Transparent;
            this.pbOMFGDog.Image = global::OMFGDog.Properties.Resources.OMFGDog;
            this.pbOMFGDog.Location = new System.Drawing.Point(0, 0);
            this.pbOMFGDog.Name = "pbOMFGDog";
            this.pbOMFGDog.Size = new System.Drawing.Size(384, 80);
            this.pbOMFGDog.TabIndex = 0;
            this.pbOMFGDog.TabStop = false;
            this.pbOMFGDog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbOMFGDog_MouseClick);
            // 
            // OMFGDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 80);
            this.Controls.Add(this.pbOMFGDog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OMFGDog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OMFGDog";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            ((System.ComponentModel.ISupportInitialize)(this.pbOMFGDog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOMFGDog;
        private System.Windows.Forms.Timer timerRun;
        private System.Windows.Forms.Timer timerTopMost;
    }
}

