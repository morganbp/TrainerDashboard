using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace mbpapps.Common.Authentication
{
	public class AuthenticationSession
	{

		private IPlatformParameters _platformParameters;
		public IPlatformParameters PlatformParameters
		{
			get {
				return _platformParameters;
			}
			set{
				_platformParameters = value;
				_authenticationClient.PlatformParameters = _platformParameters;
			}
		}
		private PublicClientApplication _authenticationClient; 

		public AuthenticationSession()
		{
			_authenticationClient = new PublicClientApplication("https://login.microsoftonline.com/trainerdashboard.onmicrosoft.com/","fca7d066-9768-4a0a-8330-09392d3122dc");

		}

		public async Task<bool> SignInSilent(){
			bool result = false;
			result = await SignInUI();
			return result;
		}

		private async Task<bool> SignInUI(){
			try {
				var result = await _authenticationClient.AcquireTokenAsync(
					new string[] {"fca7d066-9768-4a0a-8330-09392d3122dc"},
					string.Empty,
					UiOptions.ForceLogin,
					string.Empty,
					null,
					"https://login.microsoftonline.com/trainerdashboard.onmicrosoft.com/",
					"B2C_1_TrainerDashboard_SignInSignUp"
				);
				return result != null;
			}catch (MsalException ex)
			{
				return false;
			}
		}
	}
}
