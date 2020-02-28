using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BooksListTutorial.ViewModels;
using Xamarin.Essentials;

namespace BooksListTutorial
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class Microsoft : ContentPage
  {
    public ObservableCollection<string> Items { get; set; }

    public Microsoft() {
      InitializeComponent();

      // MVVM binding
      BindingContext = new MicrosoftBooksViewModel(); 

    }

    async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e) {
      if (e.SelectedItem == null)
        return;

      // deprecated Device.OpenUri(new Uri(e.SelectedItem.ToString()));
      await Launcher.OpenAsync(new Uri(e.SelectedItem.ToString()));

      //Deselect Item
      ((ListView)sender).SelectedItem = null;
    }
  }
}
