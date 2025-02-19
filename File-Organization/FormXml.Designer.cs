namespace File_Organization
{
    partial class FormXml
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
            btnSaveXml = new Button();
            dgvStudent = new DataGridView();
            Carrer = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtCareerID = new TextBox();
            btnDelete = new Button();
            btnShow = new Button();
            btnSearch = new Button();
            btnAdd = new Button();
            label3 = new Label();
            txtSemester = new TextBox();
            cmbCareer = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // btnSaveXml
            // 
            btnSaveXml.Location = new Point(243, 252);
            btnSaveXml.Name = "btnSaveXml";
            btnSaveXml.Size = new Size(75, 23);
            btnSaveXml.TabIndex = 0;
            btnSaveXml.Text = "Save Xml";
            btnSaveXml.UseVisualStyleBackColor = true;
            btnSaveXml.Click += btnSaveXml_Click;
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(219, 12);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.Size = new Size(390, 234);
            dgvStudent.TabIndex = 1;
            // 
            // Carrer
            // 
            Carrer.AutoSize = true;
            Carrer.Location = new Point(5, 88);
            Carrer.Name = "Carrer";
            Carrer.Size = new Size(41, 15);
            Carrer.TabIndex = 20;
            Carrer.Text = "Career";
            // 
            // txtName
            // 
            txtName.Location = new Point(59, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 62);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 17;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 33);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 16;
            label1.Text = "CareerId";
            // 
            // txtCareerID
            // 
            txtCareerID.Location = new Point(59, 28);
            txtCareerID.Name = "txtCareerID";
            txtCareerID.Size = new Size(121, 23);
            txtCareerID.TabIndex = 15;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(105, 232);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(105, 174);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 23;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(105, 203);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(105, 145);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 118);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 26;
            label3.Text = "Semester";
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(59, 114);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(121, 23);
            txtSemester.TabIndex = 25;
            // 
            // cmbCareer
            // 
            cmbCareer.FormattingEnabled = true;
            cmbCareer.Location = new Point(59, 80);
            cmbCareer.Name = "cmbCareer";
            cmbCareer.Size = new Size(121, 23);
            cmbCareer.TabIndex = 27;
            // 
            // FormXml
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbCareer);
            Controls.Add(label3);
            Controls.Add(txtSemester);
            Controls.Add(btnDelete);
            Controls.Add(btnShow);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(Carrer);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCareerID);
            Controls.Add(dgvStudent);
            Controls.Add(btnSaveXml);
            Name = "FormXml";
            Text = "FormXml";
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveXml;
        private DataGridView dgvStudent;
        private Label Carrer;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private TextBox txtCareerID;
        private Button btnDelete;
        private Button btnShow;
        private Button btnSearch;
        private Button btnAdd;
        private Label label3;
        private TextBox txtSemester;
        private ComboBox cmbCareer;
    }
}