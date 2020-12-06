namespace ProgramForm
{
    partial class UserForm
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
            this.data_booklist = new System.Windows.Forms.DataGridView();
            this.lbl_UserInfo = new System.Windows.Forms.Label();
            this.btnRental = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_booklist)).BeginInit();
            this.SuspendLayout();
            // 
            // data_booklist
            // 
            this.data_booklist.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.data_booklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_booklist.Location = new System.Drawing.Point(40, 130);
            this.data_booklist.Name = "data_booklist";
            this.data_booklist.RowTemplate.Height = 23;
            this.data_booklist.Size = new System.Drawing.Size(700, 300);
            this.data_booklist.TabIndex = 0;
            // 
            // lbl_UserInfo
            // 
            this.lbl_UserInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_UserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_UserInfo.Location = new System.Drawing.Point(40, 61);
            this.lbl_UserInfo.Name = "lbl_UserInfo";
            this.lbl_UserInfo.Size = new System.Drawing.Size(179, 39);
            this.lbl_UserInfo.TabIndex = 1;
            this.lbl_UserInfo.Text = "label1";
            this.lbl_UserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRental
            // 
            this.btnRental.Location = new System.Drawing.Point(274, 61);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(73, 39);
            this.btnRental.TabIndex = 2;
            this.btnRental.Text = "대출";
            this.btnRental.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(381, 61);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(73, 39);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "반납";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRental);
            this.Controls.Add(this.lbl_UserInfo);
            this.Controls.Add(this.data_booklist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "UserForm";
            this.Text = "도서관리프로그램";
            ((System.ComponentModel.ISupportInitialize)(this.data_booklist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_booklist;
        private System.Windows.Forms.Label lbl_UserInfo;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button btnReturn;
    }
}