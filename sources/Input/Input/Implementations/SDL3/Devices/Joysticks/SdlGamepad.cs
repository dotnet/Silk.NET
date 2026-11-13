// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.Input.SDL3.DataStructures;
using Silk.NET.Input.SDL3.Extensions;
using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Joysticks;

/// <summary>
/// provides the IGamepad implementation for a joystick
/// </summary>
internal sealed unsafe class SdlGamepad : SdlDevice, IGamepad, ISdlDevice<SdlGamepad>, IOrderedDevice
{
    // JoystickState IJoystick.State => _joystick.State;
    ButtonReadOnlyList<JoystickButton> IButtonDevice<JoystickButton>.State => GamepadState.Buttons;

    internal required SdlInputEventQueue<ButtonChangedEvent<JoystickButton>> ButtonEvents { get; init; }
    internal required SdlInputEventQueue<GamepadThumbstickMoveEvent> ThumbstickEvents { get; init; }
    internal required SdlInputEventQueue<GamepadTriggerMoveEvent> TriggerEvents { get; init; }

    public override ulong SdlDeviceId => _sdlDeviceId;


    // SDL names seem to match, and this is a way to provide the guarantee that a matching joystick will have
    // the same name - makes the devices easy to pair for consumers
    public override string Name => _joystick.Name;

    private static readonly Box3D<float> _touchpadBounds = new(Vector3D<float>.Zero, Vector3D<float>.One);
    private Button<JoystickButton>[] _buttons;
    private float[] _axes;
    private readonly SdlJoystick _joystick;
    private uint _sdlDeviceId;
    private GamepadHandle _gamepadHandle;

    private SdlGamepad(SdlJoystick joystick, nint uniqueId) : base(joystick.Backend, uniqueId, joystick.SdlDeviceId)
    {
        _joystick = joystick;
        _sdlDeviceId = (uint)base.SdlDeviceId;
        _state = null!; // created in Initialize method
    }

    public void RefreshSdlId() => _sdlDeviceId = NativeBackend.GetGamepadID(_gamepadHandle);

    protected internal override void Initialize(long timestamp)
    {
        var gamepadHandle = NativeBackend.OpenGamepad((uint)SdlDeviceId);
        var nullGamepad = gamepadHandle.Handle == null;
        if (nullGamepad)
        {
            // we just continue on to initialize our data,
            // and if we don't have a handle, we don't use it. we still hold on to the game device, though,
            // which is likely to be a source of confusion. however at time of writing I choose to assume
            // this would be an SDL bug, and if not, they would later emit a disconnect event the regular
            // input flow can handle.
            InputLog.Error($"Could not open gamepad handle {SdlDeviceId}.");
        }

        _gamepadHandle = gamepadHandle;

        _buttons = new Button<JoystickButton>[EnumInfo<JoystickButton>.DistinctCount];
        for (var i = 0; i < _buttons.Length; i++)
        {
            _buttons[i] = new Button<JoystickButton>(EnumInfo<JoystickButton>.UniqueNamedValues[i], false, 0);
        }

        // GamepadState reads the named JoystickAxis slots, so this must match EnumInfo's distinct axis indices.
        _axes = new float[EnumInfo<JoystickAxis>.DistinctCount];
        _axes[JoystickAxis.LeftX.Index()] = 0.5f;
        _axes[JoystickAxis.LeftY.Index()] = 0.5f;
        _axes[JoystickAxis.RightX.Index()] = 0.5f;
        _axes[JoystickAxis.RightY.Index()] = 0.5f;
        _state = new GamepadState(_buttons, _axes);

        if (!nullGamepad)
        {
            SyncGamepadState(timestamp);
            _joystick.ApplyMapping(gamepadHandle, timestamp);
        }
    }

    /// <summary>
    /// Executes rumbles that were dispatched from <see cref="SdlRumble"/>
    /// </summary>
    public void ExecuteRumble() => _rumbler?.ExecuteRumble();

    protected override void Release()
    {
        NativeBackend.CloseGamepad(_gamepadHandle);
    }

    private GamepadState _state;

    #region IGamepad

    GamepadState IGamepad.State => GamepadState;
    private GamepadState GamepadState => _state;

    public IReadOnlyList<IMotor> VibrationMotors =>
        _rumbler ??= SdlRumble.Create<GamepadHandle>(_gamepadHandle.Handle, NativeBackend, 2);

