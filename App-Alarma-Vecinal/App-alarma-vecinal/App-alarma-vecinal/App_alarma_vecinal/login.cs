using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App_alarma_vecinal
{
	public class login : ContentPage
	{
		public login ()
		{
            Label lbl_ingreso_alarma = new Label();
            lbl_ingreso_alarma.Text = "INGRESO DE ALARMA";

            Label lbl_usuario = new Label();
            lbl_usuario.Text = "USAURIO";

            Entry ent_usuario = new Entry();
            ent_usuario.Placeholder = "USUARIO";

            Label lbl_password = new Label();
            lbl_password.Text = "CONTRASEÑA";
                        
            Entry ent_password = new Entry();
            ent_password.Placeholder = "INGRESE PASSWORD";
            ent_password.IsPassword = true;

            Button btn_entrar = new Button();
            btn_entrar.Text = "ENTRAR";
            btn_entrar.Clicked += async (sender, e) =>
                {
                    String email = ent_usuario.Text;
                    String password = ent_password.Text;
                    await Navigation.PushModalAsync(new principal());
                };


            Content = new StackLayout {
                Children = {

                    lbl_ingreso_alarma,
                    lbl_usuario,
                    ent_usuario,
                    lbl_password,
                    ent_password,
                    btn_entrar
				}
			};
		}
	}
}