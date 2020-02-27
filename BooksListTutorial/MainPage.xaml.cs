using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BooksListTutorial.ViewModels;

namespace BooksListTutorial
{
  // Learn more about making custom code visible in the Xamarin.Forms previewer
  // by visiting https://aka.ms/xamarinforms-previewer
  [DesignTimeVisible(false)]
  public partial class MainPage : ContentPage
  {
    public MainPage() {
      InitializeComponent();

      BindingContext = new MicrosoftBooksViewModel();

      if(Device.Idiom == TargetIdiom.Phone) {
        TabletView.IsVisible = false;
        PhoneView.IsVisible = true;
      } else {
        TabletView.IsVisible = true;
        PhoneView.IsVisible = false;
      }
    }

    private void MicrosoftBooks_Clicked(object sender, EventArgs e) {
      Navigation.PushAsync(new Microsoft());
    }
    private void Programming_Clicked(object sender, EventArgs e) {

    }
    private void Mobile_Clicked(object sender, EventArgs e) {

    }
    private void MachineLearning_Clicked(object sender, EventArgs e) {

    }

  }
}
