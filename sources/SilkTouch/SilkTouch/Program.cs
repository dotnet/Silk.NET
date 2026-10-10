// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.CommandLine;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Build.Locator;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Silk.NET.SilkTouch.Caching;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods.Bakery;
using Silk.NET.SilkTouch.Mods.Transformation;
using Silk.NET.SilkTouch.Sources;

namespace Silk.NET.SilkTouch;

internal static class Program
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
        new(["--only", "-o"], Array.Empty<string>)
        {
            Description = "A list of job names to run.",
            Arity = ArgumentArity.ZeroOrMore,
        };

    private static Option<int> JobsOption { get; } =
        new(["--max-jobs", "-j"], () => Environment.ProcessorCount)
        {
            Description = "Maximum number of parallel jobs.",
        };

    public static async Task Main(string[] args)
    {
        var rootCommand = new RootCommand { LoggingOption, SkipOption, OnlyOption, JobsOption };

        rootCommand.SetHandler(async ctx =>
        {
            // Register MSBuild
            MSBuildLocator.RegisterDefaults();

            ILifetimeScope container;
            {
                var services = new ServiceCollection()
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
                    .AddOptions();

                // TODO: Cleanup. Probably move into a SilkTouchHost class.
                {
                    services.AddSingleton<ResponseFileHandler>();
                    services.AddSingleton<FunctionTransformer>();
                    services.AddSingleton<DefaultBakeStrategy>();
                    services.AddSingleton<IBakeStrategy>(s =>
                        s.GetRequiredService<DefaultBakeStrategy>()
                    );
                    services.TryAddSingleton<ICacheProvider, FileSystemCacheProvider>();
                    services.AddSingleton<IInputSource, GitInputSource>();
                    services.AddSingleton<IInputSource, NuGetInputSource>();
                    services.AddSingleton<IFunctionTransformer, PtrRefTransformer>();
                    services.AddSingleton<IFunctionTransformer, BoolTransformer>();
                    services.AddSingleton<IFunctionTransformer, ArrayParameterTransformer>();
                    services.TryAddSingleton<IInputResolver, UriBasedInputResolver>();
                    if (OperatingSystem.IsWindows())
                    {
                        services.AddSingleton<IStdIncludeResolver, WindowsStdIncludeResolver>();
                    }
                    else if (OperatingSystem.IsMacOS())
                    {
                        services.AddSingleton<IStdIncludeResolver, MacOSStdIncludeResolver>();
                    }
                    else
                    {
                        services.AddSingleton<IStdIncludeResolver, UnixStdIncludeResolver>();
                    }
                }

                var builder = new ContainerBuilder();
                builder.Populate(services);

                container = builder.Build();
            }

            var jobsToRun = new HashSet<string>(
                ctx.ParseResult.GetValueForOption(OnlyOption) ?? [],
                StringComparer.OrdinalIgnoreCase
            );

            var jobsToSkip = new HashSet<string>(
                ctx.ParseResult.GetValueForOption(SkipOption) ?? [],
                StringComparer.OrdinalIgnoreCase
            );

            // TODO: Refactor as fluent builder
            var allJobs = new List<SilkTouchJob>()
            {
                new(
                    "Vulkan",
                    new SilkTouchConfiguration
                    {
                        Solution = "TODO", // TODO
                        SourceProject = "null",
                        TestProject = "null",
                        DefaultLicenseHeader = "null",
                    },
                    container,
                    builder => { }
                ),
            };

            await Parallel.ForEachAsync(
                allJobs.Where(job =>
                {
                    if (jobsToSkip.Contains(job.Key))
                    {
                        return false;
                    }

                    return jobsToRun.Count == 0 || jobsToRun.Contains(job.Key);
                }),
                async (job, ct) =>
                {
                    await job.RunAsync(
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
