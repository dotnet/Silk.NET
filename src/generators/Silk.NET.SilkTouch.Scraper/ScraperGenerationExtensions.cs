// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Threading.Tasks;
using Silk.NET.SilkTouch.Generation;
using Silk.NET.SilkTouch.Scraper.Subagent;
using Ultz.Extensions.Logging;

namespace Silk.NET.SilkTouch.Scraper
{
    public static class ScraperGenerationExtensions
    {
        public static async ValueTask<bool> RunScraperAsync<T>(this SilkTouchGenerator generator)
            where T : ISubagent, new()
        {
            if (!generator.IsActive ||
                generator.AssemblyName is null ||
                generator.SyntaxTrees is null ||
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
                generator.SyntaxTrees,
                generator.ThisConfiguration!,
                generator.AllConfiguration?.Global,
                generator.BaseDirectory
            );

            await ScraperGenerator.RunAsync<T>(ctx);
            generator.IngestContext(ctx);
            return true;
        }
    }
}
