using System;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Build.Locator;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using SilkTouchX;

var logging = new Option<LogLevel>(new[] { "--log-level", "-l" }, () => LogLevel.Information);
var skip = new Option<string[]>(
    new[] { "--skip", "-s" },
    Array.Empty<string>,
    "A list of job names to skip."
)
{
    Arity = ArgumentArity.ZeroOrMore
};
var configs = new Argument<string[]>("configs", "Path(s) to JSON SilkTouch configuration(s)")
{
    Arity = ArgumentArity.OneOrMore
};
var configOverrides = new Argument<string[]>(
    "overrides",
    Array.Empty<string>,
    "Arguments recognisable by Microsoft.Extensions.Configuration.CommandLine to override JSON configuration items."
)
{
    Arity = ArgumentArity.ZeroOrMore
};
var rootCommand = new RootCommand { logging, skip, configs, configOverrides };
rootCommand.SetHandler(async ctx =>
{
    // Create the ConfigurationBuilder with support for env var & command line overrides
    var cb = new ConfigurationBuilder()
        .AddEnvironmentVariables(source => source.Prefix = "SILKDOTNET_")
        .AddCommandLine(ctx.ParseResult.GetValueForArgument(configOverrides));

    // Add the JSON files to the ConfigurationBuilder
    cb = ctx.ParseResult
        .GetValueForArgument(configs)
        .Aggregate(cb, (current, file) => current.AddJsonFile(Path.GetFullPath(file)));
    var config = cb.Build();

    // Register MSBuild
    MSBuildLocator.RegisterDefaults();

    var sp = new ServiceCollection()
        .AddLogging(builder =>
        {
            builder.AddSimpleConsole(opts =>
            {
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
        async (job, ct) =>
        {
            var generator = sp.GetRequiredService<SilkTouchGenerator>();
            await generator.OutputBindingsAsync(
                job.Key,
                job.Get<SilkTouchConfiguration>()
                    ?? throw new InvalidOperationException("failed to bind configuration"),
                ct
            );
        }
    );
});

await rootCommand.InvokeAsync(args);
