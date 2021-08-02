// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Silk.NET.SilkTouch.Scraper.Subagent;

namespace SilkTouch
{
    /// <summary>
    /// Spawns ClangSharp in a subprocess. This allows for parallelism (Clang doesn't like threads)
    /// </summary>
    internal class CommandLineSubagentSpawner : ISubagentSpawner
    {
        /// <inheritdoc />
        public async Task<int> RunClangSharpAsync(SubagentOptions opts)
        {
            // get the command line arguments this process was started with
            // using ArraySegment (lesser span) here instead of Span because it's enumerable.
            ArraySegment<string> args = Environment.GetCommandLineArgs();
            
            // trim off the arguments *we* received
            args = args[..^Program.Args.Length];

            // serialize the options and escape the quotes to send on the command line.
            var optsStr = JsonSerializer.Serialize(opts).Replace("\"", "\\\"");
            
            // the remainder is what we use to start the subprocesses.
            using var proc = new Process
            {
                StartInfo = new
                (
                    args[0],
                    $"\"{string.Join("\" \"", args[1..].Select(x => x.Replace("\"", "\\\"")))}\" \"{optsStr}\""
                )
                {
                    WorkingDirectory = Environment.CurrentDirectory
                }
            };

            if (!proc.Start())
            {
                return 3;
            }

            // run the subprocess.
            await proc.WaitForExitAsync();
            return proc.ExitCode;
        }
    }
}
