// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Frozen;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.Input.SDL3.Devices.Pointers;
using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Joysticks;

/// <summary>
/// provides the IGamepad implementation for a joystick
/// </summary>
internal sealed unsafe class SdlGamepad : SdlDevice, IGamepad, ISdlDevice<SdlGamepad>, ISdlJoystick, IJoystick
{
    private GamepadHandle _gamepadHandle;

    public SdlJoystick Joystick { get; }


    private SdlGamepad(SdlJoystick joystick, nint uniqueId) : base(joystick.Backend, uniqueId, joystick.SdlDeviceId)
    {
        Joystick = joystick;
        _sdlDeviceId = (uint)base.SdlDeviceId;
        _state = null!; // created in Initialize method
    }

    // we handle the gamepad mapping ourselves rather than relying on gamepad events from SDL
    // the hope is that doing it this way makes it more straightforward to manage input remapping with other backends or
    // adapt to unknown controllers in the future, despite being an unnecessary translation step at the moment.
    // hopefully this allows us to mimic SDL's mapping system for non-sdl input backends.
    // todo (low prio) - abstract the remapping logic into a separate class that can be injected into non-sdl backends
    //  would need to use a non-SDL binding structure
    private void Remap(GamepadHandle gamepadHandle, long timestamp, ulong sdlTimestamp)
    {
        var bindings = new Dictionary<int, GamepadBinding>();
        // _outputBindings.Clear();
        _hatBindings.Clear();
        var bindingsCount = 0;
        var mappings = NativeBackend.GetGamepadBindings(gamepadHandle, &bindingsCount);

        if (bindingsCount == 0)
        {
            if (mappings != null)
            {
                NativeBackend.Free(mappings);
            }

            SdlLog.Error("No gamepad mappings found.");
            return;
        }

        Span<int> buttonBindings = stackalloc int[bindingsCount];
        Span<int> axisBindings = stackalloc int[bindingsCount];
        Span<int> hatBindings = stackalloc int[bindingsCount];
        var buttonBindingsCount = 0;
        var axisBindingsCount = 0;
        var hatBindingListCount = 0;
        for (var i = 0; i < bindingsCount; i++)
        {
            ref var binding = ref Unsafe.AsRef<GamepadBinding>(mappings[i]);

            if (binding.OutputType == GamepadBindingType.None)
            {
                continue;
            }

            switch (binding.InputType)
            {
                case GamepadBindingType.Button:
                {
                    var id = InputIndexToMappingIndex(binding.Input.Button, InputType.Button);
                    if (AddBinding(id, binding, bindings))
                    {
                        buttonBindings[buttonBindingsCount++] = binding.Input.Button;
                    }

                    break;
                }
                case GamepadBindingType.Axis:
                {
                    var id = InputIndexToMappingIndex(binding.Input.Axis.Axis, InputType.Axis);
                    if (AddBinding(id, binding, bindings))
                    {
                        axisBindings[axisBindingsCount++] = binding.Input.Axis.Axis;
                    }

                    break;
                }
                case GamepadBindingType.Hat:
                {
                    var id = binding.Input.Hat.Hat;

                    while (_hatBindings.Count <= id)
                    {
                        _hatBindings.Add(null);
                    }

                    var list = _hatBindings[id];
                    if (list is null)
                    {
                        hatBindings[hatBindingListCount++] = id;
                        _hatBindings[id] = list = [];
                    }

                    list.Add(binding);
                    continue;
                }
                default:
                {
                    continue;
                }
            }
        }

        NativeBackend.Free(mappings);
        _bindings = bindings.ToFrozenDictionary();
        var joystickHandle = Joystick.JoystickHandle;

        // update with default states
        // doing this here lets us pre-populate our axes for consumers to know what buttons are present
        for (var i = 0; i < buttonBindingsCount; ++i)
        {
            var which = buttonBindings[i];
            var on = NativeBackend.GetJoystickButton(joystickHandle, which);
            UpdateFromJoyButton(which, on, sdlTimestamp, timestamp);
        }

        for (var i = 0; i < axisBindingsCount; ++i)
        {
            var which = axisBindings[i];
            var state = NativeBackend.GetJoystickAxis(joystickHandle, which);
            UpdateFromJoyAxis(which, state, sdlTimestamp, timestamp);
        }

        for (var i = 0; i < hatBindingListCount; ++i)
        {
            var which = hatBindings[i];
            Debug.Assert(_hatBindings[which] != null);
            var value = NativeBackend.GetJoystickHat(joystickHandle, which);
            UpdateFromJoyHat(which, (SdlJoystick.HatState)value, sdlTimestamp, timestamp);
        }

        return;

        static bool AddBinding(int id, in GamepadBinding binding, Dictionary<int, GamepadBinding> bindings)
        {
            switch (binding.OutputType)
            {
                case GamepadBindingType.Axis:
                case GamepadBindingType.Button:
                    return bindings.TryAdd(id, binding);
                default:
                    return false;
            }
        }
    }


