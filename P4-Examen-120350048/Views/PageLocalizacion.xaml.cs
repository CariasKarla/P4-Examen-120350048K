using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;


namespace P4_Examen_120350048.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLocalizacion : ContentPage
    {
        public PageLocalizacion()
        {
            InitializeComponent();
        }

        private async void btnguardar_Clicked(object sender, EventArgs e)
        {
            Location location = null;
            try
            {
                 location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null &&
                    !String.IsNullOrEmpty(descripcion_corta.Text)&&
                    !String.IsNullOrEmpty(descripcion_larga.Text))
                {
                    latitud.Text = Convert.ToString(location.Latitude);
                    longitud.Text = Convert.ToString(location.Longitude);

                }
                else
                { 
                    if(location != null)
                    {
                        await DisplayAlert("Error", "Error no esta activo el gps", "OK");
                    }
                    else if(String.IsNullOrEmpty(descripcion_corta.Text))
                    {
                        await DisplayAlert("Error", "Error sin descripcion corta", "OK");
                    }
                    else if(String.IsNullOrEmpty(descripcion_larga.Text))
                    {
                        await DisplayAlert("Error", "Error sin descripcion larga", "OK");
                    }
                }
            }
            catch (Exception ex)

            {
                await DisplayAlert("Error", "Error no esta activo el gps", "OK");

            }

        }

        private void btnver_Clicked(object sender, EventArgs e)
        {

        }
     }
}

