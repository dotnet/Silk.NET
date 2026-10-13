// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using Autofac;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Mods.Transformation;
using Silk.NET.SilkTouch.Sources;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch;

/// <summary>
/// Represents an individual SilkTouch bindings generation job.
/// </summary>
internal class SilkTouchJob : IDisposable
{
    private readonly ILifetimeScope _container;

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
    /// Gets the loaded mods for this generator instance.
    /// </summary>
    public IReadOnlyList<IMod> Mods { get; }

    /// <summary>
    /// Creates a new <see cref="SilkTouchJob"/>.
    /// </summary>
    /// <param name="key">The job key.</param>
    /// <param name="config">The job config.</param>
    /// <param name="parentContainer">The parent container. Should be the one from the <see cref="SilkTouchHost"/>.</param>
    /// <param name="configure">
    /// The action that configures the dependency container used by this job.
    /// You'll want to register SilkTouch mods during this action. See <see cref="SilkTouchRegistrationExtensions"/>.
    /// </param>
    public SilkTouchJob(
        string key,
        SilkTouchConfiguration config,
        ILifetimeScope parentContainer,
        Action<ContainerBuilder> configure
    )
    {
        Key = key;
        Config = config;

        _logger = parentContainer.Resolve<ILogger<SilkTouchJob>>();
        _inputResolver = parentContainer.Resolve<IInputResolver>();
        _container = parentContainer.BeginLifetimeScope(builder =>
        {
            // Register default dependencies
            builder.RegisterType<DocumentFactory>().SingleInstance();
            builder.RegisterType<FunctionTransformer>().SingleInstance();

            // Register user defined dependencies
            configure.Invoke(builder);
        });

        _modContextFactory = _container.Resolve<IModContextFactory>();
        _documentFactory = _container.Resolve<DocumentFactory>();
        Mods = _container.Resolve<IMod[]>();
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
        var context = await _modContextFactory.CreateContextAsync(Key, Config, ct);

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
            await mod.InitializeAsync(context, ct);
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
            await mod.ExecuteAsync(context, ct);
        }

        // Manually dispose so that we don't do this when generation fails (await using is too clever).
        await context.DisposeAsync();

        // Output the generated bindings
        _logger.LogInformation(
            "Bindings generation for {} completed in {} seconds.",
            Key,
            sw.Elapsed.TotalSeconds
        );
    }

    // TODO: Why is this here?
    internal static string GetLongestCommonPrefix(string[] s)
    {
        var k = s[0].Length;
        for (var i = 1; i < s.Length; i++)
        {
            k = Math.Min(k, s[i].Length);
            for (var j = 0; j < k; j++)
            {
                if (s[i][j] == s[0][j])
                {
                    continue;
                }

                k = j;
                break;
            }
        }

        return s[0][..k];
    }

    internal static string GetLongestCommonPath(IEnumerable<string> s)
    {
        var ret = GetLongestCommonPrefix(
            s.Select(x => Path.GetFullPath(x.Replace('\\', '/').TrimEnd('/'))).ToArray()
        );
        Debug.Assert(Directory.Exists(ret));
        return ret;
    }

    /// <inheritdoc />
    public void Dispose() => _container.Dispose();
}
