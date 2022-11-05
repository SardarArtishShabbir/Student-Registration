using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelperSpace;
namespace Student_Registration
{
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registerStudentDataSet2.tbl_student' table. You can move, or remove it, as needed.
            this.tbl_studentTableAdapter1.Fill(this.registerStudentDataSet2.tbl_student);
            // TODO: This line of code loads data into the 'registerStudentDataSet1.tbl_student' table. You can move, or remove it, as needed.
            this.tbl_studentTableAdapter.Fill(this.registerStudentDataSet1.tbl_student);

        }

        private void cmb_regID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "SELECT * from tbl_student WHERE [Registration ID]= '"+cmb_regID.Text+"' ";
            SqlConnection con = new SqlConnection(Helper.ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query,con);
           SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_name.Text = dr["Name"].ToString();
                txt_fname.Text = dr["FatherName"].ToString();
                txt_mobile.Text = dr["Mobile"].ToString();
                txt_Rno.Text = dr["RNo"].ToString();
                txt_address.Text = dr["Address"].ToString();
                txt_email.Text = dr["Email"].ToString();
               
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string Query = " DELETE FROM tbl_student WHERE [Registration ID]= '"+cmb_regID.Text+"' ";
            SqlConnection con = new SqlConnection(Helper.ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query,con);
            cmd.ExecuteNonQuery();
            Helper.Clear(this);
            MessageBox.Show("Data Deleted Successfully!");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string SqlQuery = "UPDATE tbl_student SET Name='"+txt_name.Text+"', FatherName='"+txt_fname.Text+"', Mobile='"+txt_mobile.Text+"',RNo='"+txt_Rno.Text+"',Address='"+txt_address.Text+"', Email='"+txt_email.Text+"' WHERE [Registration ID]= '"+cmb_regID.Text+"'";
            SqlConnection con = new SqlConnection(Helper.ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand(SqlQuery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully!");
        }
    }
}
