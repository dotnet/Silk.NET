// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Immutable;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Silk.NET.SilkTouch.Configuration;

namespace Silk.NET.SilkTouch.Generation
{
    /// <summary>
    /// Represents generic, form factor agnostic SilkTouch generator infrastructure. This aims to provide a common
    /// interface by which all form factors can bootstrap the generation process.
    /// </summary>
    public sealed class SilkTouchGenerator
    {
        /// <summary>
        /// Creates a <see cref="SilkTouchGenerator"/> for the given <see cref="FormFactor"/>.
        /// </summary>
        /// <param name="serviceProvider">The service provider used to resolve dependencies</param>
        /// <param name="formFactor">The form factor this generator is running within.</param>
        public SilkTouchGenerator(IServiceProvider serviceProvider, FormFactors formFactor)
        {
            ServiceProvider = serviceProvider;
            FormFactor = formFactor;
        }

        // Public Properties
        
        /// <summary>
        /// The service provider used to resolve dependencies
        /// </summary>
        public IServiceProvider ServiceProvider { get; }

        /// <summary>
        /// The form factor this generator is running within.
        /// </summary>
        public FormFactors FormFactor { get; }

        /// <summary>
        /// Whether the generator is "active" and is ready for generation to occur against it i.e. whether
        /// <see cref="Begin"/> has been called, but <see cref="End" /> hasn't.
        /// </summary>
        public bool IsActive { get; private set; }

        /// <summary>
        /// The Roslyn <see cref="Microsoft.CodeAnalysis.Compilation"/> for this C# project.
        /// </summary>
        public Compilation? Compilation { get; private set; }

        /// <summary>
        /// The assembly name for this C# project.
        /// </summary>
        public string? AssemblyName { get; private set; }

        /// <summary>
        /// The "base directory" of this project, used as the root of all relative paths referenced in the
        /// <see cref="ProjectConfiguration"/>.
        /// </summary>
        public string? BaseDirectory { get; private set; }

        // Public Events
        /// <summary>
        /// Raised when a diagnostic is raised.
        /// </summary>
        public event Action<Diagnostic>? DiagnosticRaised;
        
        /// <summary>
        /// Raise when generated output is added.
        /// </summary>
        public event Action<(string FileNameHint, string Content)>? OutputGenerated;

        /// <summary>
        /// Activates this generator, preparing it for receiving diagnostics and generated code.
        /// </summary>
        /// <param name="compilation">The compilation to use for generation.</param>
        /// <param name="editorConfig">The analyzer options (editorconfig) to use for generation.</param>
        /// <param name="additionalFiles">The analyzer additional files to use for generation.</param>
        /// <param name="assemblyName">The assembly name of the project being generated.</param>
        /// <returns>Whether the operation was successful or not.</returns>
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
                DiagnosticRaised?.Invoke(Diagnostic.Create(Diagnostics.GeneralError, Location.None, "No AssemblyName"));
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
            BaseDirectory = baseDir;
            return true;
        }

        /// <summary>
        /// After its use, copies the results of the <see cref="SilkTouchContext"/> and raises events accordingly.
        /// </summary>
        /// <param name="ctx">The context to ingest.</param>
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

        /// <summary>
        /// Cleans this generator instance.
        /// </summary>
        public void End()
        {
            IsActive = false;
            Compilation = null;
            AssemblyName = null;
            BaseDirectory = null;
        }
    }
}
