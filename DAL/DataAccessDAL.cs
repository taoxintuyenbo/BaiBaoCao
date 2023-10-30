using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class DataAccessDAL
    {
        public SqlConnection connect = null;
        string strconnec = @"Data Source=LAPTOP-5Q8BC9UT\SQLEXPRESS;Initial Catalog=Baibaocao;Integrated Security=True";
        public void Moketnoi()
        {
            if (connect == null)
            {
                connect = new SqlConnection(strconnec);
            }
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }
        public void Dongketnoi()
        {
            if(connect!=null && connect.State==ConnectionState.Open)
            {
                connect.Close();
            }
        }
    }
}
