// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using Silk.NET.SilkTouch.Configuration;
using Ultz.Extensions.Logging;

namespace Silk.NET.SilkTouch.Generation
{
    public sealed class SilkTouchGenerator
    {
        public SilkTouchGenerator(FormFactors formFactor) => FormFactor = formFactor;
        
        // Public Properties
        public FormFactors FormFactor { get; }
        public bool IsActive { get; private set; }
        public Compilation? Compilation { get; private set; }
        public string? AssemblyName { get; private set; }
        public RootConfiguration? AllConfiguration { get; private set; }
        public ProjectConfiguration? ThisConfiguration { get; private set; }
        public string? BaseDirectory { get; private set; }
        public ImmutableArray<CSharpSyntaxTree>? SyntaxTrees { get; private set; }

        // Public Events
        public event Action<Diagnostic>? DiagnosticRaised;
        public event Action<(string FileNameHint, string Content)>? OutputGenerated;

        // TODO remove duplicate code between SilkTouchSourceGenerator and GeneratorHandoff in this class
        public bool Begin
        (
            Compilation? compilation,
            AnalyzerConfigOptionsProvider editorConfig,
            ImmutableArray<AdditionalText> additionalFiles,
            string? assemblyName = null
        )
        {
            var loadDiag = Config.Load
            (
                editorConfig,
                additionalFiles,
                out var config,
                out var usedText
            );

            if (loadDiag is not null)
            {
                DiagnosticRaised?.Invoke(loadDiag);
                return false;
            }

            assemblyName ??= compilation?.AssemblyName;
            if (assemblyName is null)
            {
                DiagnosticRaised?.Invoke(Diagnostic.Create(Diagnostics.NoAssemblyName, Location.None));
                return false;
            }

            // prepare our context data
            ProjectConfiguration? projectConfig = null;
            var (_, projects) = config!;
            if ((!projects?.TryGetValue(assemblyName, out projectConfig) ?? false) ||
                projectConfig is null)
            {
                Log.Trace
                (
                    $"No project-specific config for \"{assemblyName}\" found - this is treated as \"don't run " +
                    "SilkTouch\""
                );

                DiagnosticRaised?.Invoke
                (
                    Diagnostic.Create
                    (
                        Diagnostics.NoProjectConfigInFile,
                        Location.None,
                        usedText!.Path,
                        assemblyName
                    )
                );

                return false;
            }

            if (compilation is null)
            {
                // we can't proceed further without a compilation.
                DiagnosticRaised?.Invoke(Diagnostic.Create(Diagnostics.GeneralError, Location.None, "No compilation."));
                return false;
            }
            
            var syntaxTrees = compilation.SyntaxTrees.OfType<CSharpSyntaxTree>().ToImmutableArray();
            var baseDir = Path.GetDirectoryName(usedText!.Path);
            if (baseDir is null)
            {
                DiagnosticRaised?.Invoke
                (
                    Diagnostic.Create
                    (
                        Diagnostics.GeneralError,
                        Location.None,
                        "Couldn't determine directory name for configuration file."
                    )
                );

                return false;
            }

            IsActive = true;
            Compilation = compilation;
            AssemblyName = assemblyName;
            AllConfiguration = config;
            ThisConfiguration = projectConfig;
            BaseDirectory = baseDir;
            SyntaxTrees = syntaxTrees;
            return true;
        }

        public void IngestContext(SilkTouchContext ctx)
        {
            var (outputs, diagnostics) = ctx.GetResult();
            foreach (var diagnostic in diagnostics)
            {
                DiagnosticRaised?.Invoke(diagnostic);
            }

            foreach (var (fileNameHint, content) in outputs)
            {
                OutputGenerated?.Invoke((fileNameHint, content));
            }
        }

        public void End()
        {
            IsActive = false;
            Compilation = null;
            AssemblyName = null;
            AllConfiguration = null;
            ThisConfiguration = null;
            BaseDirectory = null;
            SyntaxTrees = null;
        }
    }
}
