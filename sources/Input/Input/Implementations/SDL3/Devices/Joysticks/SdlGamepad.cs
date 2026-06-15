// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Frozen;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Joysticks;

/// <summary>
/// provides the IGamepad implementation for a joystick
/// </summary>
internal sealed unsafe class SdlGamepad : SdlDevice, IGamepad, ISdlDevice<SdlGamepad>, ISdlJoystick, IJoystick
{
    private GamepadHandle _gamepadHandle;

    public SdlJoystick Joystick { get; }


    // todo - do we want this to be an actual unique device? or should it have the same "unique id" as the joystick?
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
    // todo - abstract the remapping logic into a separate class that can be injected into non-sdl backends
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

        Span<int> buttonBindings  = stackalloc int[bindingsCount];
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

        // update with default states
        // doing this here lets us pre-populate our axes for consumers to know what buttons are present
        for (var i = 0; i < buttonBindingsCount; ++i)
        {
            var which = buttonBindings[i];
            var on = NativeBackend.GetJoystickButton(Joystick.JoystickHandle, which);
            UpdateFromJoyButton(which, on, sdlTimestamp, timestamp);
        }

        for(var i = 0; i < axisBindingsCount; ++i)
        {
            var which = axisBindings[i];

            short state = 0;
            if (NativeBackend.GetJoystickAxisInitialState(Joystick.JoystickHandle, which, &state) != 0)
            {
                InputLog.Error("Failed to get initial axis state");
            }

            UpdateFromJoyAxis(which, state, sdlTimestamp, timestamp);
        }

        for (var i = 0; i < hatBindingListCount; ++i)
        {
            // todo: grab actual state from sdl if it's available?)
            var which = hatBindings[i];
            Debug.Assert(_hatBindings[which] != null);
            UpdateFromJoyHat(which, SdlJoystick.HatState.Centered, sdlTimestamp, timestamp);
        }

        return;

        static bool AddBinding(int id, in GamepadBinding binding, Dictionary<int, GamepadBinding> bindings)
        {
            switch (binding.OutputType)
            {
                case GamepadBindingType.Axis:
                case GamepadBindingType.Button:
                    bindings.Add(id, binding);
                    return true;
                default:
                    return false;
            }
        }
    }


    private enum InputType {Axis, Button}

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
        // var joystickHandle = Joystick.JoystickHandle;
        var gamepadHandle = NativeBackend.OpenGamepad((uint)SdlDeviceId);
        if (gamepadHandle.Handle == null)
        {
            InputLog.Error($"Could not open gamepad handle {SdlDeviceId}");
        }

        _gamepadHandle = gamepadHandle;
        Remap(gamepadHandle, timestamp, sdlTimestamp);
        _state = new GamepadState(Joystick.RawButtonState, Joystick.RawAxisState);

        // int count = -1;
        // var mapping = NativeBackend.GetGamepadBindings(gamepadHandle, &count);
        // Remap();

        //List<Button<JoystickButton>> buttons = new();

        //for (var i = 0; i < count; i++)
        //{
        //    ref var bind = ref *mapping[i];
        //    bind.
        //    _state = new GamepadState(Joystick.RawButtonState, Joystick.RawAxisState);
        //}

        // NativeBackend.Free(mapping);

        Joystick.AddDeviceMapping(this);
    }

    protected override void Release()
    {
        Joystick.RemoveDeviceMapping(this);

        // todo: does this close the joystick as well?
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

    public static SdlGamepad? CreateDevice(ulong sdlDeviceId, long timestamp, ulong sdlTimestamp, SdlInputBackend backend, SilkEventContext context)
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
                ThumbstickEvents = context.GamepadThumbstickMoveSdlEvents,
                TriggerEvents = context.GamepadTriggerMoveSdlEvents,
            };
        }

        // manipulate the joystick id to make a unique gamepad id
        var guid = backend.Sdl.GetGamepadGuidForID((uint)sdlDeviceId);
        if (backend.AttemptUniqueId(guid, ref joystickUniqueId))
        {
            return new SdlGamepad(joystick, uniqueId: joystickUniqueId) {
                ThumbstickEvents = context.GamepadThumbstickMoveSdlEvents,
                TriggerEvents = context.GamepadTriggerMoveSdlEvents,
            };
        }

        joystickUniqueId = SdlInputBackend.FallbackUniqueId<SdlGamepad>(sdlDeviceId, joystickUniqueId);
        var sdlGamepad = new SdlGamepad(joystick, uniqueId: joystickUniqueId) {
            ThumbstickEvents = context.GamepadThumbstickMoveSdlEvents,
            TriggerEvents = context.GamepadTriggerMoveSdlEvents,
        };
        return sdlGamepad;
    }

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
    }

    private void UpdateGamepadAxis(GamepadAxis gAxis, float mappedValue, ulong sdlTimestamp, long timestamp)
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
                if (Joystick.UpdateRawAxisState(ToJoystickAxis(gAxis), mappedValue, sdlTimestamp, timestamp, out var moveEvt))
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
                UpdateGamepadAxis(output->Axis.Axis, outputRaw, outputAxis.AxisMin, outputAxis.AxisMax, sdlTimestamp, timestamp);
                break;
            }
            case GamepadBindingType.Button:
            {
                UpdateButton(output->Button, IsInPressedRange(joystickInput, input->AxisMin, input->AxisMax), sdlTimestamp, timestamp);
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
                // TODO not exposed today
                _ => (JoystickButton)buttonIndex
            };
    }

    private FrozenDictionary<int, GamepadBinding> _bindings;
    private readonly List<List<GamepadBinding>?> _hatBindings = [];
    internal required ISdlEventQueue<GamepadThumbstickMoveEvent> ThumbstickEvents { get; init; }
    internal required ISdlEventQueue<GamepadTriggerMoveEvent> TriggerEvents { get; init; }


    JoystickState IJoystick.State => Joystick.State;
    ButtonReadOnlyList<JoystickButton> IButtonDevice<JoystickButton>.State => GamepadState.Buttons;

    // Keep the lower endpoint exclusive to preserve the existing overlap behavior for button-like axis mappings.
    private static bool IsInPressedRange(int value, int min, int max) =>
        min <= max ? value > min && value <= max : value < min && value >= max;
}
