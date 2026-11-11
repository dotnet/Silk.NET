// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Mods.Bakery;
using Silk.NET.SilkTouch.Mods.Transformation;
using Silk.NET.SilkTouch.Sources;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch;

/// <summary>
/// Represents an individual SilkTouch bindings generation job.
/// </summary>
internal class SilkTouchJob : IDisposable
{
    private readonly ILogger<SilkTouchJob> _logger;
    private readonly IInputResolver _inputResolver;
    private readonly IModContextFactory _modContextFactory;
    private readonly DocumentFactory _documentFactory;

    /// <summary>
    /// The job key.
    /// </summary>
    public string Key { get; }

    /// <summary>
    /// The job config.
    /// </summary>
    public SilkTouchConfiguration Config { get; private set; }

    /// <summary>
    /// Gets the loaded mods for this job.
    /// </summary>
    public IReadOnlyList<IMod> Mods { get; }

    /// <summary>
    /// The service provider for this job.
    /// </summary>
    public ServiceProvider Provider;

    /// <summary>
    /// Creates a new <see cref="SilkTouchJob"/>.
    /// </summary>
    /// <param name="key">The job key.</param>
    /// <param name="config">The job config.</param>
    /// <param name="configure">
    /// The action that configures the services used by this job.
    /// You'll want to register SilkTouch mods during this action. See <see cref="SilkTouchRegistrationExtensions"/>.
    /// </param>
    public SilkTouchJob(
        string key,
        SilkTouchConfiguration config,
        Action<IServiceCollection> configure
    )
    {
        Key = key;
        Config = config;

        var services = new ServiceCollection();
        {
            // Register default dependencies
            services.AddSingleton<DocumentFactory>();
            services.AddSingleton<FunctionTransformer>();
            services.AddSingleton<ResponseFileHandler>();
            services.AddSingleton<IBakeStrategy, DefaultBakeStrategy>();

            // Register user defined dependencies
            configure.Invoke(services);
        }

        Provider = services.BuildServiceProvider();
        _logger = Provider.GetRequiredService<ILogger<SilkTouchJob>>();
        _inputResolver = Provider.GetRequiredService<IInputResolver>();
        _modContextFactory = Provider.GetRequiredService<IModContextFactory>();
        _documentFactory = Provider.GetRequiredService<DocumentFactory>();
        Mods = Provider.GetRequiredService<IEnumerable<IMod>>().ToArray();
    }

    /// <summary>
    /// Generates binding syntax trees per the given configuration.
    /// </summary>
    public async Task RunAsync(CancellationToken ct = default)
    {
        var sw = Stopwatch.StartNew();

        // Resolve any relative paths in the job configuration.
        Config = await _inputResolver.Resolve(Config);

        // Prepare the context
        await using var context = await _modContextFactory.CreateContextAsync(Key, Config, ct);

        // Initialize the document factory
        _documentFactory.DefaultNamespace = Config.DefaultNamespace;
        if (Config.DefaultLicenseHeader != null)
        {
            _documentFactory.DefaultHeader = ParseLeadingTrivia(
                await File.ReadAllTextAsync(Config.DefaultLicenseHeader, ct)
            );
        }

        // Add commonly used namespaces
        _documentFactory.AddUsing("System.Runtime.CompilerServices");
        _documentFactory.AddUsing("System.Runtime.InteropServices");

        // Just in case a mod gets naughty and tries to modify at the initialization stage.
        var srcProj = context.SourceProject;
        var testProj = context.TestProject;

        // Initialize the mods
        foreach (var mod in Mods)
        {
            _logger.LogDebug("Using mod {0} for {1}", mod.GetType().Name, Key);
            try
            {
                await mod.InitializeAsync(context, ct);

                if (!context.ContinueGeneration)
                {
                    _logger.LogInformation(
                        "{Mod} requested an early exit for {Job}. Exiting...",
                        mod,
                        Key
                    );
                    break;
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error while initializing {Mod} for {Job}", mod, Key);
                throw;
            }

            if (context.SourceProject != srcProj || context.TestProject != testProj)
            {
                throw new InvalidOperationException(
                    $"{mod.GetType().Name} illegally generated code at the initialization stage."
                );
            }
        }

        foreach (var mod in Mods)
        {
            _logger.LogInformation("Executing {} for {}...", mod.GetType().Name, Key);
            try
            {
                await mod.ExecuteAsync(context, ct);

                if (!context.ContinueGeneration)
                {
                    _logger.LogInformation(
                        "{Mod} requested an early exit for {Job}. Exiting...",
                        mod,
                        Key
                    );
                    break;
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error while executing {Mod} for {Job}", mod, Key);
                throw;
            }
        }

        // Output the generated bindings
        if (context.ContinueGeneration)
        {
            await context.OutputBindingsAsync();
        }

        _logger.LogInformation(
            "Bindings generation for {} completed in {} seconds.",
            Key,
            sw.Elapsed.TotalSeconds
        );
    }

    /// <inheritdoc />
    public void Dispose() => Provider.Dispose();
}
