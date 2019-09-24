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

namespace CharacterQuirks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Random()
        {
            int DBMax = 32;
            int DBMin = 0;

            Random rnd = new Random();
            int Trait1 = rnd.Next(DBMin, DBMax);
            int Trait2 = rnd.Next(DBMin, DBMax);
            int Trait3 = rnd.Next(DBMin, DBMax);

            int Phobia = rnd.Next(1, 12);

            lblTrait1.Text = Trait1.ToString();
            lblTrait2.Text = Trait2.ToString();
            lblTrait3.Text = Trait3.ToString();

            Reads(Trait1, Trait2, Trait3, Phobia);
        }

        public void Reads(int Trait1, int Trait2, int Trait3, int Phobia)
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sean.golden\Source\Repos\CharacterQuirks\CharacterQuirks\Database1.mdf;Integrated Security=True";


            DataSet dataset = new DataSet();

            //Trait 1// 
            using (SqlConnection connection = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From Traits Where Id = " + Trait1, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtTrait1Name.Text = reader["Name"].ToString();
                            txtTrait1Desc.Text = reader["Description"].ToString();
                        }
                    }
                }
            }

            //Trait 2// 
            using (SqlConnection connection = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From Traits Where Id = " + Trait2, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtTrait2Name.Text = reader["Name"].ToString();
                            txtTrait2Desc.Text = reader["Description"].ToString();
                        }
                    }
                }
            }

            //Trait 3// 
            using (SqlConnection connection = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From Traits Where Id = " + Trait3, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtTrait3Name.Text = reader["Name"].ToString();
                            txtTrait3Desc.Text = reader["Description"].ToString();
                        }
                    }
                }
            }

            //Phobia// 
            using (SqlConnection connection = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From Phobias Where Id = " + Phobia, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtPhobiaName.Text = reader["Name"].ToString();
                            txtPhobiaDesc.Text = reader["Description"].ToString();
                        }
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random();
        }

        private void btnTrait1Roll_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Trait1 = rnd.Next(0, 30);
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sean.golden\Source\Repos\CharacterQuirks\CharacterQuirks\Database1.mdf;Integrated Security=True";


            DataSet dataset = new DataSet();

            //Trait 1// 
            using (SqlConnection connection = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From Traits Where Id = " + Trait1, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtTrait1Name.Text = reader["Name"].ToString();
                            txtTrait1Desc.Text = reader["Description"].ToString();
                        }
                    }
                }
            }
        }

        private void btnTrait2Roll_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Trait2 = rnd.Next(0, 30);
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sean.golden\Source\Repos\CharacterQuirks\CharacterQuirks\Database1.mdf;Integrated Security=True";


            DataSet dataset = new DataSet();

            //Trait 2// 
            using (SqlConnection connection = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From Traits Where Id = " + Trait2, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtTrait2Name.Text = reader["Name"].ToString();
                            txtTrait2Desc.Text = reader["Description"].ToString();
                        }
                    }
                }
            }
        }

        private void btnTrait3Roll_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Trait3 = rnd.Next(0, 30);
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sean.golden\Source\Repos\CharacterQuirks\CharacterQuirks\Database1.mdf;Integrated Security=True";


            DataSet dataset = new DataSet();

            //Trait 3// 
            using (SqlConnection connection = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From Traits Where Id = " + Trait3, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtTrait3Name.Text = reader["Name"].ToString();
                            txtTrait3Desc.Text = reader["Description"].ToString();
                        }
                    }
                }
            }
        }

        private void btnPhobiaRoll_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Phobia = rnd.Next(0, 30);
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sean.golden\Source\Repos\CharacterQuirks\CharacterQuirks\Database1.mdf;Integrated Security=True";
            
            DataSet dataset = new DataSet();

            //Trait 1// 
            using (SqlConnection connection = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From Phobias Where Id = " + Phobia, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtPhobiaName.Text = reader["Name"].ToString();
                            txtPhobiaDesc.Text = reader["Description"].ToString();
                        }
                    }
                }
            }
        }
    }
}
