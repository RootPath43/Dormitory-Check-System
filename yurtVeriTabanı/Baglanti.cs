using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

//Data Source=LAPTOP-RRVHUN4A\SQLEXPRESS;Initial Catalog=yurtVeriTabanı;Integrated Security=True

namespace yurtVeriTabanı
{
    public class Baglanti
    {
       
        private SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-RRVHUN4A\SQLEXPRESS;Initial Catalog=yeniyurtvertiabani;Integrated Security=True");
        public SqlConnection Open()
        {
            con.Open();
            return con;
        }

        public SqlConnection Close()
        {
            con.Close();
            return con;
        }


    }
}
