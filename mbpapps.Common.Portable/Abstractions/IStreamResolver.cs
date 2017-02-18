using System;
using System.IO;

namespace mbpapps.common.Portable.Abstractions
{
	public interface IStreamResolver
	{
		Stream LoadStream(string filePath);
	}
}
