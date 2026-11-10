// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.CommandLine;
using System.CommandLine.Invocation;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Build.Locator;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Silk.NET.SilkTouch.Caching;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods;
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

    private static Option<bool> UseCacheOnlyOption { get; } =
        new(["--use-cache-only"], () => false)
        {
            Description = "Limits the generator to only using the cache.",
        };

    private static Option<bool> GenerateCacheOnlyOption { get; } =
        new(["--generate-cache-only"], () => false)
        {
            Description = "Limits the generator to only generating the cache.",
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
        var rootCommand = new RootCommand
        {
            LoggingOption,
            SkipOption,
            OnlyOption,
            JobsOption,
            UseCacheOnlyOption,
            GenerateCacheOnlyOption,
        };

        rootCommand.SetHandler(async ctx =>
        {
            try
            {
                // Register MSBuild
                MSBuildLocator.RegisterDefaults();

                // Build service provider
                var services = new ServiceCollection();
                Configure(services, ctx);
                await using var provider = services.BuildServiceProvider();

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

                var logger = provider.GetRequiredService<ILogger<SilkTouchHost>>();
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
                                services =>
                                {
                                    ConfigureForward(provider, services);
                                    jobKvp.Value.Configure.Invoke(services.SilkTouch());
                                }
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
    /// Dependencies defined here are only accessible to the host.
    /// Make them available to the jobs by using <see cref="ConfigureForward"/>.
    /// </summary>
    private void Configure(IServiceCollection services, InvocationContext ctx)
    {
        services
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

        {
            // Create config
            var config = new SilkTouchHostConfiguration()
            {
                UseCacheOnly = ctx.ParseResult.GetValueForOption(UseCacheOnlyOption),
                GenerateCacheOnly = ctx.ParseResult.GetValueForOption(GenerateCacheOnlyOption),
            };

            if (config.GenerateCacheOnly && config.UseCacheOnly)
            {
                throw new InvalidOperationException(
                    $"{UseCacheOnlyOption.Name} and {GenerateCacheOnlyOption.Name} cannot be enabled at the same time."
                );
            }

            services.AddSingleton(config);

            services.AddSingleton<IModContextFactory, MSBuildModContextFactory>();
            services.AddSingleton<ICacheProvider, FileSystemCacheProvider>();
            services.AddSingleton<IInputSource, GitInputSource>();
            services.AddSingleton<IInputSource, NuGetInputSource>();
            services.AddSingleton<IInputResolver, UriBasedInputResolver>();

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
    }

    /// <summary>
    /// Dependencies defined here will be available to jobs.
    /// </summary>
    private void ConfigureForward(IServiceProvider host, IServiceCollection services)
    {
        // Prefer to match the registration order above
        services.AddSingleton(host.GetRequiredService<ILoggerFactory>());
        services.AddSingleton(typeof(ILogger<>), typeof(Logger<>));

        services.AddSingleton(host.GetRequiredService<SilkTouchHostConfiguration>());
        services.AddSingleton(host.GetRequiredService<IModContextFactory>());
        services.AddSingleton(host.GetRequiredService<ICacheProvider>());
        services.AddSingleton(host.GetRequiredService<IInputResolver>());
        services.AddSingleton(host.GetRequiredService<IStdIncludeResolver>());
    }

    private record JobDefinition(
        SilkTouchConfiguration Config,
        Action<SilkTouchRegistrationExtensions.SilkTouchRegistrationContext> Configure
    );
}
