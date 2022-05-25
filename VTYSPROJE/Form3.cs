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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=MONSTER\\SQLEXPRESS02;Initial Catalog=UrunKiralamaSistemiVTYS;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Ilce", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            da = new SqlDataAdapter("Select * from Il", conn);

            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand adres_ekle = new SqlCommand("insert into Adres (BinaNo,Sokak,Mahalle,IlId,IlceId,UlkeId) values(@p5,@p8,@p9,@p6,@p7,@p100)",conn);
            adres_ekle.Parameters.AddWithValue("@p5", textBox5.Text);
            adres_ekle.Parameters.AddWithValue("@p8", textBox8.Text);
            adres_ekle.Parameters.AddWithValue("@p9", textBox9.Text);   
            adres_ekle.Parameters.AddWithValue("@p6", textBox6.Text);
            adres_ekle.Parameters.AddWithValue("@p7", textBox7.Text);
            adres_ekle.Parameters.AddWithValue("@p100", 1);

            adres_ekle.ExecuteNonQuery();

         

            SqlCommand command = new SqlCommand(
                "select max(AdresID) from adres",
                conn);

            Int32 adres_int = ((Int32?)command.ExecuteScalar()) ?? 0;


            SqlCommand ekle = new SqlCommand("insert into Musteriler (Ad,Soyad,TelNo,TCKNo,Email,Password,AdresId) values(@p1,@p2,@p3,@p4,@p10,@p11,@p12)", conn);
            ekle.Parameters.AddWithValue("@p1", textBox1.Text);
            ekle.Parameters.AddWithValue("@p2", textBox2.Text);
            ekle.Parameters.AddWithValue("@p3", textBox3.Text);
            ekle.Parameters.AddWithValue("@p4", textBox4.Text);
            ekle.Parameters.AddWithValue("@p10", textBox10.Text);
            ekle.Parameters.AddWithValue("@p11", textBox11.Text);
            ekle.Parameters.AddWithValue("@p12", adres_int);
            ekle.ExecuteNonQuery();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 MD = new Form5();
            MD.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand adres_ekle = new SqlCommand("insert into Adres (BinaNo,Sokak,Mahalle,IlId,IlceId,UlkeId) values(@p5,@p8,@p9,@p6,@p7,@p100)", conn);
            adres_ekle.Parameters.AddWithValue("@p5", textBox5.Text);
            adres_ekle.Parameters.AddWithValue("@p8", textBox8.Text);
            adres_ekle.Parameters.AddWithValue("@p9", textBox9.Text);
            adres_ekle.Parameters.AddWithValue("@p6", textBox6.Text);
            adres_ekle.Parameters.AddWithValue("@p7", textBox7.Text);
            adres_ekle.Parameters.AddWithValue("@p100", 1);

            adres_ekle.ExecuteNonQuery();



            SqlCommand command = new SqlCommand(
                "select max(AdresID) from adres",
                conn);

            Int32 adres_int = ((Int32?)command.ExecuteScalar()) ?? 0;
            conn.Close();

            conn.Open();
            SqlCommand guncelle = new SqlCommand("update Musteriler set Ad=@p1,Soyad=@p2,TelNo=@p3,TCKNo=@p4,Email=@p10,Password=@p11,AdresId=@p12 where Ad=@p1 and Soyad=@p2", conn);
            guncelle.Parameters.AddWithValue("@p1", textBox1.Text);
            guncelle.Parameters.AddWithValue("@p2", textBox2.Text);
            guncelle.Parameters.AddWithValue("@p3", textBox3.Text);
            guncelle.Parameters.AddWithValue("@p4", textBox4.Text);
            guncelle.Parameters.AddWithValue("@p10", textBox10.Text);
            guncelle.Parameters.AddWithValue("@p11", textBox11.Text);
            guncelle.Parameters.AddWithValue("@p12", adres_int);

            guncelle.ExecuteNonQuery();
            conn.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            textBox7.Text = id;

            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Il", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Ilce", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            string id = dataGridView2.Rows[secilen].Cells[0].Value.ToString();

            textBox6.Text = id;
        }
    }
}
