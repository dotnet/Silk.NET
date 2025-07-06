// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Numerics;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal unsafe class SdlJoystick : SdlDevice, IJoystick, IGamepad
{
    private readonly JoystickHandle _joystickHandle;
    private protected readonly JoystickType JoystickType;

    private readonly JoystickState _joystickState;
    private readonly GamepadState? _gamepadState;
    private readonly GamepadHandle? _gamepadHandle;
    public readonly bool HasGamepadImplementation;

    public sealed override string Name => NativeBackend.GetJoystickNameForID(SdlDeviceId).ReadToString();

    protected SdlJoystick(uint sdlDeviceId, SdlInputBackend backend) : base(sdlDeviceId, backend)
    {
        var joystickHandle = NativeBackend.OpenJoystick(sdlDeviceId);

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
        JoystickType = NativeBackend.GetJoystickType(joystickHandle);


        var gamepadMapping = NativeBackend.GetGamepadBindings(sdlDeviceId);
        if (gamepadMapping.Native != null)
        {
            NativeBackend.Free(gamepadMapping.Native);
        }


        int bindingsCount = 0;
        var gamepadHandle = *(GamepadHandle*)&joystickHandle; //NativeBackend.OpenGamepad(sdlDeviceId);
        var mappings = NativeBackend.GetGamepadBindings(gamepadHandle, &bindingsCount);

        if (bindingsCount != 0)
        {
            HasGamepadImplementation = true;
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
                        id = binding->Input.Button << ButtonShift;
                        break;
                    case GamepadBindingType.Axis:
                        id = binding->Input.Axis.Axis << AxisShift;
                        break;
                    case GamepadBindingType.Hat:
                        id = binding->Input.Hat.Hat;
                        break;
                }

                switch (binding->OutputType)
                {
                    case GamepadBindingType.Axis:
                        break;
                    case GamepadBindingType.Button:
                        break;
                    default:
                        // todo : throw? this should not be possible according to sdl
                        break;
                }

                if (id != null)
                {
                    if (binding->InputType == GamepadBindingType.Hat)
                    {
                        while (_hatBindings.Count <= id.Value)
                            _hatBindings.Add(null);

                        _hatBindings[id.Value] ??= new List<GamepadBinding>();
                        _hatBindings[id.Value]!.Add(*binding);
                    }
                    else
                    {
                        _bindings.Add(id.Value, *binding);
                    }
                }
            }

            NativeBackend.Free(mappings);
        }
        else if (mappings == null)
        {
            var error = NativeBackend.GetError();
            if (error.Native != null)
            {
                Console.Error.WriteLine(error.ReadToString());
                NativeBackend.Free(error.Native);
            }
        }

        if (_bindings.Count > 0)
        {
            _gamepadButtonState = new bool[(int)GamepadButton.Count];
            _gamepadAxisState = new float[(int)GamepadAxis.Count];
        }
        else
        {
            _gamepadState = null;
            _gamepadButtonState = [];
            _gamepadAxisState = [];
        }

        // init current joystick state
        var buttonCount = NativeBackend.GetNumJoystickButtons(joystickHandle);
        for (var i = 0; i < buttonCount; i++)
        {
            var joystickInput = NativeBackend.GetJoystickButtonRaw(_joystickHandle, i);
            UpdateButton(i, joystickInput);
        }

        var axisCount = NativeBackend.GetNumJoystickAxes(joystickHandle);
        _rawAxisState = new float[axisCount];
        for (int i = 0; i < axisCount; i++)
        {
            var joystickInput = NativeBackend.GetJoystickAxis(_joystickHandle, i);
            if (joystickInput == 0)
            {
                // this indicates an sdl error, so just set our internal axis to 0
                joystickInput = short.MinValue;
            }

            UpdateAxis(i, joystickInput);
        }

        var hatCount = NativeBackend.GetNumJoystickHats(joystickHandle);
        for (int i = 0; i < hatCount; ++i)
        {
            var hatInput = NativeBackend.GetJoystickHat(joystickHandle, i);
            UpdateHat(i, hatInput);
        }

        _joystickState = new JoystickState(_rawAxisState, _rawButtonState, _rawHatState);
        _gamepadState = new GamepadState()
    }

    [Flags]
    private enum HatState : byte
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


    private void UpdateHat(int hatIdx, byte hatInput)
    {
        var hatState = (HatState)hatInput;
        var left = (hatState & HatState.Left) == HatState.Left;
        var right = (hatState & HatState.Right) == HatState.Right;

        var x = (float)(*(byte*)&right - *(byte*)&left);
        var up = (hatState & HatState.Up) == HatState.Up;
        var down = (hatState & HatState.Down) == HatState.Down;
        var y = (float)(*(byte*)&up - *(byte*)&down);

        _rawHatState[hatIdx] = new Vector2(x, y);
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
            var mask = (HatState)input->HatMask;
            var bindingState = hatState & mask;
            switch (binding.OutputType)
            {
                case GamepadBindingType.Axis:
                    var axis = binding.Output.Axis;
                    UpdateGamepadAxis(
                        axis: axis.Axis,
                        value: bindingState == HatState.Centered ? axis.AxisMin : axis.AxisMax,
                        min: axis.AxisMin,
                        max: axis.AxisMax);
                    break;
                case GamepadBindingType.Button:
                    var button = binding.Output.Button;
                    UpdateGamepadButton(button, bindingState != HatState.Centered);
                    break;
            }
        }
    }

    public void UpdateAxis(int axis, short joystickInput)
    {
        _rawAxisState[axis] = (float)(joystickInput + short.MaxValue) / ushort.MaxValue;
        if (!_bindings.TryGetValue(axis << AxisShift, out var binding))
        {
            return;
        }

        Debug.Assert(binding.InputType == GamepadBindingType.Axis);

        var output = &binding.Output;

        switch (binding.OutputType)
        {
            case GamepadBindingType.Axis:
                UpdateGamepadAxis(output->Axis.Axis, joystickInput, output->Axis.AxisMin, output->Axis.AxisMax );
                break;
            case GamepadBindingType.Button:
                UpdateGamepadButton(output->Button, joystickInput > 0); // todo : threshold
                break;
        }
    }

    private void UpdateGamepadAxis(GamepadAxis axis, int value, int min, int max)
    {
        _gamepadAxisState[(int)axis] = (float)(value + min) / (max - min);
    }

    private void UpdateGamepadButton(GamepadButton button, bool value) => _gamepadButtonState[(int)button] = value;

    public void UpdateButton(int buttonIdx, byte rawValue)
    {
        var down = rawValue > 0;
        _rawButtonState[buttonIdx] = new Button<JoystickButton>((JoystickButton)buttonIdx, down, down ? 1 : 0);

        if (!_bindings.TryGetValue(buttonIdx << ButtonShift, out var binding))
        {
            return;
        }

        Debug.Assert(binding.InputType == GamepadBindingType.Button);
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
                UpdateGamepadButton(output->Button, down);
                break;
            default:
                // todo: throw? - this should not be possible
                break;
        }
    }

    protected override void Release()
    {
        if (_gamepadHandle != null)
        {
            NativeBackend.CloseGamepad(_gamepadHandle.Value);
        }

        NativeBackend.CloseJoystick(_joystickHandle);
    }

    public JoystickState State => throw new NotImplementedException();

    private readonly List<Button<JoystickButton>> _rawButtonState = [];
    private readonly float[] _rawAxisState;
    private readonly Vector2[] _rawHatState = [];
    private readonly bool[] _gamepadButtonState;
    private readonly float[] _gamepadAxisState;

    private const float _buttonPressureMultiplier = 1 / 255f;

    private static JoystickButton AsGamepadButton(GamepadButton buttonIndex) =>
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

    private readonly Dictionary<int, GamepadBinding> _bindings = new();
    private readonly List<List<GamepadBinding>?> _hatBindings = [];
    private readonly List<GamepadBinding> _outputBindings = [];

    // SDL indexes the 3 of these separately, but it is more convenient
    // for us to index buttons/hats/axes as a single list.
    // Since SDL only uses a single byte for a device index,
    // we can safely use an integer key with a bit shift like this.
    private const int ButtonShift = 0;
    private const int AxisShift = 8;

    private const short _joystickDigitalThreshold = short.MaxValue / 8;

    private readonly record struct SDLGamepadState(List<Button<JoystickButton>> Buttons, List<float> Axes);

    ButtonReadOnlyList<JoystickButton> IButtonDevice<JoystickButton>.State => _joystickState.Buttons;
}

