using System;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using SourceLink.Demo.Library.Extensions;
using SourceLink.Demo.Library.Services;

namespace SourceLink.Demo
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
	        var provider = BuildServiceProvider();
	        var demoService = provider.GetRequiredService<IDemoService>();

	        var result = demoService.GetDemoContent();

	        Console.WriteLine(JsonSerializer.Serialize(result));
        }

		private static IServiceProvider BuildServiceProvider()
			=> new ServiceCollection()
				.SetupDemo(c => c.Client = "SourceLink.Demo.App")
				.BuildServiceProvider();
    }
}
