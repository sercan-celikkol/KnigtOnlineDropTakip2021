using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KnigtOnlineDropTakip2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        string connectionString = "Server=DESKTOP-J2L0HD8\\SQLEXPRESS01;Database=KoDropDB;Trusted_Connection=True;";
        DataSet ds;
        SqlDataAdapter da;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            maskedTxtDropDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            txtBoxPrice.Text = ("0");
            GetData();
        }
        private void GetData()
        {
            con.Open();
            string Select = "Select * From DropBilgi";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Select, con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        void ItemEkle()
        {
            try
            {


                var price = txtBoxPrice.Text;
                var date = maskedTxtDropDate.Text;
                var item = txtBoxDropName.Text;
                var members = txtBoxPartyMembers.Text;

                cmd = new SqlCommand($"insert into DropBilgi (DropName, DüştüğüTarih, Fiyat, Partydekiler) values ('{item}', '{date}', {price},'{members}')", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Ohh Yeni Droplar.");

                GetData();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("Hata!");
            }
            finally
            {


            }
        }


        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            ItemEkle();
        }

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            var id = e.Row.Cells["id"].Value;
            cmd = new SqlCommand($"Delete from DropBilgi Where id = {id}", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Başarıyla silindi!");
        }

        private void dataGridView2_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Name == "id")
            {
                e.Column.HeaderText = "Sıra";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                MessageBox.Show("Silmek istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo);
                var id = row.Cells["id"].Value;
                string sql = $"Delete from DropBilgi Where id = {id}";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue($"@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetData();

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.nttgameonline.com/knight/tr/ranking/clan/5/Elmo");
        }

        private void maskedTxtDropDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
                                   //DropName, DüştüğüTarih, Fiyat, Partydekiler
