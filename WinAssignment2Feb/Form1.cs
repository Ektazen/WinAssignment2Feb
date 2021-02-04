using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WinAssignment2Feb
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());

        SqlCommand cmd = null;
        SqlDataReader dr = null;
        DataTable dt = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblActor_Click(object sender, EventArgs e)
        {

        }

        //Movie Details

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabMovDetails_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_DisplayMovie", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Movieid", SqlDbType.Int).Value = txtMovId.Text;
                    cn.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows && dr.Read())
                    {
                        lblMovName.Text = dr["MovieName"].ToString();
                        lblActor.Text = dr["Actor"].ToString();
                        lblTickets.Text = dr["Tickets"].ToString();

                        dr.Close();
                        cn.Close();
                        ShowData();

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void ShowData()
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (cmd = new SqlCommand("select * from MovieTable", cn))
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                //tabControl1. = dt;
                dr.Close();
                cn.Close();

            }
        }

        private void tabShowMov_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_ShowMovie", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Movieid", SqlDbType.Int).Value = txtMvId.Text;
                    cn.Open();
                    var obj = cmd.ExecuteScalar();
                    lblMovieN.Text = obj.ToString();
                   

                    //dr.Close();
                    cn.Close();
                    ShowData();




                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }




 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabUpdateMov_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateMovie", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add("@Movieid", SqlDbType.Int).Value = textBox1.Text;
                    cmd.Parameters.Add("@Moviename", SqlDbType.VarChar, 20).Value = txtMovieN.Text;
                    cmd.Parameters.Add("@Actor", SqlDbType.VarChar, 20).Value = txtActor.Text;
                    cmd.Parameters.Add("@Tickets", SqlDbType.VarChar, 20).Value = txtTickets.Text;

                    cn.Open();

                    int i = cmd.ExecuteNonQuery();

                    cn.Close();

                    ShowData();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (cmd = new SqlCommand("select * from MovieTable", cn))
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                //tabControl1. = dt;
                dr.Close();
                cn.Close();

            }
        }
    }

}