    private enum InputType { Axis, Button }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int InputIndexToMappingIndex(int index, InputType type)
    {
        // SDL indexes the 3 of these separately, but it is more convenient
        // for us to index buttons/hats/axes as a single list.
        // Since SDL only uses a single byte for a device index,
        // we can safely use an integer key with a bit shift like this.

        // having the axis shift as 8 frees up the top 24 bits for axes - that's a lot of axis support ;)
        const int axisShift = 8, axisAddVal = byte.MaxValue;
        return type switch {
            InputType.Button => index,
            InputType.Axis => (index << axisShift) + axisAddVal,
            _ => throw new InvalidEnumArgumentException(nameof(type), (int)type, typeof(InputType))
        };
    }

    public void Remap(long timestamp, ulong sdlTimestamp) => Remap(_gamepadHandle, timestamp, sdlTimestamp);

    public override ulong SdlDeviceId => _sdlDeviceId;
    private uint _sdlDeviceId;

    public void RefreshSdlId() => _sdlDeviceId = NativeBackend.GetGamepadID(_gamepadHandle);

    public override string Name => Joystick.Name;

    protected internal override void Initialize(long timestamp, ulong sdlTimestamp)
    {
        var gamepadHandle = NativeBackend.OpenGamepad((uint)SdlDeviceId);
        if (gamepadHandle.Handle == null)
        {
            InputLog.Error($"Could not open gamepad handle {SdlDeviceId}");
        }

        _gamepadHandle = gamepadHandle;
        Remap(gamepadHandle, timestamp, sdlTimestamp);
        _state = new GamepadState(Joystick.RawButtonState, Joystick.RawAxisState);

        Joystick.AddDeviceMapping(this);
    }

    /// <summary>
    /// Executes rumbles that were dispatched from <see cref="SdlRumble"/>
    /// </summary>
    public void ExecuteRumble() => _rumbler?.ExecuteRumble();

