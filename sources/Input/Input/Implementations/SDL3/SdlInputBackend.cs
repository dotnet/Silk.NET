// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Buffers;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.Input.SDL3.Devices.Joysticks;
using Silk.NET.Input.SDL3.Devices.Pointers;
using Silk.NET.Input.SDL3.Devices.Pointers.Targets;
using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal partial class SdlInputBackend : IInputBackend
{
    [field: MaybeNull]
    public SdlUnboundedPointerTarget UnboundedPointerTarget =>
        field ??= new SdlUnboundedPointerTarget(this);

    public ISdl Sdl { get; }

    public string Name =>
        $"Silk.NET.Input Reference Implementation using SDL3 ({Sdl.GetPlatform().ReadToString()})";

    public nint Id { get; }

    public IReadOnlyList<IInputDevice> Devices => _eventProcessingArgs.Devices;

    // todo - properly implement window focus tracking
    public WindowHandle? FocusedWindow { get; private set; }

    public readonly ICursorConfiguration CursorConfiguration;

    public unsafe SdlInputBackend(SdlPlatformInfo info)
    {
        Sdl = info.Sdl ?? SDL.Sdl.Instance;
        if (Sdl == null)
        {
            throw new ArgumentNullException(nameof(info), "No SDL instance was provided or found.");
        }

        if (info.Window == nullptr)
        {
            var focusedWindow = Sdl.GetMouseFocus();
            if (focusedWindow == nullptr)
            {
                focusedWindow = Sdl.GetKeyboardFocus();
            }

            if (focusedWindow == nullptr)
            {
                throw new ArgumentNullException(nameof(info), "No window was provided and no window had focus.");
            }

            FocusedWindow = focusedWindow;
        }

        _getDisplayHandles = GetDisplayHandles;
        _getWindowHandles = GetWindowHandles;
        _getWindowId = GetWindowId;
        _getDisplayId = GetDisplayId;
        _eventProcessingArgs = new ProcessEventArgs(this);

        var ptr = new EventFilter(OnEvent);
        // TODO overload resolution priority?
        if (!Sdl.AddEventWatch(ptr, (Ref)nullptr))
        {
            Sdl.ThrowError();
        }

        Id = (nint)ptr.Handle;
        CursorConfiguration = new SdlCursor(Sdl);

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


    // TODO we can't query support for these modes, but should we try-it-and-see to be accurate?

    // TODO if you're using one input context for all windows, there is no way to specify a window for grabbed cursor mode


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
            _pumpedSdlEvents.Clear();
            return;
        }

        // todo - do we want this before or after the event processing? or should
        // it always just be done in the same way as other input events? e.g. via events
        // windows can change without input events being processed... but who cares? as long as the devices
        // have the latest information when they're updated, we should be good?
        UpdatePointerTargets(_eventProcessingArgs.SdlWindowTargets, _eventProcessingArgs.DisplayTargets);

        // actually process the events
        if (!_pumpedSdlEvents.HasEvents)
        {
            return;
        }


        while (_pumpedSdlEvents.TryDequeue(out var evt))
        {
            ProcessEvent(evt, ref _eventProcessingArgs);
        }

        foreach (var device in _eventProcessingArgs.Devices)
        {
            // todo - implement this for all device types instead
            device.FinalizeUpdate(_silkEvents);
        }

        _silkEvents.RaiseEvents(handler);
    }


    // ?? [UnmanagedFunctionPointer()]
    private unsafe byte OnEvent(void* arg0, Event* arg1)
    {
        _pumped = true;
        _pumpedSdlEvents.Add(ref *arg1);
        return 1;
    }

    private static void ProcessEvent(in Event evt, ref ProcessEventArgs processEventArgs)
    {
        var backend = processEventArgs.Backend;
        var devices = processEventArgs.Devices;
        var timestamp = GetTimestamp(in evt);
        Debug.Assert(timestamp >= processEventArgs.PreviousTimestamp, "Events out of order");
        processEventArgs.PreviousTimestamp = timestamp;

        // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
        var type = (EventType)evt.Common.Type;

        switch (type)
        {
            case EventType.GamepadAdded:
                return;
            case EventType.GamepadRemoved:
                backend.RemoveDevice<SdlGamepad>(devices, evt.Gdevice.Which);
                return;
            case EventType.JoystickRemoved:
                backend.RemoveDevice<SdlJoystick>(devices, evt.Jdevice.Which);
                return;
            case EventType.KeyboardRemoved:
                backend.RemoveDevice<SdlKeyboard>(devices, evt.Kdevice.Which);
                return;
            case EventType.MouseRemoved:
                backend.RemoveDevice<SdlMouse>(devices, evt.Mdevice.Which);
                return;
            case EventType.PenProximityOut:
                backend.RemoveDevice<SdlPen>(devices, evt.Ptouch.Which);
                break;

            // Keyboard events
            case >= EventType.KeyDown and <= EventType.TextEditingCandidates:
            {
                if (!backend.TryGetOrCreateDevice<SdlKeyboard>(evt.Kdevice.Which, out var keyboard))
                {
                    return;
                }

                switch (type)
                {
                    case EventType.KeyboardAdded:
                        return;
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

            #region Joysticks

            // Gamepad events
            case >= EventType.GamepadAxisMotion and <= EventType.GamepadSteamHandleUpdated:
            {
                if (!backend.TryGetOrCreateDevice<SdlGamepad>(evt.Gdevice.Which, out var gamepad))
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

                    // todo - sensor + touchpad
                    case EventType.GamepadTouchpadDown:
                    case EventType.GamepadTouchpadMotion:
                    case EventType.GamepadTouchpadUp:
                    case EventType.GamepadSensorUpdate:
                    case EventType.GamepadUpdateComplete:
                    case EventType.GamepadSteamHandleUpdated:
                        break;
                }

                break;
            }

            // Joystick events
            case >= EventType.JoystickAxisMotion and <= EventType.JoystickUpdateComplete:
            {
                if (!backend.TryGetOrCreateDevice<SdlJoystick>(evt.Jdevice.Which, out var joystick))
                {
                    return;
                }

                switch (type)
                {
                    case EventType.JoystickAdded:
                        return;
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

            #endregion

            #region Pointers

            // Mouse events
            case >= EventType.MouseMotion and <= EventType.MouseAdded:
            {
                if (!backend.TryGetOrCreateDevice<SdlMouse>(evt.Mdevice.Which, out var mouse))
                {
                    return;
                }

                switch (type)
                {
                    case EventType.MouseAdded:
                        return;
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

            // Pen events
            case >= EventType.PenProximityIn and <= EventType.PenAxis:
            {
                Debug.Assert(type != EventType.PenProximityOut);

                var which = evt.Ptouch.Which;
                if (!backend.TryGetOrCreateDevice<SdlPen>(which, out var penDevice))
                {
                    return;
                }


                switch (type)
                {
                    case EventType.PenProximityIn:
                    {
                        return;
                    }
                    case EventType.PenDown:
                    case EventType.PenUp:
                    {
                        penDevice.UpDownEvent(evt.Ptouch);
                        break;
                    }
                    case EventType.PenButtonDown:
                    case EventType.PenButtonUp:
                    {
                        penDevice.ButtonEvent(evt.Pbutton);
                        break;
                    }
                    case EventType.PenMotion:
                    {
                        penDevice.MotionEvent(evt.Pmotion);
                        break;
                    }
                    case EventType.PenAxis:
                    {
                        penDevice.AxisEvent(evt.Paxis);
                        break;
                    }
                }

                break;
            }

            // Touch events
            case >= EventType.FingerDown and <= EventType.FingerCanceled:
            {
                var finger = evt.Tfinger;
                var device = finger.TouchID;
                if (!backend.TryGetOrCreateDevice<SdlTouchSurface>(device, out var touchDevice))
                {
                    return;
                }

                touchDevice.Event(finger, (FingerEventType)finger.Type);
                break;
            }

            #endregion
        }

        #region unimplemented

        switch (type)
        {
            //  Input events ----------------------------------------------------------

            // sensor? for what?
            case EventType.SensorUpdate:
            {
                break;
            }

            // Display & window (pointer target) events ----------------------------
            // todo - update pointer targets list based on add/remove?
            //  unless the way we currently collect them is sufficient
            // (see PopulatePointerTargets in SdlInputBackend.Targets.cs)
            case EventType.DisplayOrientation:
            case EventType.DisplayAdded:
            case EventType.DisplayRemoved:
            case EventType.DisplayMoved:
            case EventType.DisplayDesktopModeChanged:
            case EventType.DisplayCurrentModeChanged:
            case EventType.DisplayContentScaleChanged:
            {
                var bounds = SdlBoundedPointerTarget.CalculateAllDisplayBounds(backend.Sdl);
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
        }

        #endregion

        return;

        ulong GetTimestamp(in Event @event) =>
            unchecked((ulong)(backend._epoch + (@event.Common.Timestamp * _ticksPerNanosecond)));
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

    internal unsafe bool TryGetPointerTargetForWindow(WindowHandle window,
        [NotNullWhen(true)] out IPointerTarget? target)
    {
        if (window.Handle == null)
        {
            target = null;
            return false;
        }

        var id = Sdl!.GetWindowID(window);
        return TryGetPointerTargetForWindow(id, out target);
    }

    internal bool TryGetPointerTargetForWindow(uint id,
        [NotNullWhen(true)] out IPointerTarget? target)
    {
        if (id == 0)
        {
            target = null;
            return false;
        }

        target = _eventProcessingArgs.SdlWindowTargets.FirstOrDefault(x => x.Id == id);
        return target != null;
    }


    private class SdlEventQueue
    {
        private readonly Queue<Event> _events = new(1024);
        public void Add(ref Event p0) => _events.Enqueue(p0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryDequeue(out Event p0) => _events.TryDequeue(out p0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Clear() => _events.Clear();

        public bool HasEvents => _events.Count > 0;
    }

    private struct ProcessEventArgs
    {
        public readonly SdlInputBackend Backend;
        public readonly List<SdlDevice> Devices;
        public readonly List<SdlWindowTarget> SdlWindowTargets;
        public readonly List<SdlDisplayTarget> DisplayTargets;
        public ulong PreviousTimestamp;

        public ProcessEventArgs(SdlInputBackend backend)
        {
            Backend = backend;
            PreviousTimestamp = ulong.MinValue;
            Devices = [];
            SdlWindowTargets = [];
            DisplayTargets = [];
        }
    }

    internal enum FingerEventType : uint
    {
        Down = EventType.FingerDown,
        Up = EventType.FingerUp,
        Motion = EventType.FingerMotion,
        Canceled = EventType.FingerCanceled
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

    private readonly HashSet<nint> _deviceRegistry = [];

    // NOTE: Be careful where these are used!
    private static readonly double _ticksPerNanosecond = Stopwatch.Frequency / 10e9d;

    private ProcessEventArgs _eventProcessingArgs;
    private bool _pumped;
    private readonly long _epoch;
    private readonly SdlEventQueue _pumpedSdlEvents = new();
    private readonly SilkEventQueues _silkEvents = new();
}

[Flags]
internal enum SdlPenInputFlags : uint
{
    Down = SDL.Sdl.PenInputDown,
    Button1 = SDL.Sdl.PenInputButton1,
    Button2 = SDL.Sdl.PenInputButton2,
    Button3 = SDL.Sdl.PenInputButton3,
    Button4 = SDL.Sdl.PenInputButton4,
    Button5 = SDL.Sdl.PenInputButton5,

    EraserTip = SDL.Sdl.PenInputEraserTip,

    // Sdl 3.4
    PenInProximity = SDL.Sdl.PenInputEraserTip << 1
}

[Flags]
internal enum SdlMouseInputFlags : uint
{
    LeftButtonDown = SDL.Sdl.ButtonLmask,
    MiddleButtonDown = SDL.Sdl.ButtonMiddle,
    RightButtonDown = SDL.Sdl.ButtonRmask,
    XButton1Down = SDL.Sdl.ButtonX1Mask,
    XButton2Down = SDL.Sdl.ButtonX2Mask,
}
