using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Progenereal
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            
                InitializeComponent();

                //Definimos nuestra pantalla Master
                Master = new Menu();

                //Definimos nuestra pantalla Detail
                Detail = new NavigationPage(new Inicio());

                App.Modificador = this;
            

        }

       
    }
}
