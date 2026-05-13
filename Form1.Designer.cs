namespace WAV音效檔播放器
{
    partial class Form1
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.ofdWAVFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(115, 171);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(100, 25);
            this.txtPath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(308, 51);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "瀏覽";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(308, 115);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "播放一次";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(308, 190);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(75, 23);
            this.btnLoop.TabIndex = 3;
            this.btnLoop.Text = "重複播放";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(308, 253);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "停止播放";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(308, 332);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 26);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "結束程式";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // ofdWAVFile
            // 
            this.ofdWAVFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 524);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnLoop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.OpenFileDialog ofdWAVFile;
    }
}

