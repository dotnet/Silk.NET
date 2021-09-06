// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Generation;
using Ultz.Extensions.Logging;

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
            
            // run the overloader if the config indicates we should.
            if (generator.ThisConfiguration?.Overloader is null ||
                ((generator.ThisConfiguration?.Overloader?.FormFactors ?? OverloaderGenerator.DefaultFormFactors) &
                 generator.FormFactor) == 0)
            {
                Log.Trace("Overloader is not configured to run.");
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

            OverloaderGenerator.Run(ctx);
            generator.IngestContext(ctx);
            return true;
        }
    }
}
