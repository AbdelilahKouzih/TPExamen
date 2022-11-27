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
    public partial class Form1 : Form
    {
        private int verif;
        public Form1()
        {
            InitializeComponent();
        }

        static string chaine = @"Data Source=DESKTOP-ID5FAVQ\SQLEXPRESS;Initial Catalog=databaseexamen;Integrated Security=True";

        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        public void connection()
        {
            cnx.Open();
            cmd.Connection = cnx;


        }
        public void etatinitial()
        {

            function_clear();
            txtid.Enabled = false;
            txtquestion.Enabled = false;
            txtop1.Enabled = false;
            txtop2.Enabled = false;
            txtop3.Enabled = false;
            txtreponse.Enabled = false;
            btnvalider.Enabled = false;
            btnannuler.Enabled = false;
            btnmodifier.Enabled = true;
            btnsupprimer.Enabled = true;
            btnafficher.Enabled = true;
          
            btnajouter.Enabled = true;
        }

        public void function_clear()
        {
            txtid.Clear();
            txtquestion.Clear();
            txtop1.Clear();
            txtop2.Clear();
            txtop3.Clear();
            txtreponse.Clear();

        }
        private void lblreponse_Click(object sender, EventArgs e)
        {

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
            txtop1.Enabled = true;
            txtop2.Enabled = true;
            txtop3.Enabled = true;
            txtreponse.Enabled = true;



            cnx.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            if(verif== 1) 
            {
                if (txtid.Text == "" || txtquestion.Text == "" || txtop1.Text == "" || txtop2.Text == "" || txtop2.Text == "" || txtreponse.Text == "")
                {
                    MessageBox.Show("vous devez remplir les champs !!");
                    return;
                }
                connection();

                cmd.CommandText = "insert into QuestionQCM(id,question,option1,option2,option3,reponse) values('" + txtid.Text + "','" + txtquestion.Text + "','" + txtop1.Text + "''," + txtop1.Text + "','" + txtop2.Text + "','" + txtop1.Text + "','" + txtreponse.Text + "') ";
                cmd.ExecuteNonQuery();
                etatinitial();
                cnx.Close();


            }

            if (verif == 2)
            {
                if (txtid.Text == "" || txtquestion.Text == "" || txtop1.Text == "" || txtop2.Text == "" || txtop2.Text == "" || txtreponse.Text == "")
                {
                    MessageBox.Show("vous devez remplir les champs !!");
                    return;
                }
                connection();
           
                cmd.CommandText = "update QuestionQCM set id ='" + txtid.Text + "' ,question = '" + txtquestion.Text + "',option1 = '" + txtop1.Text + "',option2 = '" + txtop2.Text + "',option3 = '" + txtop3.Text + "',reponse = '" + txtreponse.Text + "' where id='" + txtid.Text + "' ";
                cmd.ExecuteNonQuery();
                cnx.Close();

                etatinitial();
                cnx.Close();


            }

            if (verif == 3)
            {
                if (txtid.Text == "" )
                {
                    MessageBox.Show(" vous devez remplir les champs !!");
                    return;
                }
                connection();
                cmd.CommandText = "delete from QuestionQCM where id='" + txtid.Text + "' ";
                cmd.ExecuteNonQuery();
                MessageBox.Show(" les données bien supprimer!");

                cnx.Close();

                etatinitial();
                cnx.Close();


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            etatinitial();
        }

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
            txtop1.Enabled = false;
            txtop2.Enabled = false;
            txtop3.Enabled = false;
            txtreponse.Enabled = false;
            cmd.CommandText = "select * from QuestionQCM";

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbx.DataSource = dt;
            cbx.ValueMember = "id";
            cbx.DisplayMember = "question";
            cnx.Close();
            txtid.DataBindings.Clear();
            txtquestion.DataBindings.Clear();
            txtreponse.DataBindings.Clear();
            
            txtop1.DataBindings.Clear();
            txtop2.DataBindings.Clear();
            txtop3.DataBindings.Clear();

            txtop1.DataBindings.Add("text", cbx.DataSource, "option1");
            txtop2.DataBindings.Add("text", cbx.DataSource, "option2");
            txtop3.DataBindings.Add("text", cbx.DataSource, "option3");
            txtid.DataBindings.Add("text", cbx.DataSource, "id");
            txtquestion.DataBindings.Add("text", cbx.DataSource, "question"); 
            txtreponse.DataBindings.Add("text", cbx.DataSource, "reponse");
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
            txtop1.Enabled = true;
            txtop2.Enabled = true;
            txtop3.Enabled = true;
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
            txtop1.Enabled = false;
            txtop2.Enabled = false;
            txtop3.Enabled = false;
            txtreponse.Enabled = false;

            cnx.Close();
        }
    }
}
