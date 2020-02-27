using System;
using System.Collections.Generic;
using System.Text;

namespace BooksListTutorial.ViewModels
{
  public class Item
  {
    public string Text { get; set; }
    public string Detail { get; set; }
    public string URL { get; set; }
    public override string ToString() => URL; 
  }
}
