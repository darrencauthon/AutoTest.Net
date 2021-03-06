using System;
using System.IO;
using AutoTest.Core.FileSystem;
using AutoTest.Core.DebugLog;
namespace AutoTest.Core.Configuration
{
	class DefaultConfigurationLocator : ILocateWriteLocation
	{
		private IWriteDebugInfo _debugWriter;
		
		public DefaultConfigurationLocator()
		{
			_debugWriter = new DebugWriter(getPath());
		}
		
		public string GetConfigurationFile()
		{
			return Path.Combine(getPath(), "AutoTest.config");
		}

		public IWriteDebugInfo GetDebugLogger ()
		{
			return _debugWriter;
		}
		
		private string getPath()
		{
			return PathParsing.GetRootDirectory();
		}
	}
}

