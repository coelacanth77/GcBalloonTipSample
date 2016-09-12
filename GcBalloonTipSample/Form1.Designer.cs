namespace GcBalloonTipSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            GrapeCity.Win.Components.BalloonTipInformation balloonTipInformation1 = new GrapeCity.Win.Components.BalloonTipInformation();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gcBalloonTip1 = new GrapeCity.Win.Components.GcBalloonTip();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            balloonTipInformation1.AutoClose = true;
            balloonTipInformation1.AutoShow = true;
            balloonTipInformation1.BackColor = System.Drawing.SystemColors.Desktop;
            balloonTipInformation1.IconType = GrapeCity.Win.Components.IconType.Exclamation;
            balloonTipInformation1.Shape = GrapeCity.Win.Components.BalloonShape.Square;
            balloonTipInformation1.Text = "名前を入力してください";
            balloonTipInformation1.TextForeColor = System.Drawing.SystemColors.Highlight;
            this.gcBalloonTip1.SetBalloonTipInformation(this.textBox1, balloonTipInformation1);
            this.textBox1.Location = new System.Drawing.Point(59, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "名前";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private GrapeCity.Win.Components.GcBalloonTip gcBalloonTip1;
        private System.Windows.Forms.Label label1;
    }
}

