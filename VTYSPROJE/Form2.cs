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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=MONSTER\\SQLEXPRESS02;Initial Catalog=UrunKiralamaSistemiVTYS;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("exec urunGoster", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Urun where UrunId= '" + textBox1.Text + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand ekle = new SqlCommand("insert into Urun (UrunAdi,KategoriId,AylikKiraUcreti) values(@p2,@p3,@p4)", conn);
            ekle.Parameters.AddWithValue("@p2", textBox2.Text);
            ekle.Parameters.AddWithValue("@p3", textBox3.Text);
            ekle.Parameters.AddWithValue("@p4", textBox4.Text);
            ekle.ExecuteNonQuery();
            conn.Close();

            SqlDataAdapter da = new SqlDataAdapter("exec urunGoster", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sil = new SqlCommand("Delete From Urun where UrunID=@ID",conn);
            sil.Parameters.AddWithValue("@ID", textBox1.Text);
            sil.ExecuteNonQuery();
            conn.Close();

            SqlDataAdapter da = new SqlDataAdapter("exec urunGoster", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id=dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string kategori = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox1.Text= id;
            textBox2.Text= ad;
            textBox3.Text= kategori;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand guncelle = new SqlCommand("update Urun set UrunAdi=@p2,KategoriId=@p3 where UrunID=@p1",conn);
            guncelle.Parameters.AddWithValue("@p1",textBox1.Text);
            guncelle.Parameters.AddWithValue("@p2", textBox2.Text);
            guncelle.Parameters.AddWithValue("@p3", textBox3.Text);

            guncelle.ExecuteNonQuery();
            conn.Close();

            SqlDataAdapter da = new SqlDataAdapter("exec urunGoster", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("exec urunGoster", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
