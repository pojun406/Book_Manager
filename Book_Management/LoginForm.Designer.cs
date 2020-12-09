﻿namespace ProgramForm
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_PW = new System.Windows.Forms.TextBox();
            this.Button_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ID
            // 
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID.Location = new System.Drawing.Point(60, 46);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(160, 21);
            this.txt_ID.TabIndex = 0;
            // 
            // txt_PW
            // 
            this.txt_PW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PW.Location = new System.Drawing.Point(60, 94);
            this.txt_PW.MaxLength = 64;
            this.txt_PW.Name = "txt_PW";
            this.txt_PW.PasswordChar = '*';
            this.txt_PW.Size = new System.Drawing.Size(160, 21);
            this.txt_PW.TabIndex = 1;
            // 
            // Button_Login
            // 
            this.Button_Login.Location = new System.Drawing.Point(257, 46);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(71, 69);
            this.Button_Login.TabIndex = 2;
            this.Button_Login.Text = "로그인";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "패스워드";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.txt_PW);
            this.Controls.Add(this.txt_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "도서관리프로그램";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_PW;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

