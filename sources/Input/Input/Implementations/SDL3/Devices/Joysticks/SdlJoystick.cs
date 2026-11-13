// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Frozen;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.Input.SDL3.DataStructures;
using Silk.NET.Input.SDL3.Extensions;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Joysticks;

internal sealed unsafe class SdlJoystick : SdlDevice, IJoystick, ISdlDevice<SdlJoystick>, IOrderedDevice
{
    public JoystickState State { get; private set; }
    private JoystickType _joystickType;
    private JoystickHandle _joystickHandle;

    public static SdlJoystick CreateDevice(ulong sdlDeviceId, long timestamp, bool isSimulated, SdlInputBackend backend,
        SdlInputEventContext sdlInputEvents)
    {
        nint uniqueId = 0;

        var guid = backend.Sdl.GetJoystickGuidForID((uint)sdlDeviceId);
        if (backend.AttemptUniqueId(new ReadOnlySpan<byte>(&guid, 16), ref uniqueId))
        {
            return CreatePls(backend, uniqueId, sdlDeviceId, sdlInputEvents);
        }

        var pathPtr = backend.Sdl.GetJoystickPathForID((uint)sdlDeviceId);
        if (backend.AttemptUniqueId(pathPtr, ref uniqueId))
        {
            return CreatePls(backend, uniqueId, sdlDeviceId, sdlInputEvents);
        }

        var name = backend.Sdl.GetJoystickNameForID((uint)sdlDeviceId);
        if (backend.AttemptUniqueId(name, ref uniqueId))
        {
            return CreatePls(backend, uniqueId, sdlDeviceId, sdlInputEvents);
        }

        var type = backend.Sdl.GetJoystickTypeForID((uint)sdlDeviceId);
        if (backend.AttemptUniqueId(type, ref uniqueId))
        {
            return CreatePls(backend, uniqueId, sdlDeviceId, sdlInputEvents);
        }

        uniqueId = SdlInputBackend.FallbackUniqueId<SdlJoystick>(sdlDeviceId, uniqueId);
        return CreatePls(backend, uniqueId, sdlDeviceId, sdlInputEvents);

        static SdlJoystick CreatePls(SdlInputBackend sdlInputBackend, nint uniqueId, ulong sdlDeviceId,
            SdlInputEventContext context)
        {
            return new SdlJoystick(sdlDeviceId, uniqueId, sdlInputBackend) {
                ButtonEvents = context.JoyButtonChangedEvents,
                AxisEvents = context.JoystickAxisMoveEvents,
                HatEvents = context.JoystickHatMoveEvents
            };
        }
    }


    public override string Name => NativeBackend.GetJoystickNameForID((uint)SdlDeviceId).ReadToString();

