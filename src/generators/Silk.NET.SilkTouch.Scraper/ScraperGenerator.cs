using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ClangSharp;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.FileSystemGlobbing.Abstractions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Configuration;
using Silk.NET.SilkTouch.Generation;
using Silk.NET.SilkTouch.Scraper.Subagent;
using Diagnostic = Microsoft.CodeAnalysis.Diagnostic;

namespace Silk.NET.SilkTouch.Scraper
{
    /// <summary>
    /// The SilkTouch Scraper.
    /// </summary>
    public static class ScraperGenerator
    {
        /// <summary>
        /// The form factors that the SilkTouch Scraper runs in by default.
        /// </summary>
        public const FormFactors DefaultFormFactors = FormFactors.CLI;

        /// <summary>
        /// Runs the scraper.
        /// </summary>
        /// <param name="ctx">The SilkTouch Context to generate into.</param>
        /// <typeparam name="T">The subagent spawner to use.</typeparam>
        public static async Task RunAsync<T>(SilkTouchContext ctx) where T:ISubagent
        {
            var configuration = ctx.ServiceProvider.GetService<IOptions<ScraperConfiguration>>();
            ISubagent subagentSpawner = ActivatorUtilities.CreateInstance<T>(ctx.ServiceProvider);
            await Task.WhenAll((configuration?.Value.Jobs?.Select
                ((x, i) => (x, i)) ?? Enumerable.Empty<(ScraperJobConfiguration, int)>()).Select
                (x => RunAsync(ctx, subagentSpawner, x.x, x.i)));
        }

        private static async Task RunAsync
        (
            SilkTouchContext ctx,
            ISubagent subagent,
            ScraperJobConfiguration job,
            int jobNumber
        )
        {
            var logger = ctx.ServiceProvider.GetRequiredService<ILoggerFactory>().CreateLogger(nameof(RunAsync) + "_" + jobNumber);
            var configuration = ctx.ServiceProvider.GetService<IOptions<GlobalConfiguration>>();
            // initial validation
            var error = false;
            var libraryNames = job.LibraryNames;
            if (libraryNames is not { Length: > 1 })
            {
                ctx.EmitDiagnostic(Diagnostic.Create(Diagnostics.NoLibraryName, Location.None, jobNumber));
                error = true;
            }

            if (job.HeaderText is null)
            {
                ctx.EmitDiagnostic(Diagnostic.Create(Diagnostics.NoHeaderText, Location.None, jobNumber));
                error = true;
            }

            // if the config is bad, quit now.
            if (error)
            {
                return;
            }

            // write some data to the disk for the subagent to see
            var workFolder = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            var @in = Path.Combine(workFolder, "in.h");
            var @out = Path.Combine(workFolder, "out.xml");
            string? licenseHeaderFile = null;
            Directory.CreateDirectory(workFolder);
            File.WriteAllLines(@in, job.HeaderText ?? Array.Empty<string>());
            if (configuration?.Value.FileHeaderLines is not null)
            {
                licenseHeaderFile = Path.Combine(workFolder, "licenseHeader.txt");
                await File.WriteAllLinesAsync(licenseHeaderFile, configuration.Value.FileHeaderLines);
            }
            
            // format our includes. this allows both relative paths like "../" which resolve relative to the
            // "base directory" i.e. the directory in which the config JSON is stored, and SDK names like "win-sdk"
            VisualStudioResolver.TryGetVisualStudioInfo(out var vs);
            var includes = job.IncludeDirectories?.ToList() ?? new();
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
                            Diagnostic.Create(Diagnostics.NoWindowsSdk, Location.None, "win-sdk", jobNumber)
                        );

                        continue;
                    }

                    includes.InsertRange(i, vs.UcrtIncludes);
                }
                else
                {
                    includes[i] = Path.GetFullPath(include, ctx.BaseDirectory);
                }
            }
            
            // format our traversals. this will allow globbing relative to the "base directory".
            var globber = new Matcher();
            for (var i = 0; i < (job.Traverse?.Length ?? 0); i++)
            {
                var traversal = job.Traverse![i];
                if (traversal[0] == '!')
                {
                    globber.AddExclude(traversal[1..]);
                }
                else
                {
                    globber.AddInclude(traversal);
                }
            }

            var traversals = globber.Execute(new DirectoryInfoWrapper(new(ctx.BaseDirectory))).Files
                .Select(x => Path.GetFullPath(x.Path.Replace('\\', '/'), ctx.BaseDirectory))
                .ToArray();

            logger.LogDebug("Using work folder \"{WorkFolder}\"", workFolder);
            logger.LogInformation("Starting ClangSharp subagent for \"{AssemblyName}\"", ctx.AssemblyName);
            var options = new SubagentOptions
            (
                @in,
                "__SILKTOUCH", // TODO replace this in transformation
                job.Namespace ?? ctx.AssemblyName,
                @out,
                workFolder,
                includes.ToArray(),
                PInvokeGeneratorOutputMode.Xml,
                SubagentUtils.GetOptions
                (
                    job.Exclude?.Hints ?? ExclusionHint.None,
                    job.UnixMode ?? !OperatingSystem.IsWindows()
                ),
                job.Language ?? "c++",
                job.Standard ?? "c++17",
                job.AdditionalClangArguments,
                job.DefineMacros,
                job.Exclude?.Identifiers,
                licenseHeaderFile,
                job.ClassName ?? "Interop",
                job.MethodPrefixToStrip,
                await OpenRemappingFilesAsync(job.RemappingFiles, ctx.BaseDirectory),
                traversals,
                WithAttributes: null, // will be done by mods TODO do attributes in the mods
                job.CallingConventions,
                WithLibraryPaths: null, // again, library path stuff is done in transformation
                WithSetLastErrors: null, // the current design of SilkTouch doesn't support SetLastError
                null, // currently no need to support enum type overrides
                null, // the scraper will add predefined using directives during transformation
                Debugger.IsAttached
            );

            var clangSharpErrors = new List<string>();
            var exitCode = await subagent.RunClangSharpAsync(options, clangSharpErrors);

            if (exitCode != 0)
            {
                ctx.EmitDiagnostic(Diagnostic.Create(Diagnostics.ClangSharpNonZeroExitCode, Location.None, exitCode));
                foreach (var theError in clangSharpErrors)
                {
                    ctx.EmitDiagnostic(Diagnostic.Create(Diagnostics.ClangSharpError, Location.None, theError));
                }

                return;
            }
            
            logger.LogTrace("Job done");
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
