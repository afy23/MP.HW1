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
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
            var list = new List<model.room>
            {
                new model.room{name="Derslik-B1", Image="http://ceng.eskisehir.edu.tr/Documents/Class_B1.jpg"},
            };
              {
                new model.room { name = "Derslik-B2", Image= "http://ceng.eskisehir.edu.tr/Documents/Class_B2.jpg" };
            };
            lstview.ItemsSource = list;
        }
	}
}