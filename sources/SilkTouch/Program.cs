using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Build.Locator;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Silk.NET.SilkTouch;
using Silk.NET.SilkTouch.Caching;

var logging = new Option<LogLevel>(new[] { "--log-level", "-l" }, () => LogLevel.Information);
var skip = new Option<string[]>(
    new[] { "--skip", "-s" },
    Array.Empty<string>,
    "A list of job names to skip."
) { Arity = ArgumentArity.ZeroOrMore };
var configs =
    new Argument<string[]>("configs", "Path(s) to JSON SilkTouch configuration(s)") { Arity = ArgumentArity.OneOrMore };
var configOverrides = new Argument<string[]>(
    "overrides",
    Array.Empty<string>,
    "Arguments recognisable by Microsoft.Extensions.Configuration.CommandLine to override JSON configuration items."
) { Arity = ArgumentArity.ZeroOrMore };
var jobs = new Option<int>(new[] { "--max-jobs", "-j" }, () => Environment.ProcessorCount,
    "Maximum number of parallel ClangSharp executions.");
var rootCommand = new RootCommand {
    logging,
    skip,
    configs,
    configOverrides,
    jobs
};
rootCommand.SetHandler(async ctx => {
    // Create the ConfigurationBuilder with support for env var & command line overrides
    var cb = new ConfigurationBuilder()
        .AddEnvironmentVariables(source => source.Prefix = "SILKDOTNET_")
        .AddCommandLine(ctx.ParseResult.GetValueForArgument(configOverrides));

    // Add the JSON files to the ConfigurationBuilder
    var jsons = ctx.ParseResult
        .GetValueForArgument(configs);
    cb = jsons.Aggregate(cb, (current, file) => current.AddJsonFile(Path.GetFullPath(file)));
    var config = cb.Build();
    if (jsons.Length == 1)
    {
        FileSystemCacheProvider.CommonDir = Path.GetFullPath(
            (Path.GetDirectoryName(jsons[0]) is (null or not "") and var path ? path : ".") ?? Environment.CurrentDirectory);
    }

    // Register MSBuild
    MSBuildLocator.RegisterDefaults();

    var sp = new ServiceCollection()
        .AddLogging(builder => {
            builder.AddSimpleConsole(opts => {
                opts.SingleLine = true;
                opts.ColorBehavior = Console.IsOutputRedirected
                    ? LoggerColorBehavior.Disabled
                    : LoggerColorBehavior.Default;
                opts.IncludeScopes = false;
            });
            builder.SetMinimumLevel(ctx.ParseResult.GetValueForOption(logging));
        })
        .AddOptions()
        .AddSilkTouch(config)
        .BuildServiceProvider();

    var skipped = ctx.ParseResult.GetValueForOption(skip);
    await Parallel.ForEachAsync(
        config
            .GetSection("Jobs")
            .GetChildren()
            .Where(
                x => skipped?.All(y => !x.Key.Equals(y, StringComparison.OrdinalIgnoreCase)) ?? true
            ),
        async (job, ct) => {
            var generator = sp.GetRequiredService<SilkTouchGenerator>();
            await generator.OutputBindingsAsync(
                job.Key,
                config,
                ctx.ParseResult.GetValueForOption(jobs),
                ct
            );
        }
    );
});

await rootCommand.InvokeAsync(args);
