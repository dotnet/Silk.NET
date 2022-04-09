// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Configuration;
using Silk.NET.SilkTouch.Emitter;
using Silk.NET.SilkTouch.Generation;
using Silk.NET.SilkTouch.Overloader;
using Silk.NET.SilkTouch.Scraper;
using Silk.NET.SilkTouch.Scraper.Subagent;

namespace SilkTouch
{
    internal static class GeneratorHandoff
    {
        private static readonly HashSet<string> ApplicableSkipIfs;

        static GeneratorHandoff()
        {
            ApplicableSkipIfs = new(StringComparer.OrdinalIgnoreCase)
            {
                // Windows-specific conditions
                OperatingSystem.IsWindows() ? "win" : "!win",
                OperatingSystem.IsWindowsVersionAtLeast(10) ? "win10" : "!win10",
                
                // Linux-specific conditions
                OperatingSystem.IsLinux() ? "linux" : "!linux",
                
                // macOS-specific conditions - .NET 6 doesn't support anything less than Mojave
                OperatingSystem.IsMacOS() ? "macos" : "!macos",
                OperatingSystem.IsMacOSVersionAtLeast(10, 14) ? "macos-mojave" : "!macos-mojave",
                OperatingSystem.IsMacOSVersionAtLeast(10, 15) ? "macos-catalina" : "!macos-catalina",
                OperatingSystem.IsMacOSVersionAtLeast(11) ? "macos-big-sur" : "!macos-big-sur",
                OperatingSystem.IsMacOSVersionAtLeast(12) ? "macos-monterey" : "!macos-monterey",
                
                // Others
                VisualStudioResolver.TryGetVisualStudioInfo(out _) ? "vs" : "!vs"
            };
        }
        
        public static int ExitCode { get; private set; }

        public static async Task HandleProjectAsync(IServiceProvider services, Project project)
        {
            // Create the generator
            var generator = new SilkTouchGenerator(services, FormFactors.CLI);

            var loggerFactory = services.GetRequiredService<ILoggerFactory>();
            var logger = loggerFactory.CreateLogger($"Project {project.Name}");
            var configuration = services.GetService<IOptions<ProjectConfiguration>>();
            
            var raiseDiagnostic = LogDiagnostic(logger, project.AssemblyName);
            generator.DiagnosticRaised += raiseDiagnostic;
            generator.OutputGenerated += _ => throw new NotImplementedException();

            if (!generator.Begin
            (
                await project.GetCompilationAsync(),
                project.AnalyzerOptions.AnalyzerConfigOptionsProvider,
                project.AnalyzerOptions.AdditionalFiles,
                project.AssemblyName
            ))
            {
                // diagnostics already raised, just quit.
                logger.LogDebug("generator.Begin failed");
                return;
            }

            if (configuration?.Value.CommandLineSkipIf?.Any(x => ApplicableSkipIfs.Contains(x.Trim())) ?? false)
            {
                logger.LogInformation("Per the configuration, generation has been skipped");
                return;
            }

            await generator.RunScraperAsync<ClangSharpSubagent>();
            await Task.WhenAll(Task.Run(generator.RunEmitter), Task.Run(generator.RunOverloader));
            generator.End();
        }

        private static Action<Diagnostic> LogDiagnostic(ILogger logger, string proj) => diagnostic =>
        {
            var diagnosticString = $"{diagnostic} ({proj})";
            // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
            switch (diagnostic.Severity)
            {
                case DiagnosticSeverity.Hidden:
                {
                    logger.LogTrace("{Diagnostic}", diagnosticString);
                    break;
                }
                case DiagnosticSeverity.Info:
                {
                    if (diagnostic.Descriptor.IsEnabledByDefault)
                    {
                        logger.LogInformation("{Diagnostic}", diagnosticString);
                    }
                    else
                    {
                        logger.LogTrace("{Diagnostic}", diagnosticString);
                    }

                    break;
                }
                case DiagnosticSeverity.Warning:
                {
                    if (diagnostic.Descriptor.IsEnabledByDefault)
                    {
                        logger.LogWarning("{Diagnostic}", diagnosticString);
                    }
                    else
                    {
                        logger.LogTrace("{Diagnostic}", diagnosticString);
                    }

                    break;
                }
                case DiagnosticSeverity.Error:
                {
                    logger.LogError("{Diagnostic}", diagnosticString);
                    ExitCode--;
                    break;
                }
            }
        };
    }
}
