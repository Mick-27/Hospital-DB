using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Reflection.Metadata.Ecma335;

internal class PatientInfo
{
    //class variables
    public string patientType;
    public string gender;
    public string province;
    public string natureOfIllness;
    public string fullName;
    public string patientNumber;
    public DateTime dateOfBirth;
    public string phoneNumber;

    public static SqlConnection conn;
    public PatientInfo()
    {
    }

    public PatientInfo(string patientType, string gender, string province, string natureOfIllness, string fullName, string patientNumber, DateTime dateOfBirth, string phoneNumber)
    {
        this.patientType = patientType;
        this.gender = gender;
        this.province = province;
        this.natureOfIllness = natureOfIllness;
        this.fullName = fullName;
        this.patientNumber = patientNumber;
        this.dateOfBirth = dateOfBirth;
        this.phoneNumber = phoneNumber;
    }

    public string SaveNewPatients(string patientType, string gender, string province, string natureOfIllness, string fullName, string patientNumber, DateTime dateOfBirth, string phoneNumber)
    {

        string status = "Patient could not be saved"; //error 2 
        try
        {

            if (DBconnect() == true)
            {
                string query = "INSERT INTO Patient(PatientType, Gender, Province, NatOfIll, FullName, PatientNum, DateOfBirth, PhoneNumber) VALUES (@a, @b, @c, @d, @e, @f, @g, @h);";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@a", patientType);
                cmd.Parameters.AddWithValue("@b", gender);
                cmd.Parameters.AddWithValue("@c", province);
                cmd.Parameters.AddWithValue("@d", natureOfIllness);
                cmd.Parameters.AddWithValue("@e", fullName);
                cmd.Parameters.AddWithValue("@f", patientNumber);
                cmd.Parameters.AddWithValue("@g", dateOfBirth).ToString();
                cmd.Parameters.AddWithValue("@h", phoneNumber);



                cmd.ExecuteNonQuery();
                DBDisconnect();

                status = "Patient " + fullName + " is being saved to the database";

            }


        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message + "saveNewPatient-class1.cs");

        }

        return status;

    }


    public static bool DBconnect()
    {
        bool connected = false;
        try
        {
            string connstr = "Data Source=DESKTOP-U6SNF67\\SQLEXPRESS;Integrated Security=True;Initial Catalog=hospDB;";
            conn = new SqlConnection(connstr);
            conn.Open();
            connected = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        return connected;
    }
    public static void DBDisconnect()
    {
        conn.Close();
    }


    public DataTable GetPatInfo(string patientNumberSearched)
    {
        DataTable dt = new DataTable();

        bool connected = false;
        connected = DBconnect();

        if (connected)
        {

            string query = $"SELECT PatientType, Gender, Province, NatOfIll, FullName, PatientNum, DateOfBirth, PhoneNumber FROM Patient WHERE PatientNum LIKE '%{patientNumberSearched}%'";
            SqlDataAdapter adap = new SqlDataAdapter(query, conn);
            adap.Fill(dt);
            DBDisconnect();
        }
        return dt;  // to be used as the data for the datagrid
    }

    public ArrayList DisplayAll()
    {
        ArrayList patientList = new ArrayList();
        //connect to database
        //SELECT * FROM Patient 
        // returned data from database  will be stored in an array list 
        // array list will be used in windows forms code behind file to populate the datagrid 
        // patientList.Add("john")
        return patientList;

    }


    public ArrayList SearchPatient(string patientNumberSearched) // receive a string 
    {
        ArrayList patientList = new ArrayList();
        //connect to database
        if (DBconnect())
        {
            string query = $"SELECT PatientType, Gender, Province, NatOfIll, FullName, PatientNum, DateOfBirth, PhoneNumber FROM Patient WHERE PatientNum LIKE '%{patientNumberSearched}%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string PatType = reader.GetString(0);
                string Gender = reader.GetString(1);
                string province = reader.GetString(2);
                string NatoFill = reader.GetString(3);
                string fullName = reader.GetString(4);
                string patientNum = reader.GetString(5);
                string DOB = reader.GetValue(6).ToString();
                string phone = reader.GetString(7);
                patientList.Add(patientNum + " " + fullName);

            }
            
        }

        //SELECT * FROM Patient  WHERE patientNe = patientNumber:
        // returned data from database  will be stored in an array list 
        // array list will be used in windows forms code behind file to populate the datagrid 
        return patientList;

    }

    public string DeletePatient(string patientNumberDeleted)
    {
        // connect to database 
        // DELETE FROM patient WHERE patientNumber = patientNumberDeleted
        
        String deletePat = new string(patientNumberDeleted);

        if (DBconnect())
        {
            string query = "DELETE FROM Patient WHERE patientNumber = @patientNumberDeleted";
            using SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
           cmd.ExecuteNonQuery();


        }
       
       
        return deletePat;
    }
}