    public override ulong SdlDeviceId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _sdlDeviceId;
    }


    private SdlJoystick(ulong sdlDeviceId, nint uniqueId, SdlInputBackend backend) : base(backend, uniqueId,
        sdlDeviceId)
    {
        _sdlDeviceId = sdlDeviceId;
    }


    [Flags]
    internal enum HatState : byte
    {
        Up = (byte)Sdl.HatUp,
        Right = (byte)Sdl.HatRight,
        Down = (byte)Sdl.HatDown,
        Left = (byte)Sdl.HatLeft,
        Centered = (byte)Sdl.HatCentered,
        LeftUp = (byte)Sdl.HatLeftup,
        RightUp = (byte)Sdl.HatRightup,
        LeftDown = (byte)Sdl.HatLeftdown,
        RightDown = (byte)Sdl.HatRightdown
    }

    #region Sdl Events

    public void AddBallEvent(byte ballIdx, short ballEventXrel, short ballEventYrel, ulong ballEventTimestamp,
        long timestamp)
    {
        // TODO - implement ball events.
        //  There are two options for implementation:
        //   1. treat this the same way we would treat a pointer that's locked to the center of the window - deltas only
        //   2. treat this as joystick input, with velocity indicating absolute position of the joystick
        InputLog.Debug("Ball events not implemented");
    }

    public void AddHatEvent(int hatIdx, byte hatInput, long timestamp)
    {
        var hatState = (HatState)hatInput;
        var left = (hatState & HatState.Left) == HatState.Left;
        var right = (hatState & HatState.Right) == HatState.Right;

        var x = (float)(*(byte*)&right - *(byte*)&left);
        var up = (hatState & HatState.Up) == HatState.Up;
        var down = (hatState & HatState.Down) == HatState.Down;
        var y = (float)(*(byte*)&up - *(byte*)&down);

        ref var hatStateRef = ref _rawHatState[hatIdx];
        var previous = hatStateRef;
        hatStateRef = new Vector2(x, y);

        var delta = hatStateRef - previous;
        if (delta != Vector2.Zero)
        {
            HatEvents.Enqueue(new JoystickHatMoveEvent(this, timestamp, hatIdx, hatStateRef, delta));
        }
    }

    public void AddAxisEvent(int axis, short joystickInput, long timestamp)
    {
        if ((uint)axis >= (uint)_rawAxisState.Length)
        {
            InputLog.Error($"Joystick axis {axis} out of bounds with length {_rawAxisState.Length}");
            return;
        }

        ref var axisState = ref _rawAxisState[axis];
        var previous = axisState;
        axisState = (float)(joystickInput + short.MaxValue) / ushort.MaxValue;

        var delta = axisState - previous;
        if (delta != 0)
        {
            AxisEvents.Enqueue(new JoystickAxisMoveEvent(this, timestamp, axis, axisState, delta));
        }
    }

    public void AddButtonEvent(byte sdlButtonId, byte sdlButtonDown, long timestamp)
    {
        var down = sdlButtonDown > 0;
        var joystickButton = (JoystickButton)sdlButtonId;
        var idx = joystickButton.Index();
        if (idx == -1)
        {
            InputLog.Error($"No index for button {sdlButtonId} on joystick {Id}");
            return;
        }

        if (idx >= _rawButtonState.Length)
        {
            InputLog.Error($"Joystick button {joystickButton} out of bounds with index {idx}");
            return;
        }

        ref var buttonState = ref _rawButtonState[idx];
        var previous = buttonState;
        buttonState = new Button<JoystickButton>(joystickButton, down, down ? 1 : 0);

        // ReSharper disable once CompareOfFloatsByEqualityOperator
        if (previous.IsDown != buttonState.IsDown || previous.Pressure != buttonState.Pressure)
        {
            ButtonEvents.Enqueue(new ButtonChangedEvent<JoystickButton>(this, timestamp, buttonState, previous));
        }
    }

    #endregion

    /// <summary>
    /// Returns a "split" axis vector, taking what would be a single axis value (e.g. Left Thumbstick X) from (0, 1)
    /// and splitting it into two separate axes from (0, 1)
    /// </summary>
    /// <param name="value">The axis value on a scale of 0 to 1</param>
    /// <returns>
    /// A vector representing the split axis values with <br/>
    /// X as the 'minus' component and
    /// Y as the 'plus' component
    /// </returns>
    internal static Vector2 SplitValue(float value)
    {
        value = (float)((value - 0.5d) * 2d);
        return value > 0 ? new Vector2(0, value) : new Vector2(value, 0);
    }

    protected internal override void Initialize(long timestamp)
    {
        var joystickHandle = NativeBackend.OpenJoystick((uint)SdlDeviceId);
        if (joystickHandle.Handle == null)
        {
            var error = NativeBackend.GetError();
            string? errorStr = null;
            if (error.Native != null)
            {
                errorStr = error.ReadToString();
                NativeBackend.Free(error.Native);
            }

            throw new Exception($"Failed to open joystick: {errorStr ?? "Unknown error."}");
        }

        _joystickHandle = joystickHandle;
        _joystickType = NativeBackend.GetJoystickType(joystickHandle);

        // init current joystick state
        var buttonCount = NativeBackend.GetNumJoystickButtons(joystickHandle);

        _rawButtonState = new Button<JoystickButton>[EnumInfo<JoystickButton>.DistinctCount + buttonCount];
        for (var i = 0; i < _rawButtonState.Length; i++)
        {
            _rawButtonState[i] = new Button<JoystickButton>(EnumInfo<JoystickButton>.ValueOfIndex(i), false, 0);
        }

        var axisCount = NativeBackend.GetNumJoystickAxes(joystickHandle);
        _rawAxisState = new float[EnumInfo<JoystickAxis>.DistinctCount + axisCount];

        var hatCount = NativeBackend.GetNumJoystickHats(joystickHandle);
        _rawHatState = new Vector2[hatCount];

        for (byte i = 0; i < buttonCount; i++)
        {
            var joystickInput = NativeBackend.GetJoystickButtonRaw(joystickHandle, i);
            AddButtonEvent(i, joystickInput, timestamp);
        }

        for (var i = 0; i < axisCount; i++)
        {
            // Sdl docs on GetJoystickAxis:
            // "Returns a 16-bit signed integer representing the current position of the axis or 0 on failure;
            // call SDL_GetError() for more information."
            var joystickInput = NativeBackend.GetJoystickAxis(joystickHandle, i);
            if (joystickInput == 0)
            {
                joystickInput = short.MinValue;
            }

            AddAxisEvent(i, joystickInput, timestamp);
        }

        for (var i = 0; i < hatCount; ++i)
        {
            var hatInput = NativeBackend.GetJoystickHat(joystickHandle, i);
            AddHatEvent(i, hatInput, timestamp);
        }

        State = new JoystickState(_rawAxisState, _rawButtonState, _rawHatState);
    }

    internal void ApplyMapping(GamepadHandle gamepadHandle, long timestamp)
    {
        var mapping = NativeBackend.GetGamepadMapping(gamepadHandle);
        if (mapping == nullptr)
        {
            return;
        }

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

        // update with default states
        // doing this here lets us pre-populate our axes for consumers to know what buttons are present
        for (var i = 0; i < buttonBindingsCount; ++i)
        {
            var which = buttonBindings[i];
            var on = NativeBackend.GetJoystickButton(_joystickHandle, which);
            UpdateFromJoyButton(which, on, timestamp);
        }

        for (var i = 0; i < axisBindingsCount; ++i)
        {
            var which = axisBindings[i];
            var state = NativeBackend.GetJoystickAxis(_joystickHandle, which);
            UpdateFromJoyAxis(which, state, timestamp);
        }

        for (var i = 0; i < hatBindingListCount; ++i)
        {
            var which = hatBindings[i];
            Debug.Assert(_hatBindings[which] != null);
            var value = NativeBackend.GetJoystickHat(_joystickHandle, which);
            UpdateFromJoyHat(which, (SdlJoystick.HatState)value, timestamp);
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

    /// <summary>
    /// Updates the internal state of based on the given SDL <see cref="GamepadAxis"/> input event and joystick mapping
    /// information
    /// </summary>
    /// <param name="gAxis"></param>
    /// <param name="value"></param>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <param name="timestamp"></param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    private void UpdateGamepadAxis(GamepadAxis gAxis, int value, int min, int max, long timestamp)
    {
        var lower = Math.Min(min, max);
        var upper = Math.Max(min, max);
        value = Math.Clamp(value, lower, upper);

        var mappedValue = NormalizeInRange(value, min, max);
        UpdateGAxis();

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

        void UpdateGAxis()
        {
            switch (gAxis)
            {
                case GamepadAxis.Invalid:
                    return;
                case GamepadAxis.Leftx or GamepadAxis.Lefty or GamepadAxis.Rightx or GamepadAxis.Righty:
                {
                    var axis = ToJoystickAxis(gAxis);
                    var axes = GetJoystickAxis2(axis);
                    var xIdx = axes.X.Index();
                    var yIdx = axes.Y.Index();
                    var previous = GetAxisStateByIndex2D(xIdx, yIdx);

                    if (UpdateRawAxisState(axis, mappedValue, timestamp, out _))
                    {
                        var latest = GamepadAxes.JoystickAxesToThumbstick(GetAxisStateByIndex2D(xIdx, yIdx));
                        previous = GamepadAxes.JoystickAxesToThumbstick(previous);


                        ToSplitPair(axis, out var minusAxis, out var plusAxis);
                        var split = SdlJoystick.SplitValue(mappedValue);
                        UpdateRawAxisState(minusAxis, split.X, timestamp, out _);
                        UpdateRawAxisState(plusAxis, split.Y, timestamp, out _);
                    }

                    break;
                }
                case GamepadAxis.LeftTrigger or GamepadAxis.RightTrigger:
                {
                    if (UpdateRawAxisState(ToJoystickAxis(gAxis), mappedValue, timestamp,
                            out var moveEvt))
                    {
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        float GetAxisState(JoystickAxis axis) => _rawAxisState[axis.Index()];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        float GetAxisStateByIndex(int index) => _rawAxisState[index];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        Vector2 GetAxisStateByIndex2D(int xIndex, int yIndex) =>
            new(GetAxisStateByIndex(xIndex), GetAxisStateByIndex(yIndex));

        bool UpdateRawAxisState(JoystickAxis axis, float val, long time, out JoystickAxisMoveEvent evt)
        {
            var index = axis.Index();
            if (index < 0)
            {
                InputLog.Error($"Calculated an invalid SDL axis index?? {axis} ({index})");
                evt = default;
                return false;
            }

            ref var state = ref _rawAxisState[index];
            var p = state;
            state = val;

            var delta = val - p;
            if (delta != 0)
            {
                evt = new JoystickAxisMoveEvent(this, time, index, val, delta);
                AxisEvents.Enqueue(evt);
                return true;
            }

            evt = default;
            return false;
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
    /// <param name="timestamp">The timestamp from <see cref="InputContext"/>.</param>
    public void UpdateFromJoyButton(int buttonIdx, bool down, long timestamp)
    {
        Debug.Assert(_bindings != null, "Bindings not initialized");
        var mappingIndex = InputIndexToMappingIndex(buttonIdx, InputType.Button);
        if (!_bindings.TryGetValue(mappingIndex, out var binding))
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
                    timestamp: timestamp);
                break;

            case GamepadBindingType.Button:
                UpdateFromGamepadButton(output->Button, down, timestamp);
                break;
        }
    }

    /// <summary>
    /// Takes axis input from SDL's joystick and updates the internal state of the gamepad accordingly.
    /// </summary>
    /// <param name="axis">The index/id of the axis, from SDL.</param>
    /// <param name="joystickInput">The value of the axis from SDL. If this is intended to be a mapped input, this
    /// should be the axis of your binding's output.</param>
    /// <param name="timestamp">The timestamp from <see cref="InputContext"/>.</param>
    public void UpdateFromJoyAxis(int axis, short joystickInput, long timestamp)
    {
        Debug.Assert(_bindings != null, "Bindings not initialized");
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
                UpdateGamepadAxis(output->Axis.Axis, outputRaw, outputAxis.AxisMin, outputAxis.AxisMax,
                    timestamp);
                break;
            }
            case GamepadBindingType.Button:
            {
                UpdateFromGamepadButton(output->Button, IsInPressedRange(joystickInput, input->AxisMin, input->AxisMax),
                    timestamp);

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
    /// <param name="timestamp">The timestamp from <see cref="InputContext"/>.</param>
    public void UpdateFromJoyHat(int hatIdx, SdlJoystick.HatState hatState, long timestamp)
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
                        timestamp: timestamp);
                    break;
                case GamepadBindingType.Button:
                    var button = binding.Output.Button;
                    UpdateFromGamepadButton(button, bindingState != SdlJoystick.HatState.Centered, timestamp);
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
    /// <param name="timestamp">The timestamp from <see cref="InputContext"/>.</param>
    private void UpdateFromGamepadButton(GamepadButton button, bool value, long timestamp)
    {
        var asJoystickButton = AsJoystickButton(button);
        float pressure1 = value ? 1 : 0;
        var idx1 = asJoystickButton.Index();
        if (idx1 < 0)
        {
            throw new Exception("Received an invalid SDL button??");
        }

        ref var buttonState = ref _rawButtonState[idx1];

        var previous = buttonState;

        buttonState = new Button<JoystickButton>(asJoystickButton, value, pressure1);

        // ReSharper disable once CompareOfFloatsByEqualityOperator
        if (previous.IsDown != buttonState.IsDown || previous.Pressure != buttonState.Pressure)
        {
            ButtonEvents.Enqueue(new ButtonChangedEvent<JoystickButton>(this, timestamp, buttonState, previous));
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
                _ => (JoystickButton)buttonIndex
            };
    }

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

    // Keep the lower endpoint exclusive to preserve the existing overlap behavior for button-like axis mappings.
    private static bool IsInPressedRange(int value, int min, int max) =>
        min <= max ? value > min && value <= max : value < min && value >= max;

    protected override void Release() => NativeBackend.CloseJoystick(_joystickHandle);

    public void RefreshSdlId() => _sdlDeviceId = NativeBackend.GetJoystickID(_joystickHandle);
    private ulong _sdlDeviceId;

    // State
    private Button<JoystickButton>[] _rawButtonState;
    private float[] _rawAxisState;
    private Vector2[] _rawHatState;
    private FrozenDictionary<int, GamepadBinding>? _bindings;
    private readonly List<List<GamepadBinding>?> _hatBindings = [];

    // Constants
    internal const short DigitalThreshold = short.MaxValue / 8;

    // events
    internal required SdlInputEventQueue<ButtonChangedEvent<JoystickButton>> ButtonEvents { get; init; }
    internal required SdlInputEventQueue<JoystickAxisMoveEvent> AxisEvents { get; init; }
    internal required SdlInputEventQueue<JoystickHatMoveEvent> HatEvents { get; init; }

    ButtonReadOnlyList<JoystickButton> IButtonDevice<JoystickButton>.State => State.Buttons;

    private enum InputType { Axis, Button }
}