    private SdlRumble? _rumbler;

    #endregion

    public static SdlGamepad? CreateDevice(ulong sdlDeviceId, long timestamp, bool isSimulated,
        SdlInputBackend backend, SdlInputEventContext context)
    {
        if (!backend.TryGetOrCreateDevice<SdlJoystick>(sdlDeviceId, timestamp, out var joystick))
        {
#if DEBUG
            InputLog.Warn("No joystick found for gamepad " + sdlDeviceId);
#endif
            return null;
        }

        var joystickUniqueId = joystick.Id;
        var gpn = backend.Sdl.GetRealGamepadTypeForID((uint)sdlDeviceId);

        if (backend.AttemptUniqueId(gpn, ref joystickUniqueId))
        {
            return new SdlGamepad(joystick, uniqueId: joystickUniqueId) {
                ButtonEvents = context.JoyButtonChangedEvents,
                ThumbstickEvents = context.GamepadThumbstickMoveEvents,
                TriggerEvents = context.GamepadTriggerMoveEvents,
            };
        }

        // manipulate the joystick id to make a unique gamepad id
        var guid = backend.Sdl.GetGamepadGuidForID((uint)sdlDeviceId);
        if (backend.AttemptUniqueId(guid, ref joystickUniqueId))
        {
            return new SdlGamepad(joystick, uniqueId: joystickUniqueId) {
                ButtonEvents = context.JoyButtonChangedEvents,
                ThumbstickEvents = context.GamepadThumbstickMoveEvents,
                TriggerEvents = context.GamepadTriggerMoveEvents,
            };
        }

        joystickUniqueId = SdlInputBackend.FallbackUniqueId<SdlGamepad>(sdlDeviceId, joystickUniqueId);
        var sdlGamepad = new SdlGamepad(joystick, uniqueId: joystickUniqueId) {
            ButtonEvents = context.JoyButtonChangedEvents,
            ThumbstickEvents = context.GamepadThumbstickMoveEvents,
            TriggerEvents = context.GamepadTriggerMoveEvents,
        };
        return sdlGamepad;
    }

    /// <summary>
    /// Re-reads the gamepad's current button and axis state from SDL. Called on initialization and when SDL
    /// reports that the gamepad's mapping has changed.
    /// </summary>
    public void SyncGamepadState(long timestamp)
    {
        if (_gamepadHandle.Handle == null)
        {
            return;
        }

        for (var i = 0; i <= (int)GamepadButton.DpadRight; i++)
        {
            var button = (GamepadButton)i;
            UpdateButton(button, isDown: NativeBackend.GetGamepadButtonRaw(_gamepadHandle, button) != 0, timestamp);
        }

        for (var i = 0; i < (int)GamepadAxis.Count; i++)
        {
            var axis = (GamepadAxis)i;
            UpdateAxis(axis, value: NativeBackend.GetGamepadAxis(_gamepadHandle, axis), timestamp);
        }

    }

    /// <summary>
    /// Updates the gamepad's button state from an SDL <see cref="GamepadButton"/> event.
    /// </summary>
    public void AddButtonEvent(GamepadButton button, bool isDown, long timestamp) =>
        UpdateButton(button, isDown, timestamp);

    /// <summary>
    /// Updates the gamepad's axis state from an SDL <see cref="GamepadAxis"/> event.
    /// </summary>
    public void AddAxisEvent(GamepadAxis axis, short value, long timestamp) =>
        UpdateAxis(axis, value, timestamp);


