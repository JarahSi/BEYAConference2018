using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BEYAConference
{
	public partial class MainPage : ContentPage
	{
        int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

        public void OnButtonClicked(object sender, EventArgs args)
        {
            count++;

            ((Button)sender).Text =
                String.Format("{0} click{1}!", count, count == 1 ? "" : "s");
        }
    }
}
