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
    public partial class form_add : Form
    {
        MySqlConnection connect = null;
        MySqlCommand cmd = null;
        public form_add()
        {
            InitializeComponent();
        }
        public void adat_update()
        {
            list_adatok.Items.Clear();
            cmd.CommandText = "SELECT `id`, `nev`, `szuletesidatum`, `profilkep_nev` FROM `felhasznalok`";
            connect.Close();
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

        private void form_add_Load(object sender, EventArgs e)
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

        private void button_save_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1_nev.Text))
            {
                MessageBox.Show("Adja meg a nevet");
                textBox1_nev.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("Érvénytelen dátum");
                dateTimePicker1.Focus();
                return;
            }
            cmd.CommandText = "INSERT INTO `felhasznalok` (`nev`, `szuletesidatum`, `profilkep_nev`) VALUES (@nev, @szuletesidatum, @profilkep_nev );";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nev", textBox1_nev.Text);
            cmd.Parameters.AddWithValue("@szuletesidatum", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@profilkep_nev", openFileDialog1.SafeFileName);
            connect.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeres adat rögzítés");
                    textBox1_nev.Text = "";
                    dateTimePicker1.Value = dateTimePicker1.MinDate;

                    adat_update();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            connect.Close();
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
        }

        private void button_kep_feltolt_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*. png|*.png|*.jpg|*.jpg|*.jfif|*.jfif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string kepfile = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(kepfile);
            }
            else
            {
                MessageBox.Show("folyamat megszaítva");
            }
        }
    }
}
