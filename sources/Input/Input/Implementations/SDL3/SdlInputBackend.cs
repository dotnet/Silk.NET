// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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

    public WindowHandle? FocusedWindow => _eventProcessingArgs.FocusedWindow;

    public readonly ICursorConfiguration CursorConfiguration;

    private const uint SdlInitFlags =
        SDL.Sdl.InitJoystick | SDL.Sdl.InitGamepad | SDL.Sdl.InitEvents | SDL.Sdl.InitHaptic | SDL.Sdl.InitSensor;


    public unsafe SdlInputBackend(SdlPlatformInfo info)
    {
        Sdl = info.Sdl ?? SDL.Sdl.Instance;



        if (Sdl == null)
        {
            throw new ArgumentNullException(nameof(info), "No SDL instance was provided or found.");
        }

        _getDisplayHandles = GetDisplayHandles;
        _getWindowHandles = GetWindowHandles;
        _getWindowId = GetWindowId;
        _getDisplayId = GetDisplayId;

        var ptr = new EventFilter(OnEvent);
        if (!Sdl.AddEventWatch(ptr, (Ref)nullptr))
        {
            Sdl.ThrowError();
        }

        Id = (nint)ptr.Handle;
        CursorConfiguration = new SdlCursor(Sdl);
        InitializeEventQueue(out _silkEvents);
        _eventProcessingArgs = new ProcessEventArgs(this, _silkEvents.ConnectionSdlEvents);


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

            _eventProcessingArgs.FocusedWindow = focusedWindow;
        }


        if (!Sdl.InitSubSystem(SdlInitFlags))
        {
            SdlLog.Error("Failed to initialize SDL gamepad subsystem.");
        }

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

        return;
        static void InitializeEventQueue(out SilkEventContext context)
        {
            // Create our event queue with maximal timestamp accuracy

            // The SDL timestamps deal in nanoseconds, so we take multiple measurements to get the most accurate
            // relationship between SDL and Stopwatch timeestamps
            const byte measurementCount = 4;
            Span<SdlTimestampCalculator.Basis> calibrations = stackalloc SdlTimestampCalculator.Basis[measurementCount];
            for (byte i = 0; i < measurementCount; i++)
            {
                long nowTimestamp;
                ulong nowSdl;

                // alternate the order in which we do it, so we get a more accurate average that is not influenced
                // as much by the time it takes to acquire each type of measurement
                if (i % 2 == 0)
                {
                    nowTimestamp = Stopwatch.GetTimestamp();
                    nowSdl = Silk.NET.SDL.Sdl.GetTicksNS();
                }
                else
                {
                    nowSdl = Silk.NET.SDL.Sdl.GetTicksNS();
                    nowTimestamp = Stopwatch.GetTimestamp();
                }

                calibrations[i] = new SdlTimestampCalculator.Basis(nowSdl, nowTimestamp);
            }

            context = new SilkEventContext(calibrations.Average());
        }
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
        if (handler == null)
        {
            _pumpedSdlEvents.Clear();
            return;
        }

        // QUESTION - do we want this before or after the event processing? or should
        // it always just be done in the same way as other input events? e.g. via events
        // windows can change without input events being processed... but who cares? as long as the devices
        // have the latest information when they're updated, we should be good?
        UpdatePointerTargets(_eventProcessingArgs.SdlWindowTargets, _eventProcessingArgs.SdlDisplayTargets);

        // actually process the events
        if (!_pumpedSdlEvents.HasEvents)
        {
            return;
        }

        while (_pumpedSdlEvents.TryDequeue(out var evt))
        {
            _pumpedSdlEventsSorted.Add(evt);
        }

        var sortedSpan = CollectionsMarshal.AsSpan(_pumpedSdlEventsSorted);
        sortedSpan.StableSort((x, y) => x.Event.Common.Timestamp.CompareTo(y.Event.Common.Timestamp));

        foreach (var evt in _pumpedSdlEventsSorted)
        {
            ProcessEvent(evt.Event, evt.Timestamp, ref _eventProcessingArgs);
        }

        _pumpedSdlEventsSorted.Clear();

        var devices = _eventProcessingArgs.Devices;
        for (var index = 0; index < devices.Count; index++)
        {
            var device = devices[index];
            if (device is SdlGamepad gamepad)
            {
                gamepad.ExecuteRumble();
            }

            if (device is INeedFinalizationEachFrame needer)
            {
                needer.FinalizeUpdate();
            }
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

    /// <summary>
    /// Interprets SDL events to apply to our input devices
    /// </summary>
    /// <param name="evt"></param>
    /// <param name="timestamp"></param>
    /// <param name="processEventArgs"></param>
    /// <seealso href="https://wiki.libsdl.org/SDL3/SDL_EventType"/>
    private static void ProcessEvent(in Event evt, long timestamp, ref ProcessEventArgs processEventArgs)
    {
        var backend = processEventArgs.Backend;
        if (evt.Common.Timestamp < processEventArgs.PreviousTimestamp)
        {
            InputLog.Error("Events out of order");
        }

        processEventArgs.PreviousTimestamp = evt.Common.Timestamp;

        // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
        var type = (EventType)evt.Common.Type;

        switch (type)
        {
            case EventType.GamepadAdded:
                backend.TryGetOrCreateDevice<SdlGamepad>(evt.Kdevice.Which, timestamp, evt.Common.Timestamp, out _);
                return;
            case EventType.GamepadRemoved:
                backend.RemoveDevice<SdlGamepad>(evt.Gdevice.Which, timestamp, evt.Common.Timestamp);
                return;
            case EventType.JoystickAdded:
                backend.TryGetOrCreateDevice<SdlJoystick>(evt.Kdevice.Which, timestamp, evt.Common.Timestamp, out _);
                return;
            case EventType.JoystickRemoved:
                backend.RemoveDevice<SdlJoystick>(evt.Jdevice.Which, timestamp, evt.Common.Timestamp);
                return;
            case EventType.KeyboardAdded:
                backend.TryGetOrCreateDevice<SdlKeyboard>(evt.Kdevice.Which, timestamp, evt.Common.Timestamp, out _);
                return;
            case EventType.KeyboardRemoved:
                backend.RemoveDevice<SdlKeyboard>(evt.Kdevice.Which, timestamp, evt.Common.Timestamp);
                return;
            case EventType.MouseAdded:
                backend.TryGetOrCreateDevice<SdlMouse>(evt.Mdevice.Which, timestamp, evt.Common.Timestamp, out _);
                return;
            case EventType.MouseRemoved:
                backend.RemoveDevice<SdlMouse>(evt.Mdevice.Which, timestamp, evt.Common.Timestamp);
                return;
            case EventType.PenProximityIn:
                _ = backend.TryGetOrCreateDevice<SdlPen>(evt.Ptouch.Which, timestamp, evt.Common.Timestamp, out _);
                return;
            case EventType.PenProximityOut:
                backend.RemoveDevice<SdlPen>(evt.Ptouch.Which, timestamp, evt.Common.Timestamp);
                break;

            // Keyboard events
            case >= EventType.KeyDown and <= EventType.TextEditingCandidates:
            {
                if (!backend.TryGetOrCreateDevice<SdlKeyboard>(evt.Kdevice.Which, timestamp, evt.Common.Timestamp, out var keyboard))
                {
                    return;
                }

                switch (type)
                {
                    case EventType.KeyDown:
                    case EventType.KeyUp:
                        keyboard.AddKeyEvent(evt.Key, timestamp);
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
                if (!backend.TryGetOrCreateDevice<SdlGamepad>(evt.Gdevice.Which, timestamp, evt.Common.Timestamp,
                        out var gamepad))
                {
                    return;
                }

                switch (type)
                {
                    case EventType.GamepadAxisMotion:
                        // gamepad.AddAxisEvent(evt.Gaxis.Axis, evt.Gaxis.Value, evt.Gaxis.Timestamp, timestamp);
                        break;
                    case EventType.GamepadButtonDown:
                    case EventType.GamepadButtonUp:
                        // gamepad.AddButtonEvent(evt.Gbutton.Button, evt.Gbutton.Down, evt.Gbutton.Timestamp, timestamp);
                        break;
                    case EventType.GamepadRemapped:
                        gamepad.Remap(timestamp, evt.Common.Timestamp);
                        break;

                    // todo - sensor + touchpad
                    case EventType.GamepadTouchpadDown:
                    case EventType.GamepadTouchpadMotion:
                    case EventType.GamepadTouchpadUp:
                    case EventType.GamepadSensorUpdate:
                    case EventType.GamepadUpdateComplete:
                    case EventType.GamepadSteamHandleUpdated:
                    {
#if DEBUG
                        InputLog.Debug(type.ToString());
#endif
                        break;
                    }
                }

                break;
            }

            // Joystick events
            case >= EventType.JoystickAxisMotion and <= EventType.JoystickUpdateComplete:
            {
                if (!backend.TryGetOrCreateDevice<SdlJoystick>(evt.Jdevice.Which, timestamp, evt.Common.Timestamp, out var joystick))
                {
                    return;
                }

                switch (type)
                {
                    case EventType.JoystickAxisMotion:
                        joystick.AddAxisEvent(evt.Jaxis.Axis, evt.Jaxis.Value, evt.Jaxis.Timestamp, timestamp);
                        break;
                    case EventType.JoystickBallMotion:
                        joystick.AddBallEvent(evt.Jball.Ball, evt.Jball.Xrel, evt.Jball.Yrel, evt.Jball.Timestamp, timestamp);
                        break;
                    case EventType.JoystickHatMotion:
                        joystick.AddHatEvent(evt.Jhat.Hat, evt.Jhat.Value, evt.Jhat.Timestamp, timestamp);
                        break;
                    case EventType.JoystickButtonDown:
                    case EventType.JoystickButtonUp:
                        joystick.AddButtonEvent(evt.Jbutton.Button, evt.Jbutton.Down, evt.Jbutton.Timestamp, timestamp);
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
                if (!backend.TryGetOrCreateDevice<SdlMouse>(evt.Mdevice.Which, timestamp, evt.Common.Timestamp, out var mouse))
                {
                    return;
                }

                switch (type)
                {
                    case EventType.MouseMotion:
                        mouse.AddMotion(evt.Motion, timestamp);
                        break;
                    case EventType.MouseButtonDown:
                    case EventType.MouseButtonUp:
                        mouse.AddButtonEvent(evt.Button, timestamp);
                        break;
                    case EventType.MouseWheel:
                        mouse.AddWheelEvent(evt.Wheel, timestamp);
                        break;
                }

                break;
            }

            // Pen events
            case > EventType.PenProximityIn and <= EventType.PenAxis:
            {
                Debug.Assert(type != EventType.PenProximityOut);


                if (!backend.TryGetOrCreateDevice<SdlPen>(evt.Ptouch.Which, timestamp, evt.Common.Timestamp,
                        out var penDevice))
                {
                    return;
                }


                switch (type)
                {
                    case EventType.PenDown:
                    case EventType.PenUp:
                    {
                        penDevice.UpDownEvent(evt.Ptouch, timestamp);
                        break;
                    }
                    case EventType.PenButtonDown:
                    case EventType.PenButtonUp:
                    {
                        penDevice.ButtonEvent(evt.Pbutton, timestamp);
                        break;
                    }
                    case EventType.PenMotion:
                    {
                        penDevice.MotionEvent(evt.Pmotion, timestamp);
                        break;
                    }
                    case EventType.PenAxis:
                    {
                        penDevice.AxisEvent(evt.Paxis, timestamp);
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
                if (!backend.TryGetOrCreateDevice<SdlTouchSurface>(device, timestamp, evt.Common.Timestamp, out var touchDevice))
                {
                    return;
                }

                touchDevice.Event(finger, (FingerEventType)finger.Type, timestamp);
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
            // todo - update pointer targets - probably for windows, not displays, except for unbounded targets?
            //  what about the event where a window/display moves, but a pointer does not? do we force-update the
            //  pointer device too to get the updated position? probably not.. hopefully SDL handles that internally
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
                        evt.Common.Timestamp,
                        bounds.Min.ToSystem(),
                        bounds.Max.ToSystem()
                    );

                // var id = evt.Display.DisplayID;

                InputLog.Debug($"Display bounds changed: {x.BoundedPointerTargetUpdate}");
                break;
            }
            case EventType.WindowMouseEnter:
                break;
            case EventType.WindowMouseLeave
                : // do we need to do anything? we should probably track the current window of the pointer
            {
                //var x = (QueuedEventType.MouseExitedWindow, timestamp);
                break;
            }
            case EventType.WindowMoved:
                break;
            case EventType.WindowMinimized:
                break;
            case EventType.WindowFocusGained:
                processEventArgs.FocusedWindow = processEventArgs.Backend.Sdl.GetWindowFromID(evt.Window.WindowID);
                break;
            case EventType.WindowFocusLost:
                processEventArgs.FocusedWindow = null;
                break;
            case EventType.WindowLeaveFullscreen:
                break;
            case EventType.WindowEnterFullscreen:
                break;
            case EventType.WindowExposed:
                break;
            case EventType.WindowHidden:
                break;
            case EventType.WindowDestroyed:
                break;
            case EventType.WindowShown:
                break;

            // window scaling changes:
            case EventType.WindowSafeAreaChanged:
                break;
            case EventType.WindowResized:
                break;
            case EventType.WindowRestored:
                break;
            case EventType.WindowMaximized:
                break;
            case EventType.WindowPixelSizeChanged:
                break;
            case EventType.WindowDisplayChanged:
                break;
            case EventType.WindowDisplayScaleChanged:
                break;
        }

        #endregion
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
        Sdl.QuitSubSystem(SdlInitFlags);
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

        var id = Sdl.GetWindowID(window);
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

        for (var i = 0; i < _eventProcessingArgs.SdlWindowTargets.Count; ++i)
        {
            var t = _eventProcessingArgs.SdlWindowTargets[i];
            if (t.Id == id)
            {
                target = t;
                return true;
            }

        }

        target = null;
        return false;
    }

    private readonly struct TimedRawSdlEvent
    {
        public readonly long Timestamp;
        public readonly Event Event;

        public TimedRawSdlEvent(Event @event, long timestamp)
        {
            Event = @event;
            Timestamp = timestamp;
        }
    }

    private class SdlEventQueue
    {
        private TimedRawSdlEvent[] _events = new TimedRawSdlEvent[256];
        private int _nextEventIndex;
        public void Add(ref Event p0)
        {
            var timestamp = Stopwatch.GetTimestamp();
            _isSorted = false;
            if (_nextEventIndex == _events.Length)
            {
                Array.Resize(ref _events, _events.Length * 2);
            }

            _events[_nextEventIndex++] = new TimedRawSdlEvent(p0, timestamp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryDequeue(out TimedRawSdlEvent p0)
        {
            if (_nextEventIndex == 0)
            {
                p0 = default;
                return false;
            }

            if (!_isSorted)
            {
                // sort the events by timestamp
                var span = _events.AsSpan(0, _nextEventIndex);

                // order in descending order, such that "de-queueing" the last event will return the first chronological event in the queue (last event in the array)
                span.StableSort((e1, e2) => e2.Timestamp.CompareTo(e1.Timestamp));
                _isSorted = true;
            }

            p0 = _events[--_nextEventIndex];
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Clear()
        {
            _nextEventIndex = 0;
            _isSorted = false;
        }

        public bool HasEvents => _nextEventIndex > 0;

        private bool _isSorted;

    }

    private struct ProcessEventArgs
    {
        public readonly SdlInputBackend Backend;
        public readonly IReadOnlyList<SdlDevice> Devices => _devices;
        public WindowHandle? FocusedWindow;
        public readonly List<SdlWindowTarget> SdlWindowTargets;
        public readonly List<SdlDisplayTarget> SdlDisplayTargets;
        public ulong PreviousTimestamp;
        private readonly List<SdlDevice> _devices;
        private readonly ISdlEventQueue<ConnectionEvent> _connectionEventQueue;
        private readonly HashSet<nint> _deviceRegistry = [];

        public ProcessEventArgs(SdlInputBackend backend, ISdlEventQueue<ConnectionEvent> connectionEventQueue)
        {
            Backend = backend;
            PreviousTimestamp = ulong.MinValue;
            _devices = [];
            SdlWindowTargets = [];
            SdlDisplayTargets = [];
            _connectionEventQueue = connectionEventQueue;
        }

        public void AddDevice<T>(T device, long timestamp, ulong sdlTimestamp) where T : SdlDevice, ISdlDevice<T>
        {
            if (!_deviceRegistry.Add(device.Id))
            {
                InputLog.Error($"Tried to add device with id {device.Id} that was already registered");
                return;
            }

            _devices.Add(device);
            _connectionEventQueue.Enqueue(new ConnectionEvent(device, timestamp, true), sdlTimestamp);
        }

        public bool RemoveDevice<T>(uint id, long timestamp, ulong sdlTimestamp, [NotNullWhen(true)] out SdlDevice? device) where T : SdlDevice, ISdlDevice<T>
        {
            var deviceIdx = _devices.FindIndex(x => x is T && x.SdlDeviceId == id);

            if (deviceIdx == -1)
            {
                // we never used this device to begin with, so just ignore its removal
                device = null;
                return false;
            }

            device = _devices[deviceIdx];
            device.Dispose();
            _devices.RemoveAt(deviceIdx);
            // note - registration is handled in the device ID creation process
            if (!_deviceRegistry.Remove(device.Id))
            {
                InputLog.Error($"Tried to unregister device with id {device.Id} that was not registered");
                return false;
            }

            _connectionEventQueue.Enqueue(new ConnectionEvent(device, timestamp, false), sdlTimestamp);
            return true;
        }

        public bool ContainsDevice(nint uniqueId) => _deviceRegistry.Contains(uniqueId);
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

    // NOTE: Be careful where these are used!

    private ProcessEventArgs _eventProcessingArgs;
    private bool _pumped;
    private readonly List<TimedRawSdlEvent> _pumpedSdlEventsSorted = new();
    private readonly SdlEventQueue _pumpedSdlEvents = new();
    private readonly SilkEventContext _silkEvents;
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
