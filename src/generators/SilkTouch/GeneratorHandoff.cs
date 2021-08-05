// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using Silk.NET.SilkTouch.Configuration;
using Silk.NET.SilkTouch.Emitter;
using Silk.NET.SilkTouch.Generation;
using Silk.NET.SilkTouch.Overloader;
using Silk.NET.SilkTouch.Scraper;
using Ultz.Extensions.Logging;

namespace SilkTouch
{
    internal static class GeneratorHandoff
    {
        public static int ExitCode { get; private set; }

        public static async ValueTask HandleProjectAsync(MSBuildWorkspace workspace, Project project)
        {
            // Create the generator
            var generator = new SilkTouchGenerator(FormFactors.CLI);
            var raiseDiagnostic = LogDiagnostic(project.AssemblyName);
            generator.DiagnosticRaised += raiseDiagnostic;
            generator.OutputGenerated += x =>
            {
                // TODO implement this, we need to either add our files to the workspace or come up with some other hack
                throw new NotImplementedException();
            };

            if (!generator.Begin
            (
                await project.GetCompilationAsync(),
                project.AnalyzerOptions.AnalyzerConfigOptionsProvider,
                project.AnalyzerOptions.AdditionalFiles,
                project.AssemblyName
            ))
            {
                // diagnostics already raised, just quit.
                Log.Debug($"generator.Begin failed - {project.AssemblyName}");
                return;
            }

            await generator.RunScraperAsync<ClangSharpSubagent>();
            await Task.WhenAll(Task.Run(generator.RunEmitter), Task.Run(generator.RunOverloader));
            generator.End();
        }

        private static Action<Diagnostic> LogDiagnostic(string proj) => diagnostic =>
        {
            var diagnosticString = $"{diagnostic} ({proj})";
            // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
            switch (diagnostic.Severity)
            {
                case DiagnosticSeverity.Hidden:
                {
                    Log.Trace(diagnosticString);
                    break;
                }
                case DiagnosticSeverity.Info:
                {
                    if (diagnostic.Descriptor.IsEnabledByDefault)
                    {
                        Log.Information(diagnosticString);
                    }
                    else
                    {
                        Log.Trace(diagnosticString);
                    }

                    break;
                }
                case DiagnosticSeverity.Warning:
                {
                    if (diagnostic.Descriptor.IsEnabledByDefault)
                    {
                        Log.Warning(diagnosticString);
                    }
                    else
                    {
                        Log.Trace(diagnosticString);
                    }

                    break;
                }
                case DiagnosticSeverity.Error:
                {
                    Log.Error(diagnosticString);
                    ExitCode--;
                    break;
                }
            }
        };
    }
}
