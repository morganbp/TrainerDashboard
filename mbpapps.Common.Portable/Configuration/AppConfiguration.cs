using System;
using System.Collections.Generic;
using mbpapps.Common.Portable.Configuration;

namespace mbpapps.common.Portable.Configuration
{
	public static class AppConfiguration
	{
		private static Dictionary<string, string> _appConfig;
		static AppConfiguration()
		{
			var xmlFile = "AppConfig.xml";
			try{
				_appConfig = XmlUtils.LoadXml(xmlFile);
			}catch(Exception ex) {
				throw ex;
			}
		}

		public static T Get<T>(string key){
			try {
				var rtnValue = _appConfig[key];
				return (T)Convert.ChangeType(rtnValue, typeof(T));
			}catch(Exception ex){
				throw ex;
			}
		}
	}
}
