// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Threading.Tasks;
using Silk.NET.SilkTouch.Generation;
using Silk.NET.SilkTouch.Scraper.Subagent;
using Ultz.Extensions.Logging;

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
            where T : ISubagent, new()
        {
            if (!generator.IsActive ||
                generator.AssemblyName is null ||
                generator.Compilation is null ||
                generator.ThisConfiguration is null ||
                generator.BaseDirectory is null)
            {
                // generator is not active, move along...
                Log.Debug("Generator is not active.");
                return false;
            }
            
            // run the scarper if the config indicates we should.
            if (generator.ThisConfiguration?.Scraper is null ||
                (ScraperGenerator.DefaultFormFactors & generator.FormFactor) == 0)
            {
                Log.Trace("Scraper is not configured to run.");
                return false;
            }

            var ctx = new SilkTouchContext
            (
                generator.AssemblyName,
                generator.Compilation,
                generator.ThisConfiguration!,
                generator.GlobalConfiguration,
                generator.BaseDirectory
            );

            await ScraperGenerator.RunAsync<T>(ctx);
            generator.IngestContext(ctx);
            return true;
        }
    }
}
