namespace _20_1027
{
    partial class Form1
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
            this.button_serialize = new System.Windows.Forms.Button();
            this.button_deserialize = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_serializeArr = new System.Windows.Forms.Button();
            this.button_deserializeArr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_serialize
            // 
            this.button_serialize.Location = new System.Drawing.Point(12, 12);
            this.button_serialize.Name = "button_serialize";
            this.button_serialize.Size = new System.Drawing.Size(100, 23);
            this.button_serialize.TabIndex = 0;
            this.button_serialize.Text = "Json 직렬화";
            this.button_serialize.UseVisualStyleBackColor = true;
            this.button_serialize.Click += new System.EventHandler(this.button_serialize_Click);
            // 
            // button_deserialize
            // 
            this.button_deserialize.Location = new System.Drawing.Point(319, 12);
            this.button_deserialize.Name = "button_deserialize";
            this.button_deserialize.Size = new System.Drawing.Size(100, 23);
            this.button_deserialize.TabIndex = 1;
            this.button_deserialize.Text = "Json 역직렬화";
            this.button_deserialize.UseVisualStyleBackColor = true;
            this.button_deserialize.Click += new System.EventHandler(this.button_deserialize_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 236);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(319, 41);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 236);
            this.textBox2.TabIndex = 3;
            // 
            // button_serializeArr
            // 
            this.button_serializeArr.Location = new System.Drawing.Point(118, 12);
            this.button_serializeArr.Name = "button_serializeArr";
            this.button_serializeArr.Size = new System.Drawing.Size(113, 23);
            this.button_serializeArr.TabIndex = 4;
            this.button_serializeArr.Text = "Json 직렬화 Arr";
            this.button_serializeArr.UseVisualStyleBackColor = true;
            this.button_serializeArr.Click += new System.EventHandler(this.button_serializeArr_Click);
            // 
            // button_deserializeArr
            // 
            this.button_deserializeArr.Location = new System.Drawing.Point(425, 12);
            this.button_deserializeArr.Name = "button_deserializeArr";
            this.button_deserializeArr.Size = new System.Drawing.Size(126, 23);
            this.button_deserializeArr.TabIndex = 5;
            this.button_deserializeArr.Text = "Json 역직렬화 Arr";
            this.button_deserializeArr.UseVisualStyleBackColor = true;
            this.button_deserializeArr.Click += new System.EventHandler(this.button_deserializeArr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 289);
            this.Controls.Add(this.button_deserializeArr);
            this.Controls.Add(this.button_serializeArr);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_deserialize);
            this.Controls.Add(this.button_serialize);
            this.Name = "Form1";
            this.Text = "JsonControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_serialize;
        private System.Windows.Forms.Button button_deserialize;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_serializeArr;
        private System.Windows.Forms.Button button_deserializeArr;
    }
}

