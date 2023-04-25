using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bromeroS2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string contrasena = txtContrasena.Text;
            string usuario=txtUsuario.Text;
            if (usuario == "estudiante2023" && contrasena == "uisrael2023")
            {
                Navigation.PushAsync(new Operaciones());

            }
            else {
                DisplayAlert("Alerta","Usuario/Contrasena incorrectas","Cerrar");
                txtUsuario.Text = "";
                txtContrasena.Text = "";

            }
        }

        private void btnRegistro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro()); 
        }
    }
}