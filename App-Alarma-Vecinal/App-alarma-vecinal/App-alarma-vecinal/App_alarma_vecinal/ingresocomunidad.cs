using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App_alarma_vecinal
{
	public class ingresocomunidad : ContentPage
	{
		public ingresocomunidad ()
		{
            Label ingresocomunidad = new Label();
            ingresocomunidad.Text = "INGRESO COMUNIDAD";

            Label buscar_barrio = new Label();
            buscar_barrio.Text = "BUSCAR BARRIO";

            Entry ent_buscar_barrio = new Entry();
            ent_buscar_barrio.Placeholder = "BUSCAR COMUNIDAD";

            Label password_barrio = new Label();
            password_barrio.Text = "CONTRASEÑA DE COMUNIDAD";

            Entry ent_password_barrio = new entry();
            ent_password_barrio.Placeholder = "CONTRASEÑA BARRIO";
            ent_password_barrio.IsPassword = "true";

            Button btn_entrar = new Button();
            btn_entrar.Text = "ENTRAR";

            //FALTA ENLAZAR ESTO A DONDE VA (HOME)?


            Content = new StackLayout {
				Children = {
                    ingresocomunidad,
                    buscar_barrio,
                    ent_buscar_barrio,
                    password_barrio,
                    ent_password_barrio,
                    btn_entrar

        }
			};
		}
	}
}