// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Input.SDL3.Devices.Joysticks;
using Silk.NET.Input.SDL3.Devices.Pointers;
using Silk.NET.Input.SDL3.Devices.Pointers.Targets;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal partial class SdlInputBackend : IInputBackend
{
    [field: MaybeNull]
    private SdlUnboundedPointerTarget UnboundedPointerTarget =>
        field ??= new SdlUnboundedPointerTarget(this);

    public ISdl Sdl { get; }

    public string Name =>
        $"Silk.NET.Input Reference Implementation using SDL3 ({Sdl.GetPlatform().ReadToString()})";

    public nint Id { get; }

    public IReadOnlyList<IInputDevice> Devices => _deviceRegistry.Devices;

    public WindowHandle? FocusedWindow => _focusedWindow;
    private WindowHandle? _focusedWindow;

    public readonly ICursorConfiguration CursorConfiguration;
    internal readonly SdlCursor SdlCursor;

    private const uint _sdlInitFlags =
        SDL.Sdl.InitJoystick | SDL.Sdl.InitGamepad | SDL.Sdl.InitEvents | SDL.Sdl.InitHaptic | SDL.Sdl.InitSensor;


    public SdlInputBackend(SdlPlatformInfo info)
    {
        Sdl = info.Sdl ?? SDL.Sdl.Instance;

        if (Sdl == null)
        {
            throw new ArgumentNullException(nameof(info), "No SDL instance was provided or found.");
        }

        // subscribe to SDL events
        // ReSharper disable once RedundantUnsafeContext
        unsafe
        {
            _inputSubscriptionEventPtr = new EventFilter(OnEvent);
            if (!Sdl.AddEventWatch(_inputSubscriptionEventPtr, (Ref)nullptr))
            {
                Sdl.ThrowError();
            }

            // set our context ID according to our unique event filter handle
            Id = (nint)_inputSubscriptionEventPtr.Handle;
        }

        // create cursor
        CursorConfiguration = SdlCursor = new SdlCursor(Sdl);

        // todo - manage clock drift by semi-regularly recalculating this time basis
        _timeBasis = SdlTimestampCalculator.GetHighPrecisionTimeBasis(iterationCount: 4);

        // create our event queue
        _sdlInputEvents = new SdlInputEventContext();


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

            _focusedWindow = focusedWindow;
        }

        if (!Sdl.InitSubSystem(_sdlInitFlags))
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
    }

    // This is complicated, as the input proposal mandates that nothing happens until Update is called (so the events
    // can be received on the given actor) but to also track logical events that happen between calls (i.e. from a
    // timestamp perspective). Compound this with the fact that the user might do something silly like make multiple
    // input backends (which is feasible for multiple windows I guess), or not be running anything other than input
    // (having obviously created a window beforehand but not actually polling events I guess)
    public void Update(IInputHandler? handler = null)
    {
        Sdl.PumpEvents();

        // actually process the events in-order

        var rawEvents = _rawEvents.AsSpan();

        // timestamp calculations first in a separate loop (for cache locality of calculation logic)
        for (var i = 0; i < rawEvents.Length; ++i)
        {
            ref readonly var sdlTimestamp = ref rawEvents[i].Common.Timestamp;
            var timestamp = SdlTimestampCalculator.ToTimestamp(sdlTimestamp, _timeBasis);
            _timestamps.Enqueue(in timestamp);
        }

        var timestamps = _timestamps.AsSpan();

        Debug.Assert(rawEvents.Length == timestamps.Length);

        var devices = _deviceRegistry.Devices;

        for (var index = 0; index < devices.Count; ++index)
        {
            if (devices[index] is INeedPreUpdate needer)
            {
                needer.PreUpdate();
            }
        }


        // actually process the events
        for (var i = 0; i < rawEvents.Length; ++i)
        {
            ProcessEvent(ref rawEvents[i], timestamps[i], ref _focusedWindow, this);
        }

        _rawEvents.ResetCount();
        _timestamps.ResetCount();

        for (var index = 0; index < devices.Count; index++)
        {
            var device = devices[index];
            if (device is SdlGamepad gamepad)
            {
                gamepad.ExecuteRumble();
            }

            if (device is INeedCompletionEachFrame needer)
            {
                needer.CompleteUpdate();
            }

            if (device is IMapTargetPoints mapper)
            {
                mapper.AppendPointsTranslatedToOtherTargets(_sdlWindowTargets, UnboundedPointerTarget);
            }
        }

        _sdlInputEvents.RaiseEvents(handler is null ? Span<IInputHandler>.Empty : [handler]);
    }


    // ?? [UnmanagedFunctionPointer()]
    private unsafe byte OnEvent(void* arg0, Event* arg1)
    {
        _rawEvents.Enqueue(ref Unsafe.AsRef<Event>(arg1));
        return 1;
    }

    /// <param name="evt"></param>
    /// <param name="timestamp"></param>
    /// <param name="focusedWindow"></param>
    /// <param name="backend"></param>
    /// <seealso href="https://wiki.libsdl.org/SDL3/SDL_EventType"/>
    private static void ProcessEvent(ref readonly Event evt, long timestamp, ref WindowHandle? focusedWindow, SdlInputBackend backend)
    {
        // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
        var type = (EventType)evt.Common.Type;

        switch (type)
        {
            // device creation / removal
            case EventType.GamepadAdded:
            {
                backend.TryGetOrCreateDevice<SdlGamepad>(evt.Gdevice.Which, timestamp, out _);
                return;
            }
            case EventType.GamepadRemoved:
            {
                backend.RemoveDevice<SdlGamepad>(evt.Gdevice.Which, timestamp);
                return;
            }
            case EventType.JoystickAdded:
            {
                backend.TryGetOrCreateDevice<SdlJoystick>(evt.Jdevice.Which, timestamp, out _);
                return;
            }
            case EventType.JoystickRemoved:
            {
                backend.RemoveDevice<SdlJoystick>(evt.Jdevice.Which, timestamp);
                return;
            }
            case EventType.KeyboardAdded:
            {
                backend.TryGetOrCreateDevice<SdlKeyboard>(evt.Kdevice.Which, timestamp, out _);
                return;
            }
            case EventType.KeyboardRemoved:
            {
                backend.RemoveDevice<SdlKeyboard>(evt.Kdevice.Which, timestamp);
                return;
            }
            case EventType.MouseAdded:
            {
                backend.TryGetOrCreateDevice<SdlMouse>(evt.Mdevice.Which, timestamp, out _);
                return;
            }
            case EventType.MouseRemoved:
            {
                backend.RemoveDevice<SdlMouse>(evt.Mdevice.Which, timestamp);
                return;
            }

            // IME text editing - SdlKeyboard
            case EventType.TextEditingCandidates:
            {
                (uint id, InputEventUpdateMethod<SdlKeyboard> updateEvent) candidatesEvt = (0u,
                    static (k, _, ref readonly e, _) => k.AddTextCandidatesEvent(e.EditCandidates));

                // text events are window-scoped: broadcast them to every keyboard device
                for (var index = 0; index < backend.Devices.Count; index++)
                {
                    if (backend.Devices[index] is SdlKeyboard keyboard)
                    {
                        _ = backend.TryAddInputEvent(keyboard.SdlDeviceId, timestamp, in evt, candidatesEvt.updateEvent);
                    }
                }

                break;
            }

            // Keyboard events & IME text editing - SdlKeyboard
            case >= EventType.KeyDown and <= EventType.TextInput:
            {
                (uint id, InputEventUpdateMethod<SdlKeyboard>? updateEvent) kbEvt = type switch {
                    EventType.KeyDown => (evt.Key.Which, static (k, time, ref readonly e, _) => k.AddKeyEvent(e.Key, time)),
                    EventType.KeyUp => (evt.Key.Which, static (k, time, ref readonly e, _) => k.AddKeyEvent(e.Key, time)),

                    // text events are routed to every keyboard, as they are associated with the window, not a device
                    EventType.TextEditing => (0u, static (k, _, ref readonly e, _) => k.AddTextEditingEvent(e.Edit)),
                    EventType.TextInput => (0u, static (k, _, ref readonly e, _) => k.AddTextInputEvent(e.Text)),

                    _ => (0u, null)
                };

                if (kbEvt.updateEvent is not null)
                {
                    // text events are window-scoped: broadcast them to every keyboard device
                    if (kbEvt.id == 0)
                    {
                        for (var index = 0; index < backend.Devices.Count; index++)
                        {
                            if (backend.Devices[index] is SdlKeyboard keyboard)
                            {
                                _ = backend.TryAddInputEvent(keyboard.SdlDeviceId, timestamp, in evt, kbEvt.updateEvent);
                            }
                        }
                    }
                    else
                    {
                        _ = backend.TryAddInputEvent(kbEvt.id, timestamp, in evt, kbEvt.updateEvent);
                    }
                }



                break;
            }

            #region Joysticks

            // Gamepad events - SdlGamepad
            case >= EventType.GamepadAxisMotion and <= EventType.GamepadSteamHandleUpdated:
            {
                (uint id, InputEventUpdateMethod<SdlGamepad>? updateEvent) gameEvt = type switch {
                    EventType.GamepadRemapped => (evt.Gdevice.Which, static (g, time, ref readonly _, _) => g.Remap(time)),
                    EventType.GamepadTouchpadDown => (evt.Gtouchpad.Which, static (g, time, ref readonly e, _) => g.AddTouchpadEvent(e.Gtouchpad, down: true, time)),
                    EventType.GamepadTouchpadUp => (evt.Gtouchpad.Which, static (g, time, ref readonly e, _) => g.AddTouchpadEvent(e.Gtouchpad, down: false, time)),
                    EventType.GamepadTouchpadMotion => (evt.Gtouchpad.Which, static(g, time, ref readonly e, _) => g.AddTouchpadEvent(e.Gtouchpad, null, time)),
                    EventType.GamepadSensorUpdate => (evt.Gsensor.Which, static (g, time, ref readonly e, _) => g.AddSensorEvent(e.Gsensor, time)),

                    // intentionally null, as they are handled by the joystick implementation
                    EventType.GamepadAxisMotion => (evt.Gaxis.Which, null),
                    EventType.GamepadButtonDown => (evt.Gbutton.Which, null),
                    EventType.GamepadButtonUp => (evt.Gbutton.Which, null),
                    EventType.GamepadUpdateComplete => (evt.Gdevice.Which, null),

                    // not sure what to do with this at the moment..
                    EventType.GamepadSteamHandleUpdated => (evt.Gdevice.Which, null),

                    // todo: pending updated SDL3 bindings?
                    // EventType.GamepadCapsenseTouch:
                    // EventType.GamepadCapsenseRelease:
                    _ => (0u, null)
                };

                if (gameEvt.updateEvent is not null)
                {
                    _ = backend.TryAddInputEvent(gameEvt.id, timestamp, in evt, gameEvt.updateEvent);
                }

                break;
            }

            // Joystick events - SdlJoystick
            case >= EventType.JoystickAxisMotion and <= EventType.JoystickUpdateComplete:
            {

                (uint id, InputEventUpdateMethod<SdlJoystick>? updateMethod) joyEvt = type switch {
                    EventType.JoystickAxisMotion => (evt.Jaxis.Which, static (j, time, ref readonly e, _) => j.AddAxisEvent(e.Jaxis.Axis, e.Jaxis.Value, time)),
                    EventType.JoystickBallMotion => (evt.Jball.Which, static (j, time, ref readonly e, _) => j.AddBallEvent(e.Jball.Ball, e.Jball.Xrel, e.Jball.Yrel, e.Jball.Timestamp, time)),
                    EventType.JoystickHatMotion => (evt.Jhat.Which, static (j, time, ref readonly e, _) => j.AddHatEvent(e.Jhat.Hat, e.Jhat.Value, time)),
                    EventType.JoystickButtonDown => (evt.Jbutton.Which, static (j, time, ref readonly e, _) => j.AddButtonEvent(e.Jbutton.Button, e.Jbutton.Down, time)),
                    EventType.JoystickButtonUp => (evt.Jbutton.Which, static (j, time, ref readonly e, _) => j.AddButtonEvent(e.Jbutton.Button, e.Jbutton.Down, time)),
                    EventType.JoystickBatteryUpdated => (evt.Jdevice.Which, null),
                    EventType.JoystickUpdateComplete => (evt.Jdevice.Which, null),
                    _ => (0u, null)
                };

                if (joyEvt.updateMethod is not null)
                {
                    _ = backend.TryAddInputEvent(joyEvt.id, timestamp, in evt, joyEvt.updateMethod);
                }

                break;
            }

            #endregion

            #region Pointers

            // Mouse events - SdlMouse
            case >= EventType.MouseMotion and < EventType.MouseAdded:
            {
                (uint id, uint windowId, PointerEventUpdateMethod<SdlMouse>? updateEvent) mouseEvt = type switch {
                    EventType.MouseMotion => (evt.Motion.Which, evt.Motion.WindowID, static (m, time, ref readonly e, _, target) => m.AddMotion(in e.Motion, target, time)),
                    EventType.MouseWheel => (evt.Wheel.Which, evt.Wheel.WindowID, static (m, time, ref readonly e, _, target) => m.AddWheelEvent(in e.Wheel, target, time)),

                    // button events are device-scoped: no pointer target required
                    EventType.MouseButtonDown => (evt.Button.Which, evt.Button.WindowID, static (m, time, ref readonly e, _, _) => m.AddMouseButtonEvent(in e.Button, time)),
                    EventType.MouseButtonUp => (evt.Button.Which, evt.Button.WindowID, static (m, time, ref readonly e, _, _) => m.AddMouseButtonEvent(in e.Button, time)),

                    _ => (0u, 0u, null)
                };

                if (mouseEvt.updateEvent is not null)
                {
                    _ = backend.TryAddPointerInputEvent(mouseEvt.id, mouseEvt.windowId, timestamp, in evt, mouseEvt.updateEvent);
                }

                break;
            }

            // Pen events
            case >= EventType.PenProximityIn and <= EventType.PenAxis:
            {
                (uint id, uint windowId, PointerEventUpdateMethod<SdlPen>? updateEvent) ptrEvt = type switch {
                    EventType.PenProximityIn => (evt.Pproximity.Which, evt.Pproximity.WindowID,
                        static (p, time, ref readonly e, _, target) =>
                            p.ProximityEvent(in e.Pproximity, target, proximityIn: true, time)),

                    EventType.PenProximityOut => (evt.Pproximity.Which, evt.Pproximity.WindowID,
                        static (p, time, ref readonly e, _, target) =>
                            p.ProximityEvent(in e.Pproximity, target, proximityIn: false, time)),

                    EventType.PenDown => (evt.Ptouch.Which, evt.Ptouch.WindowID,
                        static (p, time, ref readonly e, _, target) =>
                            p.UpDownEvent(in e.Ptouch, target, time)),

                    EventType.PenUp => (evt.Ptouch.Which, evt.Ptouch.WindowID,
                        static (p, time, ref readonly e, _, target) =>
                            p.UpDownEvent(in e.Ptouch, target, time)),

                    EventType.PenButtonDown => (evt.Pbutton.Which, evt.Pbutton.WindowID,
                        static (p, time, ref readonly e, _, _) =>
                            p.ButtonEvent(in e.Pbutton, time)),

                    EventType.PenButtonUp => (evt.Pbutton.Which, evt.Pbutton.WindowID,
                        static (p, time, ref readonly e, _, _) =>
                            p.ButtonEvent(in e.Pbutton, time)),

                    EventType.PenMotion => (evt.Pmotion.Which, evt.Pmotion.WindowID,
                        static (p, time, ref readonly e, _, target) =>
                            p.MotionEvent(in e.Pmotion, target, time)),

                    EventType.PenAxis => (evt.Paxis.Which, evt.Paxis.WindowID,
                        static (p, time, ref readonly e, _, target) =>
                            p.AxisEvent(in e.Paxis, target, time)),

                    _ => (0u, 0u, null)
                };

                if (ptrEvt.updateEvent is not null)
                {
                    _ = backend.TryAddPointerInputEvent(ptrEvt.id, ptrEvt.windowId, timestamp, in evt, ptrEvt.updateEvent);
                }

                break;
            }

            // Touch events
            case >= EventType.FingerDown and <= EventType.FingerCanceled:
            {
                // todo - should we use the window id as a proxy ID for the touch device here?
                var finger = evt.Tfinger;
                var device = finger.TouchID;
                if (!backend.TryGetOrCreateDevice<SdlTouchSurface>(device, timestamp, out var touchDevice))
                {
                    return;
                }

                if(backend.TryGetOrCreatePointerTargetForWindow(finger.WindowID, out var windowTarget))
                {
                    touchDevice.Event(finger, windowTarget, (FingerEventType)finger.Type, timestamp);
                }
                else
                {
                    LogFailedPointerTargetRetrieval(finger.WindowID);
                }
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
                break;
            }
            case EventType.WindowMouseEnter:
                break;
            case EventType.WindowMouseLeave:
            {
                // do we need to do anything? we should probably track the current window of the pointer
                //var x = (QueuedEventType.MouseExitedWindow, timestamp);
                break;
            }
            case EventType.WindowFocusGained:
                focusedWindow = backend.Sdl.GetWindowFromID(evt.Window.WindowID);
                break;
            case EventType.WindowFocusLost:
                focusedWindow = null;
                break;
            case EventType.WindowMinimized:
            case EventType.WindowEnterFullscreen:
            case EventType.WindowExposed:
            case EventType.WindowLeaveFullscreen:
            case EventType.WindowHidden:
            case EventType.WindowShown:
            case EventType.WindowRestored:
            case EventType.WindowMaximized:
            case EventType.WindowPixelSizeChanged:
            case EventType.WindowDisplayChanged:
            case EventType.WindowDisplayScaleChanged:
            case EventType.WindowSafeAreaChanged:
                backend.OnWindowUnclearMotion(evt.Window, timestamp);
                break;
            case EventType.WindowMoved:
                backend.OnWindowMove(evt.Window, timestamp);
                break;
            case EventType.WindowDestroyed:
                backend.OnWindowDestroyed(evt.Window, timestamp);
                break;

            case EventType.WindowResized:
                backend.OnWindowResized(evt.Window, timestamp);
                break;
        }

        #endregion

        static void LogFailedPointerTargetRetrieval(uint windowId)
        {
            #if DEBUG
            InputLog.Warn("Failed to get or create pointer target for window ID: " + windowId);
            #endif
        }
    }


    private void ReleaseUnmanagedResources()
    {
        Sdl.RemoveEventWatch(_inputSubscriptionEventPtr, (Ref)nullptr);
        _inputSubscriptionEventPtr.Dispose();
        Sdl.QuitSubSystem(_sdlInitFlags);
        _sdlInputEvents.Dispose();
        _rawEvents.Dispose();
        _timestamps.Dispose();
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }


    ~SdlInputBackend() => ReleaseUnmanagedResources();


    private delegate void InputEventUpdateMethod<in T>(T device, long timestamp, ref readonly Event evt, SdlInputBackend backend);
    private delegate void PointerEventUpdateMethod<in T>(T device, long timestamp, ref readonly Event evt, SdlInputBackend backend, IPointerTarget pointerTarget);

    internal enum FingerEventType : uint
    {
        Down = EventType.FingerDown,
        Up = EventType.FingerUp,
        Motion = EventType.FingerMotion,
        Canceled = EventType.FingerCanceled
    }

    private readonly DeviceRegistry _deviceRegistry = new([]);

    private NativeMemory<long> _timestamps;
    private NativeMemory<Event> _rawEvents;
    private readonly SdlTimestampCalculator.TimeBasis _timeBasis;
    private readonly EventFilter _inputSubscriptionEventPtr;
    private readonly SdlInputEventContext _sdlInputEvents;

    private unsafe struct NativeMemory<T> where T : unmanaged
    {
        private T* _values;
        private int _count;
        private int _capacity;
        private const int _defaultLength = 16;
        private static readonly nuint _elementSize = (uint)sizeof(T);

        public void Enqueue(ref readonly T value)
        {
            var newCount = _count + 1;
            if (newCount >= _capacity)
            {
                if (_capacity == 0)
                {
                    _capacity = _defaultLength;
                    _values = (T*)NativeMemory.Alloc((nuint)_capacity * _elementSize);
                }
                else
                {
                    // increase size
                    _capacity *= 2;
                    _values = (T*)NativeMemory.Realloc(_values, (nuint)_capacity * _elementSize);
                }
            }


            _values[_count] = value;
            _count = newCount;
        }

        public void Dispose()
        {
            if (_values != null)
            {
                NativeMemory.Free(_values);
                _capacity = 0;
                _count = 0;
                _values = null;
            }
        }

        public Span<T> AsSpan() => new(_values, _count);

        public void ResetCount() => _count = 0;
    }
}

[Flags]
[SuppressMessage("ReSharper", "RedundantNameQualifier")]
internal enum SdlMouseInputFlags : uint
{
    LeftButtonDown = SDL.Sdl.ButtonLmask,
    MiddleButtonDown = SDL.Sdl.ButtonMiddle,
    RightButtonDown = SDL.Sdl.ButtonRmask,
    XButton1Down = SDL.Sdl.ButtonX1Mask,
    XButton2Down = SDL.Sdl.ButtonX2Mask,
}
