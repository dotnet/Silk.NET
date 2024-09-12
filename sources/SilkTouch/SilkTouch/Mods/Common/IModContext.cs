// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// An interface into the mod pipeline for mod execution.
/// </summary>
public interface IModContext
{
    /// <summary>
    /// The current job key.
    /// </summary>
    string JobKey { get; }

    /// <summary>
    /// Denotes this mod as producing artifacts of the given type.
    /// </summary>
    /// <param name="allowedModes">The modes allowed to be used for this artifact.</param>
    /// <typeparam name="T">The type of the artifacts.</typeparam>
    /// <remarks>
    /// This method should be used if <see cref="AddArtifacts{T}"/> is not called prior to the enumeration of artifacts
    /// added using <see cref="AddArtifacts{T}"/>. <see cref="AddArtifacts{T}"/> does enact the behaviour of this
    /// function implicitly provided that it is called before <see cref="IMod.Initialize"/> exits.
    /// </remarks>
    void ProducesArtifacts<T>(
        ModArtifactAccess allowedModes =
            ModArtifactAccess.Exclusive | ModArtifactAccess.Shared | ModArtifactAccess.Take
    );

    /// <summary>
    /// Denotes this mod as receiving artifacts of the given type.
    /// </summary>
    /// <param name="accessMode">The mode with which the artifacts shall be accessed.</param>
    /// <typeparam name="T">The type of the artifacts.</typeparam>
    /// <remarks>
    /// This method should be used if <see cref="GetArtifacts{T}"/> is not called prior to the enumeration of artifacts
    /// added using <see cref="AddArtifacts{T}"/>. <see cref="GetArtifacts{T}"/> does enact the behaviour of this
    /// function implicitly provided that it is called before <see cref="IMod.Initialize"/> exits.
    /// </remarks>
    void ReceivesArtifacts<T>(ModArtifactAccess accessMode);

    /// <summary>
    /// Gets the artifacts of the given type from previous mods in the pipeline.
    /// </summary>
    /// <typeparam name="T">The type of the artifacts.</typeparam>
    /// <returns>The artifacts.</returns>
    /// <remarks>
    /// This should be called within <see cref="IMod.Initialize"/>, but should be enumerated as part of the evaluation
    /// of <see cref="AddArtifacts{T}"/>. Calling this and using the result either in a LINQ method chain or async
    /// generator (i.e. <c>yield</c>) should be sufficient. If this is not achievable, use
    /// <see cref="ReceivesArtifacts{T}"/>.
    /// </remarks>
    IAsyncEnumerable<T> GetArtifacts<T>(ModArtifactAccess accessMode);

    /// <summary>
    /// Adds the given artifacts to the pipeline.
    /// </summary>
    /// <param name="artifacts">The artifacts</param>
    /// <param name="allowedModes">
    /// The allowable modes with which the artifacts can be accessed. This is used to determine the concurrent flow of
    /// artifacts through the pipeline. Generally this is expected to be consistent for any given artifact type, and
    /// should reflect whether the artifact is stateful or not (i.e. stateful/mutable artifacts should use
    /// <see cref="ModArtifactAccess.Exclusive"/> or <see cref="ModArtifactAccess.Take"/>, whereas immutable artifacts
    /// should use <see cref="ModArtifactAccess.Shared"/> or <see cref="ModArtifactAccess.Take"/>). This is simply used
    /// for validation of calls to <see cref="GetArtifacts{T}"/>/<see cref="ReceivesArtifacts{T}"/>.
    /// </param>
    /// <typeparam name="T">The type of the artifacts.</typeparam>
    void AddArtifacts<T>(
        IAsyncEnumerable<T> artifacts,
        ModArtifactAccess allowedModes =
            ModArtifactAccess.Exclusive | ModArtifactAccess.Shared | ModArtifactAccess.Take
    );
}
