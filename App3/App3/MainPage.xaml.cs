using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        //Variables
       
        public MainPage()
        {
            InitializeComponent();
            
        }


        // Pecho Triceps
        async void Buttonclickedpecho (object sender, EventArgs e)
        {
            Button button = sender as Button;

            await DisplayAlert("RUTINA PARA PECHO", "PECHO PLANO", "SIGUIENTE");
            await DisplayAlert("RUTINA PARA PECHO", "APERTURAS", "SIGUIENTE");
            await DisplayAlert("RUTINA PARA PECHO", "PULL OVER", "SIGUIENTE");

        }
        // espalda biceps
        async void Buttonclickedespalda (object sender, EventArgs e)
            {
                Button button2 = sender as Button;

            await DisplayAlert("RUTINA PARA ESPALDA", "HALON CON BARRA", "SIGUIENTE");
            await DisplayAlert("RUTINA PARA ESPALDA", "SERRUCHO", "SIGUIENTE");
            await DisplayAlert("RUTINA PARA ESPALDA", "PREDICADOR", "SIGUIENTE");




        }

        // PIERNAS 
        async void ButtonclickedPierna(object sender, EventArgs e)
        {
            Button button3 = sender as Button;

            await DisplayAlert("RUTINA PARA PIERNA", "SENTADILLAS", "SIGUIENTE");
            await DisplayAlert("RUTINA PARA PIERNA", "HACK UP", "SIGUIENTE");
            await DisplayAlert("RUTINA PARA PIERNA", "TIJERA", "SIGUIENTE");

        }
      



    }
 }