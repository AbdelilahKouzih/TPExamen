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
    public partial class Dichotomique : Form
    {
        private int verif;
        public Dichotomique()
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
         
           
            txtreponse.Enabled = false;
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
           
            txtreponse.Clear();

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

            txtreponse.Enabled = true;
            cnx.Close();
        }

        private void Dichotomique_Load(object sender, EventArgs e)
        {
            etatinitial();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {

            verif = 2;

            connection();

            btnannuler.Enabled = true;
            btnmodifier.Enabled = false;
            btnvalider.Enabled = true;
            btnsupprimer.Enabled = false;
            btnafficher.Enabled = false;
            btnajouter.Enabled = false;
            cbx.Enabled = true;
            txtid.Enabled = true;
            txtquestion.Enabled = true;

            txtreponse.Enabled = true;

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

            txtreponse.Enabled = false;

            cnx.Close();

        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            if (verif == 1)
            {
                if (txtid.Text == "" || txtquestion.Text == "" || txtreponse.Text == "")
                {
                    MessageBox.Show("vous devez remplir les champs !!");
                    return;
                }
                connection();

                cmd.CommandText = "insert into Dichotomique(id,question,reponse) values('" + txtid.Text + "','" + txtquestion.Text + "','" + txtreponse.Text + "') ";
                cmd.ExecuteNonQuery();
                etatinitial();
                cnx.Close();


            }

            if (verif == 2)
            {
                if (txtid.Text == "" || txtreponse.Text == "")
                {
                    MessageBox.Show("vous devez remplir les champs !!");
                    return;
                }
                connection();

                cmd.CommandText = "update Dichotomique set id ='" + txtid.Text + "' , question = '" + txtquestion.Text + "', reponse = '" + txtreponse.Text + "' where id='" + txtid.Text + "' ";
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
                cmd.CommandText = "delete from Dichotomique where id='" + txtid.Text + "' ";
                cmd.ExecuteNonQuery();
                MessageBox.Show(" les données bien supprimer!");

                cnx.Close();

                etatinitial();
                cnx.Close();



            }
        }

       

       

        private void btnannuler_Click_1(object sender, EventArgs e)
        {
            etatinitial();
        }

        private void btnafficher_Click_1(object sender, EventArgs e)
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

            txtreponse.Enabled = false;
            cmd.CommandText = "select * from Dichotomique";

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbx.DataSource = dt;
            cbx.ValueMember = "id";
            cbx.DisplayMember = "question";
            cnx.Close();
            txtid.DataBindings.Clear();
            txtquestion.DataBindings.Clear();
            txtreponse.DataBindings.Clear();




            txtid.DataBindings.Add("text", cbx.DataSource, "id");
            txtquestion.DataBindings.Add("text", cbx.DataSource, "question");
            txtreponse.DataBindings.Add("text", cbx.DataSource, "reponse");


        }

        private void btnexamen_Click(object sender, EventArgs e)
        {
            Examen D = new Examen();
            D.Show();
        }
    }
}