    protected override void Release()
    {
        Joystick.RemoveDeviceMapping(this);
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

    public static SdlGamepad? CreateDevice(ulong sdlDeviceId, long timestamp, ulong sdlTimestamp, bool isSimulated,
        SdlInputBackend backend, SilkEventContext context)
    {
        if (!backend.TryGetOrCreateDevice<SdlJoystick>(sdlDeviceId, timestamp, sdlTimestamp, out var joystick))
        {
            return null;
        }

        var joystickUniqueId = joystick.Id;
        var gpn = backend.Sdl.GetRealGamepadTypeForID((uint)sdlDeviceId);

        if (backend.AttemptUniqueId(gpn, ref joystickUniqueId))
        {
            return new SdlGamepad(joystick, uniqueId: joystickUniqueId) {
                ThumbstickEvents = context.GamepadThumbstickMoveInputEvents,
                TriggerEvents = context.GamepadTriggerMoveInputEvents,
            };
        }

        // manipulate the joystick id to make a unique gamepad id
        var guid = backend.Sdl.GetGamepadGuidForID((uint)sdlDeviceId);
        if (backend.AttemptUniqueId(guid, ref joystickUniqueId))
        {
            return new SdlGamepad(joystick, uniqueId: joystickUniqueId) {
                ThumbstickEvents = context.GamepadThumbstickMoveInputEvents,
                TriggerEvents = context.GamepadTriggerMoveInputEvents,
            };
        }

        joystickUniqueId = SdlInputBackend.FallbackUniqueId<SdlGamepad>(sdlDeviceId, joystickUniqueId);
        var sdlGamepad = new SdlGamepad(joystick, uniqueId: joystickUniqueId) {
            ThumbstickEvents = context.GamepadThumbstickMoveInputEvents,
            TriggerEvents = context.GamepadTriggerMoveInputEvents,
        };
        return sdlGamepad;
    }

    /// <summary>
    /// Updates the internal state of based on the given SDL <see cref="GamepadAxis"/> input event and joystick mapping
    /// information
    /// </summary>
    /// <param name="gAxis"></param>
    /// <param name="value"></param>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <param name="sdlTimestamp"></param>
    /// <param name="timestamp"></param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    private void UpdateGamepadAxis(GamepadAxis gAxis, int value, int min, int max, ulong sdlTimestamp, long timestamp)
    {
        var lower = Math.Min(min, max);
        var upper = Math.Max(min, max);
        value = Math.Clamp(value, lower, upper);

        var mappedValue = NormalizeInRange(value, min, max);
        UpdateGamepadAxis(gAxis, mappedValue, sdlTimestamp, timestamp);

        return;

        static float NormalizeInRange(int current, int rangeMin, int rangeMax)
        {
            if (rangeMin == rangeMax)
            {
                return 0f;
            }

            var normalized = (current - rangeMin) / (float)(rangeMax - rangeMin);
            return Math.Clamp(normalized, 0f, 1f);
        }

        void UpdateGamepadAxis(GamepadAxis gAxis, float mappedValue, ulong sdlTimestamp, long timestamp)
        {
            switch (gAxis)
            {
                case GamepadAxis.Invalid:
                    return;
                case GamepadAxis.Leftx or GamepadAxis.Lefty or GamepadAxis.Rightx or GamepadAxis.Righty:
                {
                    var axis = ToJoystickAxis(gAxis);
                    var axes = GetJoystickAxis2(axis);
                    var xIndex = axes.X.Index();
                    var yIndex = axes.Y.Index();
                    var previous = Joystick.GetAxisStateByIndex2D(xIndex, yIndex);

                    if (Joystick.UpdateRawAxisState(axis, mappedValue, sdlTimestamp, timestamp, out _))
                    {
                        var latest = Joystick.GetAxisStateByIndex2D(xIndex, yIndex);

                        // Processed Axes
                        ThumbstickEvents.Enqueue(new GamepadThumbstickMoveEvent(Gamepad: this,
                            Timestamp: timestamp,
                            Value: latest,
                            Delta: latest - previous), sdlTimestamp);

                        ToSplitPair(axis, out var minusAxis, out var plusAxis);
                        var split = SdlJoystick.SplitValue(mappedValue);
                        Joystick.UpdateRawAxisState(minusAxis, split.X, sdlTimestamp, timestamp, out _);
                        Joystick.UpdateRawAxisState(plusAxis, split.Y, sdlTimestamp, timestamp, out _);
                    }

                    break;
                }
                case GamepadAxis.LeftTrigger or GamepadAxis.RightTrigger:
                {
                    if (Joystick.UpdateRawAxisState(ToJoystickAxis(gAxis), mappedValue, sdlTimestamp, timestamp,
                            out var moveEvt))
                    {
                        TriggerEvents.Enqueue(new GamepadTriggerMoveEvent(this, moveEvt.Timestamp, moveEvt.Axis,
                            moveEvt.Value, moveEvt.Delta), sdlTimestamp);
                    }

                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException(nameof(gAxis), gAxis, null);
            }

            return;

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

            static (JoystickAxis X, JoystickAxis Y) GetJoystickAxis2(JoystickAxis axis) =>
                axis switch {
                    JoystickAxis.LeftX or JoystickAxis.LeftY => (JoystickAxis.LeftX, JoystickAxis.LeftY),
                    JoystickAxis.RightX or JoystickAxis.RightY => (JoystickAxis.RightX, JoystickAxis.RightY),
                    _ => throw new ArgumentOutOfRangeException(nameof(axis), axis, null)
                };
        }
    }


    /// <summary>
    /// Provides the correct axis names from the given <see cref="JoystickAxis"/> to split it from being a larger
    /// axis (e.g. <see cref="JoystickAxis.LeftX"/>) into a more specific set of names that describe their positive and
    /// negative values separately (e.g. <see cref="JoystickAxis.MinusLeftX"/> and <see cref="JoystickAxis.PlusLeftX"/>).
    /// </summary>
    /// <param name="axis">The axis to split, </param>
    /// <param name="splitMinus">The resulting axis name for the negative value of the given axis.</param>
    /// <param name="splitPlus">The resulting axis name for the positive value of the given axis.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// This method only supports named axes that have a positive and
    /// negative variants named as well. <br/><br/>
    /// <see cref="JoystickAxis.LeftX"/>, <see cref="JoystickAxis.RightX"/>, <see cref="JoystickAxis.LeftY"/>,
    /// and <see cref="JoystickAxis.RightY"/>.
    /// </exception>
    private static void ToSplitPair(JoystickAxis axis, out JoystickAxis splitMinus, out JoystickAxis splitPlus)
    {
        switch (axis)
        {
            case JoystickAxis.LeftX:
                splitMinus = JoystickAxis.MinusLeftX;
                splitPlus = JoystickAxis.PlusLeftX;
                break;
            case JoystickAxis.RightX:
                splitMinus = JoystickAxis.MinusRightX;
                splitPlus = JoystickAxis.PlusRightX;
                break;
            case JoystickAxis.LeftY:
                splitMinus = JoystickAxis.MinusLeftY;
                splitPlus = JoystickAxis.PlusLeftY;
                break;
            case JoystickAxis.RightY:
                splitMinus = JoystickAxis.MinusRightY;
                splitPlus = JoystickAxis.PlusRightY;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(axis), axis, null);
        }
    }

    #region ISdlJoystick

    /// <summary>
    /// Takes the button press from our joystick and updates the internal state of the gamepad accordingly.
    /// </summary>
    /// <param name="buttonIdx">The index/id of the button, from SDL.</param>
    /// <param name="down">Whether the button was pressed or released.</param>
    /// <param name="sdlTimestamp">The timestamp of the event from SDL.</param>
    /// <param name="timestamp">The timestamp from <see cref="InputContext"/>.</param>
    public void UpdateFromJoyButton(int buttonIdx, bool down, ulong sdlTimestamp, long timestamp)
    {
        if (!_bindings.TryGetValue(InputIndexToMappingIndex(buttonIdx, InputType.Button), out var binding))
        {
            InputLog.Warn($"No button binding for index {buttonIdx}");
            return;
        }

        Debug.Assert(binding.InputType == GamepadBindingType.Button && binding.Input.Button == buttonIdx);
        var bindingType = binding.OutputType;
        var output = &binding.Output;
        switch (bindingType)
        {
            case GamepadBindingType.Axis:
                var axis = output->Axis;
                UpdateGamepadAxis(
                    gAxis: axis.Axis,
                    value: down ? axis.AxisMax : axis.AxisMin,
                    min: axis.AxisMin,
                    max: axis.AxisMax,
                    sdlTimestamp: sdlTimestamp,
                    timestamp: timestamp);
                break;

            case GamepadBindingType.Button:
                UpdateButton(output->Button, down, sdlTimestamp, timestamp);
                break;
        }
    }

    /// <summary>
    /// Takes axis input from SDL's joystick and updates the internal state of the gamepad accordingly.
    /// </summary>
    /// <param name="axis">The index/id of the axis, from SDL.</param>
    /// <param name="joystickInput">The value of the axis from SDL. If this is intended to be a mapped input, this
    /// should be the axis of your binding's output.</param>
    /// <param name="sdlTimestamp">The timestamp of the event from SDL.</param>
    /// <param name="timestamp">The timestamp from <see cref="InputContext"/>.</param>
    public void UpdateFromJoyAxis(int axis, short joystickInput, ulong sdlTimestamp, long timestamp)
    {
        if (!_bindings.TryGetValue(InputIndexToMappingIndex(axis, InputType.Axis), out var binding))
        {
            return;
        }

        Debug.Assert(binding.InputType == GamepadBindingType.Axis);

        var output = &binding.Output;
        var input = &binding.Input.Axis;

        switch (binding.OutputType)
        {
            case GamepadBindingType.Axis:
            {
                var inputPercent = NormalizeInRange(joystickInput, input->AxisMin, input->AxisMax);

                ref readonly var outputAxis = ref output->Axis;
                var outputRaw = MapNormalizedToRange(inputPercent, outputAxis.AxisMin, outputAxis.AxisMax);
                UpdateGamepadAxis(output->Axis.Axis, outputRaw, outputAxis.AxisMin, outputAxis.AxisMax, sdlTimestamp,
                    timestamp);
                break;
            }
            case GamepadBindingType.Button:
            {
                UpdateButton(output->Button, IsInPressedRange(joystickInput, input->AxisMin, input->AxisMax),
                    sdlTimestamp, timestamp);
                break;
            }
        }

        return;

        static int MapNormalizedToRange(float normalized, int min, int max)
        {
            var mapped = min + ((max - min) * normalized);
            var lower = Math.Min(min, max);
            var upper = Math.Max(min, max);
            return Math.Clamp((int)MathF.Round(mapped), lower, upper);
        }

        static float NormalizeInRange(int value, int min, int max)
        {
            if (min == max)
            {
                if (value < min)
                {
                    return 0;
                }

                if (value > max)
                {
                    return 1;
                }

                return 0.5f;
            }

            var normalized = (value - min) / (float)(max - min);
            return Math.Clamp(normalized, 0f, 1f);
        }
    }

    /// <summary>
    /// Takes hat input from SDL and updates the internal state of the gamepad accordingly.
    /// </summary>
    /// <param name="hatIdx">The index/id of the hat, from SDL.</param>
    /// <param name="hatState">The state of the hat from SDL.</param>
    /// <param name="sdlTimestamp">The timestamp of the event from SDL.</param>
    /// <param name="timestamp">The timestamp from <see cref="InputContext"/>.</param>
    public void UpdateFromJoyHat(int hatIdx, SdlJoystick.HatState hatState, ulong sdlTimestamp, long timestamp)
    {
        if (_hatBindings.Count <= hatIdx)
        {
            return;
        }

        var bindings = _hatBindings[index: hatIdx];
        if (bindings is not { Count: > 0 })
        {
            return;
        }

        foreach (var binding in bindings)
        {
            Debug.Assert(condition: binding.InputType == GamepadBindingType.Hat && binding.Input.Hat.Hat == hatIdx);
            var input = &binding.Input.Hat;
            var mask = (SdlJoystick.HatState)input->HatMask;
            var bindingState = hatState & mask;
            switch (binding.OutputType)
            {
                case GamepadBindingType.Axis:
                    var axis = binding.Output.Axis;
                    UpdateGamepadAxis(
                        gAxis: axis.Axis,
                        value: bindingState == SdlJoystick.HatState.Centered ? axis.AxisMin : axis.AxisMax,
                        min: axis.AxisMin,
                        max: axis.AxisMax,
                        sdlTimestamp: sdlTimestamp,
                        timestamp: timestamp);
                    break;
                case GamepadBindingType.Button:
                    var button = binding.Output.Button;
                    UpdateButton(button, bindingState != SdlJoystick.HatState.Centered, sdlTimestamp, timestamp);
                    break;
            }
        }
    }

    #endregion

    /// <summary>
    /// Final registration of a button press into the gamepad's internal state.
    /// </summary>
    /// <param name="button">The button that was pressed.</param>
    /// <param name="value">Whether the button was pressed or released.</param>
    /// <param name="sdlTimestamp">The timestamp of the event from SDL.</param>
    /// <param name="timestamp">The timestamp from <see cref="InputContext"/>.</param>
    private void UpdateButton(GamepadButton button, bool value, ulong sdlTimestamp, long timestamp)
    {
        var asJoystickButton = AsJoystickButton(button);
        Joystick.UpdateRawButtonState(asJoystickButton, value, value ? 1 : 0, sdlTimestamp, timestamp);
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
                _ => (JoystickButton)buttonIndex
            };
    }

