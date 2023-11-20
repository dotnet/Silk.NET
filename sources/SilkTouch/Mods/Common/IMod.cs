using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SilkTouchX.Clang;

namespace SilkTouchX.Mods;

/// <summary>
/// Represents a "mod" - a type that will ingest ClangSharp configurations and the outputs from their configurations,
/// possibly adding modifications to either before and after it goes to ClangSharp. This is essentially to manipulate
/// the data flowing in and out of the ClangSharp P/Invoke Generator according to some external configuration without
/// having to modify the original response files.
/// </summary>
/// <remarks>
/// Each mod type is instantiated for each SilkTouch job to enable the safe storage of state.
/// </remarks>
public interface IMod
{
    /// <summary>
    /// Runs before SilkTouch does anything with the given job name and job configuration.
    /// </summary>
    /// <param name="key">The job name (corresponds to the configuration key for mod configs).</param>
    /// <param name="config">The job config.</param>
    /// <returns>An asynchronous task.</returns>
    Task BeforeJobAsync(string key, SilkTouchConfiguration config) => Task.CompletedTask;

    /// <summary>
    /// Runs before SilkTouch invokes ClangSharp with the given parsed response files. Gives each mod an opportunity to
    /// modify the generator configuration.
    /// </summary>
    /// <param name="key">The job name (corresponds to the configuration key for mod configs).</param>
    /// <param name="rsps">The read response files.</param>
    /// <returns>
    /// The modified response files to be passed into either the next mod or ClangSharp if this is the last mod.
    /// </returns>
    Task<List<ResponseFile>> BeforeScrapeAsync(string key, List<ResponseFile> rsps) =>
        Task.FromResult(rsps);

    /// <summary>
    /// Runs after SilkTouch has invoked ClangSharp which generated the given syntax nodes. Gives each mod an
    /// opportunity to mutate the syntax tree.
    /// </summary>
    /// <param name="key">The job name (corresponds to the configuration key for mod configs).</param>
    /// <param name="syntax">The generated output from ClangSharp (or the previous mod).</param>
    /// <returns>
    /// The modified syntax nodes to be either passed to the next mod or output from the generator if this is the last
    /// mod.
    /// </returns>
    Task<GeneratedSyntax> AfterScrapeAsync(string key, GeneratedSyntax syntax) =>
        Task.FromResult(syntax);

    /// <summary>
    /// Runs before SilkTouch is going to output the MSBuild workspace. The generated documents have already been added,
    /// so this gives the opportunity for the mod to modify the workspace further.
    /// </summary>
    /// <param name="key">The job name (corresponds to the configuration key for mod configs).</param>
    /// <param name="workspace">The generated output from scraping.</param>
    /// <returns>The modified MSBuild solution either to be output or passed to the next mod if applicable.</returns>
    Task<GeneratorWorkspace> BeforeOutputAsync(string key, GeneratorWorkspace workspace) =>
        Task.FromResult(workspace);

    /// <summary>
    /// Runs after all generation activities have completed. Gives each mod an opportunity to clean up its state for
    /// this job.
    /// </summary>
    /// <param name="key">The job name (corresponds to the configuration key for mod configs).</param>
    /// <returns>An asynchronous task.</returns>
    Task AfterJobAsync(string key) => Task.CompletedTask;
}
