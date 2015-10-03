using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
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
            doctorIDs = new string[100];
           // public static string[] DoctorIDs{set; get;}
            using (SqlConnection cn = new SqlConnection())
            {
            cn.ConnectionString = @"Data Source=kraka.ucn.dk;Initial Catalog=dmai0914_2Sem_6;Persist Security Info=True;User ID=dmai0914_2Sem_6;Password=IsAllowed";
            cn.Open();
            string strSQL = "Select * From Doctor";
            using (SqlCommand cm = new SqlCommand(strSQL, cn))
            {
                using(SqlDataReader dr = cm.ExecuteReader())
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        Console.WriteLine("{0} is nr {1}", dr["doctorNo"].ToString(), dr["personId"].ToString());
                        doctorIDs[i++] = dr["personId"].ToString();
                    }
                }
            }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        
        }
        public static string getDrId()
        {
            return doctorIDs[2];
        }
        public void nothing()
        {

        }
    }
}
