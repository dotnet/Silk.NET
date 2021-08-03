using System;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Silk.NET.SilkTouch.Configuration;
using Silk.NET.SilkTouch.Generation;
using Silk.NET.SilkTouch.Scraper.Subagent;
using Ultz.Extensions.Logging;

namespace Silk.NET.SilkTouch.Scraper
{
    public static class ScraperGenerator
    {
        public const FormFactors DefaultFormFactors = FormFactors.CLI;
        public static void Run<T>(SilkTouchContext ctx) where T:ISubagentSpawner, new()
        {
            var subagentSpawner = new T();
            var error = false;
            var libraryNames = ctx.Configuration.Scraper?.LibraryNames;
            if ((libraryNames?.Length ?? 0) == 0)
            {
                ctx.EmitDiagnostic(Diagnostic.Create(Diagnostics.NoLibraryName, Location.None, ctx.AssemblyName));
                error = true;
            }

            if (error)
            {
                return;
            }

            var workFolder = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(workFolder);

            var includes = ctx.Configuration.Scraper?.IncludeDirectories?.ToList() ?? new();
            for (int i = 0; i < includes.Count; i++)
            {
                var include = includes[i];
                if (include == "win10-sdk")
                {
                    
                }
                else if (include.StartsWith("win10-sdk-"))
                {
                    
                }
            }

            Log.Information($"Starting ClangSharp subagent for \"{ctx.AssemblyName}\"...");
            var options = new SubagentOptions
            (
                libraryNames![0], // we know libraryNames isn't null here, but the compiler disagrees.
                ctx.Configuration.Scraper?.Namespace ?? ctx.AssemblyName,
                workFolder,
                workFolder,
            );
        }
    }
}
