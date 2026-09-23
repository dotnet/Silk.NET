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
        CursorConfiguration = new SdlCursor(Sdl);

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

        // actually process the events
        for (var i = 0; i < rawEvents.Length; ++i)
        {
            ProcessEvent(ref rawEvents[i], timestamps[i], ref _focusedWindow, this);
        }

        _rawEvents.ResetCount();
        _timestamps.ResetCount();

        var devices = _deviceRegistry.Devices;
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

        if (handler is not null)
        {
            _sdlInputEvents.RaiseEvents(handler);
        }
    }


    // ?? [UnmanagedFunctionPointer()]
    private unsafe byte OnEvent(void* arg0, Event* arg1)
    {
        _rawEvents.Enqueue(ref Unsafe.AsRef<Event>(arg1));
        return 1;
    }

    /// <summary>
    /// Interprets SDL events to apply to our input devices
    /// </summary>
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
            case EventType.GamepadAdded:
                backend.TryGetOrCreateDevice<SdlGamepad>(evt.Gdevice.Which, timestamp, out _);
                return;
            case EventType.GamepadRemoved:
                backend.RemoveDevice<SdlGamepad>(evt.Gdevice.Which, timestamp);
                return;
            case EventType.JoystickAdded:
                backend.TryGetOrCreateDevice<SdlJoystick>(evt.Jdevice.Which, timestamp, out _);
                return;
            case EventType.JoystickRemoved:
                backend.RemoveDevice<SdlJoystick>(evt.Jdevice.Which, timestamp);
                return;
            case EventType.KeyboardAdded:
                backend.TryGetOrCreateDevice<SdlKeyboard>(evt.Kdevice.Which, timestamp, out _);
                return;
            case EventType.KeyboardRemoved:
                backend.RemoveDevice<SdlKeyboard>(evt.Kdevice.Which, timestamp);
                return;
            case EventType.MouseAdded:
                backend.TryGetOrCreateDevice<SdlMouse>(evt.Mdevice.Which, timestamp, out _);
                return;
            case EventType.MouseRemoved:
                backend.RemoveDevice<SdlMouse>(evt.Mdevice.Which, timestamp);
                return;

            // Keyboard events
            case >= EventType.KeyDown and <= EventType.TextEditingCandidates:
            {
                if (!backend.TryGetOrCreateDevice<SdlKeyboard>(evt.Kdevice.Which, timestamp, out var keyboard))
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
                if (!backend.TryGetOrCreateDevice<SdlGamepad>(evt.Gdevice.Which, timestamp, out var gamepad))
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
                        gamepad.Remap(timestamp);
                        break;

                    // todo - sensor + touchpad
                    case EventType.GamepadTouchpadDown:
                        gamepad.AddTouchpadEvent(evt.Gtouchpad, down: true, timestamp);
                        break;
                    case EventType.GamepadTouchpadMotion:
                        gamepad.AddTouchpadEvent(evt.Gtouchpad, down: null, timestamp);
                        break;
                    case EventType.GamepadTouchpadUp:
                        gamepad.AddTouchpadEvent(evt.Gtouchpad, down: false, timestamp);
                        break;
                    case EventType.GamepadSensorUpdate:
                        gamepad.AddSensorEvent(evt.Gsensor, timestamp);
                        break;
                    case EventType.GamepadUpdateComplete:
                        // ignore
                        break;
                    /* // todo: pending updated SDL3 bindings?
                    case EventType.GamepadCapsenseTouch:
                        break;
                    case EventType.GamepadCapsenseRelease:
                        break;
                        */
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
                if (!backend.TryGetOrCreateDevice<SdlJoystick>(evt.Jdevice.Which, timestamp, out var joystick))
                {
                    return;
                }

                switch (type)
                {
                    case EventType.JoystickAxisMotion:
                        joystick.AddAxisEvent(evt.Jaxis.Axis, evt.Jaxis.Value, timestamp);
                        break;
                    case EventType.JoystickBallMotion:
                        joystick.AddBallEvent(evt.Jball.Ball, evt.Jball.Xrel, evt.Jball.Yrel, evt.Jball.Timestamp,
                            timestamp);
                        break;
                    case EventType.JoystickHatMotion:
                        joystick.AddHatEvent(evt.Jhat.Hat, evt.Jhat.Value, timestamp);
                        break;
                    case EventType.JoystickButtonDown:
                    case EventType.JoystickButtonUp:
                        joystick.AddButtonEvent(evt.Jbutton.Button, evt.Jbutton.Down, timestamp);
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
                if (!backend.TryGetOrCreateDevice<SdlMouse>(evt.Mdevice.Which, timestamp, out var mouse))
                {
                    return;
                }


                switch (type)
                {
                    case EventType.MouseMotion:
                    {
                        if(backend.TryGetOrCreatePointerTargetForWindow(evt.Motion.WindowID, out var windowTarget))
                        {
                            mouse.AddMotion(in evt.Motion, windowTarget, timestamp);
                        }
                        else
                        {
                            LogFailedPointerTargetRetrieval(evt.Motion.WindowID);
                        }
                        break;
                    }
                    case EventType.MouseButtonDown:
                    case EventType.MouseButtonUp:
                    {
                        mouse.AddMouseButtonEvent(in evt.Button, timestamp);
                        break;
                    }
                    case EventType.MouseWheel:
                    {
                        if (backend.TryGetOrCreatePointerTargetForWindow(evt.Wheel.WindowID, out var windowTarget))
                        {
                            mouse.AddWheelEvent(in evt.Wheel, windowTarget, timestamp);
                        }
                        else
                        {
                            LogFailedPointerTargetRetrieval(evt.Wheel.WindowID);
                        }

                        break;
                    }
                }

                break;
            }

            // Pen events

            case EventType.PenProximityIn:
            case EventType.PenProximityOut:
            case >= EventType.PenProximityIn and <= EventType.PenAxis:
            {
                if (!backend.TryGetOrCreateDevice<SdlPen>(evt.Pproximity.Which, timestamp, out var penDevice))
                {
                    return;
                }

                switch (type)
                {
                    case EventType.PenProximityIn:
                    case EventType.PenProximityOut:
                    {
                        if (backend.TryGetOrCreatePointerTargetForWindow(evt.Pproximity.WindowID, out var windowTarget))
                        {
                            penDevice.ProximityEvent(in evt.Pproximity, windowTarget, type == EventType.PenProximityIn, timestamp);
                        }
                        else
                        {
                            LogFailedPointerTargetRetrieval(evt.Pproximity.WindowID);
                        }

                        break;
                    }
                    case EventType.PenDown:
                    case EventType.PenUp:
                    {
                        if(backend.TryGetOrCreatePointerTargetForWindow(evt.Ptouch.WindowID, out var windowTarget))
                        {
                            penDevice.UpDownEvent(in evt.Ptouch, windowTarget, timestamp);
                        }
                        else
                        {
                            LogFailedPointerTargetRetrieval(evt.Ptouch.WindowID);
                        }

                        break;
                    }
                    case EventType.PenButtonDown:
                    case EventType.PenButtonUp:
                    {
                        penDevice.ButtonEvent(in evt.Pbutton, timestamp);
                        break;
                    }
                    case EventType.PenMotion:
                    {
                        if(backend.TryGetOrCreatePointerTargetForWindow(evt.Pmotion.WindowID, out var windowTarget))
                        {
                            penDevice.MotionEvent(in evt.Pmotion, windowTarget, timestamp);
                        }
                        else
                        {
                            LogFailedPointerTargetRetrieval(evt.Pmotion.WindowID);
                        }
                        break;
                    }
                    case EventType.PenAxis:
                    {
                        if (backend.TryGetOrCreatePointerTargetForWindow(evt.Paxis.WindowID, out var windowTarget))
                        {
                            penDevice.AxisEvent(in evt.Paxis, windowTarget, timestamp);
                        }
                        else
                        {
                            LogFailedPointerTargetRetrieval(evt.Paxis.WindowID);
                        }

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

        void LogFailedPointerTargetRetrieval(uint windowId)
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
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }


    ~SdlInputBackend() => ReleaseUnmanagedResources();



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
