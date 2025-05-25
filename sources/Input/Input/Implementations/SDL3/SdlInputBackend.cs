// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.InteropServices;
using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal class SdlInputBackend : IInputBackend, ICursorConfiguration
{
    private static readonly double _ticksPerNanosecond = Stopwatch.Frequency / 10e9d;

    private bool _pumped;
    private long _epoch;
    private List<IInputDevice> _devices = [];
    private List<QueuedEvent> _eventQueue = [];
    private WindowHandle _focusedWindow;
    private ISdl _sdl;

    public unsafe SdlInputBackend(SdlPlatformInfo info)
    {
        ArgumentNullException.ThrowIfNull(info.Sdl);
        ArgumentNullException.ThrowIfNull(info.Window.Handle);
        var ptr = new EventFilter(OnEvent);
        _sdl = info.Sdl;
        _focusedWindow = info.Window;
        // TODO overload resolution priority?
        if (!Sdl.AddEventWatch(ptr, (Ref)nullptr))
        {
            Sdl.ThrowError();
        }

        Id = (nint)ptr.Handle;

        // The epoch deals in nanoseconds, so we take multiple measurements for the most accurate timestamps.
        const byte epochMeasurements = 3;
        var epoch = 0L;
        for (byte i = 0; i < epochMeasurements; i++)
        {
            // We know the ticks per nanosecond, so to get the epoch timestamp we multiply the TicksNS by the ticks per
            // nanosecond to get the number of ticks relative to SDL's epoch, and then subtract that from the timestamp
            // now to get the timestamp of SDL's epoch. From there, when we receive an event we can just report the
            // timestamp as _epoch + (timestamp * _ticksPerNanosecond).
            var nowTimestamp = Stopwatch.GetTimestamp();
            var nowTicks = Sdl.GetTicksNS();
            epoch += unchecked(nowTimestamp - (long)(nowTicks * _ticksPerNanosecond));
        }

        _epoch = epoch / epochMeasurements;

        // ===============================================================================================
        // === If we ever need to share common state across window-specific "backends", use the below: ===
        // ===============================================================================================
        // // Get the root surface - our windowing backend assumes there is only one root surface. If this is not the
        // // case then this is undefined behaviour.
        // var rootSurface = info.Window;
        // var parent = rootSurface;
        // while ((parent = Sdl.GetWindowParent(rootSurface)) != nullptr)
        // {
        //     rootSurface = parent;
        // }
        // // Get the surface properties.
        // var props = Sdl.GetWindowProperties(rootSurface);
        // if (props == 0)
        // {
        //     Sdl.ThrowError();
        // }
        // // Get or create the root object.
        // Ref<sbyte> pname = "org.dotnetfoundation.silkdotnet.inputroot";
        // var root = (nint)Sdl.GetPointerProperty(props, pname, nullptr);
        // if (root != 0)
        // {
        //     Root =
        //         GCHandle.FromIntPtr(root).Target as SdlBackendRoot
        //         ?? throw new InvalidOperationException(
        //             "The global input data for this ancestry of SDL windows was not in an expected format."
        //         );
        // }
        // else
        // {
        //     Root = new SdlBackendRoot();
        //     var newHandle = GCHandle.Alloc(Root);
        //     if (
        //         Sdl.SetPointerPropertyWithCleanup(
        //             props,
        //             pname,
        //             (Ptr)GCHandle.ToIntPtr(newHandle),
        //             new CleanupPropertyCallback(&CleanupRoot),
        //             nullptr
        //         )
        //     )
        //     {
        //         return;
        //     }
        //     newHandle.Free();
        //     Sdl.ThrowError();
        // }
        // // Register ourselves with the root.
        // Root.Backends.Add(this, null);
        // Id = (nint)Root.EventFilter.Handle + Root.Backends.Count() - 1;
    }

    // [UnmanagedCallersOnly]
    // private static unsafe void CleanupRoot(void* _, void* value)
    // {
    //     var gch = GCHandle.FromIntPtr((nint)value);
    //     (gch.Target as SdlBackendRoot)?.Dispose();
    //     gch.Free();
    // }
    // public SdlBackendRoot Root { get; }

    // NOTE: Be careful where these are used!
    public SdlPlatformInfo Info { get; }

    [field: MaybeNull]
    public SdlBoundedPointerTarget BoundedPointerTarget =>
        field ??= new SdlBoundedPointerTarget(this);

    [field: MaybeNull]
    public SdlUnboundedPointerTarget UnboundedPointerTarget =>
        field ??= new SdlUnboundedPointerTarget(this);

    public ISdl Sdl => Info.Sdl ?? SDL.Sdl.Instance;

    public string Name =>
        $"Silk.NET.Input Reference Implementation using SDL3 ({Sdl.GetPlatform().ReadToString()})";

    public nint Id { get; }

    public IReadOnlyList<IInputDevice> Devices => _devices;

    // TODO we can't query support for these modes, but should we try-it-and-see to be accurate?
    public CursorModes SupportedModes =>
        CursorModes.Normal | CursorModes.Confined | CursorModes.Unbounded;

    // TODO if you're using one input context for all windows, there is no way to specify a window for grabbed cursor mode

    public CursorModes Mode
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CursorStyles SupportedStyles => throw new NotImplementedException();

    public CursorStyles Style
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CustomCursor Image
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    // This is complicated, as the input proposal mandates that nothing happens until Update is called (so the events
    // can be received on the given actor) but to also track logical events that happen between calls (i.e. from a
    // timestamp perspective). Compound this with the fact that the user might do something silly like make multiple
    // input backends (which is feasible for multiple windows I guess), or not be running anything other than input
    // (having obviously created a window beforehand but not actually polling events I guess)
    public void Update(IInputHandler? handler = null)
    {
        if (!_pumped)
        {
            Sdl.PumpEvents();
        }

        _pumped = false;
        throw new NotImplementedException();
    }

    private enum QueuedEventType : byte
    {
        /// <summary>
        /// The mouse has exited the window and the shared point should be marked inactive until proven otherwise by
        /// further mouse motion (indicating it has entered another window).
        /// </summary>
        /// <remarks>
        /// We do not track the mouse enter events as this would cause us to fire twice for a mouse entering a window:
        /// once for the entering, and once for new position.
        /// </remarks>
        MouseExitedWindow,

        /// <summary>
        /// The display bounds have been changed, meaning that <see cref="SdlBoundedPointerTarget"/>'s
        /// <see cref="IPointerTarget.Bounds"/> will have changed.
        /// </summary>
        BoundedPointerTargetUpdate,
    }

    private readonly record struct QueuedEvent(
        QueuedEventType Type,
        ulong Timestamp,
        Vector2 Vector0 = default,
        Vector2 Vector1 = default
    );

    private ulong GetTimestamp(ref readonly Event @event) =>
        unchecked((ulong)(_epoch + (@event.Common.Timestamp * _ticksPerNanosecond)));

    private unsafe byte OnEvent(void* arg0, Event* arg1)
    {
        _pumped = true;
        // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
        switch ((EventType)arg1->Common.Type)
        {
            case EventType.DisplayOrientation:
            case EventType.DisplayAdded:
            case EventType.DisplayRemoved:
            case EventType.DisplayMoved:
            case EventType.DisplayDesktopModeChanged:
            case EventType.DisplayCurrentModeChanged:
            case EventType.DisplayContentScaleChanged:
            {
                var bounds = SdlBoundedPointerTarget.CalculateBounds(Sdl);
                _eventQueue.Add(
                    new QueuedEvent(
                        QueuedEventType.BoundedPointerTargetUpdate,
                        GetTimestamp(ref *arg1),
                        bounds.Min.ToSystem(),
                        bounds.Max.ToSystem()
                    )
                );
                break;
            }
            case EventType.WindowMouseLeave:
            {
                _eventQueue.Add(
                    new QueuedEvent(QueuedEventType.MouseExitedWindow, GetTimestamp(ref *arg1))
                );
                break;
            }
            case EventType.KeyDown:
                break;
            case EventType.KeyUp:
                break;
            case EventType.TextEditing:
                break;
            case EventType.TextInput:
                break;
            case EventType.KeymapChanged:
                break;
            case EventType.KeyboardAdded:
                break;
            case EventType.KeyboardRemoved:
                break;
            case EventType.TextEditingCandidates:
                break;
            case EventType.MouseMotion:
                break;
            case EventType.MouseButtonDown:
                break;
            case EventType.MouseButtonUp:
                break;
            case EventType.MouseWheel:
                break;
            case EventType.MouseAdded:
                break;
            case EventType.MouseRemoved:
                break;
            case EventType.JoystickAxisMotion:
                break;
            case EventType.JoystickBallMotion:
                break;
            case EventType.JoystickHatMotion:
                break;
            case EventType.JoystickButtonDown:
                break;
            case EventType.JoystickButtonUp:
                break;
            case EventType.JoystickAdded:
                break;
            case EventType.JoystickRemoved:
                break;
            case EventType.JoystickBatteryUpdated:
                break;
            case EventType.JoystickUpdateComplete:
                break;
            case EventType.GamepadAxisMotion:
                break;
            case EventType.GamepadButtonDown:
                break;
            case EventType.GamepadButtonUp:
                break;
            case EventType.GamepadAdded:
                break;
            case EventType.GamepadRemoved:
                break;
            case EventType.GamepadRemapped:
                break;
            case EventType.GamepadTouchpadDown:
                break;
            case EventType.GamepadTouchpadMotion:
                break;
            case EventType.GamepadTouchpadUp:
                break;
            case EventType.GamepadSensorUpdate:
                break;
            case EventType.GamepadUpdateComplete:
                break;
            case EventType.GamepadSteamHandleUpdated:
                break;
            case EventType.FingerDown:
                break;
            case EventType.FingerUp:
                break;
            case EventType.FingerMotion:
                break;
            case EventType.FingerCanceled:
                break;
            case EventType.ClipboardUpdate:
                break;
            case EventType.SensorUpdate:
                break;
            case EventType.PenProximityIn:
                break;
            case EventType.PenProximityOut:
                break;
            case EventType.PenDown:
                break;
            case EventType.PenUp:
                break;
            case EventType.PenButtonDown:
                break;
            case EventType.PenButtonUp:
                break;
            case EventType.PenMotion:
                break;
            case EventType.PenAxis:
                break;
        }

        return 1;
    }

    private unsafe void ReleaseUnmanagedResources()
    {
        Sdl.RemoveEventWatch(
            new EventFilter((delegate* unmanaged<void*, Event*, byte>)(void*)Id),
            nullptr
        );
        SilkMarshal.Free((Ptr)Id);
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~SdlInputBackend() => ReleaseUnmanagedResources();
}
