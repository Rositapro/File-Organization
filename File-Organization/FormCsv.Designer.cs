namespace File_Organization
{
    partial class FormCsv
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
            label3 = new Label();
            txtID = new TextBox();
            txtStock = new TextBox();
            btnDelete = new Button();
            btnShow = new Button();
            btnSearch = new Button();
            btnAdd = new Button();
            Carrer = new Label();
            txtPrice = new TextBox();
            label2 = new Label();
            Name = new Label();
            txtName = new TextBox();
            dgvBook = new DataGridView();
            btnSaveCsv = new Button();
            txtEdition = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 48);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 55;
            label3.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(68, 43);
            txtID.Name = "txtID";
            txtID.Size = new Size(121, 23);
            txtID.TabIndex = 54;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(68, 132);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(121, 23);
            txtStock.TabIndex = 53;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(114, 282);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 52;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(114, 224);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 51;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(114, 253);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 50;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(114, 195);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 49;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Carrer
            // 
            Carrer.AutoSize = true;
            Carrer.Location = new Point(14, 132);
            Carrer.Name = "Carrer";
            Carrer.Size = new Size(36, 15);
            Carrer.TabIndex = 48;
            Carrer.Text = "Stock";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(68, 100);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(121, 23);
            txtPrice.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 106);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 46;
            label2.Text = "Price";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(14, 77);
            Name.Name = "Name";
            Name.Size = new Size(39, 15);
            Name.TabIndex = 45;
            Name.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(68, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 44;
            // 
            // dgvBook
            // 
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(222, 27);
            dgvBook.Name = "dgvBook";
            dgvBook.Size = new Size(390, 234);
            dgvBook.TabIndex = 43;
            // 
            // btnSaveCsv
            // 
            btnSaveCsv.Location = new Point(234, 271);
            btnSaveCsv.Name = "btnSaveCsv";
            btnSaveCsv.Size = new Size(75, 23);
            btnSaveCsv.TabIndex = 42;
            btnSaveCsv.Text = "Save Csv";
            btnSaveCsv.UseVisualStyleBackColor = true;
            btnSaveCsv.Click += btnSaveCsv_Click;
            // 
            // txtEdition
            // 
            txtEdition.Location = new Point(68, 166);
            txtEdition.Name = "txtEdition";
            txtEdition.Size = new Size(121, 23);
            txtEdition.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 166);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 56;
            label1.Text = "Edition";
            // 
            // FormCsv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEdition);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(txtStock);
            Controls.Add(btnDelete);
            Controls.Add(btnShow);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(Carrer);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(Name);
            Controls.Add(txtName);
            Controls.Add(dgvBook);
            Controls.Add(btnSaveCsv);
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtID;
        private TextBox txtStock;
        private Button btnDelete;
        private Button btnShow;
        private Button btnSearch;
        private Button btnAdd;
        private Label Carrer;
        private TextBox txtPrice;
        private Label label2;
        private Label Name;
        private TextBox txtName;
        private DataGridView dgvBook;
        private Button btnSaveCsv;
        private TextBox txtEdition;
        private Label label1;
    }
}