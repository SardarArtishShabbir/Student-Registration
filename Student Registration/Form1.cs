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
using HelperSpace;
namespace Student_Registration
{
    public partial class Form1 : Form
    {
        //string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["myConString"].ToString();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registerStudentDataSet.tbl_student' table. You can move, or remove it, as needed.
            this.tbl_studentTableAdapter.Fill(this.registerStudentDataSet.tbl_student);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sqlQuery = "INSERT INTO tbl_student VALUES('"+txt_reg.Text+"','"+txt_name.Text+"','"+txt_fname.Text+"','"+txt_mobile.Text+"','"+txt_Rno.Text+"','"+txt_address.Text+"','"+txt_email.Text+"')";
            SqlConnection con = new SqlConnection(Helper.ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record saved Sucessfull!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Helper.Clear(this);
            this.tbl_studentTableAdapter.Fill(this.registerStudentDataSet.tbl_student);
        }

        private void dgv_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
