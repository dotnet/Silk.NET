// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Silk.NET.Input.SDL3.Devices.Joysticks;
using Silk.NET.Input.SDL3.Devices.Pointers;
using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal partial class SdlInputBackend : IInputBackend
{
    private static readonly double _ticksPerNanosecond = Stopwatch.Frequency / 10e9d;

    private bool _pumped;
    private long _epoch;
    private List<SdlDevice> _devices = [];
    private readonly EventQueue _pumpedEvents = new();
    private WindowHandle _focusedWindow;
    private ISdl _sdl;

    public unsafe WindowHandle? FocusedWindow => _focusedWindow.Handle == null ? null : _focusedWindow;
    public readonly ICursorConfiguration CursorConfiguration;

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
        CursorConfiguration = new SdlCursor(Sdl);

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
    public SdlUnboundedPointerTarget UnboundedPointerTarget =>
        field ??= new SdlUnboundedPointerTarget(this);

    public ISdl Sdl=> Info.Sdl ?? SDL.Sdl.Instance;

    public string Name =>
        $"Silk.NET.Input Reference Implementation using SDL3 ({Sdl.GetPlatform().ReadToString()})";

    public nint Id { get; }

    public IReadOnlyList<IInputDevice> Devices => _devices;

    // TODO we can't query support for these modes, but should we try-it-and-see to be accurate?

    // TODO if you're using one input context for all windows, there is no way to specify a window for grabbed cursor mode

    public HashSet<nint> DeviceRegistry { get; } = [];

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
        if (handler == null)
        {
            _pumpedEvents.Clear();
            return;
        }

        // process all events that have been queued?

        while (_pumpedEvents.TryDequeue(out var evt))
        {
            ProcessEvent(in evt, handler);
        }

        foreach (var device in _devices)
        {
            if (device is SdlKeyboard keyboard)
            {
                keyboard.UpdateModState();
            }
        }
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

    private ulong GetTimestamp(in Event @event) =>
        unchecked((ulong)(_epoch + (@event.Common.Timestamp * _ticksPerNanosecond)));

    private unsafe byte OnEvent(void* arg0, Event* arg1)
    {
        _pumped = true;
        _pumpedEvents.Add(ref *arg1);
        return 1;
    }

    private void ProcessEvent(in Event evt, IInputHandler handler)
    {
        var timestamp = GetTimestamp(in evt);
        Debug.Assert(timestamp >= _previousTimestamp, "Events out of order");
        _previousTimestamp = timestamp;

        // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
        var type = (EventType)evt.Common.Type;

        switch (type)
        {
            case EventType.GamepadRemoved:
                RemoveDevice<SdlGamepad>(_devices, evt.Gdevice.Which);
                return;
            case EventType.JoystickRemoved:
                RemoveDevice<SdlJoystick>(_devices, evt.Jdevice.Which);
                return;
            case EventType.KeyboardRemoved:
                RemoveDevice<SdlKeyboard>(_devices, evt.Kdevice.Which);
                return;
            case EventType.MouseRemoved:
                RemoveDevice<SdlSharedMouse>(_devices, evt.Mdevice.Which);
                RemoveDevice<SdlUnboundedMouse>(_devices, evt.Mdevice.Which);
                return;
            case >= EventType.KeyDown and <= EventType.TextEditingCandidates:
            {
                if (!TryGetOrCreateDevice<SdlKeyboard>(evt.Kdevice.Which, out var keyboard))
                {
                    return;
                }

                if (type == EventType.KeyboardAdded)
                {
                    return;
                }

                switch (type)
                {
                    case EventType.KeyDown:
                    case EventType.KeyUp:
                        keyboard.AddKeyEvent(evt.Key);
                        break;
                    case EventType.TextEditing:
                        keyboard.AddTextEditingEvent(evt.Edit);
                        break;
                    case EventType.TextEditingCandidates:
                        keyboard.AddTextCandidatesEvent(evt.EditCandidates);
                        break;
                    case EventType.TextInput:
                        keyboard.AddTextInputEvent(evt.Text);
                        break;
                }

                break;
            }
            case >= EventType.GamepadAxisMotion and <= EventType.GamepadSteamHandleUpdated:
            {
                if (!TryGetOrCreateDevice<SdlGamepad>(evt.Gdevice.Which, out var gamepad))
                {
                    return;
                }

                if (type is EventType.GamepadAdded)
                {
                    return;
                }

                switch (type)
                {
                    case EventType.GamepadAxisMotion:
                        gamepad.AddAxisEvent(evt.Gaxis.Axis, evt.Gaxis.Value);
                        break;
                    case EventType.GamepadButtonDown:
                    case EventType.GamepadButtonUp:
                        gamepad.AddButtonEvent(evt.Gbutton.Button, evt.Gbutton.Down);
                        break;
                    case EventType.GamepadRemapped:
                        gamepad.Remap();
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
                }

                break;
            }
            case >= EventType.JoystickAxisMotion and <= EventType.JoystickUpdateComplete:
            {
                if (!TryGetOrCreateDevice<SdlJoystick>(evt.Jdevice.Which, out var joystick))
                {
                    return;
                }

                if (type is EventType.JoystickAdded)
                {
                    // already done
                    return;
                }

                switch (type)
                {
                    case EventType.JoystickAxisMotion:
                        joystick.AddAxisEvent(evt.Jaxis.Axis, evt.Jaxis.Value);
                        break;
                    case EventType.JoystickBallMotion:
                        // todo: ball events?
                        break;
                    case EventType.JoystickHatMotion:
                        joystick.AddHatEvent(evt.Jhat.Hat, evt.Jhat.Value);
                        break;
                    case EventType.JoystickButtonDown:
                    case EventType.JoystickButtonUp:
                        joystick.AddButtonEvent(evt.Jbutton.Button, evt.Jbutton.Down);
                        break;
                    case EventType.JoystickBatteryUpdated:
                        break;
                    case EventType.JoystickUpdateComplete:
                        break;
                }
                break;
            }
            case >= EventType.MouseMotion and <= EventType.MouseAdded:
            {
                if(!TryGetOrCreateDevice<SdlSharedMouse>(evt.Mdevice.Which, out var mouse))
                {
                    return;
                }

                if (type is EventType.MouseAdded)
                {
                    return;
                }

                switch (type)
                {
                    case EventType.MouseMotion:
                        mouse.AddMotion(evt.Motion);
                        break;
                    case EventType.MouseButtonDown:
                    case EventType.MouseButtonUp:
                        mouse.AddButtonEvent(evt.Button);
                        break;
                    case EventType.MouseWheel:
                        mouse.AddWheelEvent(evt.Wheel);
                        break;
                }

                break;
            }
        }

        switch (type)
        {
            //  Input events ----------------------------------------------------------

            // sensor? for what?
            case EventType.SensorUpdate:
                break;

            // ----- Pointer events

            // mouse
            case EventType.MouseMotion:
                break;
            case EventType.MouseButtonDown:
                break;
            case EventType.MouseButtonUp:
                break;
            case EventType.MouseWheel:
                break;

            // touch
            case EventType.FingerDown:
                break;
            case EventType.FingerUp:
                break;
            case EventType.FingerMotion:
                break;
            case EventType.FingerCanceled:
                break;

            // pen
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

            // Display & window (pointer target) events ----------------------------
            case EventType.DisplayOrientation:
            case EventType.DisplayAdded:
            case EventType.DisplayRemoved:
            case EventType.DisplayMoved:
            case EventType.DisplayDesktopModeChanged:
            case EventType.DisplayCurrentModeChanged:
            case EventType.DisplayContentScaleChanged:
            {
                var bounds = SdlBoundedPointerTarget.CalculateAllDisplayBounds(Sdl);
                var x = (QueuedEventType.BoundedPointerTargetUpdate,
                        timestamp,
                        bounds.Min.ToSystem(),
                        bounds.Max.ToSystem()
                    );
                Console.WriteLine($"Display bounds changed: {x.BoundedPointerTargetUpdate}");
                break;
            }
            case EventType.WindowMouseLeave
                : // do we need to do anything? we should probably track the current window of the pointer
            {
                //var x = (QueuedEventType.MouseExitedWindow, timestamp);
                break;
            }

            // Text input events -------------------------------------------
            // todo: attribute this to a keyboard device? or something else?
            case EventType.TextEditing:
                break;
            case EventType.TextInput:
                break;
            case EventType.TextEditingCandidates:
                break;
            case EventType.ClipboardUpdate:
                break;
        }
    }

    internal bool TryGetOrCreateDevice<T>(uint id, [NotNullWhen(true)] out T? device) where T : SdlDevice, ISdlDevice<T>
    {
        // If we already have a device with this ID, return it.
        for (var i = 0; i < _devices.Count; i++)
        {
            if (_devices[i] is T typedDevice && typedDevice.SdlDeviceId == id)
            {
                device = typedDevice;
                return true;
            }
        }

        try
        {
            device = T.CreateDevice(id, this);
        }
        catch (Exception e)
        {
            Console.Error.WriteLine($"Failed to create device {nameof(T)} with id '{id}': {e}");
            device = null;
            return false;
        }

        if (device is null)
        {
            Console.Error.WriteLine($"Failed to create device {nameof(T)} with id '{id}'");
            return false;
        }


        _devices.Add(device);
        Console.WriteLine($"Gamepad added: (sdl ID: {id})");
        return true;
    }

    private static bool RemoveDevice<T>(List<SdlDevice> devices, uint id)
    {
        var deviceIdx = devices.FindIndex(x => x is T && x.SdlDeviceId == id);

        if (deviceIdx == -1)
        {
            // we never used this device to begin with, so just ignore its removal
            return false;
        }

        var device = devices[deviceIdx];
        device.Dispose();
        devices.RemoveAt(deviceIdx);

        // device IDs may have changed when a device was removed, so we need to refresh them
        RefreshDeviceIds(devices);
        return true;
    }

    private static void RefreshDeviceIds(List<SdlDevice> devices)
    {
        for (var i = 0; i < devices.Count; i++)
        {
            if (devices[i] is IOrderedDevice d)
            {
                d.RefreshSdlId();
            }
        }
    }

    private ulong _previousTimestamp = ulong.MinValue;

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

    private class EventQueue
    {
        private readonly Queue<Event> _events = new(1024);
        public void Add(ref Event p0) => _events.Enqueue(p0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryDequeue(out Event p0) => _events.TryDequeue(out p0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Clear() => _events.Clear();
    }

    internal unsafe bool TryGetPointerTargetForWindow(WindowHandle window, [NotNullWhen(true)] out IPointerTarget? target)
    {
        if (window.Handle == null)
        {
            target = null;
            return false;
        }

        var id = _sdl.GetWindowID(window);
        return TryGetPointerTargetForWindow(id, out target);
    }

    internal bool TryGetPointerTargetForWindow(uint id, [NotNullWhen(true)] out IPointerTarget? target)
    {
        if (id == 0)
        {
            target = null;
            return false;
        }

        // todo : get the SDL window (or other window) with the given ID
        target = null;
        throw new NotImplementedException();
    }
}
