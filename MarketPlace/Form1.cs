namespace MarketPlace
{
    public partial class MarketPlace_Dashboard : Form
    {
        public MarketPlace_Dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Vendor_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Product_Catalog_Click(object sender, EventArgs e)
        {

            panelContent.Controls.Clear();

           
            Form2 myForm2 = new Form2();
            myForm2.TopLevel = false;                         
            myForm2.FormBorderStyle = FormBorderStyle.None;    
            myForm2.Dock = DockStyle.Fill;                     

         
            panelContent.Controls.Add(myForm2);
            myForm2.Show();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

           
            dataGridView1.Dock = DockStyle.Fill;
            panelContent.Controls.Add(dataGridView1);
        }

        private void MarketPlace_Dashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            dataGridView1.Rows.Add("Brake Lever Set", "Motor Parts", "PHP 999", "142 sold", " Active");
            dataGridView1.Rows.Add("Handlebar System", "Bike Parts", "PHP 599", "65 sold", " Active");
            dataGridView1.Rows.Add("Performance Steering Wheel", "Car Parts", "PHP 2,499", "12 sold", " Low Stock");
            dataGridView1.Rows.Add("Alloy Wheel Car Rim", "Car Parts", "PHP 4,500", "0 sold", " Draft");
            dataGridView1.Rows.Add("Crankset Chainring Kit", "Bike Parts", "PHP 850", "88 sold", " Out of Stock");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
