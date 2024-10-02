// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Threading;
using System.Threading.Tasks;

namespace Silk.NET.SilkTouch.Mods;

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
    /// Initialises the mod for the given job context.
    /// </summary>
    /// <param name="ctx">The generation job context.</param>
    void Initialize(IModContext ctx) { }

    /// <summary>
    /// Executes the mod as originally initialised for the given job context asynchronously.
    /// </summary>
    /// <param name="ctx">The generation job context.</param>
    /// <param name="ct">Cancellation token.</param>
    /// <returns>An asynchronous task.</returns>
    /// <remarks>
    /// Always preceded by <see cref="Initialize"/>.
    /// </remarks>
    Task ExecuteAsync(IModContext ctx, CancellationToken ct = default);
}
