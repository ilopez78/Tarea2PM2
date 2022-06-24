using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea2PM2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Clicked(object sender, EventArgs e)
        {


            var datos = new Datos
            { Nombres = nom.Text, Apellidos = ape.Text, Edad = edad.Text, Email = mail.Text };

            await Navigation.PushAsync(new Page2(datos));
        }
    }
}
