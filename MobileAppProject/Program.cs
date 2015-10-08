using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace MobileAppProject
{
    static class Program
    {
        private static string[] doctorIDs;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int count = 0;
           // public static string[] DoctorIDs{set; get;}
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
                    int i = 0;
                    while (dr.Read())
                    {
                        Console.WriteLine("{0} ", dr["value"].ToString());
                        doctorIDs[i++] = dr["value"].ToString();
                    }
                }
                //using (SqlDataAdapter da = new SqlDataAdapter())
                //{
                //    string[] first =  Form1.getFieldInfo();
                //  //  string second = Form1.getFieldInfo()[1];
                //    if (first != null )
                //    {
                //        da.InsertCommand = new SqlCommand("insert into Doctor values(@doctorNo @personId)", cn);
                //        da.InsertCommand.Parameters.Add("@doctorNo", SqlDbType.VarChar).Value = first[0];
                //        da.InsertCommand.Parameters.Add("personId", SqlDbType.VarChar).Value = first[1];
                //        da.InsertCommand.ExecuteNonQuery();
                //        cn.Close();
                //        Console.WriteLine("fuck ya");
                //    }
                //    Console.WriteLine("fuck no");

                //    }
            }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        
        }
        public static string getDrId()
        {
            return doctorIDs[doctorIDs.Length-1];
        }
  
    }
}