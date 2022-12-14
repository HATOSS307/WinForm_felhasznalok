using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace felhasz_nyivantartas
{
    public partial class Form_nyito : Form
    {
        MySqlConnection connect = null;
        MySqlCommand cmd = null;
        public Form_nyito()
        {
            InitializeComponent();
        }

        public void adat_update()
        {
            list_adatok.Items.Clear();
            cmd.CommandText = "SELECT `id`, `nev`, `szuletesidatum`, `profilkep_nev` FROM `felhasznalok`";
            connect.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    adatok uj = new adatok(dr.GetInt32("id"), dr.GetString("nev"), dr.GetMySqlDateTime("szuletesidatum"), dr.GetString("profilkep_nev"));
                    list_adatok.Items.Add(uj);
                }
            }
            connect.Close();
        }
        private void Form_nyito_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "felhasznalo_nyilvantartas";
            connect = new MySqlConnection(builder.ConnectionString);
            try
            {
                //terv szerint
                connect.Open();
                cmd = connect.CreateCommand();
            }
            catch (MySqlException ex)
            {
                //terv megbukott
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leált");
                Environment.Exit(0);
            }
            finally
            {
                connect.Close();
            }
            adat_update();

        
        }

        private void rögzítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.form_New.ShowDialog();
            adat_update();
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.form_Edit.ShowDialog();
            adat_update();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.form_Delete.ShowDialog();
            adat_update();
        }

        private void list_adatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_adatok.SelectedIndex < 0)
            {
                return;
            }
            adatok kivalasztott = (adatok)list_adatok.SelectedItem;
            textBox_id.Text = kivalasztott.Id.ToString();
            textBox1_nev.Text = kivalasztott.Nev.ToString();
            MySqlDateTime szuletesi_datum = kivalasztott.Szuletesidatum;
           // pictureBox1.Image = Image.FromFile(kivalasztott.Profilkep_nev);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
