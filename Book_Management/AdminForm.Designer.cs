namespace ProgramForm
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMake = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBookManage = new System.Windows.Forms.Button();
            this.btnUserCheck = new System.Windows.Forms.Button();
            this.data_UserManage = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_UserManage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnMake);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(404, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USER 가입창";
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(279, 67);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(60, 60);
            this.btnMake.TabIndex = 1;
            this.btnMake.Text = "등록";
            this.btnMake.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 21);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 21);
            this.textBox1.TabIndex = 0;
            // 
            // btnBookManage
            // 
            this.btnBookManage.Location = new System.Drawing.Point(12, 38);
            this.btnBookManage.Name = "btnBookManage";
            this.btnBookManage.Size = new System.Drawing.Size(120, 50);
            this.btnBookManage.TabIndex = 2;
            this.btnBookManage.Text = "도서관리";
            this.btnBookManage.UseVisualStyleBackColor = true;
            this.btnBookManage.Click += new System.EventHandler(this.btnBookM_Click);
            // 
            // btnUserCheck
            // 
            this.btnUserCheck.Location = new System.Drawing.Point(155, 38);
            this.btnUserCheck.Name = "btnUserCheck";
            this.btnUserCheck.Size = new System.Drawing.Size(120, 50);
            this.btnUserCheck.TabIndex = 2;
            this.btnUserCheck.Text = "대출관리";
            this.btnUserCheck.UseVisualStyleBackColor = true;
            this.btnUserCheck.Click += new System.EventHandler(this.btnUserCheck_Click);
            // 
            // data_UserManage
            // 
            this.data_UserManage.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.data_UserManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_UserManage.Location = new System.Drawing.Point(12, 122);
            this.data_UserManage.Name = "data_UserManage";
            this.data_UserManage.RowTemplate.Height = 23;
            this.data_UserManage.Size = new System.Drawing.Size(362, 291);
            this.data_UserManage.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "비밀번호";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.data_UserManage);
            this.Controls.Add(this.btnUserCheck);
            this.Controls.Add(this.btnBookManage);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AdminForm";
            this.Text = "도서관리프로그램";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_UserManage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBookManage;
        private System.Windows.Forms.Button btnUserCheck;
        private System.Windows.Forms.DataGridView data_UserManage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}