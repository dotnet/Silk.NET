// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Silk.NET.Core;
using Silk.NET.Maths;

namespace Silk.NET.Windowing.Hosting;

/// <summary>
/// An implementation of <see cref="ISurfaceHost"/> that can be used across multiple threads. This is used to implement
/// the logic required to allow multiple surfaces to run concurrently while still respecting the typical single-threaded
/// requirements of surface hosts. The thread the main surface is launched from is assumed to be the main thread, and
/// will run the event loop. Every surface will have its own thread that calls back to this event thread.
/// </summary>
/// <typeparam name="TUnderlying">The underlying surface host.</typeparam>
public class MultiThreadedSurfaceHost<TUnderlying> : ISurfaceHost
    where TUnderlying : ISurfaceHost
{
    internal static SurfaceHandle RootSurface;
    internal static BreakneckRequest<EventThreadResponse, ChildThreadRequest> Comms;
    internal static EventPumpHandle EventPump;
    internal static int EventPumpRefCount;
    internal static int EventPumpRemainingAcks;
    internal static int CurrentEvent;
    internal static HostEventKind CurrentEventKind;
    internal static int Querying;
    internal static bool HasSeparateEventThread;

    internal enum ChildThreadRequestType
    {
        /// <summary>
        /// Execute the given delegate. Used on slow paths.
        /// </summary>
        /// <remarks>
        /// Request: ObjectData = Func&lt;object?&gt;, Response: ObjectData = output from delegate
        /// </remarks>
        Func,

        /// <summary>
        /// Execute the given delegate. Used on slow paths.
        /// </summary>
        /// <remarks>
        /// Request: ObjectData = Action&lt;object?&gt;, Response: nothing
        /// </remarks>
        Action,

        /// <summary>
        /// Instructs the main thread to pump events.
        /// </summary>
        PumpEvents,

        /// <summary>
        /// <see cref="ISurfaceHost.GetSurfaceProperty{T}"/> where <c>T</c> is <see cref="SurfaceHandle"/>.
        /// </summary>
        GetSurfaceProperty,

        /// <summary>
        /// <see cref="ISurfaceHost.SetSurfaceProperty{T}"/> where <c>T</c> is <see cref="SurfaceHandle"/>.
        /// </summary>
        SetSurfaceProperty
    }

    internal readonly record struct ChildThreadRequest(
        ChildThreadRequestType OpCode,
        object? ObjectData,
        SurfaceProperty Data
    );

    internal readonly record struct EventThreadResponse(
        ExceptionDispatchInfo? Error,
        object? ObjectData,
        SurfacePropertyValue Data
    )
    {
        public EventThreadResponse Assert()
        {
            Error?.Throw();
            return this;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static bool IsAssumedToBeOnAppropriateThread<T>(T handle)
        where T : ISurfaceOrRequestHandle =>
        !IsMultiSurface
        || typeof(T) != typeof(SurfaceHandle)
        || RootSurface == default
        || (
            typeof(T) == typeof(SurfaceHandle)
            && !HasSeparateEventThread
            && RootSurface == (SurfaceHandle)(object)handle
        );

    private static T SlowPath<T, THandle>(Func<T> action, THandle subject)
        where THandle : ISurfaceOrRequestHandle =>
        IsAssumedToBeOnAppropriateThread(subject)
            ? action()
            : (T)
                Comms
                    .Request(new ChildThreadRequest(ChildThreadRequestType.Func, action, default))
                    .Assert()
                    .ObjectData!;

    private static void SlowPath<THandle>(Action action, THandle subject)
        where THandle : ISurfaceOrRequestHandle
    {
        if (IsAssumedToBeOnAppropriateThread(subject))
        {
            action();
            return;
        }

        Comms
            .Request(new ChildThreadRequest(ChildThreadRequestType.Action, action, default))
            .Assert();
    }

    /// <inheritdoc />
    public static bool IsMultiSurface => TUnderlying.IsMultiSurface;

    /// <inheritdoc />
    public static RequestHandle CreateSurfaceRequest() => TUnderlying.CreateSurfaceRequest();

    /// <inheritdoc />
    public static void CopySurfaceRequest<TSrc>(RequestHandle dest, TSrc src)
        where TSrc : ISurfaceOrRequestHandle =>
        SlowPath(() => TUnderlying.CopySurfaceRequest(dest, src), src);

    /// <inheritdoc />
    public static void DestroySurfaceRequest(RequestHandle surfaceRequest) =>
        TUnderlying.DestroySurfaceRequest(surfaceRequest);

    /// <inheritdoc />
    public static bool TryInheritPlatformInfo<TPlatformInfo>(
        RequestHandle surfaceRequest,
        TPlatformInfo info
    )
        where TPlatformInfo : notnull => TUnderlying.TryInheritPlatformInfo(surfaceRequest, info);

    /// <inheritdoc />
    public static SurfaceHandle CreateChildSurface(
        SurfaceHandle parent,
        RequestHandle surfaceRequest
    ) => SlowPath(() => TUnderlying.CreateChildSurface(parent, surfaceRequest), parent);

    /// <inheritdoc />
    public static void TerminateSurface(SurfaceHandle surface) =>
        SlowPath(() => TUnderlying.TerminateSurface(surface), surface);

    /// <inheritdoc />
    public static bool TryGetPlatformInfo<TPlatformInfo>(
        SurfaceHandle handle,
        [NotNullWhen(true)] out TPlatformInfo? platformInfo
    )
    {
        var (ret, retInfo) = SlowPath(
            () =>
                (
                    TUnderlying.TryGetPlatformInfo(handle, out TPlatformInfo? platformInfo),
                    platformInfo
                ),
            handle
        );
        platformInfo = retInfo;
        return ret;
    }

    /// <inheritdoc />
    public static SurfaceProperty GetSurfaceProperty<T>(T handle, SurfacePropertyName propertyName)
        where T : ISurfaceOrRequestHandle =>
        IsAssumedToBeOnAppropriateThread(handle)
            ? TUnderlying.GetSurfaceProperty(handle, propertyName)
            : new SurfaceProperty
            {
                PropertyName = propertyName,
                Value = Comms
                    .Request(
                        new ChildThreadRequest(
                            ChildThreadRequestType.GetSurfaceProperty,
                            null,
                            new SurfaceProperty { PropertyName = propertyName }
                        )
                    )
                    .Assert()
                    .Data
            };

    /// <inheritdoc />
    public static void SetSurfaceProperty<T>(T handle, SurfaceProperty property)
        where T : ISurfaceOrRequestHandle
    {
        if (IsAssumedToBeOnAppropriateThread(handle))
        {
            TUnderlying.SetSurfaceProperty(handle, property);
            return;
        }

        Comms
            .Request(
                new ChildThreadRequest(ChildThreadRequestType.SetSurfaceProperty, null, property)
            )
            .Assert();
    }

    /// <inheritdoc />
    public static HostStatus LaunchMainSurface<TActor>(RequestHandle surfaceRequest, TActor actor)
        where TActor : IHostActor
    {
        if (RootSurface != default)
        {
            throw new InvalidOperationException(
                "MultiThreadedSurfaceHost only supports one root surface per underlying host."
            );
        }

        return TUnderlying.LaunchMainSurface(surfaceRequest, new RootHostActor<TActor>(actor));
    }

    struct RootHostActor<TNext>(TNext next) : IHostActor
        where TNext : IHostActor
    {
        public void HandleInit(SurfaceHandle surface)
        {
            if (RootSurface == default)
            {
                RootSurface = surface;
            }

            next.HandleInit(surface);
        }

        public void HandleTick()
        {
            next.HandleTick();
            DoRequests();
        }

        public void HandleQuit(SurfaceHandle surface)
        {
            next.HandleQuit(surface);
            if (surface == RootSurface)
            {
                DoRequests();
                RootSurface = default;
            }
        }

        private void DoRequests()
        {
            // Use a try block outside the per-request loop to avoid small exception regions which incur a small penalty
            // in some cases.
            bool errored;
            do
            {
                try
                {
                    errored = false;
                    while (Comms.TryGetRequest(out var req))
                    {
                        switch (req.OpCode)
                        {
                            case ChildThreadRequestType.Func:
                            {
                                Comms.Provide(
                                    new EventThreadResponse(
                                        null,
                                        Unsafe.As<Func<object?>>(req.ObjectData)!.Invoke(),
                                        default
                                    )
                                );
                                break;
                            }
                            case ChildThreadRequestType.Action:
                            {
                                Unsafe.As<Action>(req.ObjectData)!.Invoke();
                                Comms.Provide(default);
                                break;
                            }
                            case ChildThreadRequestType.PumpEvents:
                            {
                                Comms.Provide(default); // don't want them waiting for us

                                // If this is the first time we're pumping, create the underlying pump and carry on.
                                // Otherwise, we need to acknowledge the previous event first.
                                if (EventPump == default)
                                {
                                    EventPump = TUnderlying.CreateEventPump(RootSurface);
                                }
                                else if (CurrentEventKind != HostEventKind.None)
                                {
                                    TUnderlying.AcknowledgeEvent(EventPump, CurrentEvent);
                                }

                                // Query the event.
                                if (
                                    TUnderlying.QueryEvent(EventPump, ref CurrentEvent)
                                    is not HostEventKind.None
                                        and var kind
                                )
                                {
                                    CurrentEventKind = kind;
                                    EventPumpRemainingAcks = EventPumpRefCount;
                                }

                                Querying = 0;
                                break;
                            }
                            default:
                            {
                                throw new ArgumentOutOfRangeException(nameof(req.OpCode));
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    errored = true;
                    Comms.Provide(
                        new EventThreadResponse(ExceptionDispatchInfo.Capture(e), default, default)
                    );
                }
            } while (errored);
        }
    }

    /// <inheritdoc />
    public static EventPumpHandle CreateEventPump(SurfaceHandle relatedSurface)
    {
        if (CurrentEventKind != HostEventKind.None)
        {
            Interlocked.Increment(ref EventPumpRemainingAcks);
        }

        // The actual pump is created in the PumpEvents action.
        return new EventPumpHandle(Interlocked.Increment(ref EventPumpRefCount));
    }

    /// <inheritdoc />
    public static void DestroyEventPump(EventPumpHandle pump)
    {
        Interlocked.Decrement(ref EventPumpRefCount);
        if (CurrentEventKind != HostEventKind.None)
        {
            Interlocked.Decrement(ref EventPumpRemainingAcks);
        }
    }

    /// <inheritdoc />
    public static HostEventKind QueryEvent(EventPumpHandle pump, ref int @event)
    {
        if (Querying > 0)
        {
            return HostEventKind.None;
        }

        if (@event == CurrentEvent)
        {
            if (EventPumpRemainingAcks <= 0 && Interlocked.CompareExchange(ref Querying, 1, 0) == 0)
            {
                Comms.Request(
                    new ChildThreadRequest(ChildThreadRequestType.PumpEvents, default, default)
                );
                // The main thread will pump events in the background and should hopefully be done by the time this is
                // called again.
            }

            return HostEventKind.None;
        }

        @event = CurrentEvent;
        return CurrentEventKind;
    }

    /// <inheritdoc />
    public static SurfaceHandle GetEventSurface(EventPumpHandle pump, int @event) =>
        TUnderlying.GetEventSurface(EventPump, @event);

    /// <inheritdoc />
    public static void AcknowledgeEvent(EventPumpHandle pump, int @event)
    {
        if (@event != CurrentEvent)
        {
            return;
        }

        if (Interlocked.Decrement(ref EventPumpRemainingAcks) == 0)
        {
            SlowPath(
                () =>
                {
                    TUnderlying.DestroyEventPump(EventPump);
                    EventPump = default;
                    EventPumpRemainingAcks = 0;
                    CurrentEvent = 0;
                    CurrentEventKind = HostEventKind.None;
                },
                default(SurfaceHandle)
            );
        }
    }

    /// <inheritdoc />
    public static SurfaceProperty GetEventPropertyChanged(EventPumpHandle pump, int @event) =>
        TUnderlying.GetEventPropertyChanged(pump, @event);
}
