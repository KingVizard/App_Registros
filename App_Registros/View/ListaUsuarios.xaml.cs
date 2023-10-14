using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_Registros.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Registros
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaUsuarios : ContentPage
	{
		public ListaUsuarios()
		{
			InitializeComponent();
            mostrar();
		}

        public async void mostrar()
        {
            var EmpleadosList = await App.SQLiteDb.GetEmpleadosAsync();
            if (EmpleadosList != null)
            {
                lsEmpleados.ItemsSource = EmpleadosList;
            }
        }

        private async void btnVolver_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}