// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Silk.NET.SilkTouch.Configuration;
using Silk.NET.SilkTouch.Emitter;
using Silk.NET.SilkTouch.Generation;
using Silk.NET.SilkTouch.Overloader;

namespace Silk.NET.SilkTouch.Roslyn
{
    /// <summary>
    /// The Source Generator form factor for SilkTouch.
    /// </summary>
    [Generator]
    public class SilkTouchSourceGenerator : IIncrementalGenerator
    {
        /// <inheritdoc />
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            context.RegisterSourceOutput(
                // probably builds some incremental logic here to process the analyzer config options into an IConfiguration.
                context.CompilationProvider.Combine(context.AnalyzerConfigOptionsProvider)
                    .Combine(context.AdditionalTextsProvider.Collect()),
                    static (productionContext, source) =>
                    {
                        IServiceProvider serviceProvider = CreateSourceGeneratorServiceProvider();
                        
                        var generator = new SilkTouchGenerator(serviceProvider, FormFactors.Roslyn);
                        generator.DiagnosticRaised += productionContext.ReportDiagnostic;
                        generator.OutputGenerated += x => productionContext.AddSource(x.FileNameHint, x.Content);
                        if (!generator.Begin(source.Left.Left, source.Left.Right, source.Right))
                        {
                            // diagnostics already raised, just quit.
                            return;
                        }

                        generator.RunEmitter();
                        generator.RunOverloader();
                        generator.End();
                    }
            );
        }

        private static IServiceProvider CreateSourceGeneratorServiceProvider()
        {
            // IConfiguration needs to be loaded from the usual sources + the .editorconfig
            throw new NotImplementedException();
        }
    }
}
