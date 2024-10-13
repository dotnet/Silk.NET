// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using Silk.NET.Core.Analyzers;

namespace Silk.NET.Windowing.Hosting;

/// <summary>
/// Represents a raw API for creating surfaces.
/// </summary>
/// <remarks>
/// Many APIs must only be called on the &quot;main thread&quot;. This refers to the thread that calls the entry
/// assembly's main function.
/// </remarks>
[MockStaticAbstract]
public interface ISurfaceHost : ISurfaceProvider
{
    /// <summary>
    /// Whether multiple surfaces can be spawned as children of the first surface created.
    /// </summary>
    /// <remarks>
    /// This is expected to be thread-safe. This should not be called before <see cref="LaunchMainSurface{TActor}"/>.
    /// </remarks>
    static abstract bool IsMultiSurface { get; }

    /// <summary>
    /// Creates a surface request.
    /// </summary>
    /// <returns>
    /// A surface request. Must be destroyed either using <see cref="DestroySurfaceRequest"/>.
    /// </returns>
    /// <remarks>
    /// This can be called on any thread. Any implementation that cannot honour this should defer any thread-sensitive
    /// operations to surface creation time.
    /// </remarks>
    static abstract RequestHandle CreateSurfaceRequest();

    /// <summary>
    /// Duplicates the surface request represented by <paramref name="src"/> and copies the data into
    /// <paramref name="dest"/>.
    /// </summary>
    /// <param name="dest">The destination request.</param>
    /// <param name="src">
    /// The source handle. If this is a window, then a point-in-time snapshot of the window's state shall be taken and
    /// replicated on a best-effort basis in the request.
    /// </param>
    /// <typeparam name="TSrc">The source handle type.</typeparam>
    /// <remarks>
    /// This must be called on the main thread. Assumed to be a slow path operation.
    /// </remarks>
    static abstract void CopySurfaceRequest<TSrc>(RequestHandle dest, TSrc src)
        where TSrc : ISurfaceOrRequestHandle;

    /// <summary>
    /// Destroys a surface request.
    /// </summary>
    /// <param name="surfaceRequest">The surface request.</param>
    /// <remarks>
    /// This can be called on any thread. Any implementation that cannot honour this should defer any thread-sensitive
    /// operations to surface creation time.
    /// </remarks>
    static abstract void DestroySurfaceRequest(RequestHandle surfaceRequest);

    /// <summary>
    /// Attempts to incorporate existing window handles as part of the request for the surface.
    /// </summary>
    /// <param name="surfaceRequest">The surface request.</param>
    /// <param name="info">The platform info.</param>
    /// <typeparam name="TPlatformInfo">The platform info type.</typeparam>
    /// <returns>Returns true except where the handles are incompatible in which case false is returned.</returns>
    /// <remarks>
    /// This can be called on any thread. Any implementation that cannot honour this should defer any thread-sensitive
    /// operations to surface creation time.
    /// </remarks>
    static abstract bool TryInheritPlatformInfo<TPlatformInfo>(
        RequestHandle surfaceRequest,
        TPlatformInfo info
    )
        where TPlatformInfo : notnull;

    /// <summary>
    /// Launches the main surface. This is blocking in most cases, but is not guaranteed to block. Do not use
    /// <c>using var</c> in code that launches surfaces - instead defer to the callbacks on your surface actor. If this
    /// method does not block, you shouldn't either.
    /// </summary>
    /// <param name="surfaceRequest">The surface request.</param>
    /// <param name="actor">An actor responding to surface lifecycle pulses.</param>
    /// <typeparam name="TActor">The type of the host actor.</typeparam>
    /// <remarks>
    /// This must be called on the main thread. Assumed that this is only called once.
    /// </remarks>
    static abstract HostStatus LaunchMainSurface<TActor>(RequestHandle surfaceRequest, TActor actor)
        where TActor : IHostActor;

    /// <summary>
    /// Launches a child surface. The root surface receives
    /// </summary>
    /// <param name="parent">The parent surface.</param>
    /// <param name="surfaceRequest">The request for the child surface.</param>
    /// <returns>The child surface handle. This is also delivered to the host actor.</returns>
    static abstract SurfaceHandle CreateChildSurface(
        SurfaceHandle parent,
        RequestHandle surfaceRequest
    );

    /// <summary>
    /// Terminates the surface. This results in the <see cref="IHostActor"/> of the main surface receiving a final
    /// <see cref="IHostActor.HandleQuit"/> event for this handle.
    /// </summary>
    /// <param name="surface"></param>
    static abstract void TerminateSurface(SurfaceHandle surface);

    /// <summary>
    /// Attempts to get the platform info for the given surface.
    /// </summary>
    /// <param name="handle">The surface.</param>
    /// <param name="platformInfo">The retrieved platform info.</param>
    /// <typeparam name="TPlatformInfo">The type of the platform info to retrieve.</typeparam>
    /// <returns>Whether the platform info was found.</returns>
    /// <remarks>
    /// This must be called on the main thread.
    /// </remarks>
    static abstract bool TryGetPlatformInfo<TPlatformInfo>(
        SurfaceHandle handle,
        [NotNullWhen(true)] out TPlatformInfo? platformInfo
    );

