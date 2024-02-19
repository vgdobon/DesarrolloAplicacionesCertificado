using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerosControles
{
	public partial class Camping : System.Web.UI.Page
	{
		Dictionary<string, double> diccionarioCosteAlojamiento;
		Dictionary<string, double> diccionarioCosteExtra;


		protected void Page_Load(object sender, EventArgs e)
		{
			diccionarioCosteAlojamiento = new Dictionary<string, double>
			{
				{ "Tienda Iglu", 6 },
				{ "Tienda Familiar", 10 },
				{ "Bungalow", 45 }
			};

			diccionarioCosteAlojamiento = new Dictionary<string, double>
			{
				{ "Toma de Luz", 2 },
				{ "Agua caliente", 3 },
				{ "Aparcamiento", 5 }
			};
		}

		protected int CalcularDias(DateTime fechaInicio, DateTime fechaFin)
		{
			TimeSpan diferencia = fechaFin - fechaInicio;
			return diferencia.Days;
		}

		protected void Calcular_TextChanged(object sender, EventArgs e)
		{

			int dias = 0;

			if (CalendarEntrada.Text != "" && CalendarSalida.Text != "")
			{
				dias = CalcularDias(Convert.ToDateTime(CalendarEntrada.Text), Convert.ToDateTime(CalendarSalida.Text));
				tdDias.InnerText = dias.ToString();
			}

			if (dias != 0)
			{

				List<RadioButton> radioButtons = mytable.Controls.OfType<RadioButton>().ToList();
				RadioButton rbTarget = radioButtons
					.Where(r => r.GroupName == "GroupName" && r.Checked)
						.Single();
				RadioButton radioButtonChecked = form1.Controls.OfType<RadioButton>()
									  .FirstOrDefault(r => r.Checked);
				double costeAlojamiento = 0;

				if ( radioButtonChecked != null)
				{
					costeAlojamiento = diccionarioCosteAlojamiento[radioButtonChecked.Text] * dias;
					tdCostoAlojamiento.InnerText = costeAlojamiento.ToString();
					tdTipoAlojamiento.InnerText = radioButtonChecked.Text;
					tdCosteAlojamientoTotal.InnerText = costeAlojamiento.ToString();
				}




				HashSet<string>  checkedButtons = new HashSet<string>();
				//checkedButtons.

				foreach (System.Web.UI.WebControls.CheckBox c in form1.Controls.OfType<System.Web.UI.WebControls.CheckBox>())
				{
					if (c.Checked)
					{
						checkedButtons.Add(c.Text);
					}
				}

				double costeExtra = 0;

				foreach (var item in checkedButtons)
				{
					double coste = diccionarioCosteExtra[item];
					costeExtra += coste;

					if(item == "Aparcamiento")
					{
						tdAparcamiento.InnerText = Convert.ToString( coste * dias);
					}
					if (item == "Agua caliente")
					{
						tdAguaCaliente.InnerText = Convert.ToString(coste * dias);
					
					}

					if (item == "Toma de Luz caliente")
					{
						tdTomaLuz.InnerText = Convert.ToString(coste * dias);

					}
				}

				tdCosteExtras.InnerText = costeExtra.ToString();
				tdCosteExtasTotal.InnerText = costeExtra.ToString();

				tdCosteTotal.InnerText = (costeAlojamiento + costeExtra).ToString();
			}
			

			





		}
	}
}