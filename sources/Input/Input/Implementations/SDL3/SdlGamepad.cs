// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

/// <summary>
/// provides the IGamepad implementation for a joystick
/// </summary>
internal sealed unsafe class SdlGamepad : SdlDevice, IGamepad, ISdlDevice<SdlGamepad>, ISdlJoystick
{
    private readonly GamepadHandle _gamepadHandle;

    public SdlJoystick Joystick { get; }

    private SdlGamepad(SdlJoystick joystick) : base(joystick.SdlDeviceId, joystick.Backend)
    {
        Joystick = joystick;

        var bindingsCount = 0;
        var joystickHandle = joystick.JoystickHandle;
        var gamepadHandle = *(GamepadHandle*)&joystickHandle; //NativeBackend.OpenGamepad(sdlDeviceId);
        var mappings = NativeBackend.GetGamepadBindings(gamepadHandle, &bindingsCount);

        if (bindingsCount == 0)
        {
            if (mappings == null)
            {
                var error = NativeBackend.GetError();
                if (error.Native != null)
                {
                    Console.Error.WriteLine(error.ReadToString());
                    NativeBackend.Free(error.Native);
                }
            }

            throw new Exception("No gamepad mappings found.");
        }

        _gamepadHandle = gamepadHandle;
        for (int i = 0; i < bindingsCount; i++)
        {
            var binding = mappings[i];

            if (binding->OutputType == GamepadBindingType.None)
            {
                continue;
            }

            int? id = null;

            switch (binding->InputType)
            {
                case GamepadBindingType.Button:
                    id = binding->Input.Button << _buttonShift;
                    break;
                case GamepadBindingType.Axis:
                    id = binding->Input.Axis.Axis << _axisShift;
                    break;
                case GamepadBindingType.Hat:
                    id = binding->Input.Hat.Hat;
                    break;
            }

            switch (binding->OutputType)
            {
                case GamepadBindingType.Axis:
                case GamepadBindingType.Button:
                    _outputBindings.Add(*binding);
                    break;
            }

            if (id == null)
            {
                continue;
            }

            if (binding->InputType == GamepadBindingType.Hat)
            {
                while (_hatBindings.Count <= id.Value)
                {
                    _hatBindings.Add(null);
                }

                _hatBindings[id.Value] ??= [];
                _hatBindings[id.Value]!.Add(*binding);
            }
            else
            {
                _bindings.Add(id.Value, *binding);
            }
        }

        NativeBackend.Free(mappings);
        GamepadState = new GamepadState(joystick.RawButtonState, joystick.RawAxisState);
        Joystick.AddDeviceMapping(this);
    }

    public override string Name => Joystick.Name;

    protected override void Release()
    {
        Joystick.RemoveDeviceMapping(this);

        // todo: does this close the joystick as well?
        NativeBackend.CloseGamepad(_gamepadHandle);
    }

    #region IGamepad

    GamepadState IGamepad.State => GamepadState;
    private GamepadState GamepadState { get; }

    #endregion


    #region Rumble

    public IReadOnlyList<IMotor> VibrationMotors => _rumbler ??= SdlRumble.Create<GamepadHandle>(_gamepadHandle.Handle, NativeBackend, 2);
    private SdlRumble? _rumbler;


    #endregion

    public static SdlGamepad CreateDevice(uint sdlDeviceId, SdlInputBackend backend)
    {
        var joystick = backend.GetOrCreateDevice<SdlJoystick>(sdlDeviceId);
        return new SdlGamepad(joystick);
    }

    ~SdlGamepad() => Release();


