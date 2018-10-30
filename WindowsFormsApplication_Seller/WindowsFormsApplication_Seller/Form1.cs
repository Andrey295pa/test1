using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication_Seller
{
    public partial class Form1 : Form
    {
        string tmp = null;
        string sqlCon = null;
        SqlConnection sqlConnection = null;
        SqlCommand sqlCommand = null;
        SqlDataReader sqlDataRead = null;
        

        public Form1()
        {
            InitializeComponent();
            comboBox_Meny.SelectedIndexChanged += comboBox_Meny_SelectedIndexChanged;
            sqlCon = @"Data Source=DESKTOP-33DE0F9;Initial Catalog=ByProdyc; Integrated Security=true ";
            sqlConnection = new SqlConnection(sqlCon);
        }

        void comboBox_Meny_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tmp = comboBox_Meny.Text;
            if(comboBox_Meny.Text=="Продавцы")
            {
                listBox_Table.Items.Clear();
                tmp="select *from Seller";
            }
            else if (comboBox_Meny.Text == "Покупатели ")
            {
                listBox_Table.Items.Clear();
                tmp = "select *from Buyer";
            }
            else if (comboBox_Meny.Text == "Продажи")
            {
                listBox_Table.Items.Clear();
                tmp = "select *from ForSale";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(tmp, sqlConnection);
                sqlDataRead = sqlCommand.ExecuteReader();

                while (sqlDataRead.Read())
                {
                   
                   // listBox1.Items.Add("id=" + sqlDataRead[0] + " FirstName- " + sqlDataRead[1] + " Lastname- " + sqlDataRead[2]);
                    if (comboBox_Meny.Text!="Продажи")
                    listBox_Table.Items.Add("id=" + sqlDataRead[0] + " FirstName- " + sqlDataRead[1] + " Lastname- " + sqlDataRead[2]);
                    else
                        listBox_Table.Items.Add("id=" + sqlDataRead[0] + " Id Seller- " + sqlDataRead[1] + " Id Buyer- " + sqlDataRead[2] + " Price- " + sqlDataRead[3] + " Date- " + sqlDataRead[3]);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlDataRead.Close();
                sqlConnection.Close();
            }
        }
        }
    }

