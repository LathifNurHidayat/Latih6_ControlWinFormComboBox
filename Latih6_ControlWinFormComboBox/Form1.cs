namespace Latih6_ControlWinFormComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbManual.Items.Add("Marksman");
            cmbManual.Items.Add("Tank");
            cmbManual.Items.Add("Mage");


            List<string> itemRole = new List<string>
            {"Marksman","Tank","Mage"};
            cmbBinding.DataSource = itemRole;


            string SelectedItem = cmbBinding.SelectedItem.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbManual.Items.RemoveAt(cmbManual.SelectedIndex);
        }
    }
}