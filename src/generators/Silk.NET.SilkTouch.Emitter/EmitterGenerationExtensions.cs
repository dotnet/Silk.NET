// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Generation;
using Ultz.Extensions.Logging;

namespace Silk.NET.SilkTouch.Emitter
{
    public static class EmitterGenerationExtensions
    {
        public static bool RunEmitter(this SilkTouchGenerator generator)
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
            
            // run the emitter if the config indicates we should.
            if (generator.ThisConfiguration?.Emitter is null ||
                ((generator.ThisConfiguration?.Emitter?.FormFactors ?? EmitterGenerator.DefaultFormFactors) &
                 generator.FormFactor) == 0)
            {
                Log.Trace("Emitter is not configured to run.");
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

            EmitterGenerator.Run(ctx);
            generator.IngestContext(ctx);
            return true;
        }
    }
}
