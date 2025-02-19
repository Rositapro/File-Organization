namespace File_Organization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCsvForm_Click(object sender, EventArgs e)
        {
            FormCsv csvForm = new FormCsv();
            csvForm.Show();
        }

        private void btnXmlForm_Click(object sender, EventArgs e)
        {
            FormXml xmlForm = new FormXml();
            xmlForm.Show();
        }

        private void btnJsonForm_Click(object sender, EventArgs e)
        {
            FormJson jsonForm = new FormJson();
            jsonForm.Show();

        }
    }
}
