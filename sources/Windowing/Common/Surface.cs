// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Numerics;
using Silk.NET.Windowing.Hosting;

namespace Silk.NET.Windowing;

/// <summary>
/// An implementation of an <see cref="ISurface"/> using a <see cref="ISurfaceHost"/>, optionally providing an
/// event-based subscription mechanism for <see cref="ISurfaceActor"/>'s events.
/// </summary>
public abstract class Surface : ISurface, ISurfaceActor
{
    /// <summary>
    /// Creates a surface with the given configuration and underlying implementation.
    /// </summary>
    /// <param name="config">The configuration for the surface.</param>
    /// <typeparam name="TExtra">The type of the configuration for the surface.</typeparam>
    /// <typeparam name="TImpl">The surface implementation.</typeparam>
    /// <returns>The surface.</returns>
    /// <remarks>
    /// The underlying implementation may be wrapped in a <see cref="MultiThreadedSurfaceHost{TUnderlying}"/> if it
    /// isn't already if <see cref="ISurfaceHost.IsMultiSurface"/> is <c>true</c> to facilitate the use of
    /// multi-threaded multi-window workflows. Note that a surface must only access its own properties from the thread
    /// on which it was created.
    /// </remarks>
    public static Surface Create<TExtra, TImpl>(TExtra config)
        where TExtra : IConfigureHost
        where TImpl : ISurfaceHost
    {
        var req = TImpl.CreateSurfaceRequest();
        config.ConfigureHost<RequestHandle, TImpl>(req);
        if (
            !TImpl.IsMultiSurface
            || typeof(IMultiThreadedSurfaceHost).IsAssignableFrom(typeof(TImpl))
        )
        {
            return Surface<TImpl>.Create(req);
        }

        return Surface<MultiThreadedSurfaceHost<TImpl>>.Create(req);
    }

    /// <summary>
    /// Creates a surface with no thread safety, the given configuration, and underlying implementation.
    /// </summary>
    /// <param name="config">The configuration for the surface.</param>
    /// <typeparam name="TExtra">The type of the configuration for the surface.</typeparam>
    /// <typeparam name="TImpl">The surface implementation.</typeparam>
    /// <returns>The surface.</returns>
    public static Surface<TImpl> CreateSingleThreaded<TExtra, TImpl>(TExtra config)
        where TExtra : IConfigureHost
        where TImpl : ISurfaceHost => Surface<TImpl>.Create(config);

    /// <summary>
    /// Marker interface so we can check in an inlining-friendly way whether <c>TImpl</c> is already a
    /// <see cref="MultiThreadedSurfaceHost{TUnderlying}"/> without knowing <c>TUnderlying</c>.
    /// </summary>
    internal interface IMultiThreadedSurfaceHost;

    /// <inheritdoc />
    public abstract Vector2 ClientSize { get; }

    /// <inheritdoc />
    public abstract SurfaceHandle Handle { get; protected set; }

    /// <summary>
    /// An event executed when the surface is first loaded.
    /// </summary>
    /// <remarks>
    /// If you are using a surface actor, this event will not be raised and instead forwarded to your surface actor.
    /// </remarks>
    public event SurfaceEventHandler<SurfaceStateEventArgs>? Created;

    /// <summary>
    /// An event executed when the surface is about to terminate irrevocably.
    /// </summary>
    /// <remarks>
    /// If you are using a surface actor, this event will not be raised and instead forwarded to your surface actor.
    /// </remarks>
    public event SurfaceEventHandler<SurfaceStateEventArgs>? Terminating;

    /// <summary>
    /// An event executed when the surface, possibly as a result of user action, is requesting closure. This may still
    /// be reversible at this stage.
    /// </summary>
    /// <remarks>
    /// If you are using a surface actor, this event will not be raised and instead forwarded to your surface actor.
    /// </remarks>
    public event SurfaceEventHandler<SurfaceStateEventArgs>? Closing;

    /// <summary>
    /// An event executed when the surface is pausing on request of the operating system.
    /// </summary>
    /// <remarks>
    /// If you are using a surface actor, this event will not be raised and instead forwarded to your surface actor.
    /// </remarks>
    public event SurfaceEventHandler<SurfaceStateEventArgs>? Pausing;

    /// <summary>
    /// An event executed when the surface is resuming on request of the operating system.
    /// </summary>
    /// <remarks>
    /// If you are using a surface actor, this event will not be raised and instead forwarded to your surface actor.
    /// </remarks>
    public event SurfaceEventHandler<SurfaceStateEventArgs>? Resuming;

    /// <summary>
    /// An event executed when the surface is first loaded.
    /// </summary>
    /// <remarks>
    /// If you are using a surface actor, this event will not be raised and instead forwarded to your surface actor.
    /// </remarks>
    public event SurfaceEventHandler<SurfaceStateEventArgs>? LowMemory;

