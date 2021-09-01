using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BMI_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public float calculate(float weight, float height)
        {

            float bmi = weight / (height * height);

            return bmi;

        }


        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                float bmi = calculate(float.Parse(weightTbox.Text), float.Parse(heightTbox.Text));
                bmiTbox.Text = bmi.ToString();


                if (bmi < 18.5)
                {
                    bmiLabel.Text = "Under Weight";

                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    bmiLabel.Text = "Healthy";
                }
                else if (bmi >= 25 && bmi <= 29.9)
                {
                    bmiLabel.Text = "Over Weight";
                }

                else
                {
                    bmiLabel.Text = "Obese";

                }


                if (patientidTbox.Text.Length < 13 || patientidTbox.Text.Length > 13)
                {
                    idElabel.Text = "Enter a valid ID number";
                }

                else
                {
                    try
                    {
                        idElabel.Text = "";

                        String str = "Data Source=LAPTOP-Q1L5OKJ1;Initial Catalog=BMIcalculator;Integrated Security=True";

                        String query = "Insert into newPatients (patientId, weight, height,[bmi/comment]) VALUES ( @patientId, @weight, @height,@bmi)"; ;

                        SqlConnection con = new SqlConnection(str);

                        SqlCommand cmd = new SqlCommand(query, con);

                        con.Open();
                        cmd.Parameters.AddWithValue("@patientId", patientidTbox.Text);
                        cmd.Parameters.AddWithValue("@weight", weightTbox.Text);
                        cmd.Parameters.AddWithValue("height", heightTbox.Text);
                        cmd.Parameters.AddWithValue("@bmi", bmiLabel.Text);




                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record is saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        DataSet ds = new DataSet();





                        con.Close();
                    }
                    catch (Exception es)
                    {

                        MessageBox.Show(es.Message);
                    }
                }

            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message);


            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
