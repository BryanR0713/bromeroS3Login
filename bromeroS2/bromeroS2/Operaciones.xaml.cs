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
    public partial class Operaciones : ContentPage
    {
        public Operaciones()
        {
            InitializeComponent();
        }
        private void btnSaludo_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNobre.Text;
            DisplayAlert("Mensaje de bienvenida", "Bienvenido a la Universidad UIsrael "  + nombre, "Cerrar");
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double datoUno = Convert.ToDouble(txtDatoUno.Text);
            double datosDos = Convert.ToDouble(txtDatosDos.Text);

            double suma = datoUno + datosDos;
            txtResultado.Text = suma.ToString();
            lblResultados.Text = suma.ToString();

        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            txtDatoUno.Text = "";
            txtDatosDos.Text = "";
            txtResultado.Text = "";
            lblResultados.Text = "";
        }
    }
}