    private FrozenDictionary<int, GamepadBinding> _bindings;
    private readonly List<List<GamepadBinding>?> _hatBindings = [];
    internal required IInputEventQueue<GamepadThumbstickMoveEvent> ThumbstickEvents { get; init; }
    internal required IInputEventQueue<GamepadTriggerMoveEvent> TriggerEvents { get; init; }


    JoystickState IJoystick.State => Joystick.State;
    ButtonReadOnlyList<JoystickButton> IButtonDevice<JoystickButton>.State => GamepadState.Buttons;

    // Keep the lower endpoint exclusive to preserve the existing overlap behavior for button-like axis mappings.
    private static bool IsInPressedRange(int value, int min, int max) =>
        min <= max ? value > min && value <= max : value < min && value >= max;

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

        // todo - reconcile top-left zero with whatever the standard in this library is (bottom-left zero?)
        var bounds = new Box3D<float>(Vector3D<float>.Zero, Vector3D<float>.One);
        if (!Backend.TryGetVirtualTouchpad(Id, evt.Touchpad, bounds, evt.Timestamp, timestamp, out var surface))
        {
            InputLog.Warn("Failed to retrieve touch surface for gamepad input");
            return;
        }

        Debug.Assert(surface.IsSimulated);
        Debug.Assert(surface.Targets.Count == 1);
        Debug.Assert(surface.Targets[0] is FalseTouchSurfaceTarget);
        var fingerId = evt.Finger;

        surface.Event(
            fingerId: Unsafe.As<int, uint>(ref fingerId),
            target: surface.Targets[0],
            position: new Vector3(evt.X, evt.Y, 0),
            eventType: down switch {
                true => SdlInputBackend.FingerEventType.Down,
                false => SdlInputBackend.FingerEventType.Up,
                null => SdlInputBackend.FingerEventType.Motion,
            },
            pressure: evt.Pressure,
            sdlTimestamp: evt.Timestamp,
            timestamp: timestamp,
            isPositionInWindowSpace: true);
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
           * squared. This measurement includes the force of gravity, so a device at
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
           * observer looking from a positive location on one of the axes would see
           * positive rotation on that axis when it appeared to be rotating
           * counter-clockwise.
           *
           * - `values[0]`: Angular speed around the x axis (pitch)
           * - `values[1]`: Angular speed around the y axis (yaw)
           * - `values[2]`: Angular speed around the z axis (roll)
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
}
