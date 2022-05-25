using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace oruzara
{
    public partial class podaci : Form
    {
        int rb = 0;
        DataTable table;

        public podaci()
        {
            InitializeComponent();
        }
  

        private void loadd()
        {
            SqlConnection connetion = Konekcija.Connect();
            StringBuilder command = new StringBuilder("SELECT id, ime, sifra, kapacitet_sanzera, datum_uvoza FROM Puska ");
            SqlDataAdapter adapter = new SqlDataAdapter(command.ToString(), connetion);
            table = new DataTable();
            adapter.Fill(table);
        }


        private void text_Load()
        {
            if (table.Rows.Count == 0)
            {
                textBox1.Text = "";
                txtIme.Text = "";
                txtSifra.Text = "";
                txtKapacitet.Text = "";
                txtMetak.Text = "";
                btn_del.Enabled = false;
            }
            else
            {
                textBox1.Text = table.Rows[rb]["id"].ToString();
                txtIme.Text = table.Rows[rb]["ime"].ToString();
                txtSifra.Text = table.Rows[rb]["sifra"].ToString();
                txtKapacitet.Text = table.Rows[rb]["kapacitet_sanzera"].ToString();
                txtMetak.Text = table.Rows[rb]["datum_uvoza"].ToString();
                btn_del.Enabled = true;
            }

            if (rb == 0)
            {
                btn_frst.Enabled = false;
                btn_prev.Enabled = false;
            }
            else
            {
                btn_frst.Enabled = true;
                btn_prev.Enabled = true;
            }

            if (rb == table.Rows.Count - 1)
            {
                btn_last.Enabled = false;
                btn_next.Enabled = false;
            }
            else
            {
                btn_last.Enabled = true;
                btn_next.Enabled = true;
            }

        }

        private void podaci_Load(object sender, EventArgs e)
        {
            loadd();
            text_Load();
        }

        private void btn_frst_Click(object sender, EventArgs e)
        {

            rb = 0;
            text_Load();
        }

        private void btn_prev_Click_1(object sender, EventArgs e)
        {
            rb--;
            text_Load();
        }

        private void btn_next_Click_1(object sender, EventArgs e)
        {
            rb++;
            text_Load();
        }

        private void btn_last_Click_1(object sender, EventArgs e)
        {
            rb = table.Rows.Count - 1;
            text_Load();
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = Konekcija.Connect();
            StringBuilder command = new StringBuilder("INSERT INTO Puska (ime, sifra, kapacitet_sanzera, datum_uvoza) VALUES('");
            command.Append(txtIme.Text + "', '");
            command.Append(txtSifra.Text + "', '");
            command.Append(txtKapacitet.Text + "', ");
            command.Append(txtMetak.Text + ", ");
            SqlCommand cmd = new SqlCommand(command.ToString(), connection);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            loadd();
            rb = table.Rows.Count - 1;
            text_Load();
        }

        private void btn_chg_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("UPDATE Puska SET ");
            naredba.Append(" ime = '" + txtIme.Text + "', ");
            naredba.Append(" prezime = '" + txtSifra.Text + "', ");
            naredba.Append(" email = '" + txtKapacitet.Text + "', ");
            naredba.Append(" pozicija_id = " + txtMetak.Text + ", ");
            naredba.Append(" WHERE id = " + textBox1.Text);
            SqlConnection connection = Konekcija.Connect();
            SqlCommand command = new SqlCommand(naredba.ToString(), connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            loadd();
            text_Load();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string command = "DELETE FROM Puska WHERE id = " + textBox1.Text;
            SqlConnection connection = Konekcija.Connect();
            SqlCommand cmd = new SqlCommand(command, connection);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            loadd();
            rb = table.Rows.Count - 1;
            text_Load();
        }
    }
}
