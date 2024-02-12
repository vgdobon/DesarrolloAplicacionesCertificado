using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerProyecto
{
	public partial class Fechas : System.Web.UI.Page
	{
		public static DateTime Dt { get; set;}
		public static int DiasAdd { get; set; }

		public Fechas() {
			Dt = DateTime.Now;
		}
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

        protected void Button1_Click(object sender, EventArgs e)
        {
			Fechas.DiasAdd++;
			lblSalida.Text = Fechas.Dt.AddDays(DiasAdd).ToString();
        }
    }
}