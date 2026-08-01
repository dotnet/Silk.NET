using System.CommandLine;
using Microsoft.Build.Locator;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Silk.NET.SilkTouch.Caching;

namespace Silk.NET.SilkTouch;

internal class Program
{
    private static Option<LogLevel> LoggingOption { get; } =
        new(["--log-level", "-l"], () => LogLevel.Information);

    private static Option<string[]> SkipOption { get; } =
        new(["--skip", "-s"], Array.Empty<string>)
        {
            Description = "A list of job names to skip. Takes precedence over --only.",
            Arity = ArgumentArity.ZeroOrMore,
        };

    private static Option<string[]> OnlyOption { get; } =
        new(new[] { "--only", "-o" }, Array.Empty<string>)
        {
            Description = "A list of job names to run.",
            Arity = ArgumentArity.ZeroOrMore,
        };

    private static Argument<string[]> ConfigsArgument { get; } =
        new("configs")
        {
            Description = "Path(s) to JSON SilkTouch configuration(s)",
            Arity = ArgumentArity.OneOrMore,
        };

    private static Argument<string[]> ConfigOverridesArgument { get; } =
        new("overrides", Array.Empty<string>)
        {
            Description =
                "Arguments recognisable by Microsoft.Extensions.Configuration.CommandLine to override JSON configuration items.",
            Arity = ArgumentArity.ZeroOrMore,
        };

    private static Option<int> JobsOption { get; } =
        new(new[] { "--max-jobs", "-j" }, () => Environment.ProcessorCount)
        {
            Description = "Maximum number of parallel ClangSharp executions.",
        };

    public static async Task Main(string[] args)
    {
        var rootCommand = new RootCommand
        {
            LoggingOption,
            SkipOption,
            OnlyOption,
            ConfigsArgument,
            ConfigOverridesArgument,
            JobsOption,
        };

        rootCommand.SetHandler(async ctx =>
        {
            // Create the ConfigurationBuilder with support for env var & command line overrides
            var cb = new ConfigurationBuilder()
                .AddEnvironmentVariables(source => source.Prefix = "SILKDOTNET_")
                .AddCommandLine(ctx.ParseResult.GetValueForArgument(ConfigOverridesArgument));

            // Add the JSON files to the ConfigurationBuilder
            var jsons = ctx.ParseResult.GetValueForArgument(ConfigsArgument);
            cb = jsons.Aggregate(
                cb,
                (current, file) => current.AddJsonFile(Path.GetFullPath(file))
            );
            var config = cb.Build();
            if (jsons.Length == 1)
            {
                FileSystemCacheProvider.CommonDir = Path.GetFullPath(
                    (Path.GetDirectoryName(jsons[0]) is (null or not "") and var path ? path : ".")
                        ?? Environment.CurrentDirectory
                );
            }

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
                    builder.SetMinimumLevel(ctx.ParseResult.GetValueForOption(LoggingOption));
                })
                .AddOptions()
                .AddSilkTouch(config)
                .BuildServiceProvider();

            var jobsToRun = new HashSet<string>(
                ctx.ParseResult.GetValueForOption(OnlyOption) ?? [],
                StringComparer.OrdinalIgnoreCase
            );

            var jobsToSkip = new HashSet<string>(
                ctx.ParseResult.GetValueForOption(SkipOption) ?? [],
                StringComparer.OrdinalIgnoreCase
            );

            var logger = sp.GetRequiredService<ILogger<Program>>();
            var generator = sp.GetRequiredService<SilkTouchGenerator>();

            await Parallel.ForEachAsync(
                config
                    .GetSection("Jobs")
                    .GetChildren()
                    .Where(section =>
                    {
                        if (jobsToSkip.Contains(section.Key))
                        {
                            return false;
                        }

                        return jobsToRun.Count == 0 || jobsToRun.Contains(section.Key);
                    }),
                async (job, ct) =>
                {
                    await generator.RunAsync(
                        job.Key,
                        job,
                        // TODO parallelism configuration
                        // ctx.ParseResult.GetValueForOption(jobs),
                        ct
                    );
                }
            );

            // Workaround for dangling logging/socket engine threads
            Environment.Exit(0);
        });

        await rootCommand.InvokeAsync(args);
    }
}
