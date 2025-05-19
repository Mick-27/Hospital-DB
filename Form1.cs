using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace Assignment_Q1_GUI
{
    public partial class Form1 : Form
    {
        PatientInfo patient;
        public Form1()
        {
            InitializeComponent();
            UpdateDatGrid(); //opens datagrid as form opens 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                string constr = "Data Source=DESKTOP-U6SNF67\\SQLEXPRESS;Integrated Security=True;Initial Catalog=hospDB;";
                SqlConnection conn = new SqlConnection(constr);
                // to open the connection 
                conn.Open();
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "error in form1Load-form.cs");
            }

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e) //search button 
        {
            //connect to database
            string connString = "Data Source=DESKTOP-U6SNF67\\SQLEXPRESS;Integrated Security=True;Initial Catalog=hospDB;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            PatientInfo patient = new PatientInfo();

            DataTable dt = new DataTable();
            dt = patient.GetPatInfo(txtSearch.Text);
            dtgrdPatients.DataSource = dt;
           
           
            txtSearch.Text = "";

            conn.Close();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //save button
        {
            //validate data input 
            if (ValidateInput())
            {

                PatientInfo patient = new PatientInfo();
                string returnMessage = patient.SaveNewPatients(cmbPatType.Text, cmbGender.Text, cmbProvince.Text, txtNOI.Text, txtFullName.Text, txtPatNum.Text, Convert.ToDateTime(txtDOB.Text), txtPhnNum.Text);
                MessageBox.Show(returnMessage);


                clearInput();
                UpdateDatGrid();
            }
        }

        private void UpdateDatGrid()
        {
            //connect to database
            string connString = "Data Source=DESKTOP-U6SNF67\\SQLEXPRESS;Integrated Security=True;Initial Catalog=hospDB;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            //select columns from patient table
            string query = "SELECT PatientType, Gender, Province, NatOfIll, FullName, PatientNum, DateOfBirth, PhoneNumber FROM Patient";
            SqlDataAdapter adap = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();

            adap.Fill(dt); //error
            //fill datdgrid wit temp table from database
            dtgrdPatients.DataSource = dt;
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            UpdateDatGrid();
        }

        private bool ValidateInput()
        {
            if (txtPatNum.Text == "")
            {
                MessageBox.Show("You need to add a Patient number please");
                return false;
            }
            // do all checks for boxes
            else if (txtFullName.Text == "")
            {
                MessageBox.Show("You need to add a Full Name of Patient please");
                return false;
            }

            else if (txtPhnNum.Text == "")
            {
                MessageBox.Show("You need to add a Patient Phone Number please");
                return false;
            }

            else if (txtNOI.Text == "")
            {
                MessageBox.Show("You need to add a Patient Nature of Illness please");
                return false;
            }
            else if (txtDOB.Text == "")
            {
                MessageBox.Show("You need to add a Patient Date of birth please");
                return false;
            }

            else if (string.IsNullOrEmpty(cmbGender.Text))
            {
                MessageBox.Show("You need to select a Gender ");
                return false;
            }

            else if (string.IsNullOrEmpty(cmbProvince.Text))
            {
                MessageBox.Show("You need to select a Province ");
                return false;
            }

            else if (string.IsNullOrEmpty(cmbPatType.Text))
            {
                MessageBox.Show("You need to select a Patient Type ");
                return false;
            }


            else
            {
                patient = new PatientInfo(cmbPatType.Text, cmbGender.Text, cmbProvince.Text, txtNOI.Text, txtFullName.Text, txtPatNum.Text, Convert.ToDateTime(txtDOB.Text), txtPhnNum.Text);


                return true;
            }

        }

        private void clearInput() // clears data in text boxes 
        {
            txtPatNum.Clear();
            txtDOB.Clear();
            txtFullName.Clear();
            txtNOI.Clear();
            txtPhnNum.Clear();
            txtSearch.Clear();

            //cmbPatType.Items.Clear();
            //cmbGender.Items.Clear();
            //cmbProvince.Items.Clear();

            //put in if statement 
            // MessageBox.Show("You have successfuly added a new patient ");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PatientInfo patient = new PatientInfo();
            
            try
            {
                string connString = "Data Source=DESKTOP-U6SNF67\\SQLEXPRESS;Integrated Security=True;Initial Catalog=hospDB;";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
               
                if (dtgrdPatients.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Enter Patient Number");

                }
                else
                {

                    if (MessageBox.Show("Are you  sure You want to delete Patient Record", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("Patient " + dtgrdPatients.SelectedRows[0].Cells[5].Value.ToString() + " Deleted");
                        string query = "DELETE FROM Patient WHERE patientNum = '" + dtgrdPatients.SelectedRows[0].Cells[5].Value.ToString()+ "'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();

                        string PatientSelected = dtgrdPatients.SelectedRows[0].ToString();
                        dtgrdPatients.Rows.Remove(dtgrdPatients.SelectedRows[0]);
                       
                        

                    }
                }

            }
            catch ( Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        
        }


    }
}