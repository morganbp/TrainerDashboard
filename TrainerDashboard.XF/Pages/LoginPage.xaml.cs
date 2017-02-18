using System;
using System.Collections.Generic;
using mbpapps.Common.Authentication;
using Xamarin.Forms;

namespace TrainerDashboard.XF
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
			SignInButton.Clicked += Login;

		}

		async void Login(object sender, EventArgs e)
		{
			var result = await AuthenticationManager.Session.SignInSilent();
		}
	}
}
