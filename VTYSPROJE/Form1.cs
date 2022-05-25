using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VTYSPROJE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'vTYSPROJEDataSet1.Urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunTableAdapter.Fill(this.vTYSPROJEDataSet1.Urun);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Musteri_Click(object sender, EventArgs e)
        {
            Form2 UD = new Form2();
            UD.Show();
            this.Hide();
        }
        private void Test_Click(object sender, EventArgs e)
        {
            Form2 UD = new Form2();
            UD.Show();
            this.Hide();
        }

        private void Urun_Click_1(object sender, EventArgs e)
        {
            Form2 UD = new Form2();
            UD.Show();
            //this.Hide();


        }

        private void Test_Click_1(object sender, EventArgs e)
        {
            Form4 KD = new Form4();
            KD.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 UD = new Form3();
            UD.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
