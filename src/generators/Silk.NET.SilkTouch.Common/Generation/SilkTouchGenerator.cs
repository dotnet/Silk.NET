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
        public GlobalConfiguration? GlobalConfiguration { get; private set; }
        public ProjectConfiguration? ThisConfiguration { get; private set; }
        public string? BaseDirectory { get; private set; }

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
            if (!Config.TryLoad
            (
                editorConfig,
                additionalFiles,
                out var projectConfig,
                out var usedText,
                DiagnosticRaised
            ))
            {
                return false;
            }

            assemblyName ??= compilation?.AssemblyName;
            if (assemblyName is null)
            {
                DiagnosticRaised?.Invoke(Diagnostic.Create(Diagnostics.NoAssemblyName, Location.None));
                return false;
            }

            // prepare our context data
            if (compilation is null)
            {
                // we can't proceed further without a compilation.
                DiagnosticRaised?.Invoke(Diagnostic.Create(Diagnostics.GeneralError, Location.None, "No compilation."));
                return false;
            }
            
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
            GlobalConfiguration = projectConfig?.GetGlobalConfiguration(baseDir);
            ThisConfiguration = projectConfig;
            BaseDirectory = baseDir;
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
            GlobalConfiguration = null;
            ThisConfiguration = null;
            BaseDirectory = null;
        }
    }
}
