using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HW1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
            var list = new List<model.room>
            {
                new model.room{name="", Image=""},
            };
            {
                new model.room { name = "", Image = "" };
            };
            lst.ItemsSource = list;
        }
	}
}