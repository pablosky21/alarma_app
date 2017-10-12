using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App_alarma_vecinal
{
	public class crearalarma : ContentPage
	{
		public crearalarma ()
		{

            Label crearalarma = new Label();
            crearalarma.Text = "CREAR ALARMA";

            Label nombre_alarma = new Label();
            nombre_alarma.Text = "NOMBRE DEL BARRIO";

            Entry ent_nombre_alarma = new Entry();
            ent_nombre_alarma.Placeholder = "NOMBRE DEL BARRIO";

            Label password_comunitario = new Label();
            password_comunitario.Text = "CONTRASEÑA_COMUNITARIA";

            Entry ent_password_comunitario = new Entry();
            ent_password_comunitario.Placeholder = "CONTRASEÑA COMUNITARIA";
            ent_password_comunitario.IsPassword = "true";

            Label contactos = new Label();
            contactos.Text = "CONTACTOS";

            Entry ent_agregar_personas = new Entry();
            ent_agregar_personas.Placeholder = "AGREGAR PERSONAS";

            Button btn_agregar_personas = new Button();
            btn_agregar_personas.Text = "AGREGAR PERSONA";

            Button btn_crear_comunidad = new Button();
            btn_crear_comunidad.Text = "CREAR COMUNIDAD";





            Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to Xamarin Forms!" }
				}
			};
		}
	}
}