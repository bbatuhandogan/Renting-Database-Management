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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=MONSTER\\SQLEXPRESS02;Initial Catalog=UrunKiralamaSistemiVTYS;Integrated Security=True");
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'urunKiralamaSistemiVTYSDataSet.kiralamalariGoster' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            SqlDataAdapter da = new SqlDataAdapter("exec KiralamalariGoster", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand ekle = new SqlCommand("insert into Kiralamalar (MusteriId,UrunId,TakipNo,KiraBaslangic,KiraBitis) values(@p2,@p3,@p4,@p5,@p6)", conn);
            ekle.Parameters.AddWithValue("@p2", textBox2.Text);
            ekle.Parameters.AddWithValue("@p3", textBox3.Text);
            ekle.Parameters.AddWithValue("@p4", textBox4.Text);
            ekle.Parameters.AddWithValue("@p5", dateTimePicker1.Value);
            ekle.Parameters.AddWithValue("@p6", dateTimePicker2.Value);
            ekle.ExecuteNonQuery();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand guncelle = new SqlCommand("update Kiralamalar set MusteriId=@p2,UrunId=@p3,TakipNo=@p4,KiraBaslangic=@p5,KiraBitis=@p6 where KiraID=@p1", conn);
            guncelle.Parameters.AddWithValue("@p1", textBox1.Text);
            guncelle.Parameters.AddWithValue("@p2", textBox2.Text);
            guncelle.Parameters.AddWithValue("@p3", textBox3.Text);
            guncelle.Parameters.AddWithValue("@p4", textBox4.Text);
            guncelle.Parameters.AddWithValue("@p5", dateTimePicker1.Value);
            guncelle.Parameters.AddWithValue("@p6", dateTimePicker2.Value);

            guncelle.ExecuteNonQuery();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sil = new SqlCommand("Delete From Kiralamalar where KiraID=@p1", conn);
            sil.Parameters.AddWithValue("@p1", textBox1.Text);
            sil.ExecuteNonQuery();
            conn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("exec AylikBorcGoster", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("exec SuresiDolacakKiralamalar", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("exec YaklasanKiralar", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("exec KiralamalariGoster", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button8_Click(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.TakipNoIleKiraSorgula("+ textBox4.Text+")", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.BelirliMusteriKiraGoster(" + textBox2.Text + ")", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
