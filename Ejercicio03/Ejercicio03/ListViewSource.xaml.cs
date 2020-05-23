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
            //listView.ItemTemplate = new DataTemplate(typeof(CustomCell));
            
            var items = new ObservableCollection<CustomCell>();
            items.Add(new CustomCell { title = "titulo 1",subtitle="sub titulo1" });
            items.Add(new CustomCell { title = "dos",subtitle="sub dos" });
            items.Add(new CustomCell { title = "tres",subtitle="subs tres" });

			//Esto es bastante común
            //listView.ItemSelected += OnSelection;
            //listView.ItemTapped += OnTap;

            listView.ItemsSource = items;

        }

		//Eventos que se van agregar en tiempo de ejecución
		void OnTap(object sender, ItemTappedEventArgs e)
		{
			DisplayAlert("Item Tapped", e.Item.ToString(), "Ok");
		}

		void OnSelection(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
			{
				return;
			}
			DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");
		}


		//Eventos generados por Visual Studio
		private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{

			DisplayAlert("Item Selected",((CustomCell)e.SelectedItem).title, "Ok");
		}

		private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			DisplayAlert("Item Selected", ((CustomCell)e.Item).title, "Ok");
		}
	}
}