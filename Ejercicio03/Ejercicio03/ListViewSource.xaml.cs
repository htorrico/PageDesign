using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio03
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewSource : ContentPage
    {
		public ListViewSource ()
		{
			InitializeComponent ();
            listView.ItemTemplate = new DataTemplate(typeof(CustomCell));
            var items = new ObservableCollection<CustomCell>();
            items.Add(new CustomCell { title = "uno",subtitle="sub uno" });
            items.Add(new CustomCell { title = "dos",subtitle="sub dos" });
            items.Add(new CustomCell { title = "tres",subtitle="subs tres" });

            listView.ItemsSource = items;

        }
	}
}