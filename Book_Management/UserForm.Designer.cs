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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.btn_End = new System.Windows.Forms.Button();
            this.btn_Rental = new System.Windows.Forms.Button();
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
            this.data_booklist.Size = new System.Drawing.Size(501, 300);
            this.data_booklist.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(116, 57);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(229, 21);
            this.txtbox1.TabIndex = 2;
            // 
            // btn_End
            // 
            this.btn_End.Location = new System.Drawing.Point(626, 39);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(99, 55);
            this.btn_End.TabIndex = 3;
            this.btn_End.Text = "종료";
            this.btn_End.UseVisualStyleBackColor = true;
            // 
            // btn_Rental
            // 
            this.btn_Rental.Location = new System.Drawing.Point(626, 375);
            this.btn_Rental.Name = "btn_Rental";
            this.btn_Rental.Size = new System.Drawing.Size(99, 55);
            this.btn_Rental.TabIndex = 4;
            this.btn_Rental.Text = "대출";
            this.btn_Rental.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_Rental);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.data_booklist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "UserForm";
            this.Text = "도서관리프로그램";
            ((System.ComponentModel.ISupportInitialize)(this.data_booklist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_booklist;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.Button btn_Rental;
    }
}