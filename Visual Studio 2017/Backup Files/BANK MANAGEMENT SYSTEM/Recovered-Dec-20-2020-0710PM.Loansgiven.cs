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
    public partial class Loansgiven : UserControl
    {
        private static Loansgiven _instance;

        public static Loansgiven Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Loansgiven();
                }
                return _instance;
            }
        }
        public Loansgiven()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");

        private void Loansgiven_Load(object sender, EventArgs e)
        {
            refresh_DG3();
        }

        public void refresh_DG3()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("LoanDetails_SP", con);
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


                DG3.DataSource = DS.Tables[0];
                this.DG3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.DG3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.DG3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void AddText_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("LoanAcquired_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@LO_ID", idTextBox.Text);
            cmd.Parameters.AddWithValue("@LO_TYPE", LotypeTextBox.Text);
            cmd.Parameters.AddWithValue("@AMOUNT", AmountTextBox.Text);

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
            refresh_DG3();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteLoan_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@LO_ID", idTextBox.Text);
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
                refresh_DG3();
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
                SqlCommand cmd = new SqlCommand("SearchLO_ID_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LO_ID", LATextBox.Text);

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


                DG3.DataSource = DS.Tables[0];
                this.DG3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.DG3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.DG3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            LotypeTextBox.Text = "";
            AmountTextBox.Text = "";

        }
    }
}
