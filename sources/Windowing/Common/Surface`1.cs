// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using Silk.NET.Core;
using Silk.NET.Windowing.Hosting;

namespace Silk.NET.Windowing;

/// <summary>
/// Represents an abstract surface from which operating system events can be received and to which user graphics can be
/// drawn using the capabilities provided by the platform.
/// </summary>
public sealed class Surface<TImpl> : Surface, IHostActor
    where TImpl : ISurfaceHost
{
    internal Surface() { }

    /// <summary>
    /// Creates a surface with the given configuration.
    /// </summary>
    /// <param name="config">The configuration for the surface..</param>
    /// <typeparam name="TExtra">The type of the configuration for the surface.</typeparam>
    /// <returns>The surface.</returns>
    public static Surface<TImpl> Create<TExtra>(TExtra config)
        where TExtra : IConfigureHost
    {
        var req = TImpl.CreateSurfaceRequest();
        config.ConfigureHost<RequestHandle, TImpl>(req);
        return Create(req);
    }

    internal static Surface<TImpl> Create(RequestHandle req) =>
        // TODO init components based on the request properties configured.
        new() { Request = req };

    /// <inheritdoc />
    public override Vector2 ClientSize =>
        Handle != default
            ? TImpl.GetSurfaceProperty(Handle, SurfacePropertyName.ClientSizeVector2).Float
            : TImpl.GetSurfaceProperty(Request, SurfacePropertyName.ClientSizeVector2).Float;

    /// <inheritdoc />
    public override SurfaceHandle Handle { get; protected set; }

    private RequestHandle Request { get; set; }

    /// <inheritdoc />
    public override void Launch<T>(T actor) => TImpl.LaunchMainSurface(Request, this);

    /// <inheritdoc />
    public override void Launch() => Launch(this);

    /// <inheritdoc />
    public override void Dispose()
    {
        if (Request.Value is not 0)
        {
            TImpl.DestroySurfaceRequest(Request);
        }

        if (Handle.Value is not 0)
        {
            TImpl.TerminateSurface(Handle);
        }
    }

    void IHostActor.HandleInit(SurfaceHandle surface) => throw new NotImplementedException();

    void IHostActor.HandleTick() => throw new NotImplementedException();

    void IHostActor.HandleQuit(SurfaceHandle surface) => throw new NotImplementedException();
}
