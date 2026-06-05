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
            lblAge.Location = new Point(86, 84);
            lblAge.Margin = new Padding(6, 0, 6, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(47, 30);
            lblAge.TabIndex = 1;
            lblAge.Text = "Yaş";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 255, 128);
            btnAdd.Location = new Point(142, 121);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 37);
            btnAdd.TabIndex = 2;
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
            txtAge.Location = new Point(142, 84);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(167, 31);
            txtAge.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(142, 207);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 37);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CornflowerBlue;
            btnUpdate.Location = new Point(142, 164);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 37);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(875, 469);
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
    }
}
