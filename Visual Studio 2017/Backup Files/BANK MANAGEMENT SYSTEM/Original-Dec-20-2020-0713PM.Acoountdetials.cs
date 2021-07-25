using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BANK_MANAGEMENT_SYSTEM
{
    public partial class Acoountdetials : UserControl
    {
        private static Acoountdetials _instance;

        public static Acoountdetials Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Acoountdetials();
                }
                return _instance;
            }
        }
        public Acoountdetials()
        {
            InitializeComponent();
        }



        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");


          private void Acoountdetials_Load(object sender, EventArgs e)
          { 
            refresh_DG2();
          }
        
          public void refresh_DG2()
          {
            try
            {  
                SqlCommand cmd = new SqlCommand("Account_Details_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("----------INVALID OPERATION--------\n" + ex);
                }
                con.Close();


                DG2.DataSource = DS.Tables[0]; 
                this.DG2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.DG2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.DG2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void AddingItem_Click(object sender, EventArgs e)
        {


            SqlCommand cmd = new SqlCommand("AddAccount_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ACC_ID", Acc_IdTextBox.Text);
                cmd.Parameters.AddWithValue("@ACC_TYPE", Acc_TypeTextBox.Text);
                cmd.Parameters.AddWithValue("@BALANCE", BalanceTextBox.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("-----INVALID OPERATION-------\n" + ex);
                }
                con.Close();
                refresh_DG2();
            }
        

      
        private void DeleteTab_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteAC_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ACC_ID", Acc_IdTextBox.Text);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("-------INVALID OPERATION--------" + ex);
                }
                con.Close();
                refresh_DG2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void SearchTab_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchCUS_ID_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ACC_ID",Cus_IdTextBox.Text); 
                    
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("----------INVALID OPERATION--------\n" + ex);
                }
                con.Close();


                DG2.DataSource = DS.Tables[0];
                this.DG2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.DG2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.DG2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void ClearTab_Click(object sender, EventArgs e)
        {
            Acc_IdTextBox.Text = "";
            Acc_TypeTextBox.Text = "";
            BalanceTextBox.Text = "";
        }
    }
}
