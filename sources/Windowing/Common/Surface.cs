// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using Silk.NET.Core;

namespace Silk.NET.Windowing;

/// <summary>
/// Represents an abstract surface from which operating system events can be received and to which user graphics can be
/// drawn using the capabilities provided by the platform.
/// </summary>
public partial class Surface : ISurface
{
    [HluHostedComponent]
    private ISurface? _nativeSurface;

    [HluHostedComponent(true)]
    private IPlatformInfo? _platformInfo;

    /// <summary>
    /// Creates a surface with the given underlying <see cref="ISurface"/> and no other components. This is strongly
    /// discouraged, you should use <see cref="SurfaceBuilder{TExtra,TImpl}"/> instead.
    /// </summary>
    /// <remarks>
    /// This constructor is useful if you want to manually configure components.
    /// </remarks>
    /// <param name="surface">The underlying surface.</param>
    public Surface(ISurface surface) => _nativeSurface = surface;

    /// <inheritdoc />
    public Vector2 ClientSize => _nativeSurface!.ClientSize;

    /// <inheritdoc />
    public IntPtr Handle => _nativeSurface!.Handle;

    /// <inheritdoc />
    public void Run<T>(T actor)
        where T : ISurfaceActor => _nativeSurface!.Run(actor);
}
