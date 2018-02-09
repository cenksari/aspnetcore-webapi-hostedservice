namespace AspNetCoreHostedService
{
	using System;
	using System.Diagnostics;
	using System.Threading;
	using System.Threading.Tasks;

	public class BackgroundService : HostedService
	{
		protected override async Task ExecuteAsync(CancellationToken token)
		{
			while (!token.IsCancellationRequested)
			{
				Trace.WriteLine($"{DateTime.Now.ToString("dd MMMM yyyy, dddd - HH:mm:ss")} - Background job started");

				await Task.Delay(TimeSpan.FromSeconds(15), token);
			}
		}
	}
}