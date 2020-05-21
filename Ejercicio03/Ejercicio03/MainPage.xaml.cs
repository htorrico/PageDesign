using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio03
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ButtonDemo());

            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ButtonCode());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DatepickerDemo());

            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EditorDemo());

            };
            Item5.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EditorCode());

            };
            Item6.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EntryDemo());

            };
            Item7.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EntryCode());

            };
            Item8.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new LabelDemo());

            };
            Item9.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new LabelCode());

            };
            Item10.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new LocalImage());

            };
            Item11.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EmbeddedImage());

            };
            Item12.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewDemo());

            };
            Item13.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewCode());

            };
            Item14.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewSource());

            };
        }
    }
}
