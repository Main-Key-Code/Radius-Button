
namespace ZeroControls
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
            this.kyButton1 = new ZeroControls.KYButton();
            this.kyButton2 = new ZeroControls.KYButton();
            this.kyButton3 = new ZeroControls.KYButton();
            this.kyButton4 = new ZeroControls.KYButton();
            this.SuspendLayout();
            // 
            // kyButton1
            // 
            this.kyButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.kyButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.kyButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.kyButton1.BorderRadius = 40;
            this.kyButton1.BorderSize = 0;
            this.kyButton1.FlatAppearance.BorderSize = 0;
            this.kyButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kyButton1.ForeColor = System.Drawing.Color.White;
            this.kyButton1.Location = new System.Drawing.Point(249, 199);
            this.kyButton1.Name = "kyButton1";
            this.kyButton1.Size = new System.Drawing.Size(216, 40);
            this.kyButton1.TabIndex = 0;
            this.kyButton1.Text = "kyButton1";
            this.kyButton1.TextColor = System.Drawing.Color.White;
            this.kyButton1.UseVisualStyleBackColor = false;
            this.kyButton1.Click += new System.EventHandler(this.kyButton1_Click);
            // 
            // kyButton2
            // 
            this.kyButton2.BackColor = System.Drawing.SystemColors.Control;
            this.kyButton2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.kyButton2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.kyButton2.BorderRadius = 40;
            this.kyButton2.BorderSize = 1;
            this.kyButton2.FlatAppearance.BorderSize = 0;
            this.kyButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kyButton2.ForeColor = System.Drawing.Color.Black;
            this.kyButton2.Location = new System.Drawing.Point(249, 258);
            this.kyButton2.Name = "kyButton2";
            this.kyButton2.Size = new System.Drawing.Size(216, 40);
            this.kyButton2.TabIndex = 1;
            this.kyButton2.Text = "kyButton2";
            this.kyButton2.TextColor = System.Drawing.Color.Black;
            this.kyButton2.UseVisualStyleBackColor = false;
            // 
            // kyButton3
            // 
            this.kyButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.kyButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.kyButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.kyButton3.BorderRadius = 80;
            this.kyButton3.BorderSize = 0;
            this.kyButton3.FlatAppearance.BorderSize = 0;
            this.kyButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kyButton3.ForeColor = System.Drawing.Color.White;
            this.kyButton3.Location = new System.Drawing.Point(498, 199);
            this.kyButton3.Name = "kyButton3";
            this.kyButton3.Size = new System.Drawing.Size(120, 40);
            this.kyButton3.TabIndex = 2;
            this.kyButton3.Text = "kyButton3";
            this.kyButton3.TextColor = System.Drawing.Color.White;
            this.kyButton3.UseVisualStyleBackColor = false;
            // 
            // kyButton4
            // 
            this.kyButton4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.kyButton4.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.kyButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.kyButton4.BorderRadius = 65;
            this.kyButton4.BorderSize = 0;
            this.kyButton4.FlatAppearance.BorderSize = 0;
            this.kyButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kyButton4.ForeColor = System.Drawing.Color.White;
            this.kyButton4.Location = new System.Drawing.Point(249, 52);
            this.kyButton4.Name = "kyButton4";
            this.kyButton4.Size = new System.Drawing.Size(475, 91);
            this.kyButton4.TabIndex = 3;
            this.kyButton4.Text = "kyButton4";
            this.kyButton4.TextColor = System.Drawing.Color.White;
            this.kyButton4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kyButton4);
            this.Controls.Add(this.kyButton3);
            this.Controls.Add(this.kyButton2);
            this.Controls.Add(this.kyButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private KYButton kyButton1;
        private KYButton kyButton2;
        private KYButton kyButton3;
        private KYButton kyButton4;
    }
}

