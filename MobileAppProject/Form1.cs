using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace MobileAppProject
{
    public partial class Form1 : Form
    {
        private static string[] firstField;
       // private static string secondField;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "look here";
            Console.WriteLine("!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(showInfo).Start();
        }
        void showInfo()
        {

            Action a = () => textBox1.Text =   Program.getDrId(); 
            BeginInvoke(a);
            jnjjjjjjjjjjjjjnj;
        }
         void addInfo()
        {
            Action a = () =>
            {
                firstField = new string[2];
                firstField[0] = txtFirstField.Text;
                firstField[1] = txtSecondField.Text;
            };
            BeginInvoke(a);
           // return firstField;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int id = 0;
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = @"Data Source=kraka.ucn.dk;Initial Catalog=dmai0914_2Sem_6;Persist Security Info=True;User ID=dmai0914_2Sem_6;Password=IsAllowed";

                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    string strSQL = "INSERT INTO [Table_1] VALUES ( @value)";


                    da.InsertCommand = new SqlCommand(strSQL, cn);
                  //  da.InsertCommand.Parameters.AddWithValue("@value1", txtFirstField.Text);
                    da.InsertCommand.Parameters.AddWithValue("@value", txtSecondField.Text);
                    cn.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    cn.Close();
                    Console.WriteLine("fuck ya");
                }
            }
            Console.WriteLine("fuck no");

                }
            
           
           
            // new Thread(addInfo).Start();
        
       public static string[] getFieldInfo()
        {
            return firstField;
        }

       private void button3_Click(object sender, EventArgs e)
       {
           int i = 0;
           string[] doctorIDs;
           int count = 0;
           using (SqlConnection cn = new SqlConnection())
           {
               cn.ConnectionString = @"Data Source=kraka.ucn.dk;Initial Catalog=dmai0914_2Sem_6;Persist Security Info=True;User ID=dmai0914_2Sem_6;Password=IsAllowed";
               cn.Open();
               string strSQL = "select count (*) from Table_1";
               using (SqlCommand cm = new SqlCommand(strSQL, cn))
               {
                   count = (int)cm.ExecuteScalar();

                   using (SqlDataReader dr = cm.ExecuteReader())
                   {

                       doctorIDs = new string[count];
                   }

               }
               strSQL = "Select * From Table_1";

               using (SqlCommand cm = new SqlCommand(strSQL, cn))
               {
                   using (SqlDataReader dr = cm.ExecuteReader())
                   {
                       //  Console.WriteLine(dr.VisibleFieldCount);
                       
                       while (dr.Read())
                       {
                           Console.WriteLine("{0} ", dr["value"].ToString());
                           doctorIDs[i++] = dr["value"].ToString();
                       }
                   }
               }
           }
           textBox1.Text = doctorIDs[i - 1];
       }
    }
}
