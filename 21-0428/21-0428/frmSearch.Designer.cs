namespace _21_0428
{
    partial class frmSearch
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbSearchBox = new System.Windows.Forms.ListBox();
            this.lbPattern = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("굴림", 11F);
            this.txtSearch.Location = new System.Drawing.Point(69, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(360, 24);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("굴림", 11F);
            this.lbSearch.Location = new System.Drawing.Point(66, 33);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(67, 15);
            this.lbSearch.TabIndex = 1;
            this.lbSearch.Text = "자동완성";
            // 
            // lbSearchBox
            // 
            this.lbSearchBox.FormattingEnabled = true;
            this.lbSearchBox.ItemHeight = 12;
            this.lbSearchBox.Location = new System.Drawing.Point(69, 106);
            this.lbSearchBox.Name = "lbSearchBox";
            this.lbSearchBox.ScrollAlwaysVisible = true;
            this.lbSearchBox.Size = new System.Drawing.Size(360, 280);
            this.lbSearchBox.Sorted = true;
            this.lbSearchBox.TabIndex = 2;
            // 
            // lbPattern
            // 
            this.lbPattern.Font = new System.Drawing.Font("굴림", 11F);
            this.lbPattern.Location = new System.Drawing.Point(66, 402);
            this.lbPattern.Name = "lbPattern";
            this.lbPattern.Size = new System.Drawing.Size(212, 45);
            this.lbPattern.TabIndex = 3;
            this.lbPattern.Text = "검색패턴 : ";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 452);
            this.Controls.Add(this.lbPattern);
            this.Controls.Add(this.lbSearchBox);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmSearch";
            this.Text = "자동완성";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.ListBox lbSearchBox;
        private System.Windows.Forms.Label lbPattern;
    }
}

