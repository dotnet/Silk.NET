// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Silk.NET.SilkTouch.Configuration;
using Silk.NET.SilkTouch.Emitter;
using Silk.NET.SilkTouch.Generation;
using Silk.NET.SilkTouch.Overloader;
using Ultz.Extensions.Logging;

namespace Silk.NET.SilkTouch.Roslyn
{
    public class SilkTouchSourceGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
            // TODO do we need to do initialization downstream?
        }

        public void Execute(GeneratorExecutionContext context)
        {
            // Prevent debug logs from being output by forcing the LoggerProvider to null - we don't want this in Roslyn
            Log.LoggerProvider = null;
            
            // Create the generator
            var generator = new SilkTouchGenerator(FormFactors.Roslyn);
            generator.DiagnosticRaised += context.ReportDiagnostic;
            generator.OutputGenerated += x => context.AddSource(x.FileNameHint, x.Content);
            if (!generator.Begin(context.Compilation, context.AnalyzerConfigOptions, context.AdditionalFiles))
            {
                // diagnostics already raised, just quit.
                return;
            }

            generator.RunEmitter();
            generator.RunOverloader();
            generator.End();
        }

        private static void Copy
        (
            GeneratorExecutionContext context,
            IEnumerable<(string FileNameHint, string Content)> outputs,
            IEnumerable<Diagnostic> diagnostics
        )
        {
            foreach (var (fileNameHint, content) in outputs)
            {
                context.AddSource(fileNameHint, content);
            }

            foreach (var diagnostic in diagnostics)
            {
                context.ReportDiagnostic(diagnostic);
            }
        }
    }
}
