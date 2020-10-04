// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CommandLine;
using CommandLine.Text;
using MoreLinq;
using Newtonsoft.Json;
using Silk.NET.BuildTools.Baking;
using Silk.NET.BuildTools.Bind;
using Silk.NET.BuildTools.Converters;
using Silk.NET.BuildTools.Pipeline;

namespace Silk.NET.BuildTools
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Silk.NET Build Tools");
            Console.WriteLine($"(C) {DateTime.Now.Year} Ultz Limited");
            Console.WriteLine();
            var sw = new Stopwatch();
            sw.Start();
            Switch(args);
            sw.Stop();
            Console.WriteLine();
            Console.WriteLine("Completed in {0} seconds.", sw.Elapsed.TotalSeconds);
        }

        private static void Switch(string[] args)
        {
            switch (args[0].ToLower())
            {
                case "bind":
                    Binder.Bind(GetArgs<BindOptions>(args));
                    break;
                case "convert":
                    ProfileConverter.WriteProfiles(GetArgs<CommandLineOptions>(args));
                    break;
                case "bake":
                    ProfileBakery.Bake(GetArgs<BakeryOptions>(args));
                    break;
                case "clean":
                    Directory.GetFiles(args[1], "*.gen.cs", SearchOption.AllDirectories).ForEach(File.Delete);
                    break;
                default:
                    PipelineFile(args);
                    break;
            }
        }

        private static void PipelineFile(string[] args)
        {
            if (File.Exists(args[0]))
            {
                Environment.CurrentDirectory = Path.GetDirectoryName(args[0]);
                var tasks = JsonConvert.DeserializeObject<PipelineTask[]>
                    (File.ReadAllText(Path.GetFileName(args[0])));
                for (var index = 0; index < tasks.Length; index++)
                {
                    var task = tasks[index];
                    Console.WriteLine($"Starting task \"{task.Task}\" ({index})...");
                    Switch(new[] { task.Task }.Concat(task.Args).ToArray());
                    Console.WriteLine("Task completed successfully.");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        private static T GetArgs<T>(IEnumerable<string> args)
        {
            object val = null;
            var parserResult = new Parser(x => x.HelpWriter = TextWriter.Null).ParseArguments<T>(args);
            parserResult.WithParsed(result => val = result);
            parserResult.WithNotParsed
            (
                errs =>
                {
                    var helpText = HelpText.AutoBuild
                        (parserResult, h => HelpText.DefaultParsingErrorsHandler(parserResult, h), e => e);
                    helpText.Copyright = string.Empty;
                    helpText.Heading = string.Empty;
                    Console.WriteLine(helpText);
                    Environment.Exit(-1);
                }
            );
            return (T) val;
        }
    }
}
