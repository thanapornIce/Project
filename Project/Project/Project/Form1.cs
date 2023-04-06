using System.Windows.Forms;
using System.Xml.Linq;

namespace Project
{
    public partial class Form1 : Form2
    {
        private Order order;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                order = new Order()
                {
                    Name = txtName.Text,
                    Lastname = txtLastname.Text,
                    Food = txtFood.Text,
                    Price = int.Parse(txtPrice.Text),
                    Time = txtTime.Text,
                    Phone = txtPhone.Text
                };
            }
            catch
            {
                MessageBox.Show("¤Ø³¡ÃÍ¡¢éÍÁÙÅäÁè¶Ù¡µéÍ§");
            }
            this.DialogResult = DialogResult.OK;
        }
        public Order getOrder()
        {
            return order;
        }
    }
}