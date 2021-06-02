using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BLE_Control
{
    class connect
    {
        public static SqlConnection connects = new SqlConnection(@"Data Source=DESKTOP-3KIRA0J;Initial Catalog=doan-3;Integrated Security=True");
    }
}
