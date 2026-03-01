// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Input;
using Surface = Silk.NET.Windowing.Surface;

internal partial class InputTesting
{
    private static void ExecuteInput(InputContext? context, INativeWindow window)
    {
        if (context is null)
        {
            return;
        }

        TestLog.Debug($"Update called on {window}");
        context.Update();
    }

    private static InputContext InitInputContext<TSurface>(TSurface surface) where TSurface : Surface
    {
        TestLog.Debug("Initializing input context");
        var inputContext = surface.CreateInput();
        inputContext.ConnectionChanged += OnInputConnectionChanged;

        // keyboard events
        inputContext.Keyboards.KeyChanged += OnKeyChanged;
        inputContext.Keyboards.KeyChar += OnKeyChar;

        // gamepad events
        inputContext.Gamepads.ThumbstickMove += OnGamepadThumbstickMove;
        inputContext.Gamepads.TriggerMove += OnGamepadTriggerMove;
        inputContext.Gamepads.ButtonChanged += OnGamepadButtonChanged;

        // joystick events
        inputContext.Joysticks.AxisMove += OnJoystickAxisMove;
        inputContext.Joysticks.ButtonChanged += OnJoystickButtonChanged;
        inputContext.Joysticks.HatMove += OnJoystickHatMove;

        // pointer events
        inputContext.Pointers.ButtonChanged += OnPointerButtonChanged;
        inputContext.Pointers.Click += OnPointerClick;
        inputContext.Pointers.DoubleClick += OnPointerDoubleClick;
        inputContext.Pointers.GripChanged += OnPointerGripChanged;
        inputContext.Pointers.PointChanged += OnPointerPointChanged;
        inputContext.Pointers.TargetChanged += OnPointerTargetChanged;
        inputContext.Pointers.MouseScroll += OnPointerScroll;

        return inputContext;
    }

    private static void OnInputConnectionChanged(ConnectionEvent obj)
    {
        TestLog.Debug($"{obj.Device.Name} {obj.Device.Id} {(obj.IsConnected ? "connected" : "disconnected")}");
    }

    private static void OnJoystickHatMove(JoystickHatMoveEvent obj)
    {
        TestLog.Debug($"{nameof(JoystickAxisMoveEvent)} from {obj.Joystick} moved to {obj.Value}");;
    }

    private static void OnJoystickButtonChanged(ButtonChangedEvent<JoystickButton> obj)
    {
        TestLog.Debug($"{nameof(ButtonChangedEvent<>)} {obj.Button.Name} from {obj.Device} changed to {obj.Button.IsDown}");
    }

    private static void OnPointerScroll(MouseScrollEvent obj)
    {
        TestLog.Debug($"{nameof(MouseScrollEvent)} from {obj.Mouse} changed from {obj.WheelPosition - obj.Delta} to {obj.WheelPosition}");
    }

    private static void OnPointerTargetChanged(PointerTargetChangedEvent obj)
    {
        TestLog.Debug($"{nameof(PointerTargetChangedEvent)} from {obj.Pointer} changed from to {obj.Target} with bounds {obj.OldBounds} to new bounds: {obj.NewBounds}");
    }

    private static void OnPointerPointChanged(PointChangedEvent obj)
    {
        TestLog.Debug($"{nameof(PointChangedEvent)} from {obj.Pointer} changed from {obj.OldPoint} to {obj.NewPoint}");
    }

    private static void OnPointerGripChanged(PointerGripChangedEvent obj)
    {
        TestLog.Debug($"{nameof(PointerGripChangedEvent)} from {obj.Pointer} changed from {obj.GripPressure - obj.Delta} to {obj.GripPressure}");
    }

    private static void OnPointerDoubleClick(PointerClickEvent obj)
    {
        TestLog.Debug($"Double-{nameof(PointerClickEvent)} from {obj.Pointer} with button {obj.Button} at {obj.Point}");
    }

    private static void OnPointerClick(PointerClickEvent obj)
    {
        TestLog.Debug($"{nameof(PointerClickEvent)} from {obj.Pointer} with button {obj.Button} at {obj.Point}");
    }

    private static void OnPointerButtonChanged(ButtonChangedEvent<PointerButton> obj)
    {
        TestLog.Debug($"{nameof(ButtonChangedEvent<>)} {obj.Button.Name} from {obj.Device} changed to {obj.Button.IsDown}");
    }

    private static void OnJoystickAxisMove(JoystickAxisMoveEvent obj)
    {
        TestLog.Debug($"{nameof(JoystickAxisMoveEvent)} {obj.Axis} from {obj.Joystick} changed from {obj.Value - obj.Delta} to {obj.Value}");
    }

    private static void OnGamepadButtonChanged(ButtonChangedEvent<JoystickButton> obj)
    {
        TestLog.Debug($"{nameof(ButtonChangedEvent<>)} {obj.Button.Name} from {obj.Device} changed to {obj.Button.IsDown}");
    }

    private static void OnGamepadTriggerMove(GamepadTriggerMoveEvent obj)
    {
        TestLog.Debug($"{nameof(GamepadTriggerMoveEvent)} from {obj.Gamepad} changed from {obj.Value - obj.Delta} to {obj.Value}");
    }

    private static void OnGamepadThumbstickMove(GamepadThumbstickMoveEvent obj)
    {
        TestLog.Debug($"{nameof(GamepadThumbstickMoveEvent)} from {obj.Gamepad} changed from {obj.Value - obj.Delta} to {obj.Value}");
    }

    private static void OnKeyChar(KeyCharEvent obj)
    {
        TestLog.Debug($"{nameof(KeyCharEvent)} {obj.Character} from {obj.Keyboard} pressed");
    }

    private static void OnKeyChanged(KeyChangedEvent obj)
    {
        var key = obj.Key;
        TestLog.Debug($"{nameof(KeyCharEvent)} {key} from {obj.Keyboard} changed to {key.IsDown}");
    }
}