    /// <summary>
    /// Gets a property value on the given surface/request.
    /// </summary>
    /// <param name="handle">The surface or surface request handle.</param>
    /// <param name="propertyName">The property to retrieve.</param>
    /// <returns>The property value. </returns>
    /// <typeparam name="T">A <see cref="SurfaceHandle"/> or <see cref="RequestHandle"/>.</typeparam>
    /// <remarks>
    /// If the property is not supported, this should return a default value for the property. The onus is on the caller
    /// to check whether the property (or feature in which the property is required) is supported. This must be called
    /// on the main thread unless <typeparamref name="T"/> is a <see cref="RequestHandle"/>.
    /// </remarks>
    static abstract SurfaceProperty GetSurfaceProperty<T>(
        T handle,
        SurfacePropertyName propertyName
    )
        where T : ISurfaceOrRequestHandle;

    /// <summary>
    /// Gets a property value on the given surface/request.
    /// </summary>
    /// <param name="handle">The surface or surface request handle.</param>
    /// <param name="property">The property name and value.</param>
    /// <typeparam name="T">A <see cref="SurfaceHandle"/> or <see cref="RequestHandle"/>.</typeparam>
    /// <remarks>
    /// If the property is not supported, this should do nothing. The onus is on the caller to check whether the
    /// property (or feature in which the property is required) is supported. This must be called on the main thread
    /// unless <typeparamref name="T"/> is a <see cref="RequestHandle"/>.
    /// </remarks>
    static abstract void SetSurfaceProperty<T>(T handle, SurfaceProperty property)
        where T : ISurfaceOrRequestHandle;

    /// <summary>
    /// Creates an event pump to receive events regarding hosted surfaces.
    /// </summary>
    /// <param name="relatedSurface">
    /// A surface from which all events from all related surfaces will be received.
    /// </param>
    /// <returns>The event pump.</returns>
    /// <remarks>
    /// This must be called on the main thread. Not every implementation has the concept of an event pump resource, but
    /// this should return a non-zero handle in any case.
    /// </remarks>
    // RATIONALE: Dylan Says: I was having a real debate with myself as I've been extremely critical of having static
    // state in the past. It makes sense for the surface host API to be a static, C-like API to ease mapping it to C
    // APIs with which it's implemented, but in the most part there's still a concept of memory management/resource
    // ownership. In SDL event pumps are global resources, but I didn't want this to leak out to potentially impact
    // other implementations for which this isn't the case and risk having dangling static state. So I introduced the
    // event pump concept. It is expected to be unused in our SDL implementation.
    //
    // NOTE: This originally was to be "one event pump per root surface" but I changed this to technically allow
    // multiple pumps to exist even if the underlying implementation doesn't. The reason behind this is the routing of
    // events from the root HLU surface to the child HLU surfaces would incur a virtual method penalty as we'd be
    // storing the surface actor as an interface.
    static abstract EventPumpHandle CreateEventPump(SurfaceHandle relatedSurface);

    /// <summary>
    /// Destroys an event pump.
    /// </summary>
    /// <param name="pump">The event pump.</param>
    /// <remarks>This must be called on the main thread.</remarks>
    static abstract void DestroyEventPump(EventPumpHandle pump);

    /// <summary>
    /// Pumps the event queue and determines whether there is an event to handle. <see cref="AcknowledgeEvent"/> must be
    /// used after the event is inspected, otherwise subsequent calls will return <see cref="HostEventKind.None"/>.
    /// </summary>
    /// <param name="pump">The event pump.</param>
    /// <param name="event">
    /// An implementation-defined integer identifying the event received. This should be maintained across calls to the
    /// event pump to ensure the correct event is subsequently received from the event pump. Must only be modified upon
    /// a successful query.
    /// </param>
    /// <returns>The event kind if an event has been taken from the event queue, false otherwise.</returns>
    /// <remarks>This must be called on the main thread.</remarks>
    static abstract HostEventKind QueryEvent(EventPumpHandle pump, ref int @event);

    /// <summary>
    /// Gets the surface associated with the event retrieved from <see cref="QueryEvent"/>.
    /// </summary>
    /// <param name="pump">The event pump to query.</param>
    /// <param name="event">The event as returned from <see cref="QueryEvent"/>.</param>
    /// <returns>The surface with which the event currently represented by the event pump is associated.</returns>
    /// <remarks>
    /// This is expected to be thread-safe, but this function must only be used between a call to
    /// <see cref="QueryEvent"/> and <see cref="AcknowledgeEvent"/>.
    /// </remarks>
    static abstract SurfaceHandle GetEventSurface(EventPumpHandle pump, int @event);

    /// <summary>
    /// Acknowledges the event contained in the event pump, allowing <see cref="QueryEvent"/> to query a new event.
    /// </summary>
    /// <param name="pump">The pump containing the event.</param>
    /// <param name="event">The event being acknowledged as returned from <see cref="QueryEvent"/>.</param>
    /// <remarks>This must be called on the main thread.</remarks>
    static abstract void AcknowledgeEvent(EventPumpHandle pump, int @event);

    /// <summary>
    /// Gets the property changed as part of a <see cref="HostEventKind.SurfacePropertyChanged"/> event.
    /// </summary>
    /// <param name="pump">The event pump from which the event was received.</param>
    /// <param name="event">The event being acknowledged as returned from <see cref="QueryEvent"/>.</param>
    /// <returns>The property changed.</returns>
    static abstract SurfaceProperty GetEventPropertyChanged(EventPumpHandle pump, int @event);
}
