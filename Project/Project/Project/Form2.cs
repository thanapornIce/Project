using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Project
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        List<Order> orders = new List<Order>();
        public Form2()
        {
            InitializeComponent();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "";
            saveFile.Filter = "CSV|*.csv";
            saveFile.ShowDialog();

            if (saveFile.Filter != "")
            {
                using (StreamWriter file = new StreamWriter(saveFile.FileName))
                {
                    foreach (Order item in orders)
                    {
                        file.WriteLine($"{item.Name},{item.Lastname},{item.Food},{item.Price},{item.Time},{item.Phone}");

                    }

                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Add = new Form2();
            Add.ShowDialog();
            if (Add.DialogResult == DialogResult.OK)
            {
                orders.Add(Add.getOrder());
                Refresh();
            }
        }
    
        public void Refresh()
        {
            dataGridView1.Rows.Clear();
            foreach (Order item in orders)
            {
                dataGridView1.Rows.Add(item.Name, item.Lastname,item.Food, item.Price, item.Time, item.Phone);
            }
        }

    private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "CSV files(*.csv)|*.csv|All files(*.*)|*.*";
            OpenFileDialog.ShowDialog();
            if (OpenFileDialog.FileName != "")
            {
                dataGridView1.Rows.Clear();
                using (StreamReader file = new StreamReader(OpenFileDialog.FileName))
                {
                    string line;
                    int count = 0;
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        orders.Add(new Order()
                        {
                            Name = data[0],
                            Lastname = data[1],
                            Food = data[2],
                            Price = int.Parse(data[3]),
                            Time = data[4],
                            Phone = data[5]
                            
                        });
                        Refresh();
                    }
                }
            }
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                orders.RemoveAt(dataGridView1.SelectedRows[0].Index);
                Refresh();
                MessageBox.Show("เสร็จสิ้นแล้ว");
            }
            catch
            {
                MessageBox.Show("เกิดข้อผิดพลาด");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