    public void AddTouchpadEvent(in GamepadTouchpadEvent evt, bool? down, long timestamp)
    {
        /*
               typedef struct SDL_GamepadTouchpadEvent
               {
                   SDL_EventType type; /**< SDL_EVENT_GAMEPAD_TOUCHPAD_DOWN or SDL_EVENT_GAMEPAD_TOUCHPAD_MOTION or SDL_EVENT_GAMEPAD_TOUCHPAD_UP * /
                   Uint32 reserved;
                   Uint64 timestamp;   /**< In nanoseconds, populated using SDL_GetTicksNS() * /
                   SDL_JoystickID which; /**< The joystick instance id * /
                   Sint32 touchpad;    /**< The index of the touchpad * /
                   Sint32 finger;      /**< The index of the finger on the touchpad * /
                   float x;            /**< Normalized in the range 0...1 with 0 being on the left * /
                   float y;            /**< Normalized in the range 0...1 with 0 being at the top * /
                   float pressure;     /**< Normalized in the range 0...1 * /
               } SDL_GamepadTouchpadEvent;
             */

        // todo - reconcile SDL's top-left zero with whatever the standard in this library is (bottom-left zero?)
        if (!Backend.TryGetVirtualTouchpad(Id, evt.Touchpad, timestamp, out var surface, out var target))
        {
            InputLog.Warn("Failed to retrieve touch surface for gamepad input");
            return;
        }

        target.SetBounds(_touchpadBounds);
        var fingerId = evt.Finger;

        surface.Event(
            fingerId: Unsafe.As<int, uint>(ref fingerId),
            target: target,
            position: new Vector3(evt.X, evt.Y, 0),
            eventType: down switch {
                true => SdlInputBackend.FingerEventType.Down,
                false => SdlInputBackend.FingerEventType.Up,
                null => SdlInputBackend.FingerEventType.Motion,
            },
            pressure: evt.Pressure,
            timestamp: timestamp);
    }

    public void AddSensorEvent(in GamepadSensorEvent evtGsensor, long timestamp)
    {
        /*
           typedef struct SDL_GamepadSensorEvent
           {
               SDL_EventType type; /**< SDL_EVENT_GAMEPAD_SENSOR_UPDATE * /
               Uint32 reserved;
               Uint64 timestamp;   /**< In nanoseconds, populated using SDL_GetTicksNS() * /
               SDL_JoystickID which; /**< The joystick instance id * /
               Sint32 sensor;      /**< The type of the sensor, one of the values of SDL_SensorType * /
               float data[3];      /**< Up to 3 values from the sensor, as defined in SDL_sensor.h * /
               Uint64 sensor_timestamp; /**< The timestamp of the sensor reading in nanoseconds, not necessarily synchronized with the system clock * /
           } SDL_GamepadSensorEvent;
         */

        /*
         * The different sensors defined by SDL.
         *
         * Additional sensors may be available, using platform dependent semantics.
         *
         * Here are the additional Android sensors:
         *
         * https://developer.android.com/reference/android/hardware/SensorEvent.html#values
         *
         * Accelerometer sensor notes:
         *
         * The accelerometer returns the current acceleration in SI meters per second
         * squared. This includes the force of gravity, so a device at
         * rest will have an value of SDL_STANDARD_GRAVITY away from the center of the
         * earth, which is a positive Y value.
         *
         * - `values[0]`: Acceleration on the x axis
         * - `values[1]`: Acceleration on the y axis
         * - `values[2]`: Acceleration on the z axis
         *
         * For phones and tablets held in natural orientation and game controllers
         * held in front of you, the axes are defined as follows:
         *
         * - -X ... +X : left ... right
         * - -Y ... +Y : bottom ... top
         * - -Z ... +Z : farther ... closer
         *
         * The accelerometer axis data is not changed when the device is rotated.
         *
         * Gyroscope sensor notes:
         *
         * The gyroscope returns the current rate of rotation in radians per second.
         * The rotation is positive in the counter-clockwise direction. That is, an
         * observer looking from a positive location on a device sees the rotation
         * as counter-clockwise when the device is rolled to the left.
         *
         * - `values[0]`: Angular speed around the x-axis (pitch)
         * - `values[1]`: Angular speed around the y-axis (yaw)
         * - `values[2]`: Angular speed around the z-axis (roll)
         *
         * For phones and tablets held in natural orientation and game controllers
         * held in front of you, the axes are defined as follows:
         *
         * - -X ... +X : left ... right
         * - -Y ... +Y : bottom ... top
         * - -Z ... +Z : farther ... closer
         *
         * The gyroscope axis data is not changed when the device is rotated.
         *
         * \since This enum is available since SDL 3.2.0.
         *
         * \sa SDL_GetCurrentDisplayOrientation
         */

        // todo - define axes and implement
        var sensorType = (SensorType)evtGsensor.Sensor;
    }

