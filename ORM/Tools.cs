using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ORM
{
    public class Tools
    {   //Singleton Pattern. ADON.NET ile proje geliştirildi.
		private SqlConnection baglanti;

		public SqlConnection Baglanti
		{
			get {

				if (baglanti == null)
					baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
				return baglanti; }
		}
	}
}
