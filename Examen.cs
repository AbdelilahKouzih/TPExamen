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

namespace TPExamen
{
    public partial class Examen : Form
    {
        private int verif;
        public Examen()
        {
            InitializeComponent();
        }
        
        static string chaine = @"Data Source=DESKTOP-ID5FAVQ\SQLEXPRESS;Initial Catalog=databaseexamen;Integrated Security=True";

        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        private void connection()
        {
            cnx.Open();
            cmd.Connection = cnx;


        }
        private void etatinitial()
        {

            function_clear();
            txtid.Enabled = false;
            txtquestion.Enabled = false;
            txtfin.Enabled = false;
            txtdebut.Enabled = false;
            txtqcm.Enabled = false;
            txtouvert.Enabled = false;


            
            btnvalider.Enabled = false;
            btnannuler.Enabled = false;
            btnmodifier.Enabled = true;
            btnsupprimer.Enabled = true;
            btnafficher.Enabled = true;

            btnajouter.Enabled = true;
        }

        private void function_clear()
        {
            txtid.Clear();
            txtquestion.Clear();
            txtfin.Clear();
            txtdebut.Clear();
            txtqcm.Clear();
            txtouvert.Clear();

            

        }
        private void btnajouter_Click(object sender, EventArgs e)
        {
            verif = 1;
            connection();
            function_clear();

            btnannuler.Enabled = true;
            btnmodifier.Enabled = false;
            btnvalider.Enabled = true;
            btnajouter.Enabled = false;
            btnsupprimer.Enabled = false;
            btnafficher.Enabled = false;
            cbx.Enabled = false;
            txtid.Enabled = true;
            txtquestion.Enabled = true;
            txtdebut.Enabled = true;
            txtfin.Enabled = true;
            txtouvert.Enabled = true;
            txtqcm.Enabled = true;
            

            
            cnx.Close();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            verif = 2;

            connection();
            function_clear();
            btnannuler.Enabled = true;
            btnmodifier.Enabled = false;
            btnvalider.Enabled = true;
            btnsupprimer.Enabled = false;
            btnafficher.Enabled = false;
            btnajouter.Enabled = false;
            cbx.Enabled = true;
            txtid.Enabled = true;
            txtquestion.Enabled = true;
            txtdebut.Enabled = true;
            txtfin.Enabled = true;
            txtouvert.Enabled = true;
            txtqcm.Enabled = true;
           

            cnx.Close();
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            verif = 3;

            connection();
            function_clear();
            btnannuler.Enabled = true;
            btnmodifier.Enabled = false;
            btnvalider.Enabled = true;
            btnsupprimer.Enabled = false;
            btnajouter.Enabled = false;
            btnafficher.Enabled = false;
            cbx.Enabled = false;
            txtid.Enabled = true;
            txtquestion.Enabled = false;
            txtdebut.Enabled = false;
            txtfin.Enabled = false;
            txtouvert.Enabled = false;
            txtqcm.Enabled = false;
            cnx.Close();
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            if (verif == 1)
            {
                if (txtid.Text == "" || txtquestion.Text == "" || txtdebut.Text == "" || txtdebut.Text == "")
                {
                    MessageBox.Show("vous devez remplir les champs !!");
                    return;
                }
                connection();

                cmd.CommandText = "insert into Examen(id,id_questiondi,id_questionqcm,id_questionouvert,date_debut,date_fin) values('" + txtid.Text + "','" + txtquestion.Text + "','" + txtqcm.Text + "','" + txtouvert.Text + "','" + txtdebut.Text + "','" + txtfin.Text + "') ";
                cmd.ExecuteNonQuery();
                etatinitial();
                cnx.Close();


            }

            if (verif == 2)
            {
                if (txtid.Text == "")
                {
                    MessageBox.Show("vous devez remplir le champ d'identifiant !!");
                    return;
                }
                connection();

                cmd.CommandText = "update Examen set id ='" + txtid.Text + "' , id_questiondi = '" + txtquestion.Text + "', id_questionqcm = '" + txtqcm.Text + "', id_questionouvert = '" + txtouvert.Text + "', date_debut = '" + txtdebut.Text + "', date_fin = '" + txtfin.Text + "' where id='" + txtid.Text + "' ";
                cmd.ExecuteNonQuery();
                cnx.Close();

                etatinitial();
                cnx.Close();


            }

            if (verif == 3)
            {
                if (txtid.Text == "")
                {
                    MessageBox.Show(" vous devez remplir les champs !!");
                    return;
                }
                connection();
                cmd.CommandText = "delete from Examen where id='" + txtid.Text + "' ";
                cmd.ExecuteNonQuery();
                MessageBox.Show(" les données bien supprimer!");

                cnx.Close();

                etatinitial();
                cnx.Close();
            } }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            etatinitial();
        }

        private void btnafficher_Click(object sender, EventArgs e)
        {

            connection();

            btnannuler.Enabled = false;
            btnmodifier.Enabled = true;
            btnvalider.Enabled = false;
            btnsupprimer.Enabled = true;
            btnafficher.Enabled = false;
            cbx.Enabled = true;
            txtid.Enabled = false;
            txtquestion.Enabled = false;

            txtdebut.Enabled = false;
            txtfin.Enabled = false;
            cmd.CommandText = "select * from Examen";

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbx.DataSource = dt;
            cbx.ValueMember = "id";
            cbx.DisplayMember = "question";
            cnx.Close();
            txtid.DataBindings.Clear();
            txtquestion.DataBindings.Clear();
            txtdebut.DataBindings.Clear();
            txtfin.DataBindings.Clear();
            txtqcm.DataBindings.Clear();
            txtouvert.DataBindings.Clear();

            txtid.DataBindings.Add("text", cbx.DataSource, "id");
            txtquestion.DataBindings.Add("text", cbx.DataSource, "id_questiondi");
            txtdebut.DataBindings.Add("text", cbx.DataSource, "date_debut");
            txtfin.DataBindings.Add("text", cbx.DataSource, "date_fin");
            txtqcm.DataBindings.Add("text", cbx.DataSource, "id_questionqcm");
            txtouvert.DataBindings.Add("text", cbx.DataSource, "id_questionouvert");



        }

        private void Examen_Load(object sender, EventArgs e)
        {
            etatinitial();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnqcm_Click(object sender, EventArgs e)
        {
            Form1 f= new Form1();
            f.Show();
        }

        private void btnouvert_Click(object sender, EventArgs e)
        {
            QuestionOuvert f = new QuestionOuvert();
            f.Show();
        }

        private void btndi_Click(object sender, EventArgs e)
        {

           Dichotomique  f = new Dichotomique();
            f.Show();
        }
    }
}
