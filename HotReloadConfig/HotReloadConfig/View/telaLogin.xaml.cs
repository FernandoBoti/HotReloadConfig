using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HotReloadConfig.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class telaLogin : ContentPage
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {


            //Navigation.PushAsync(new Home());

            //PushModalAsync => Torna página que está sendo aberta a principal.
            //para entender melhor ler o documento: https://docs.microsoft.com/pt-br/xamarin/xamarin-forms/app-fundamentals/navigation/modal


            //new NavigationPage(new Home()) => define que a pagina que está sendo aberta é uma NavigationPage
            Navigation.PushModalAsync(new NavigationPage(new Home()));

            //Navigation.PushAsync(new NavigationPage(new Home()));
        }
    }
}