using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public class KetNoiCSDl
    {
        static string ChuoiKetNoi = System.Configuration.ConfigurationManager.ConnectionStrings["CSDL"].ConnectionString.ToString();
        SqlConnection KetNoi = new SqlConnection(ChuoiKetNoi);

        public string GetSetChuoiKetNoi
        {
            get { return ChuoiKetNoi; }
            set { ChuoiKetNoi = value; }
        }

        public SqlConnection LayKetNoi
        {
            get { return KetNoi; }
            set { KetNoi = value; }
        }

        public void MoKetNoi()
        {
            if (KetNoi.State == ConnectionState.Closed)
            {
                KetNoi.Open();
            }
        }

        public void DongKetNoi()
        {
            if (KetNoi.State == ConnectionState.Open)
            {
                KetNoi.Close();
            }
        }

    }
}