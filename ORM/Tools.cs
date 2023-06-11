using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ORM
{
    public class Tools
    {   //Singleton Pattern. ADON.NET ile proje geliştirildi.
		private SqlConnection baglanti;

		public SqlConnection Baglanti
		{
			get {

				if (baglanti == null)
					baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
				return baglanti; }
		}

		public static DataTable Select(string procName, SqlConnection baglanti)
		{
            SqlDataAdapter adapter = new SqlDataAdapter(string.Format("prc_{0}_Select", procName), baglanti);
			adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			DataTable dt = new DataTable();
			adapter.Fill(dt);

			return dt;
		}
	}
}
