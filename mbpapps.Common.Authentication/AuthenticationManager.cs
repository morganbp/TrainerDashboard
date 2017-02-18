using System;
using Microsoft.Identity.Client;
using Splat;

namespace mbpapps.Common.Authentication
{
	public class AuthenticationManager
	{
		static Lazy<AuthenticationSession> Implementation = new Lazy<AuthenticationSession>(() => InitializeSession(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

		public static AuthenticationSession Session {
			get{
				var ret = Implementation.Value;
				if(ret == null){
					throw NotImplementedInReferenceAssembly();
				}
				return ret;
			}
		}

		internal static Exception NotImplementedInReferenceAssembly () 
		{
			return new NotImplementedException("This functionality is not implemented in native assemblies. Call AuthenticationSetup.Init() to initialize Platform Parameters");
		}

		static AuthenticationSession InitializeSession()
		{
			try{
				return new AuthenticationSession();
			}catch(Exception){
				return null;
			}
		}
	}
}
