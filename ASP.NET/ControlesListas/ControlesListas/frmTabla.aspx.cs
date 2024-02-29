using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlesListas
{
	public partial class frmTabla : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void cblFontStyle_Init(object sender, EventArgs e)
		{
			//Crear matriz de elementos para añadirla

			string[] estilos = { "Subrayado" , "Sobrerayado", "Tachado" };
			string[] code = {"u", "o","s"};

			//Añadir elementos a la lista
			for(int i = 0; i < estilos.GetLength(0); i++)
			{
				this.cblFontStyle.Items.Add(new ListItem(estilos[i], code[i]));
			}
		}
	}
}