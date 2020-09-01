namespace Birthstone {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.FindOut_button = new System.Windows.Forms.Button();
            this.jewelryBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FindOut_button
            // 
            this.FindOut_button.Location = new System.Drawing.Point(112, 135);
            this.FindOut_button.Name = "FindOut_button";
            this.FindOut_button.Size = new System.Drawing.Size(182, 64);
            this.FindOut_button.TabIndex = 0;
            this.FindOut_button.Text = "調べる";
            this.FindOut_button.UseVisualStyleBackColor = true;
            this.FindOut_button.Click += new System.EventHandler(this.FindOut_button_Click);
            // 
            // jewelryBox
            // 
            this.jewelryBox.FormattingEnabled = true;
            this.jewelryBox.Items.AddRange(new object[] {
            " ",
            "1月",
            "2月",
            "3月",
            "4月",
            "5月",
            "6月",
            "7月",
            "8月",
            "9月",
            "10月",
            "11月",
            "12月"});
            this.jewelryBox.Location = new System.Drawing.Point(140, 49);
            this.jewelryBox.Name = "jewelryBox";
            this.jewelryBox.Size = new System.Drawing.Size(121, 26);
            this.jewelryBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 251);
            this.Controls.Add(this.jewelryBox);
            this.Controls.Add(this.FindOut_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FindOut_button;
        private System.Windows.Forms.ComboBox jewelryBox;
    }
}

