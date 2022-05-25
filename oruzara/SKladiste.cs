using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace oruzara
{
    public partial class SKladiste : Form
    {
        public SKladiste()
        {
            InitializeComponent();
        }

        private void SKladiste_Load(object sender, EventArgs e) 
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select puska.id,ime,sifra,datum_uvoza,kapacitet_sanzera,metkovi.vrsta from puska join metkovi on puska.metak = Metkovi.id", Konekcija.Connect());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            //dataGridView1.Columns.Add(new DataColumn("Stanje", (int)));
            dataGridView1.Columns["id"].ReadOnly = true;
        }
    }
}
