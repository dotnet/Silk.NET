// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace Silk.NET.Windowing;

/// <summary>
/// Represents a surface with a user-controlled lifecycle.
/// </summary>
/// <remarks>
/// This API is <b>not guaranteed to be supported</b> on all platforms and you should only use it if you know what
/// you're doing and know you need the granular control this API provides! Please use
/// <see cref="ISurfaceApplication.Run{T}" /> instead where possible. If you insist on using this API, please fall back
/// to <see cref="ISurfaceApplication.Run{T}" /> if <see cref="TryCreate{T}" /> returns <c>false</c> indicating a lack
/// of support.
/// </remarks>
public interface IDetachedSurfaceLifecycle : IDisposable
{
    /// <summary>
    /// Gets the surface with which this lifecycle is associated. The destruction of this surface is handled by
    /// the <see cref="IDisposable.Dispose" /> method of this <see cref="IDetachedSurfaceLifecycle" /> implementation.
    /// </summary>
    Surface Surface { get; }

    /// <summary>
    /// Gets a value indicating whether the surface is indicating that its lifecycle should conclude as a result of
    /// its current configuration e.g. an entire tick passing with <see cref="ISurfaceWindow.IsCloseRequested" /> being
    /// <c>true</c>.
    /// </summary>
    /// <remarks>
    /// It is expected that <see cref="Tick" /> shall not be called if this property is <c>true</c>.
    /// </remarks>
    bool ShouldTerminate { get; }

    /// <summary>
    /// Steps the underlying implementation's surface lifecycle (i.e. event loop), running a single tick on the
    /// <see cref="Surface" />.
    /// </summary>
    /// <remarks>
    /// It is expected that implementations shall return after doing as little work as possible. For instance, if the
    /// underlying implementation exposes one-by-one event retrieval or otherwise allows customisation of the extent to
    /// which the event pump is run, it is expected that a single event shall be pumped in this case. Note that this is
    /// just an example and the exact details of this is implementation-defined.
    /// </remarks>
    void Tick();

    /// <summary>
    /// Attempts to create a <see cref="IDetachedSurfaceLifecycle" /> using the reference implementation.
    /// </summary>
    /// <param name="lifecycle">The created surface lifecycle on success, <c>null</c> otherwise.</param>
    /// <typeparam name="T">
    /// The application that shall be associated with the surface. Note that even with this API,
    /// <see cref="ISurfaceApplication.Initialize{T}" /> shall still be called for consistency and portability. However,
    /// unlike <see cref="ISurfaceApplication.Run{T}" />, this method shall not block and will instead return an
    /// <see cref="IDetachedSurfaceLifecycle" /> on which <see cref="Tick" /> is expected to be continuously called to
    /// enact the same behaviour on the surface. The associated application is also used for any additional global
    /// configuration, such as <see cref="ISurfaceApplication.WindowClass" />.
    /// </typeparam>
    /// <returns>
    /// <c>true</c> if <paramref name="lifecycle" /> has been populated with an <see cref="IDetachedSurfaceLifecycle" />
    /// object containing a valid <see cref="Surface" />, <c>false</c> otherwise.
    /// </returns>
    /// <remarks>
    /// This is the same reference implementation that <see cref="ISurfaceApplication.Run{T}" /> would otherwise use.
    /// </remarks>
    static sealed bool TryCreate<T>([NotNullWhen(true)] out IDetachedSurfaceLifecycle? lifecycle)
        where T : ISurfaceApplication => throw new NotImplementedException();
}
