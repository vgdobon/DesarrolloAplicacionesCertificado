using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aplicacion
{
	public partial class ProbarValidacion : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnValidar_Click(object sender, EventArgs e)
        {
			//Cancela el evento si la página no es válida
			if (!Page.IsValid)
			{
				return;
			}

			lblResultado.Text = "Has hecho click en el botón del Enviar";
        }
    }
}