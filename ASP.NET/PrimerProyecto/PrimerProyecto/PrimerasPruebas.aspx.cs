using System;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace PrimerProyecto
{
	public partial class PrimerasPruebas : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnCalcular_Click(object sender, EventArgs e)
		{
			if(txtNumero1.Text == "" || txtNumero2.Text == "")
			{
				lblResultado.Text = "Por favor, ingrese los dos números";
				return;
			}


			if(txtNumero2.Text == "0")
			{
				lblResultado.Text = "El segundo número no puede ser cero";
				return;
			}

			//Validar que los datos sean números
			if(!int.TryParse(txtNumero1.Text, out int num1) || !int.TryParse(txtNumero2.Text, out int num2))
			{
				lblResultado.Text = "Por favor, ingrese números";
				return;
			}

			int suma = num1 + num2;
			int resta = num1 - num2;
			double multiplicacion = (Convert.ToDouble(num1) * Convert.ToDouble(num2));
			double division = Convert.ToDouble(num1) / Convert.ToDouble(num2);

			lblResultado.Text = 
				"<br/>Suma: " + suma + "<br/>" +
				"Resta es: " + resta + "<br/>" +
				"Mltiplicación: " + multiplicacion + "<br/>" +
				"División: " + division.ToString("N2");
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			String [,] frutas = new String[6,2];

			frutas[0,0]="Manzana";
			frutas[1,0]="Naranja";
			frutas[2,0]="Pera";
			frutas[3,0]="Melón";
			frutas[4,0] ="Sandía";
			frutas[5,0] ="Plátano";
			Random rnd = new Random();


			for (int i = 0; i < frutas.Length/2; i++)
			{
				double precio = rnd.Next(10);
				frutas[i,1] = precio.ToString("N2");
			}

			ControlCollection col = form1.Controls;
			Table tabla = col[14] as Table;
			//buscar una celda en la tabla
			//col.IndexOf
			//Encontrar una cela en la pagina web html
			TableCell cell = form1.FindControl("1") as TableCell;
			

			for (int i = 0; i < 1 ; i++)
			{
				String id= (i + 1).ToString();
				String idPrecio = (i+1) + "precio";


				

				foreach(Control c in col)
				{
					if(c is HtmlTableCell)
					{
						HtmlTableCell hgc = (HtmlTableCell)c;
						if(hgc.ID == id)
						{
							hgc.InnerHtml = frutas[i,0];
						}
						if(hgc.ID == idPrecio)
						{
							hgc.InnerHtml = frutas[i,1];
						}
					}
				}




			}

		}
	}
}