using System;
using mbpapps.Common.Authentication;
using Microsoft.Identity.Client;
using TrainerDashboard.XF;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(LoginPage), typeof(TrainerDashboard.XF.iOS.Renderers.LoginPageRenderer))]
namespace TrainerDashboard.XF.iOS.Renderers
{
	public class LoginPageRenderer : PageRenderer
	{
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			AuthenticationManager.Session.PlatformParameters = new PlatformParameters(ViewController);
		}
	}
}
