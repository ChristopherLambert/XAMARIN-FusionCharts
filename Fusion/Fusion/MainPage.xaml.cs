using Fusion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Fusion
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            var config = DependencyService.Get<IConfig>();
            webViewHtml.Source = config.Diretorio + "Home.html";

        }
	}
}
