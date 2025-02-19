namespace File_Organization
{
    partial class FormJson
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
            dgvStore = new DataGridView();
            btnSaveJson = new Button();
            label3 = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStore).BeginInit();
            SuspendLayout();
            // 
            // txtStock
            // 
            txtStock.Location = new Point(62, 108);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(121, 23);
            txtStock.TabIndex = 39;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(108, 228);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(108, 170);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 37;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(108, 199);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 36;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(108, 141);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Carrer
            // 
            Carrer.AutoSize = true;
            Carrer.Location = new Point(8, 108);
            Carrer.Name = "Carrer";
            Carrer.Size = new Size(36, 15);
            Carrer.TabIndex = 34;
            Carrer.Text = "Stock";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(62, 76);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(121, 23);
            txtPrice.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 82);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 32;
            label2.Text = "Price";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(8, 53);
            Name.Name = "Name";
            Name.Size = new Size(39, 15);
            Name.TabIndex = 31;
            Name.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(62, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 30;
            // 
            // dgvStore
            // 
            dgvStore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStore.Location = new Point(222, 25);
            dgvStore.Name = "dgvStore";
            dgvStore.Size = new Size(390, 234);
            dgvStore.TabIndex = 29;
            // 
            // btnSaveJson
            // 
            btnSaveJson.Location = new Point(246, 265);
            btnSaveJson.Name = "btnSaveJson";
            btnSaveJson.Size = new Size(75, 23);
            btnSaveJson.TabIndex = 28;
            btnSaveJson.Text = "Save Json";
            btnSaveJson.UseVisualStyleBackColor = true;
            btnSaveJson.Click += btnSaveJson_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 24);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 41;
            label3.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(62, 19);
            txtID.Name = "txtID";
            txtID.Size = new Size(121, 23);
            txtID.TabIndex = 40;
            // 
            // FormJson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(dgvStore);
            Controls.Add(btnSaveJson);
            //Name = "FormJson";
            //Text = "FormJson";
            ((System.ComponentModel.ISupportInitialize)dgvStore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private DataGridView dgvStore;
        private Button btnSaveJson;
        private Label label3;
        private TextBox txtID;
    }
}