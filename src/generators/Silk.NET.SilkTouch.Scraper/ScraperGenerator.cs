using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ClangSharp;
using Microsoft.CodeAnalysis;
using Silk.NET.SilkTouch.Configuration;
using Silk.NET.SilkTouch.Generation;
using Silk.NET.SilkTouch.Scraper.Subagent;
using Ultz.Extensions.Logging;
using Diagnostic = Microsoft.CodeAnalysis.Diagnostic;

namespace Silk.NET.SilkTouch.Scraper
{
    public static class ScraperGenerator
    {
        public const FormFactors DefaultFormFactors = FormFactors.CLI;
        public static async Task RunAsync<T>(SilkTouchContext ctx) where T:ISubagent, new()
        {
            Log.Information("Scraper started.");
            var subagentSpawner = new T();
            var error = false;
            var libraryNames = ctx.Configuration.Scraper?.LibraryNames;
            if ((libraryNames?.Length ?? 0) == 0)
            {
                ctx.EmitDiagnostic(Diagnostic.Create(Diagnostics.NoLibraryName, Location.None, ctx.AssemblyName));
                error = true;
            }

            if (ctx.Configuration.Scraper?.HeaderText is null)
            {
                ctx.EmitDiagnostic(Diagnostic.Create(Diagnostics.NoHeaderText, Location.None, ctx.AssemblyName));
                error = true;
            }

            if (error)
            {
                return;
            }

            var workFolder = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            var @in = Path.Combine(workFolder, "in.h");
            var @out = Path.Combine(workFolder, "out.xml");
            string? licenseHeaderFile = null;
            Directory.CreateDirectory(workFolder);
            File.WriteAllLines(@in, ctx.Configuration.Scraper?.HeaderText ?? Array.Empty<string>());

            if (ctx.GlobalConfiguration?.FileHeaderLines is not null)
            {
                licenseHeaderFile = Path.Combine(workFolder, "licenseHeader.txt");
                await File.WriteAllTextAsync(licenseHeaderFile, licenseHeaderFile);
            }
            
            VisualStudioResolver.TryGetVisualStudioInfo(out var vs);

            var includes = ctx.Configuration.Scraper?.IncludeDirectories?.ToList() ?? new();
            for (var i = 0; i < includes.Count; i++)
            {
                var include = includes[i];
                if (include == "win-sdk")
                {
                    includes.RemoveAt(i);
                    if (vs is null)
                    {
                        ctx.EmitDiagnostic
                        (
                            Diagnostic.Create(Diagnostics.NoWindowsSdk, Location.None, "win-sdk", ctx.AssemblyName)
                        );

                        continue;
                    }

                    includes.InsertRange(i, vs.UcrtIncludes);
                }
            }

            Log.Debug($"Using work folder \"{workFolder}\"");
            Log.Information($"Starting ClangSharp subagent for \"{ctx.AssemblyName}\"...");
            var options = new SubagentOptions
            (
                @in,
                "__SILKTOUCH", // TODO replace this in transformation, our library path logic will be more lenient
                ctx.Configuration.Scraper?.Namespace ?? ctx.AssemblyName,
                @out,
                workFolder,
                includes.ToArray(),
                PInvokeGeneratorOutputMode.Xml,
                SubagentUtils.GetOptions
                (
                    ctx.Configuration.Scraper?.Exclude?.Hints ?? ExclusionHint.None,
                    ctx.Configuration.Scraper?.UnixMode ?? !OperatingSystem.IsWindows()
                ),
                ctx.Configuration.Scraper?.Language ?? "c++",
                ctx.Configuration.Scraper?.Standard ?? "c++17",
                ctx.Configuration.Scraper?.AdditionalClangArguments,
                ctx.Configuration.Scraper?.DefineMacros,
                ctx.Configuration.Scraper?.Exclude?.Identifiers,
                licenseHeaderFile,
                ctx.Configuration.Scraper?.ClassName ?? "Interop",
                ctx.Configuration.Scraper?.MethodPrefixToStrip,
                await OpenRemappingFilesAsync(ctx.Configuration.Scraper?.RemappingFiles, ctx.BaseDirectory),
                ctx.Configuration.Scraper?.Traverse,
                WithAttributes: null, // will be done by mods TODO do attributes in the mods
                ctx.Configuration.Scraper?.CallingConventions,
                WithLibraryPaths: null, // again, library path stuff is done in transformation
                WithSetLastErrors: null, // the current design of SilkTouch doesn't support SetLastError
                null, // currently no need to support enum type overrides
                null // the scraper will add predefined using directives during transformation
            );

            var clangSharpErrors = new List<string>();
            var exitCode = await subagentSpawner.RunClangSharpAsync(options, clangSharpErrors);

            if (exitCode != 0)
            {
                ctx.EmitDiagnostic(Diagnostic.Create(Diagnostics.ClangSharpNonZeroExitCode, Location.None, exitCode));
                foreach (var theError in clangSharpErrors)
                {
                    ctx.EmitDiagnostic(Diagnostic.Create(Diagnostics.ClangSharpError, Location.None, theError));
                }

                return;
            }
            
            // TODO mods
            // TODO transformation + ctx.EmitOutput
        }

        private static async ValueTask<Dictionary<string, string>?> OpenRemappingFilesAsync
        (
            string[]? files,
            string baseDir
        )
        {
            if (files is null)
            {
                return null;
            }

            var ret = new Dictionary<string, string>();
            foreach (var file in files)
            {
                var text = await File.ReadAllTextAsync(Path.GetFullPath(file, baseDir));
                var dict = JsonSerializer.Deserialize<Dictionary<string, string>>(text);
                if (dict is null)
                {
                    continue;
                }
                
                foreach (var (key, value) in dict)
                {
                    if (!ret.TryAdd(key, value))
                    {
                        // TODO idk log that there's a duplicate remapping maybe?
                    }
                }
            }

            return ret;
        }
    }
}
