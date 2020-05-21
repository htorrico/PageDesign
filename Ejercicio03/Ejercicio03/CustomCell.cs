using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Ejercicio03
{
    public class CustomCell : ViewCell
    {
        public string title { get; set; }
        public string subtitle { get; set; }

        public CustomCell()
        {
            //instantiate each of our views
            //var image = new Image();
            StackLayout cellWrapper = new StackLayout();
            StackLayout horizontalLayout = new StackLayout();
            Label left = new Label();
            Label right = new Label();
            left.Text = title;
            right.Text = subtitle;
            //set bindings
            left.SetBinding(Label.TextProperty, "title");
            right.SetBinding(Label.TextProperty, "subtitle");
            //image.SetBinding(Image.SourceProperty, "image");

            //Set properties for desired design
            cellWrapper.BackgroundColor = Color.FromHex("#eee");
            horizontalLayout.Orientation = StackOrientation.Horizontal;
            right.HorizontalOptions = LayoutOptions.EndAndExpand;
            left.TextColor = Color.FromHex("#f35e20");
            right.TextColor = Color.FromHex("503026");

            //add views to the view hierarchy
            //horizontalLayout.Children.Add(image);
            horizontalLayout.Children.Add(left);
            horizontalLayout.Children.Add(right);
            cellWrapper.Children.Add(horizontalLayout);
            View = cellWrapper;
        }
    }
}
