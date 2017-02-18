using System;
using System.IO;
using mbpapps.common.Portable.Abstractions;

namespace TrainerDashboard.XF.iOS.Plugins
{
	public class StreamResolver : IStreamResolver
	{

		public Stream LoadStream(string filePath)
		{
			try
			{
				return new FileStream("AppConfig.xml", FileMode.Open, FileAccess.Read);
			}catch(Exception ex){
				throw ex;
			}
		}
	}
}
