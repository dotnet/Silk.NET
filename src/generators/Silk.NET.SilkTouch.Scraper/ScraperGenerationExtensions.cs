// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Configuration;
using Silk.NET.SilkTouch.Generation;
using Silk.NET.SilkTouch.Scraper.Subagent;

namespace Silk.NET.SilkTouch.Scraper
{
    /// <summary>
    /// Contains a helper method for running the SilkTouch Scraper given a <see cref="SilkTouchGenerator"/> instnace.
    /// </summary>
    public static class ScraperGenerationExtensions
    {
        /// <summary>
        /// Runs the SilkTouch Scraper.
        /// </summary>
        /// <param name="generator">The generator instance to run the scraper on.</param>
        /// <typeparam name="T">The type of the subagent spawner to use.</typeparam>
        /// <returns>An asynchronous task encapsulating whether the generator was successfully started.</returns>
        public static async Task<bool> RunScraperAsync<T>(this SilkTouchGenerator generator)
            where T : ISubagent
        {
            var logger = generator.ServiceProvider.GetRequiredService<ILoggerFactory>().CreateLogger(nameof(RunScraperAsync));
            if (!generator.IsActive ||
                generator.AssemblyName is null ||
                generator.Compilation is null ||
                generator.BaseDirectory is null)
            {
                // generator is not active, move along...
                logger.LogDebug("Generator is not active");
                return false;
            }
            
            // run the scarper if the form factor matches
            // we do not check for some configuration value because the scraper should never run outside of the CLI
            if ((ScraperGenerator.DefaultFormFactors & generator.FormFactor) == 0)
            {
                logger.LogTrace("Scraper is not configured to run");
                return false;
            }

            var ctx = new SilkTouchContext
            (
                generator.AssemblyName,
                generator.Compilation,
                generator.BaseDirectory,
                generator.ServiceProvider
            );

            await ScraperGenerator.RunAsync<T>(ctx);
            generator.IngestContext(ctx);
            return true;
        }
    }
}
