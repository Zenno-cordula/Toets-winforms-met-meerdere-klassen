namespace _1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFactuurAanmaken_Click(object sender, EventArgs e)
        {
            if (txtFactuurID.Text != "" && txtNaamKlant.Text != "" && txtKlantNr.Text != "")
            {
                Factuur objFactuur = new Factuur(Convert.ToInt32(txtFactuurID.Text), Convert.ToInt32(txtKlantNr.Text), txtNaamKlant.Text);
                lstFacturen.Items.Add(objFactuur);
                txtFactuurID.Text = "";
                txtNaamKlant.Text = "";
                txtKlantNr.Text = "";
            }
        }

        private void btnFactuurLijnAanmaken_Click(object sender, EventArgs e)
        {
            if (txtProduct.Text != "" && txtAantal.Text != "" && txtPrijs.Text != "" && lstFacturen.SelectedItem != null)
            {
                Factuur objFactuurLijn = (Factuur)lstFacturen.SelectedItem;
            }
        }

        private void lstFacturen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFacturen.Items != null)
            {
                
            }
        }
    }
}