    private void UpdateButton(GamepadButton button, bool isDown, long timestamp)
    {
        var joystickButton = AsJoystickButton(button);
        if (joystickButton == JoystickButton.Unknown)
        {
            // Outputs outside the standard gamepad button set are not part of the IGamepad API.
            return;
        }

        var idx = joystickButton.Index();
        if ((uint)idx >= (uint)_buttons.Length)
        {
            return;
        }

        ref var state = ref _buttons[idx];
        var previous = state;
        state = new Button<JoystickButton>(joystickButton, isDown, isDown ? 1 : 0);

        // ReSharper disable once CompareOfFloatsByEqualityOperator
        if (previous.IsDown != state.IsDown || previous.Pressure != state.Pressure)
        {
            ButtonEvents.Enqueue(new ButtonChangedEvent<JoystickButton>(this, timestamp, state, previous));
        }

        return;

        static JoystickButton AsJoystickButton(GamepadButton buttonIndex) =>
            buttonIndex switch {
                GamepadButton.South => JoystickButton.ButtonDown,
                GamepadButton.East => JoystickButton.ButtonRight,
                GamepadButton.West => JoystickButton.ButtonLeft,
                GamepadButton.North => JoystickButton.ButtonUp,
                GamepadButton.Back => JoystickButton.Back,
                GamepadButton.Guide => JoystickButton.Home,
                GamepadButton.Start => JoystickButton.Start,
                GamepadButton.LeftStick => JoystickButton.LeftStick,
                GamepadButton.RightStick => JoystickButton.RightStick,
                GamepadButton.LeftShoulder => JoystickButton.LeftBumper,
                GamepadButton.RightShoulder => JoystickButton.RightBumper,
                GamepadButton.DpadUp => JoystickButton.DPadUp,
                GamepadButton.DpadDown => JoystickButton.DPadDown,
                GamepadButton.DpadLeft => JoystickButton.DPadLeft,
                GamepadButton.DpadRight => JoystickButton.DPadRight,
                _ => JoystickButton.Unknown
            };
    }

    private void UpdateAxis(GamepadAxis axis, short value, long timestamp)
    {
        switch (axis)
        {
            case GamepadAxis.Leftx or GamepadAxis.Lefty or GamepadAxis.Rightx or GamepadAxis.Righty:
            {
                var joystickAxis = ToJoystickAxis(axis);
                var (xIdx, yIdx) = GetAxisPair(joystickAxis);
                var previous = GamepadAxes.JoystickAxesToThumbstick(new Vector2(_axes[xIdx], _axes[yIdx]));

                _axes[joystickAxis.Index()] = (value + 32768f) / 65535f;

                var latest = GamepadAxes.JoystickAxesToThumbstick(new Vector2(_axes[xIdx], _axes[yIdx]));
                if (latest != previous)
                {
                    ThumbstickEvents.Enqueue(new GamepadThumbstickMoveEvent(Gamepad: this,
                        Timestamp: timestamp,
                        Value: latest,
                        Delta: latest - previous));
                }

                break;
            }

            case GamepadAxis.LeftTrigger or GamepadAxis.RightTrigger:
            {
                var idx = ToJoystickAxis(axis).Index();
                var previous = _axes[idx];
                var latest = Math.Clamp(value / (float)short.MaxValue, 0f, 1f);
                if (Math.Abs(latest - previous) > 1E-7)
                {
                    _axes[idx] = latest;
                    TriggerEvents.Enqueue(new GamepadTriggerMoveEvent(this, timestamp,
                        axis == GamepadAxis.LeftTrigger ? 0 : 1, latest, latest - previous));
                }

                break;
            }
        }

        return;

        static (int X, int Y) GetAxisPair(JoystickAxis axis) => axis switch {
            JoystickAxis.LeftX or JoystickAxis.LeftY => (JoystickAxis.LeftX.Index(), JoystickAxis.LeftY.Index()),
            JoystickAxis.RightX or JoystickAxis.RightY => (JoystickAxis.RightX.Index(), JoystickAxis.RightY.Index()),
            _ => throw new ArgumentOutOfRangeException(nameof(axis), axis, null)
        };

        // SDL -> Silk.NET
        static JoystickAxis ToJoystickAxis(GamepadAxis gamepadAxis) => gamepadAxis switch {
            GamepadAxis.Leftx => JoystickAxis.LeftX,
            GamepadAxis.Lefty => JoystickAxis.LeftY,
            GamepadAxis.Rightx => JoystickAxis.RightX,
            GamepadAxis.Righty => JoystickAxis.RightY,
            GamepadAxis.LeftTrigger => JoystickAxis.LeftTrigger,
            GamepadAxis.RightTrigger => JoystickAxis.RightTrigger,
            _ => throw new ArgumentOutOfRangeException(nameof(gamepadAxis), gamepadAxis, null)
        };
    }
}
