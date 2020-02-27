using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using System.Reflection;

namespace BooksListTutorial
{
  [Preserve(AllMembers = true)]
  [ContentProperty("Source")]
  public class ImageResourceExtension : IMarkupExtension
  {
    public string Source { get; set; }
    public object ProvideValue(IServiceProvider serviceProvider) {
      if(Source == null) {
        return null;
      }

      var imageSource = ImageSource.FromResource(Source, Assembly.GetExecutingAssembly());
      return imageSource;
    }
  }
}
