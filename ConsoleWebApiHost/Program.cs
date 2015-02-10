using System;
using Microsoft.Owin.Hosting;
using WebApiHost;

namespace ConsoleWebApiHost
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			using(var server = WebApp.Start<Startup>("http://localhost:7777"))
			{
				Console.WriteLine ("Web API Server running...");
				Console.ReadLine ();
			}
		}
	}
}
