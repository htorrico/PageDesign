using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio03
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageDemo : ContentPage
	{
		public ImageDemo ()
		{
			InitializeComponent ();
            //var image = new Image { Source = "logotest.jpg" };
            //StackLayout stack = new StackLayout();
            //stack.Children.Add(image);
            //Content = stack;

        }
	}
}