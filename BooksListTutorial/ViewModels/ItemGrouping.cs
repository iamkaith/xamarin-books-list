using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BooksListTutorial.ViewModels
{
  public class ItemGrouping<K, T>: ObservableCollection<T>
  {
    public K Key { get; private set; }

    public ItemGrouping(K key, IEnumerable<T> items) {
      Key = key;
      foreach(var item in items) {
        this.Items.Add(item);
      }
    }
  }
}
