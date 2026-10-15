// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.CommandLine;
using System.CommandLine.Invocation;
using System.Diagnostics.CodeAnalysis;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Build.Locator;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Silk.NET.SilkTouch.Caching;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Mods.Bakery;
using Silk.NET.SilkTouch.Sources;

namespace Silk.NET.SilkTouch;

/// <summary>
/// The main entrypoint for the SilkTouch bindings generator.
/// </summary>
public class SilkTouchHost
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

    private readonly Dictionary<string, JobDefinition> _jobDefinitions = [];

    private SilkTouchHost() { }

    /// <summary>
    /// Creates a new <see cref="SilkTouchHost"/>.
    /// </summary>
    public static SilkTouchHost Create() => new();

    /// <summary>
    /// Defines a SilkTouch bindings generation job.
    /// </summary>
    public SilkTouchHost DefineJob(
        string key,
        SilkTouchConfiguration config,
        Action<SilkTouchRegistrationExtensions.SilkTouchRegistrationContext> configure
    )
    {
        _jobDefinitions.Add(key, new JobDefinition(config, configure));
        return this;
    }

    /// <summary>
    /// Runs the <see cref="SilkTouchHost"/> with the provided CLI arguments.
    /// </summary>
    public async Task RunAsync(string[] args)
    {
        var rootCommand = new RootCommand { LoggingOption, SkipOption, OnlyOption, JobsOption };

        rootCommand.SetHandler(async ctx =>
        {
            try
            {
                // Register MSBuild
                MSBuildLocator.RegisterDefaults();

                // Build container
                var builder = new ContainerBuilder();
                Configure(builder, ctx);
                await using ILifetimeScope container = builder.Build();

                var jobKeysToRun = new HashSet<string>(
                    ctx.ParseResult.GetValueForOption(OnlyOption) ?? [],
                    StringComparer.OrdinalIgnoreCase
                );

                var jobKeysToSkip = new HashSet<string>(
                    ctx.ParseResult.GetValueForOption(SkipOption) ?? [],
                    StringComparer.OrdinalIgnoreCase
                );

                var jobsToRun = _jobDefinitions.Where(job =>
                {
                    if (jobKeysToSkip.Contains(job.Key))
                    {
                        return false;
                    }

                    return jobKeysToRun.Count == 0 || jobKeysToRun.Contains(job.Key);
                });

                var logger = container.Resolve<ILogger<SilkTouchHost>>();
                try
                {
                    await Parallel.ForEachAsync(
                        jobsToRun,
                        new ParallelOptions
                        {
                            MaxDegreeOfParallelism = ctx.ParseResult.GetValueForOption(JobsOption),
                        },
                        async (jobKvp, ct) =>
                        {
                            using var job = new SilkTouchJob(
                                jobKvp.Key,
                                jobKvp.Value.Config,
                                container,
                                builder => jobKvp.Value.Configure.Invoke(builder.SilkTouch())
                            );

                            await job.RunAsync(ct);
                        }
                    );
                }
                catch (Exception e)
                {
                    logger.LogError(e, "Error occurred while running SilkTouch");
                    throw;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Exit(1);
            }

            Exit(0);
        });

        await rootCommand.InvokeAsync(args);
    }

    [DoesNotReturn]
    private static void Exit(int exitCode) =>
        // Workaround for dangling logging/socket engine threads
        Environment.Exit(exitCode);

    /// <summary>
    /// Dependencies defined here will be shared by all jobs.
    /// </summary>
    private void Configure(ContainerBuilder builder, InvocationContext ctx)
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

        builder.Populate(services);

        {
            builder
                .RegisterType<MSBuildModContextFactory>()
                .As<IModContextFactory>()
                .SingleInstance();

            builder.RegisterType<ResponseFileHandler>().SingleInstance();

            builder
                .RegisterType<DefaultBakeStrategy>()
                .AsSelf()
                .AsImplementedInterfaces()
                .SingleInstance();

            builder.RegisterType<FileSystemCacheProvider>().As<ICacheProvider>().SingleInstance();

            builder.RegisterType<GitInputSource>().As<IInputSource>().SingleInstance();

            builder.RegisterType<NuGetInputSource>().As<IInputSource>().SingleInstance();

            builder.RegisterType<UriBasedInputResolver>().As<IInputResolver>().SingleInstance();

            if (OperatingSystem.IsWindows())
            {
                builder
                    .RegisterType<WindowsStdIncludeResolver>()
                    .As<IStdIncludeResolver>()
                    .SingleInstance();
            }
            else if (OperatingSystem.IsMacOS())
            {
                builder
                    .RegisterType<MacOSStdIncludeResolver>()
                    .As<IStdIncludeResolver>()
                    .SingleInstance();
            }
            else
            {
                builder
                    .RegisterType<UnixStdIncludeResolver>()
                    .As<IStdIncludeResolver>()
                    .SingleInstance();
            }
        }
    }

    private record JobDefinition(
        SilkTouchConfiguration Config,
        Action<SilkTouchRegistrationExtensions.SilkTouchRegistrationContext> Configure
    );
}
