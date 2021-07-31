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
            var configFileName = "silktouch.json";
            if (context.AnalyzerConfigOptions.GlobalOptions.TryGetValue
                (Constants.ConfigFileEditorconfigOption, out var file))
            {
                configFileName = file;
            }

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
                                Location.Create(additionalFile.Path, TextSpan.FromBounds(0, 0), default)
                            )
                        );
                    }

                    configFilePath = additionalFile.Path;
                }
            }

            if (configFilePath is null)
            {
                // TODO report diagnostic that this isn't found.
            }

            // TODO fix all the warnings in the morning because i'm tired and just wanna commit something.
            var syntaxTrees = context.Compilation.SyntaxTrees.OfType<CSharpSyntaxTree>().ToArray();
            var projectConfig = Config.Load(configFilePath)[context.Compilation.AssemblyName];

            var ctx = new SilkTouchContext { SyntaxTrees = syntaxTrees, Configuration = projectConfig };

            EmitterGenerator.Run(ctx);
            var (emitterOutputs, emitterDiagnostics) = ctx.GetResult();

            ctx = new() { SyntaxTrees = syntaxTrees, Configuration = projectConfig };

            OverloaderGenerator.Run(ctx);
            var (overloaderOutputs, overloaderDiagnostics) = ctx.GetResult();
            
            // TODO add the outputs and the diagnostics to roslyn. seriously i'm tired and cba to finish the job.
        }
    }
}
