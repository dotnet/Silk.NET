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
            // Get the config file name. Uses silktouch.json unless overridden in .editorconfig.
            var configFileName = "silktouch.json";
            if (context.AnalyzerConfigOptions.GlobalOptions.TryGetValue
                (Constants.ConfigFileEditorconfigOption, out var file))
            {
                configFileName = file;
            }

            // Try and find an AdditionalFiles entry for the SilkTouch config.
            string? configFilePath = null;
            foreach (var additionalFile in context.AdditionalFiles)
            {
                if (additionalFile.Path == configFileName || Path.GetFileName(additionalFile.Path) == configFileName)
                {
                    if (configFilePath is not null)
                    {
                        context.ReportDiagnostic
                        (
                            Diagnostic.Create
                            (
                                Diagnostics.MultipleConfigFiles,
                                Location.Create(additionalFile.Path, TextSpan.FromBounds(0, 0), default),
                                configFilePath,
                                additionalFile.Path
                            )
                        );

                        continue;
                    }

                    configFilePath = additionalFile.Path;
                }
            }
            
            // Prevent debug logs from being output by forcing the LoggerProvider to null - we don't want this in Roslyn
            Log.LoggerProvider = null;

            if (configFilePath is null)
            {
                context.ReportDiagnostic(Diagnostic.Create(Diagnostics.NoConfigFile, Location.None));
                return;
            }

            if (context.Compilation.AssemblyName is null)
            {
                context.ReportDiagnostic(Diagnostic.Create(Diagnostics.NoAssemblyName, Location.None));
                return;
            }

            // prepare our context data
            var syntaxTrees = context.Compilation.SyntaxTrees.OfType<CSharpSyntaxTree>().ToArray();
            var projectConfig = Config.Load(configFilePath)[context.Compilation.AssemblyName];

            // run the emitter if the config indicates we should.
            if (((projectConfig.Emitter.FormFactors ?? EmitterGenerator.DefaultFormFactors) & FormFactors.Roslyn) != 0)
            {
                var ctx = new SilkTouchContext(syntaxTrees, projectConfig);
                EmitterGenerator.Run(ctx);
                var (outputs, diagnostics) = ctx.GetResult();
                Copy(context, outputs, diagnostics);
            }

            // run the overloader if the config indicates we should.
            if (((projectConfig.Overloader.FormFactors ?? OverloaderGenerator.DefaultFormFactors) & FormFactors.Roslyn)
                != 0)
            {
                var ctx = new SilkTouchContext(syntaxTrees, projectConfig);
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
