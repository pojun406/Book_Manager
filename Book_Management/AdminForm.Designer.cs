﻿namespace ProgramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SearchUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMake = new System.Windows.Forms.Button();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.data_UserManage = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_DelBook = new System.Windows.Forms.Button();
            this.btn_SearchBookList = new System.Windows.Forms.Button();
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.txt_writer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_genre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bookname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_booknum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.data_BookList = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_SearchRentList = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.data_Rent = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_UserManage)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_BookList)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Rent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SearchUser);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnMake);
            this.groupBox1.Controls.Add(this.txt_Tel);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Location = new System.Drawing.Point(445, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(418, 484);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USER 가입창";
            // 
            // btn_SearchUser
            // 
            this.btn_SearchUser.Location = new System.Drawing.Point(315, 135);
            this.btn_SearchUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SearchUser.Name = "btn_SearchUser";
            this.btn_SearchUser.Size = new System.Drawing.Size(69, 44);
            this.btn_SearchUser.TabIndex = 5;
            this.btn_SearchUser.Text = "조회";
            this.btn_SearchUser.UseVisualStyleBackColor = true;
            this.btn_SearchUser.Click += new System.EventHandler(this.btn_SearchUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Book_Management.Properties.Resources.Library_2_icon;
            this.pictureBox1.Location = new System.Drawing.Point(37, 192);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "핸드폰 번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "이름";
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(315, 74);
            this.btnMake.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(69, 44);
            this.btnMake.TabIndex = 4;
            this.btnMake.Text = "등록";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(37, 145);
            this.txt_Tel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(246, 25);
            this.txt_Tel.TabIndex = 3;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(37, 84);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(246, 25);
            this.txt_Name.TabIndex = 2;
            // 
            // data_UserManage
            // 
            this.data_UserManage.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.data_UserManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_UserManage.Location = new System.Drawing.Point(17, 19);
            this.data_UserManage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_UserManage.Name = "data_UserManage";
            this.data_UserManage.RowHeadersWidth = 51;
            this.data_UserManage.RowTemplate.Height = 23;
            this.data_UserManage.Size = new System.Drawing.Size(400, 475);
            this.data_UserManage.TabIndex = 3;
//            this.data_UserManage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_UserManage_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 29);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 546);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.data_UserManage);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(885, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "기본관리";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.data_BookList);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(885, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "도서관리";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_DelBook);
            this.groupBox2.Controls.Add(this.btn_SearchBookList);
            this.groupBox2.Controls.Add(this.btn_AddBook);
            this.groupBox2.Controls.Add(this.txt_writer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_genre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_bookname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_booknum);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(446, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(400, 484);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "도서목록관리";
            // 
            // btn_DelBook
            // 
            this.btn_DelBook.Location = new System.Drawing.Point(267, 391);
            this.btn_DelBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DelBook.Name = "btn_DelBook";
            this.btn_DelBook.Size = new System.Drawing.Size(126, 54);
            this.btn_DelBook.TabIndex = 7;
            this.btn_DelBook.Text = "삭제";
            this.btn_DelBook.UseVisualStyleBackColor = true;
            this.btn_DelBook.Click += new System.EventHandler(this.btn_DelBook_Click);
            // 
            // btn_SearchBookList
            // 
            this.btn_SearchBookList.Location = new System.Drawing.Point(267, 195);
            this.btn_SearchBookList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SearchBookList.Name = "btn_SearchBookList";
            this.btn_SearchBookList.Size = new System.Drawing.Size(126, 54);
            this.btn_SearchBookList.TabIndex = 6;
            this.btn_SearchBookList.Text = "조회";
            this.btn_SearchBookList.UseVisualStyleBackColor = true;
            this.btn_SearchBookList.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Location = new System.Drawing.Point(267, 291);
            this.btn_AddBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(126, 54);
            this.btn_AddBook.TabIndex = 6;
            this.btn_AddBook.Text = "추가";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // txt_writer
            // 
            this.txt_writer.Location = new System.Drawing.Point(7, 406);
            this.txt_writer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_writer.Name = "txt_writer";
            this.txt_writer.Size = new System.Drawing.Size(237, 25);
            this.txt_writer.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "저자";
            // 
            // txt_genre
            // 
            this.txt_genre.Location = new System.Drawing.Point(7, 306);
            this.txt_genre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_genre.Name = "txt_genre";
            this.txt_genre.Size = new System.Drawing.Size(237, 25);
            this.txt_genre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "장르";
            // 
            // txt_bookname
            // 
            this.txt_bookname.Location = new System.Drawing.Point(7, 210);
            this.txt_bookname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_bookname.Name = "txt_bookname";
            this.txt_bookname.Size = new System.Drawing.Size(237, 25);
            this.txt_bookname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "도서명";
            // 
            // txt_booknum
            // 
            this.txt_booknum.Location = new System.Drawing.Point(7, 109);
            this.txt_booknum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_booknum.Name = "txt_booknum";
            this.txt_booknum.Size = new System.Drawing.Size(386, 25);
            this.txt_booknum.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "도서번호";
            // 
            // data_BookList
            // 
            this.data_BookList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.data_BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_BookList.Location = new System.Drawing.Point(17, 19);
            this.data_BookList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_BookList.Name = "data_BookList";
            this.data_BookList.RowHeadersWidth = 51;
            this.data_BookList.RowTemplate.Height = 23;
            this.data_BookList.Size = new System.Drawing.Size(400, 475);
            this.data_BookList.TabIndex = 1;
           // this.data_BookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_BookList_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.btn_SearchRentList);
            this.tabPage3.Controls.Add(this.btn_Return);
            this.tabPage3.Controls.Add(this.data_Rent);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(885, 517);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "대출관리";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Book_Management.Properties.Resources.Library_2_icon;
            this.pictureBox2.Location = new System.Drawing.Point(705, 82);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 181);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btn_SearchRentList
            // 
            this.btn_SearchRentList.Location = new System.Drawing.Point(723, 330);
            this.btn_SearchRentList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SearchRentList.Name = "btn_SearchRentList";
            this.btn_SearchRentList.Size = new System.Drawing.Size(113, 62);
            this.btn_SearchRentList.TabIndex = 2;
            this.btn_SearchRentList.Text = "조회";
            this.btn_SearchRentList.UseVisualStyleBackColor = true;
            this.btn_SearchRentList.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(723, 431);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(113, 62);
            this.btn_Return.TabIndex = 3;
            this.btn_Return.Text = "반납처리";
            this.btn_Return.UseVisualStyleBackColor = true;
            // 
            // data_Rent
            // 
            this.data_Rent.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.data_Rent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Rent.Location = new System.Drawing.Point(17, 19);
            this.data_Rent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_Rent.Name = "data_Rent";
            this.data_Rent.RowHeadersWidth = 51;
            this.data_Rent.RowTemplate.Height = 23;
            this.data_Rent.Size = new System.Drawing.Size(651, 475);
            this.data_Rent.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그아웃ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(896, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 576);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminForm";
            this.Text = "도서관리프로그램";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_UserManage)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_BookList)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Rent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.DataGridView data_UserManage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView data_BookList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_DelBook;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.TextBox txt_writer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_genre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bookname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_booknum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView data_Rent;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_SearchRentList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_SearchUser;
        private System.Windows.Forms.Button btn_SearchBookList;
    }
}