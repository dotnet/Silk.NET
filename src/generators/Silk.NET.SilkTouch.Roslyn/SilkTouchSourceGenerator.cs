// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
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
            var loadDiag = Config.Load(context.AnalyzerConfigOptions, context.AdditionalFiles, out var config, out var usedText);
            if (loadDiag is not null)
            {
                context.ReportDiagnostic(loadDiag);
                return;
            }

            // Prevent debug logs from being output by forcing the LoggerProvider to null - we don't want this in Roslyn
            Log.LoggerProvider = null;

            if (context.Compilation.AssemblyName is null)
            {
                context.ReportDiagnostic(Diagnostic.Create(Diagnostics.NoAssemblyName, Location.None));
                return;
            }

            // prepare our context data
            ProjectConfiguration? projectConfig = null;
            var syntaxTrees = context.Compilation.SyntaxTrees.OfType<CSharpSyntaxTree>().ToArray();
            var (global, projects) = config!;
            if ((!projects?.TryGetValue(context.Compilation.AssemblyName, out projectConfig) ?? false) ||
                projectConfig is null)
            {
                context.ReportDiagnostic
                (
                    Diagnostic.Create
                    (
                        Diagnostics.NoProjectConfigInFile,
                        Location.None,
                        usedText!.Path,
                        context.Compilation.AssemblyName
                    )
                );

                return;
            }

            var baseDir = Path.GetDirectoryName(usedText!.Path);
            if (baseDir is null)
            {
                context.ReportDiagnostic
                (
                    Diagnostic.Create
                    (
                        Diagnostics.GeneralError,
                        Location.None,
                        "Couldn't determine directory name for configuration file."
                    )
                );

                return;
            }

            // run the emitter if the config indicates we should.
            if (projectConfig?.Emitter is null ||
                ((projectConfig.Emitter.FormFactors ?? EmitterGenerator.DefaultFormFactors) & FormFactors.Roslyn) != 0)
            {
                var ctx = new SilkTouchContext
                (
                    context.Compilation.AssemblyName,
                    syntaxTrees,
                    projectConfig!,
                    global,
                    baseDir
                );

                EmitterGenerator.Run(ctx);
                var (outputs, diagnostics) = ctx.GetResult();
                Copy(context, outputs, diagnostics);
            }

            // run the overloader if the config indicates we should.
            if (projectConfig?.Overloader is null ||
                ((projectConfig.Overloader.FormFactors ?? OverloaderGenerator.DefaultFormFactors) & FormFactors.Roslyn)
                != 0)
            {
                var ctx = new SilkTouchContext
                (
                    context.Compilation.AssemblyName,
                    syntaxTrees,
                    projectConfig!,
                    global,
                    baseDir
                );

                OverloaderGenerator.Run(ctx);
                var (outputs, diagnostics) = ctx.GetResult();
                Copy(context, outputs, diagnostics);
            }
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
