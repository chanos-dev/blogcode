namespace _20_1021
{
    partial class FormProcess
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
            this.button_Process = new System.Windows.Forms.Button();
            this.textBox_Process = new System.Windows.Forms.TextBox();
            this.textBox_args = new System.Windows.Forms.TextBox();
            this.button_args = new System.Windows.Forms.Button();
            this.textBox_args1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Process
            // 
            this.button_Process.Location = new System.Drawing.Point(12, 56);
            this.button_Process.Name = "button_Process";
            this.button_Process.Size = new System.Drawing.Size(234, 34);
            this.button_Process.TabIndex = 0;
            this.button_Process.Text = "실행";
            this.button_Process.UseVisualStyleBackColor = true;
            this.button_Process.Click += new System.EventHandler(this.button_Process_Click);
            // 
            // textBox_Process
            // 
            this.textBox_Process.Location = new System.Drawing.Point(12, 29);
            this.textBox_Process.Name = "textBox_Process";
            this.textBox_Process.Size = new System.Drawing.Size(234, 21);
            this.textBox_Process.TabIndex = 1;
            // 
            // textBox_args
            // 
            this.textBox_args.Location = new System.Drawing.Point(13, 129);
            this.textBox_args.Name = "textBox_args";
            this.textBox_args.Size = new System.Drawing.Size(234, 21);
            this.textBox_args.TabIndex = 3;
            // 
            // button_args
            // 
            this.button_args.Location = new System.Drawing.Point(13, 183);
            this.button_args.Name = "button_args";
            this.button_args.Size = new System.Drawing.Size(234, 34);
            this.button_args.TabIndex = 2;
            this.button_args.Text = "아규먼트 실행";
            this.button_args.UseVisualStyleBackColor = true;
            this.button_args.Click += new System.EventHandler(this.button_args_Click);
            // 
            // textBox_args1
            // 
            this.textBox_args1.Location = new System.Drawing.Point(13, 156);
            this.textBox_args1.Name = "textBox_args1";
            this.textBox_args1.Size = new System.Drawing.Size(234, 21);
            this.textBox_args1.TabIndex = 4;
            // 
            // FormProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 242);
            this.Controls.Add(this.textBox_args1);
            this.Controls.Add(this.textBox_args);
            this.Controls.Add(this.button_args);
            this.Controls.Add(this.textBox_Process);
            this.Controls.Add(this.button_Process);
            this.Name = "FormProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Process;
        private System.Windows.Forms.TextBox textBox_Process;
        private System.Windows.Forms.TextBox textBox_args;
        private System.Windows.Forms.Button button_args;
        private System.Windows.Forms.TextBox textBox_args1;
    }
}

