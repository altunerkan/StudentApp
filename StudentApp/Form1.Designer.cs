namespace StudentApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblAge = new Label();
            btnAdd = new Button();
            dgvStudents = new DataGridView();
            txtName = new TextBox();
            txtAge = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            label2 = new Label();
            txtGrade = new TextBox();
            lblFailedCount = new Label();
            lblAverageGrade = new Label();
            lblPassedCount = new Label();
            btnShowAll = new Button();
            btnShowPassed = new Button();
            btnShowFailed = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(28, 34);
            lblName.Margin = new Padding(6, 0, 6, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(105, 30);
            lblName.TabIndex = 0;
            lblName.Text = "Ad Soyad";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(86, 74);
            lblAge.Margin = new Padding(6, 0, 6, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(47, 30);
            lblAge.TabIndex = 1;
            lblAge.Text = "Yaş";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 255, 128);
            btnAdd.Location = new Point(170, 145);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 37);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(436, 34);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(427, 272);
            dgvStudents.TabIndex = 3;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(142, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(167, 31);
            txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(142, 71);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(167, 31);
            txtAge.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(170, 231);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 37);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CornflowerBlue;
            btnUpdate.Location = new Point(170, 188);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 37);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(696, 383);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(167, 31);
            txtSearch.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(647, 383);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 30);
            label1.TabIndex = 9;
            label1.Text = "🔎";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(128, 255, 255);
            btnSearch.Location = new Point(771, 420);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 37);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Ara...";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 111);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 30);
            label2.TabIndex = 11;
            label2.Text = "Not";
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(142, 110);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(167, 31);
            txtGrade.TabIndex = 6;
            // 
            // lblFailedCount
            // 
            lblFailedCount.AutoSize = true;
            lblFailedCount.Location = new Point(771, 1);
            lblFailedCount.Name = "lblFailedCount";
            lblFailedCount.Size = new Size(92, 30);
            lblFailedCount.TabIndex = 14;
            lblFailedCount.Text = "Kalan: 0";
            // 
            // lblAverageGrade
            // 
            lblAverageGrade.AutoSize = true;
            lblAverageGrade.Location = new Point(436, 1);
            lblAverageGrade.Name = "lblAverageGrade";
            lblAverageGrade.Size = new Size(129, 30);
            lblAverageGrade.TabIndex = 15;
            lblAverageGrade.Text = "Ortalama: 0";
            // 
            // lblPassedCount
            // 
            lblPassedCount.AutoSize = true;
            lblPassedCount.Location = new Point(615, 1);
            lblPassedCount.Name = "lblPassedCount";
            lblPassedCount.Size = new Size(99, 30);
            lblPassedCount.TabIndex = 16;
            lblPassedCount.Text = "Geçen: 0";
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.LightSeaGreen;
            btnShowAll.Location = new Point(436, 312);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(115, 37);
            btnShowAll.TabIndex = 17;
            btnShowAll.Text = "Tümü";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnShowPassed
            // 
            btnShowPassed.BackColor = Color.LightGreen;
            btnShowPassed.Location = new Point(599, 312);
            btnShowPassed.Name = "btnShowPassed";
            btnShowPassed.Size = new Size(115, 37);
            btnShowPassed.TabIndex = 18;
            btnShowPassed.Text = "Geçenler";
            btnShowPassed.UseVisualStyleBackColor = false;
            btnShowPassed.Click += btnShowPassed_Click;
            // 
            // btnShowFailed
            // 
            btnShowFailed.BackColor = Color.Brown;
            btnShowFailed.Location = new Point(748, 312);
            btnShowFailed.Name = "btnShowFailed";
            btnShowFailed.Size = new Size(115, 37);
            btnShowFailed.TabIndex = 19;
            btnShowFailed.Text = "Kalanlar";
            btnShowFailed.UseVisualStyleBackColor = false;
            btnShowFailed.Click += btnShowFailed_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(875, 469);
            Controls.Add(btnShowFailed);
            Controls.Add(btnShowPassed);
            Controls.Add(btnShowAll);
            Controls.Add(lblPassedCount);
            Controls.Add(lblAverageGrade);
            Controls.Add(lblFailedCount);
            Controls.Add(txtGrade);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(dgvStudents);
            Controls.Add(btnAdd);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblAge;
        private Button btnAdd;
        private DataGridView dgvStudents;
        private TextBox txtName;
        private TextBox txtAge;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtSearch;
        private Label label1;
        private Button btnSearch;
        private Label label2;
        private TextBox txtGrade;
        private Label label3;
        private Label label4;
        private Label lblFailedCount;
        private Label lblAverageGrade;
        private Label lblPassedCount;
        private Button btnShowAll;
        private Button btnShowPassed;
        private Button btnShowFailed;
    }
}
