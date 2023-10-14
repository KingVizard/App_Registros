using App_Registros.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Registros
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            //mostrar();
        }

        private async void btn_Guardar_Clicked(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                Empleados emple = new Empleados
                {
                    Nombre = txtNombre.Text.Trim(),
                    ApellidoPaterno = txtApellidoP.Text.Trim(),
                    ApellidoMaterno = txtApellidoM.Text.Trim(),
                    Edad = int.Parse(txtEdad.Text),
                    Telefono = txtTelefono.Text.Trim(),
                };

                await App.SQLiteDb.SaveEmpleadoAsync(emple);
                //await App.SQLiteDB.SaveEmpleadoAsync(emple);
                
                txtNombre.Text = "";
                txtApellidoP.Text = "";
                txtApellidoM.Text = "";
                txtEdad.Text = "";
                txtTelefono.Text = "";
                await DisplayAlert("Aviso", "Se guardo de manera exitosa", "Ok");
                /*
                var EmpleadosList = await App.SQLiteDb.GetEmpleadosAsync();
                if (EmpleadosList != null)
                {
                    lsEmpleados.ItemsSource = EmpleadosList;
                }
                */
                //mostrar();
            }
            else
            {
                await DisplayAlert("Aviso", "Ingresar los datos", "Ok");
            }
        }

        public bool validarDatos()
        {
            bool respuesta;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                respuesta = false;
            } 
            else if (string.IsNullOrEmpty(txtApellidoP.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtApellidoM.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtEdad.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;
            }
            return respuesta;
        }

       //public async void mostrar()
       // {
       //     var EmpleadosList = await App.SQLiteDb.GetEmpleadosAsync();
       //     if (EmpleadosList != null)
       //     {
       //         lsEmpleados.ItemsSource = EmpleadosList;
       //     }
       // }
      
        private async void btnMostrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ListaUsuarios());
        }
    }
}
