namespace File_Organization
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
            btnCsvForm = new Button();
            btnXmlForm = new Button();
            btnJsonForm = new Button();
            SuspendLayout();
            // 
            // btnCsvForm
            // 
            btnCsvForm.Location = new Point(170, 85);
            btnCsvForm.Name = "btnCsvForm";
            btnCsvForm.Size = new Size(75, 23);
            btnCsvForm.TabIndex = 0;
            btnCsvForm.Text = "CSV";
            btnCsvForm.UseVisualStyleBackColor = true;
            btnCsvForm.Click += btnCsvForm_Click;
            // 
            // btnXmlForm
            // 
            btnXmlForm.Location = new Point(170, 114);
            btnXmlForm.Name = "btnXmlForm";
            btnXmlForm.Size = new Size(75, 23);
            btnXmlForm.TabIndex = 1;
            btnXmlForm.Text = "XML";
            btnXmlForm.UseVisualStyleBackColor = true;
            btnXmlForm.Click += btnXmlForm_Click;
            // 
            // btnJsonForm
            // 
            btnJsonForm.Location = new Point(170, 143);
            btnJsonForm.Name = "btnJsonForm";
            btnJsonForm.Size = new Size(75, 23);
            btnJsonForm.TabIndex = 2;
            btnJsonForm.Text = "JSON";
            btnJsonForm.UseVisualStyleBackColor = true;
            btnJsonForm.Click += btnJsonForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 306);
            Controls.Add(btnJsonForm);
            Controls.Add(btnXmlForm);
            Controls.Add(btnCsvForm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCsvForm;
        private Button btnXmlForm;
        private Button btnJsonForm;
    }
}
