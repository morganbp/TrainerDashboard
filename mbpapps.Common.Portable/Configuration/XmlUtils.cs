using System;
using System.Collections.Generic;
using System.Xml.Linq;
using mbpapps.common.Portable.Abstractions;
using Splat;

namespace mbpapps.Common.Portable.Configuration
{
	public static class XmlUtils
	{
		public static Dictionary<string, string> LoadXml(string xmlFile)
		{
			try
			{
				var stream = Locator.Current.GetService<IStreamResolver>().LoadStream(xmlFile);

				var xml = XDocument.Load(stream);
				stream.Dispose();

				var dictionary = new Dictionary<string, string>();
				var elements = xml.Descendants("config").Descendants("item");
				foreach(var child in elements){
					var key = child.Attribute("key");
					var val = child.Attribute("value");
					if(!string.IsNullOrEmpty(key.Value) && val != null)
					{
						dictionary.Add(key.Value, val.Value);
					}
						
				}
			}catch(Exception ex){
				throw ex;
			}
			return null;
		}
	}
}
