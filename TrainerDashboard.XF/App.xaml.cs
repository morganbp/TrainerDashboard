using System;
using System.Collections.Generic;
using mbpapps.common.Portable.Configuration;
using Xamarin.Forms;

namespace TrainerDashboard.XF
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			MainPage = new NavigationPage(new LoginPage());
		}
	}
}
