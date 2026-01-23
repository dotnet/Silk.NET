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
            _silkEvents.ClearEvents();
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

            // Keyboard events
            case >= EventType.KeyDown and <= EventType.TextEditingCandidates:
            {
                if (!backend.TryGetOrCreateDevice<SdlKeyboard>(evt.Kdevice.Which, out var keyboard))
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

            #region Joysticks

            // Gamepad events
            case >= EventType.GamepadAxisMotion and <= EventType.GamepadSteamHandleUpdated:
            {
                if (!backend.TryGetOrCreateDevice<SdlGamepad>(evt.Gdevice.Which, out var gamepad))
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

            #endregion

            #region Pointers

            // Mouse events
            case >= EventType.MouseMotion and <= EventType.MouseAdded:
            {
                if (!backend.TryGetOrCreateDevice<SdlMouse>(evt.Mdevice.Which, out var mouse))
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

            // Pen events
            case >= EventType.PenProximityIn and <= EventType.PenAxis:
            {
                var which = evt.Ptouch.Which;
                if (!backend.TryGetOrCreateDevice<SdlPen>(which, out var penDevice))
                {
                    return;
                }

                _ = backend.TryGetPointerTargetForWindow(evt.Ptouch.WindowID, out var target);

                switch (type)
                {
                    case EventType.PenProximityIn:
                    {
                        penDevice.SetProximity(target, true);
                        return;
                    }
                    case EventType.PenProximityOut:
                    {
                        penDevice.SetProximity(target, false);
                        break;
                    }
                    case EventType.PenDown:
                    case EventType.PenUp:
                    case EventType.PenButtonDown:
                    case EventType.PenButtonUp:
                    case EventType.PenMotion:
                    {
                        ref readonly var penEvt = ref evt.Ptouch;
                        penDevice.Event(target, new Vector2(penEvt.X, penEvt.Y), (SdlPenInputFlags)penEvt.PenState);
                        break;
                    }
                    case EventType.PenAxis:
                    {
                        ref readonly var penEvt = ref evt.Paxis;
                        penDevice.Event(target, new Vector2(penEvt.X, penEvt.Y), (SdlPenInputFlags)penEvt.PenState,
                            penEvt.Axis, penEvt.Value);
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

                _ = backend.TryGetPointerTargetForWindow(finger.WindowID, out var target);
                touchDevice.Event(finger, target, (FingerEventType)finger.Type);
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

    internal class SilkEventQueues
    {
        public IEventQueue<ButtonChangedEvent<JoystickButton>> ButtonChangedEvents => _buttonChangedEvents;

        public IEventQueue<ConnectionEvent> ConnectionEvents => _connectionEvents;

        public IEventQueue<KeyChangedEvent> KeyChangedEvents => _keyChangedEvents;

        public IEventQueue<GamepadThumbstickMoveEvent> GamepadThumbstickMoveEvents => _gamepadThumbstickMoveEvents;

        public IEventQueue<GamepadTriggerMoveEvent> GamepadTriggerMoveEvents => _gamepadTriggerMoveEvents;

        public IEventQueue<JoystickAxisMoveEvent> JoystickAxisMoveEvents => _joystickAxisMoveEvents;

        public IEventQueue<JoystickHatMoveEvent> JoystickHatMoveEvents => _joystickHatMoveEvents;

        public IEventQueue<KeyCharEvent> KeyCharEvents => _keyCharEvents;

        public IEventQueue<MouseScrollEvent> MouseScrollEvents => _mouseScrollEvents;

        public IEventQueue<PointChangedEvent> PointChangedEvents => _pointChangedEvents;

        public IEventQueue<PointerClickEvent> PointerClickEvents => _pointerClickEvents;

        public IEventQueue<PointerGripChangedEvent> PointerGripChangedEvents => _pointerGripChangedEvents;

        public IEventQueue<PointerTargetChangedEvent> PointerTargetChangedEvents => _pointerTargetChangedEvents;

        private readonly OrderedEventQueue _orderedEvents = new();
        private readonly EventQueue<ButtonChangedEvent<JoystickButton>> _buttonChangedEvents = new();
        private readonly EventQueue<ConnectionEvent> _connectionEvents = new();
        private readonly EventQueue<KeyChangedEvent> _keyChangedEvents = new();
        private readonly EventQueue<GamepadThumbstickMoveEvent> _gamepadThumbstickMoveEvents = new();
        private readonly EventQueue<GamepadTriggerMoveEvent> _gamepadTriggerMoveEvents = new();
        private readonly EventQueue<JoystickAxisMoveEvent> _joystickAxisMoveEvents = new();
        private readonly EventQueue<JoystickHatMoveEvent> _joystickHatMoveEvents = new();
        private readonly EventQueue<KeyCharEvent> _keyCharEvents = new();
        private readonly EventQueue<MouseScrollEvent> _mouseScrollEvents = new();
        private readonly EventQueue<PointChangedEvent> _pointChangedEvents = new();
        private readonly EventQueue<PointerClickEvent> _pointerClickEvents = new();
        private readonly EventQueue<PointerGripChangedEvent> _pointerGripChangedEvents = new();
        private readonly EventQueue<PointerTargetChangedEvent> _pointerTargetChangedEvents = new();

        public void RaiseEvents(params Span<IInputHandler> handlers)
        {
            _orderedEvents.Enqueue(_buttonChangedEvents);
            _orderedEvents.Enqueue(_connectionEvents);
            _orderedEvents.Enqueue(_keyChangedEvents);
            _orderedEvents.Enqueue(_gamepadThumbstickMoveEvents);
            _orderedEvents.Enqueue(_gamepadTriggerMoveEvents);
            _orderedEvents.Enqueue(_joystickAxisMoveEvents);
            _orderedEvents.Enqueue(_joystickHatMoveEvents);
            _orderedEvents.Enqueue(_keyCharEvents);
            _orderedEvents.Enqueue(_mouseScrollEvents);
            _orderedEvents.Enqueue(_pointChangedEvents);
            _orderedEvents.Enqueue(_pointerClickEvents);
            _orderedEvents.Enqueue(_pointerGripChangedEvents);
            _orderedEvents.Enqueue(_pointerTargetChangedEvents);
            _orderedEvents.SortDescending();

            if (handlers is { Length: > 0 })
            {
                while (_orderedEvents.TryDequeue(out var evt))
                {
                    switch (evt.Value)
                    {
                        case var genericEvt when genericEvt.Type == typeof(ButtonChangedEvent<JoystickButton>):
                        {
                            RaiseEvent(handlers, genericEvt.Value<ButtonChangedEvent<JoystickButton>>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(ConnectionEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<ConnectionEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(KeyChangedEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<KeyChangedEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(GamepadThumbstickMoveEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<GamepadThumbstickMoveEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(GamepadTriggerMoveEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<GamepadTriggerMoveEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(JoystickAxisMoveEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<JoystickAxisMoveEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(JoystickHatMoveEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<JoystickHatMoveEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(KeyCharEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<KeyCharEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(MouseScrollEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<MouseScrollEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(PointChangedEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<PointChangedEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(PointerClickEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<PointerClickEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(PointerGripChangedEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<PointerGripChangedEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(PointerTargetChangedEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<PointerTargetChangedEvent>());
                            break;
                        }
                        default:
                        {
                            throw new InvalidOperationException(nameof(evt.Value.Type));
                        }
                    }
                }
            }


            _buttonChangedEvents.Clear();
            _connectionEvents.Clear();
            _keyChangedEvents.Clear();
            _gamepadThumbstickMoveEvents.Clear();
            _gamepadTriggerMoveEvents.Clear();
            _joystickAxisMoveEvents.Clear();
            _joystickHatMoveEvents.Clear();
            _keyCharEvents.Clear();
            _mouseScrollEvents.Clear();
            _pointChangedEvents.Clear();
            _pointerClickEvents.Clear();
            _pointerGripChangedEvents.Clear();
            _pointerTargetChangedEvents.Clear();
        }

        private static void RaiseEvent<TItem>(Span<IInputHandler> handlers, in TItem evt)
            where TItem : struct, ITimestampedEvent
        {
            for (var index = 0; index < handlers.Length; index++)
            {
                var handler = handlers[index];
                if (handler is IInputHandler<TItem> inputHandler)
                {
                    inputHandler.Handle(evt);
                }
            }
        }
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

internal interface IEventQueue<T> where T : struct, ITimestampedEvent
{
    public void Enqueue(in T item);
}

internal record struct GenericEvent(nint EventPtr, long Timestamp, Type Type) : ITimestampedEvent
{
    public unsafe T Value<T>() => Unsafe.AsRef<T>((void*)EventPtr);
}

internal interface ITimestampedEvent
{
    public long Timestamp { get; }
}

internal sealed class OrderedEventQueue : EventQueue<GenericEvent>
{
    public void Enqueue<T>(in EventQueue<T> queue) where T : struct, ITimestampedEvent
    {
        for(var i = 0; i < queue.Count; ++i)
        {
            Enqueue(queue.AsGenericEvent(i));
        }
    }

    public void Sort()
    {
        var span = Events.AsSpan(0, Count);
        span.Sort((x, y) => x.Timestamp.CompareTo(y.Timestamp));
    }

    public void SortDescending()
    {
        var span = Events.AsSpan(0, Count);
        span.Sort((x, y) => y.Timestamp.CompareTo(x.Timestamp));
    }
}

internal unsafe class EventQueue<T> : IEventQueue<T> where T : struct, ITimestampedEvent
{
    protected T[] Events { get; private set; } = [];
    public int Count { get; private set; }

    public nint this[int index] => (nint)Unsafe.AsPointer(ref Events[index]);

    public GenericEvent AsGenericEvent(int index)
    {
        ref var evt = ref Events[index];
        return new GenericEvent((nint)Unsafe.AsPointer(ref evt), evt.Timestamp, typeof(T));
    }

    public void Enqueue(in T item)
    {
        if (Events.Length == Count)
        {
            var newEvts = GC.AllocateArray<T>(length: Events.Length == 0 ? 16 : Events.Length * 2, pinned: true);
            Events.CopyTo(newEvts, 0);
            Events = newEvts;
            Debug.Assert(Events.Length > Count);
        }

        Events[Count++] = item;
    }

    public bool TryDequeue([NotNullWhen(true)] out T? value)
    {
        if (Count == 0)
        {
            value = null;
            return false;
        }

        value = Events[--Count];
        return true;
    }

    public void Clear()
    {
        Events.AsSpan().Clear();
        Count = 0;
    }
}
