// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Scraper.Subagent;

namespace SilkTouch
{
    /// <summary>
    /// Spawns ClangSharp in a subprocess. This allows for parallelism (Clang doesn't like threads)
    /// </summary>
    internal class ClangSharpSubagent : ISubagent
    {
        private readonly ILogger _logger;

        public ClangSharpSubagent(ILogger<ClangSharpSubagent> logger)
        {
            _logger = logger;
        }
        
        /// <inheritdoc />
        public async Task<int> RunClangSharpAsync(SubagentOptions opts, List<string>? errors = null)
        {
            // get the command line arguments this process was started with
            // using ArraySegment (lesser span) here instead of Span because it's enumerable.
            var execPath = typeof(ClangSharpHandoff).Assembly.Location;
            string candidate;
            
            // use the executable (.exe on windows, no extension on unix) if available, otherwise just launch dotnet
            execPath = Path.GetExtension(execPath) != ".dll"
                ? execPath
                : File.Exists(candidate = Path.GetFileNameWithoutExtension(execPath) + ".exe")
                    ? candidate
                    : File.Exists(candidate = candidate[..^4])
                        ? candidate
                        : "dotnet";

            // serialize the options and escape the quotes to send on the command line.
            var optsStr = JsonSerializer.Serialize(opts).Replace("\"", "\\\"");
            
            // the remainder is what we use to start the subprocesses.
            using var proc = new Process
            {
                StartInfo = new
                (
                    execPath,
                    execPath == "dotnet"
                        ? $"\"{typeof(ClangSharpHandoff).Assembly.Location}\" clangsharp \"{optsStr}\""
                        : $"clangsharp \"{optsStr}\""
                )
                {
                    WorkingDirectory = Environment.CurrentDirectory,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            
            // get the env vars of a developer command prompt if we can
            if (!Program.NoEnvironmentEmulation && VisualStudioResolver.TryGetVisualStudioInfo(out var vsInfo))
            {
                foreach (var (k, v) in vsInfo.Variables)
                {
                    proc.StartInfo.Environment[k] = v;
                }
            }
            
            _logger.LogTrace("Running command \"{FileName}\" {Arguments}", proc.StartInfo.FileName, proc.StartInfo.Arguments);

            // run the subprocess.
            if (!proc.Start())
            {
                return (int) ExitCodes.SubagentFailedToStart;
            }

            // log its logs to the log
            while (!proc.StandardOutput.EndOfStream)
            {
                var line = await proc.StandardOutput.ReadLineAsync();
                if (line is null)
                {
                    continue;
                }

                var level = line[..2] switch
                {
                    "I:" => LogLevel.Information,
                    "W:" => LogLevel.Warning,
                    "T:" => LogLevel.Trace,
                    "E:" => LogLevel.Error,
                    _ => LogLevel.Debug
                };
                
                _logger.Log(level, "{Namespace}: {Message}", opts.NamespaceName, line[2..]);
            }
            
            await proc.WaitForExitAsync();
            return proc.ExitCode;
        }
    }
}
