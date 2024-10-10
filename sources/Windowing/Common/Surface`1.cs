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
public sealed class Surface<TImpl> : Surface
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
    public override void Launch<T>(T actor) =>
        TImpl.LaunchMainSurface(Request, new ActorRouter<T>(this, actor));

    /// <inheritdoc />
    public override void Launch() => Launch(this);

    class ActorRouter<TActor>(Surface<TImpl> self, TActor actor) : IHostActor
        where TActor : ISurfaceActor
    {
        private EventPumpHandle _eventPump;
        private int _event;

        public void HandleInit(SurfaceHandle surface)
        {
            if (self.Handle == default)
            {
                self.Handle = surface;
                _eventPump = TImpl.CreateEventPump(surface);
                actor.HandleCreated();
            }
        }

        public void HandleTick()
        {
            if (self.Handle == default || _eventPump == default)
            {
                // misbehaving impl?
                return;
            }

            var eventBefore = _event;
            var eventKind = TImpl.QueryEvent(_eventPump, ref _event);
            if (eventKind == HostEventKind.None)
            {
                return;
            }

            // these may be the same if the last tick threw an exception and somehow we're continuing past it. in this
            // case, we acknowledge the dangling event and just move on.
            if (eventBefore != _event)
            {
                switch (eventKind)
                {
                    case HostEventKind.SurfacePropertyChanged:
                    {
                        var property = TImpl.GetEventPropertyChanged(_eventPump, _event);
                        switch (property.PropertyName)
                        {
                            case SurfacePropertyName.ClientSizeVector2:
                            {
                                actor.HandleClientSizeChanged(property.Float);
                                break;
                            }
                            case SurfacePropertyName.UseSeparateEventThreadBoolean:
                            case SurfacePropertyName.UseBufferedEventLoopBoolean:
                            {
                                break;
                            }
                        }
                        break;
                    }
                }
            }

            TImpl.AcknowledgeEvent(_eventPump, _event);
        }

        public void HandleQuit(SurfaceHandle surface)
        {
            if (self.Handle != surface)
            {
                return;
            }

            actor.HandleTerminating();
            self.Handle = default;
        }

        private void Reset()
        {
            if (_eventPump != default)
            {
                TImpl.DestroyEventPump(_eventPump);
                _eventPump = default;
            }

            if (self.Handle == default)
            {
                TImpl.TerminateSurface(self.Handle);
                self.Handle = default; // this surface is effectively forgotten at this point
            }
        }

        // shouldn't ever do anything, as the only reason we'd be destructing is if the backend forgot about this actor
        // which means it's quit already
        ~ActorRouter() => Reset();
    }

    /// <inheritdoc />
    public override void Dispose()
    {
        if (Request.Value is not 0)
        {
            TImpl.DestroySurfaceRequest(Request);
            Request = default;
        }

        if (Handle.Value is not 0)
        {
            TImpl.TerminateSurface(Handle);
            // Handle = default will happen in ActorRouter.Reset (in theory)
        }
    }
}