    /// <summary>
    /// An event executed when the <see cref="ClientSize"/> changes.
    /// </summary>
    /// <remarks>
    /// If you are using a surface actor, this event will not be raised and instead forwarded to your surface actor.
    /// </remarks>
    public event SurfaceEventHandler<SurfaceStateEventArgs<Vector2>>? ClientSizeChanged;

    /// <summary>
    /// An event executed <see cref="UpdatesPerSecond"/> times per second.
    /// </summary>
    /// <remarks>
    /// If you are using a surface actor, this event will not be raised and instead forwarded to your surface actor.
    /// </remarks>
    public event SurfaceEventHandler<TimedEventArgs>? Update;

    /// <summary>
    /// An event executed <see cref="UpdatesPerSecond"/> times per second.
    /// </summary>
    /// <remarks>
    /// If you are using a surface actor, this event will not be raised and instead forwarded to your surface actor.
    /// </remarks>
    public event SurfaceEventHandler<TimedEventArgs>? Render;

    /// <summary>
    /// The number of times per second that <see cref="Update"/> should be called. <c>0</c> or lower is interpreted as
    /// &quot;as fast as possible&quot;.
    /// </summary>
    public double UpdatesPerSecond
    {
        get => 1 / _updatePeriod;
        set => _updatePeriod = 1 / value;
    }

    private double _updatePeriod = 1 / 60.0;

    /// <summary>
    /// The number of times per second that <see cref="Render"/> should be called. <c>0</c> or lower is interpreted as
    /// &quot;as fast as possible&quot;.
    /// </summary>
    public double FramesPerSecond
    {
        get => 1 / _renderPeriod;
        set => _renderPeriod = 1 / value;
    }

    private double _renderPeriod = 1 / 60.0;

    /// <inheritdoc />
    /// <remarks>
    /// The events exposed on this class won't fire and will instead be forwarded to the given <paramref name="actor"/>.
    /// </remarks>
    public abstract void Launch<T>(T actor)
        where T : ISurfaceActor;

    /// <summary>
    /// Runs the window's event loop, dispatching events to the event fields on this object. This may be blocking,
    /// but won't always be blocking. You should dispose of your window and other resources in the window callbacks
    /// themselves. For instance, on mobile platforms a busy thread is often created by the underlying implementation
    /// implicitly, therefore the busy loop runs as a separate runnable. In this case, the window merely dispatches to
    /// that thread.
    /// </summary>
    public abstract void Launch();

    /// <inheritdoc />
    public abstract void Dispose();

    /// <summary>
    /// Whether to force the main loop (i.e. the execution of <see cref="Update"/> and <see cref="Render"/>) to be
    /// uncapped. This is usually useful to set to <c>true</c> once the V-Sync swap interval has been set, and
    /// effectively results in <see cref="FramesPerSecond"/> being ignored.
    /// </summary>
    protected bool ForceUncappedRender { get; set; }

    private Stopwatch _renderStopwatch = new();
    private Stopwatch _updateStopwatch = new();

    void ISurfaceActor.HandleTick()
    {
        var delta = _updateStopwatch.Elapsed.TotalSeconds;
        if (delta >= _updatePeriod)
        {
            _updateStopwatch.Restart();
            Update?.Invoke(this, new TimedEventArgs(delta));
        }

        delta = _renderStopwatch.Elapsed.TotalSeconds;
        if (delta >= _renderPeriod || ForceUncappedRender)
        {
            _renderStopwatch.Restart();
            Render?.Invoke(this, new TimedEventArgs(delta));
            // TODO swap if MakeCurrent wasn't called on the OpenGL context and ShouldSwapAutomatically is enabled.
        }
    }

    void ISurfaceActor.HandleCreated()
    {
        _renderStopwatch.Restart();
        _updateStopwatch.Restart();
        Created?.Invoke(this, new SurfaceStateEventArgs());
    }

    void ISurfaceActor.HandleTerminating() =>
        Terminating?.Invoke(this, new SurfaceStateEventArgs());

    void ISurfaceActor.HandleClosing() => Closing?.Invoke(this, new SurfaceStateEventArgs());

    void ISurfaceActor.HandlePausing() => Pausing?.Invoke(this, new SurfaceStateEventArgs());

    void ISurfaceActor.HandleResuming() => Resuming?.Invoke(this, new SurfaceStateEventArgs());

    void ISurfaceActor.HandleLowMemory() => LowMemory?.Invoke(this, new SurfaceStateEventArgs());

    void ISurfaceActor.HandleClientSizeChanged(Vector2 newSize) =>
        ClientSizeChanged?.Invoke(this, new SurfaceStateEventArgs<Vector2>(newSize));
}