    private void UpdateGamepadAxis(GamepadAxis axis, int value, int min, int max)
    {
        var mappedValue = (float)(value + min) / (max - min);
        switch (axis)
        {
            case GamepadAxis.Invalid:
                return;
            case GamepadAxis.Leftx:
            {
                Joystick.UpdateRawAxisState(JoystickAxis.LeftX, mappedValue);

                var split = SdlJoystick.SplitValue(mappedValue);
                Joystick.UpdateRawAxisState(JoystickAxis.MinusLeftX, split.minus);
                Joystick.UpdateRawAxisState(JoystickAxis.PlusLeftX, split.plus);
                break;
            }
            case GamepadAxis.Lefty:
            {
                Joystick.UpdateRawAxisState(JoystickAxis.LeftY, mappedValue);

                var split = SdlJoystick.SplitValue(mappedValue);
                Joystick.UpdateRawAxisState(JoystickAxis.MinusLeftY, split.minus);
                Joystick.UpdateRawAxisState(JoystickAxis.PlusLeftY, split.plus);
                break;
            }
            case GamepadAxis.Rightx:
            {
                Joystick.UpdateRawAxisState(JoystickAxis.RightX, mappedValue);

                var split = SdlJoystick.SplitValue(mappedValue);
                Joystick.UpdateRawAxisState(JoystickAxis.MinusRightX, split.minus);
                Joystick.UpdateRawAxisState(JoystickAxis.PlusRightX, split.plus);
                break;
            }
            case GamepadAxis.Righty:
            {
                Joystick.UpdateRawAxisState(JoystickAxis.RightY, mappedValue);

                var split = SdlJoystick.SplitValue(mappedValue);
                Joystick.UpdateRawAxisState(JoystickAxis.MinusRightY, split.minus);
                Joystick.UpdateRawAxisState(JoystickAxis.PlusRightY, split.plus);
                break;
            }
            case GamepadAxis.LeftTrigger:
            {
                Joystick.UpdateRawAxisState(JoystickAxis.LeftTrigger, mappedValue);
                break;
            }
            case GamepadAxis.RightTrigger:
            {
                Joystick.UpdateRawAxisState(JoystickAxis.RightTrigger, mappedValue);
                break;
            }
            default:
                throw new ArgumentOutOfRangeException(nameof(axis), axis, null);
        }
    }

    #region ISdlJoystick

    public void UpdateButton(int buttonIdx, bool down)
    {
        if (!_bindings.TryGetValue(buttonIdx << _buttonShift, out var binding))
        {
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
                    axis: axis.Axis,
                    value: down ? axis.AxisMax : axis.AxisMin,
                    min: axis.AxisMin,
                    max: axis.AxisMax);
                break;

            case GamepadBindingType.Button:
                UpdateButtonBinding(output->Button, down);
                break;
        }
    }

    public void AddButtonEvent(byte sdlButtonId, byte sdlButtonDown) => UpdateButton(sdlButtonId, sdlButtonDown > 0);

    public void UpdateAxis(int axis, short joystickInput)
    {
        if (!_bindings.TryGetValue(axis << _axisShift, out var binding))
        {
            return;
        }

        Debug.Assert(binding.InputType == GamepadBindingType.Axis);

        var output = &binding.Output;
        var input = &binding.Input.Axis;

        switch (binding.OutputType)
        {
            case GamepadBindingType.Axis:
                UpdateGamepadAxis(output->Axis.Axis, joystickInput, input->AxisMin, input->AxisMax);
                break;
            case GamepadBindingType.Button:
                UpdateButtonBinding(output->Button, joystickInput >= input->AxisMin && joystickInput <= input->AxisMax);
                break;
        }
    }

    public void UpdateHat(int hatIdx, SdlJoystick.HatState hatState)
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
                        axis: axis.Axis,
                        value: bindingState == SdlJoystick.HatState.Centered ? axis.AxisMin : axis.AxisMax,
                        min: axis.AxisMin,
                        max: axis.AxisMax);
                    break;
                case GamepadBindingType.Button:
                    var button = binding.Output.Button;
                    UpdateButtonBinding(button, bindingState != SdlJoystick.HatState.Centered);
                    break;
            }
        }
    }

    #endregion

    private void UpdateButtonBinding(GamepadButton button, bool value)
    {
        var asJoystickButton = AsJoystickButton(button);
        Joystick.UpdateRawButtonState(asJoystickButton, value, value ? 1 : 0);
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


    // SDL indexes the 3 of these separately, but it is more convenient
    // for us to index buttons/hats/axes as a single list.
    // Since SDL only uses a single byte for a device index,
    // we can safely use an integer key with a bit shift like this.
    private const int _buttonShift = 0;
    private const int _axisShift = 8;
    private readonly Dictionary<int, GamepadBinding> _bindings = new();
    private readonly List<List<GamepadBinding>?> _hatBindings = [];
    private readonly List<GamepadBinding> _outputBindings = [];
}
