namespace Barcode
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_barcode = new System.Windows.Forms.Button();
            this.chb_preview = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_barcode
            // 
            this.btn_barcode.Location = new System.Drawing.Point(115, 62);
            this.btn_barcode.Name = "btn_barcode";
            this.btn_barcode.Size = new System.Drawing.Size(97, 36);
            this.btn_barcode.TabIndex = 0;
            this.btn_barcode.Text = "바코드 출력";
            this.btn_barcode.UseVisualStyleBackColor = true;
            this.btn_barcode.Click += new System.EventHandler(this.button1_Click);
            // 
            // chb_preview
            // 
            this.chb_preview.AutoSize = true;
            this.chb_preview.Location = new System.Drawing.Point(115, 104);
            this.chb_preview.Name = "chb_preview";
            this.chb_preview.Size = new System.Drawing.Size(72, 16);
            this.chb_preview.TabIndex = 1;
            this.chb_preview.Text = "미리보기";
            this.chb_preview.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 176);
            this.Controls.Add(this.chb_preview);
            this.Controls.Add(this.btn_barcode);
            this.Name = "MainForm";
            this.Text = "바코드 출력";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_barcode;
        private System.Windows.Forms.CheckBox chb_preview;
    }
}

