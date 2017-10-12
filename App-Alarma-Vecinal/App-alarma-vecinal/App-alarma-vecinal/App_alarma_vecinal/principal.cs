using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App_alarma_vecinal
{
	public class principal : ContentPage
	{
		public principal ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "VENTANA DE AYUDA" }
				}
			};
		}
	}
}