using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CommandLine;
using CommandLine.Text;
using Generator.Bind;
using Generator.Convert;
using Newtonsoft.Json;
using Silk.NET.BuildTools.Pipeline;

namespace Silk.NET.BuildTools
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Silk.NET Build Tools");
            Console.WriteLine($"(C) {DateTime.Now.Year} Ultz Limited");
            var sw = new Stopwatch();
            sw.Start();
            Switch(args);
            sw.Stop();
            Console.WriteLine();
            Console.WriteLine("Completed in {0} seconds.", sw.Elapsed.TotalSeconds);
        }

        static void Switch(string[] args)
        {
            switch (args[0].ToLower())
            {
                case "bind":
                    Binder.Bind(GetArgs<BindOptions>(args));
                    break;
                case "convert":
                    Converter.Convert(GetArgs<ConvertOptions>(args));
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
                foreach (var task in JsonConvert.DeserializeObject<PipelineTask[]>(File.ReadAllText(Path.GetFileName(args[0]))))
                {
                    Switch(new []{task.Task}.Concat(task.Args).ToArray());
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
