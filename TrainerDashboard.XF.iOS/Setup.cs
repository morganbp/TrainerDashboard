using System;
using mbpapps.common.Portable.Abstractions;
using Splat;
using TrainerDashboard.XF.iOS.Plugins;

namespace TrainerDashboard.XF.iOS
{
	public  class Setup
	{
		private static Setup _instance;
		public static Setup Current{
			get {
				if(_instance == null){
					_instance = new Setup();
				}
				return _instance;
			}
		}

		public void Initialize()
		{
			Locator.CurrentMutable.RegisterLazySingleton(() => new StreamResolver(), typeof(IStreamResolver));
		}

}
}
