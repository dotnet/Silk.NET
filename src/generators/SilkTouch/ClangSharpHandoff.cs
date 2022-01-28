// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json;
using ClangSharp;
using ClangSharp.Interop;
using Silk.NET.SilkTouch.Scraper.Subagent;

namespace SilkTouch
{
    internal static class ClangSharpHandoff
    {
        [SuppressMessage("ReSharper", "BitwiseOperatorOnEnumWithoutFlags")]
        public static int RunClangSharp(string[] args)
        {
            SubagentOptions? options;
            if (args.Length != 2 || (options = JsonSerializer.Deserialize<SubagentOptions>(args[1])) is null)
            {
                Console.WriteLine
                (
                    "E:The \"silktouch clangsharp\" command is an implementation detail and should not be used. " +
                    "To use ClangSharp, visit https://github.com/microsoft/clangsharp."
                );

                return (int) ExitCodes.SubagentBadArgs;
            }

            if (options.DebugAttach && Environment.GetEnvironmentVariable("SilkTouch_NoNestedDebug") != "1")
            {
                Debugger.Launch();
            }
            
            Console.WriteLine($"T:Clang Version: {clang.getClangVersion()}");

            // the code below is based off ClangSharp
            // Copyright (c) Microsoft and Contributors. All rights reserved.
            // Licensed under the University of Illinois/NCSA Open Source License.
            // https://github.com/microsoft/ClangSharp/blob/main/LICENSE.txt
            
            // I wish we could use the actual ClangSharpPInvokeGenerator executable, but it's a dotnet tool which means
            // we can't reference it. Luckily, this executable is just a shim for calling into the
            // ClangSharp.PInvokeGenerator library so we can just replicate what the executable does in here.
            
            var clangCommandLineArgs = new List<string>
            {
                $"--language={options.Language}", // Treat subsequent input files as having type <language>
                $"--std={options.Standard}", // Language standard to compile for
                "-Wno-pragma-once-outside-header" // We are processing files which may be header files
            };

            clangCommandLineArgs.AddRange(options.IncludeDirectories.Select(x => "--include-directory=" + x));
            clangCommandLineArgs.AddRange(options.DefineMacros?.Select(x => "--define-macro=" + x) ?? Enumerable.Empty<string>());
            clangCommandLineArgs.AddRange(options.AdditionalArgs ?? Enumerable.Empty<string>());

            var translationFlags = CXTranslationUnit_Flags.CXTranslationUnit_None;

            translationFlags |=
                CXTranslationUnit_Flags.CXTranslationUnit_IncludeAttributedTypes; // Include attributed types in CXType
            translationFlags |=
                CXTranslationUnit_Flags.CXTranslationUnit_VisitImplicitAttributes; // Implicit attrs should be visited

            var config = (PInvokeGeneratorConfiguration) options;

            if (config.GenerateMacroBindings)
            {
                translationFlags |= CXTranslationUnit_Flags.CXTranslationUnit_DetailedPreprocessingRecord;
            }

            var exitCode = 0;

            var finishedCommandLineArgs = clangCommandLineArgs.ToArray();
            using var pinvokeGenerator = new PInvokeGenerator(config);
            var translationUnitError = CXTranslationUnit.TryParse
            (
                pinvokeGenerator.IndexHandle, options.HeaderFile, finishedCommandLineArgs,
                Array.Empty<CXUnsavedFile>(), translationFlags, out var handle
            );
            var skipProcessing = false;

            if (translationUnitError != CXErrorCode.CXError_Success)
            {
                Console.WriteLine($"E:Parsing failed due to '{translationUnitError}'.");
                skipProcessing = true;
            }
            else if (handle.NumDiagnostics != 0)
            {
                for (uint i = 0; i < handle.NumDiagnostics; ++i)
                {
                    using var diagnostic = handle.GetDiagnostic(i);

                    Console.Write
                    (
                        diagnostic.Severity switch
                        {
                            CXDiagnosticSeverity.CXDiagnostic_Error => "E:",
                            CXDiagnosticSeverity.CXDiagnostic_Fatal => "E:",
                            CXDiagnosticSeverity.CXDiagnostic_Warning => "W:",
                            CXDiagnosticSeverity.CXDiagnostic_Ignored => "T:",
                            CXDiagnosticSeverity.CXDiagnostic_Note => "T:",
                            _ => "T:"
                        }
                    );

                    Console.WriteLine(diagnostic.Format(CXDiagnostic.DefaultDisplayOptions).ToString());

                    skipProcessing |= diagnostic.Severity == CXDiagnosticSeverity.CXDiagnostic_Error;
                    skipProcessing |= diagnostic.Severity == CXDiagnosticSeverity.CXDiagnostic_Fatal;
                }
            }

            if (skipProcessing)
            {
                Console.WriteLine("E:One or more errors during parsing.");
                return (int) ExitCodes.SubagentFailedToParse;
            }

            try
            {
                using var translationUnit = TranslationUnit.GetOrCreate(handle);
                Console.WriteLine("I:Processing...");

                pinvokeGenerator.GenerateBindings
                    (translationUnit, options.HeaderFile, finishedCommandLineArgs, translationFlags);
            }
            catch (Exception e)
            {
                Console.WriteLine("E:" + e);
            }

            if (pinvokeGenerator.Diagnostics.Count != 0)
            {
                foreach (var diagnostic in pinvokeGenerator.Diagnostics)
                {
                    Console.Write
                    (
                        diagnostic.Level switch
                        {
                            DiagnosticLevel.Info => "T:",
                            DiagnosticLevel.Warning => "W:",
                            DiagnosticLevel.Error => "E:",
                            _ => "T:"
                        }
                    );
                    Console.WriteLine(diagnostic);
                    if (diagnostic.Level == DiagnosticLevel.Error)
                    {
                        exitCode--;
                    }
                }
            }

            if (exitCode < 0)
            {
                Console.WriteLine("E:One or more errors during bindings generation.");
            }

            return exitCode;
        }
    }
}
