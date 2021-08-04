// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Build.Logging;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch;
using Silk.NET.SilkTouch.Configuration;
using Silk.NET.SilkTouch.Emitter;
using Silk.NET.SilkTouch.Generation;
using Silk.NET.SilkTouch.Overloader;
using Ultz.Extensions.Logging;

namespace SilkTouch
{
    internal static class GeneratorHandoff
    {
        public static int ExitCode { get; private set; }
        public static async ValueTask HandleProjectAsync(Project project, CancellationToken cancellationToken)
        {
            var loadDiag = Config.Load
            (
                project.AnalyzerOptions.AnalyzerConfigOptionsProvider,
                project.AnalyzerOptions.AdditionalFiles,
                out var config,
                out var usedText
            );

            if (loadDiag is not null)
            {
                WriteDiagnostics(loadDiag);
                return;
            }

            if (!project.TryGetCompilation(out var compilation))
            {
                WriteDiagnostics();
                return;
            }
            
            if (compilation.AssemblyName is null)
            {
                WriteDiagnostics(Diagnostic.Create(Diagnostics.NoAssemblyName, Location.None));
                return;
            }

            // prepare our context data
            ProjectConfiguration? projectConfig = null;
            var syntaxTrees = compilation.SyntaxTrees.OfType<CSharpSyntaxTree>().ToArray();
            var (global, projects) = config!;
            if ((!projects?.TryGetValue(compilation.AssemblyName, out projectConfig) ?? false) ||
                projectConfig is null)
            {
                WriteDiagnostics
                (
                    Diagnostic.Create
                    (
                        Diagnostics.NoProjectConfigInFile,
                        Location.None,
                        usedText!.Path,
                        compilation.AssemblyName
                    )
                );
            }

            var baseDir = Path.GetDirectoryName(usedText!.Path);
            if (baseDir is null)
            {
                WriteDiagnostics
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
                    compilation.AssemblyName,
                    syntaxTrees,
                    projectConfig!,
                    global,
                    baseDir
                );

                EmitterGenerator.Run(ctx);
                var (outputs, diagnostics) = ctx.GetResult();
                Copy(project, outputs, diagnostics);
            }

            // run the overloader if the config indicates we should.
            if (projectConfig?.Overloader is null ||
                ((projectConfig.Overloader.FormFactors ?? OverloaderGenerator.DefaultFormFactors) & FormFactors.Roslyn)
                != 0)
            {
                var ctx = new SilkTouchContext
                (
                    compilation.AssemblyName,
                    syntaxTrees,
                    projectConfig!,
                    global,
                    baseDir
                );

                OverloaderGenerator.Run(ctx);
                var (outputs, diagnostics) = ctx.GetResult();
                Copy(project, outputs, diagnostics);
            }
        }

        private static void Copy(Project project, List<(string FileNameHint, string Content)> outputs, List<Diagnostic> diagnostics)
        {
            // TODO IMPLEMENT THIS SHIT
            throw new NotImplementedException();
        }

        private static void WriteDiagnostics(params Diagnostic[] diagnostics)
            => WriteDiagnostics((IEnumerable<Diagnostic>) diagnostics);

        private static void WriteDiagnostics(IEnumerable<Diagnostic> diagnostics)
        {
            foreach (var diagnostic in diagnostics)
            {
                // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
                switch (diagnostic.Severity)
                {
                    case DiagnosticSeverity.Hidden:
                    {
                        Log.Trace(diagnostic.ToString());
                        break;
                    }
                    case DiagnosticSeverity.Info:
                    {
                        Log.Information(diagnostic.ToString());
                        break;
                    }
                    case DiagnosticSeverity.Warning:
                    {
                        Log.Warning(diagnostic.ToString());
                        break;
                    }
                    case DiagnosticSeverity.Error:
                    {
                        Log.Error(diagnostic.ToString());
                        ExitCode--;
                        break;
                    }
                }
            }
        }
    }
}
