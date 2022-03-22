// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Configuration;
using Silk.NET.SilkTouch.Generation;

namespace Silk.NET.SilkTouch.Overloader
{
    /// <summary>
    /// Contains a helper method for launching the SilkTouch Overloader given a <see cref="SilkTouchGenerator"/>
    /// instance.
    /// </summary>
    public static class OverloaderGenerationExtensions
    {
        /// <summary>
        /// Runs the overloader.
        /// </summary>
        /// <param name="generator">The generator to generate into.</param>
        /// <returns>Whether the overloader was started successfully.</returns>
        public static bool RunOverloader(this SilkTouchGenerator generator)
        {
            var logger = generator.ServiceProvider.GetRequiredService<ILoggerFactory>()
                .CreateLogger(nameof(RunOverloader));
            var configuration = generator.ServiceProvider.GetService<IOptions<OverloaderConfiguration>>();
            if (!generator.IsActive ||
                generator.AssemblyName is null ||
                generator.Compilation is null ||
                generator.BaseDirectory is null)
            {
                // generator is not active, move along...
                logger.LogDebug("Generator is not active");
                return false;
            }
            
            // run the overloader if the config indicates we should.
            if (configuration is null ||
                ((configuration.Value.FormFactors ?? OverloaderGenerator.DefaultFormFactors) &
                 generator.FormFactor) == 0)
            {
                logger.LogTrace("Overloader is not configured to run");
                return false;
            }

            var ctx = new SilkTouchContext
            (
                generator.AssemblyName,
                generator.Compilation,
                generator.BaseDirectory,
                generator.ServiceProvider
            );

            OverloaderGenerator.Run(ctx);
            generator.IngestContext(ctx);
            return true;
        }
    }
}
