// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace Silk.NET.Input;

/// <summary>
/// A <see cref="InputEventUnion"/> tagged with a <see cref="InputEventType"/>.
/// </summary>
/// <remarks>
/// This type is not intended for public consumption and has no API/ABI stability guarantees.
/// </remarks>
[Experimental(
    "ST0005",
    UrlFormat = "https://dotnet.github.io/Silk.NET/docs/v3/silk.net/diagnostics/{0}"
)]
internal struct InputEvent
{
    /// <summary>
    /// The type of the event.
    /// </summary>
    public InputEventType Type;

    /// <summary>
    /// The event data.
    /// </summary>
    public InputEventUnion Event;

    /// <summary>
    /// Dispatches the event to the given handler.
    /// </summary>
    /// <param name="handler">The handler.</param>
    public void Dispatch(IInputHandler handler)
    {
        switch (Type)
        {
            case InputEventType.ConnectionEvent:
            {
                handler.HandleDeviceConnectionChanged(Event.Connection);
                break;
            }
            case InputEventType.PointerButtonChangedEvent
                when handler is IButtonInputHandler<PointerButton> typedHandler:
            {
                typedHandler.HandleButtonChanged(Event.PointerButtonChanged);
                break;
            }
            case InputEventType.KeyButtonChangedEvent
                when handler is IButtonInputHandler<KeyName> typedHandler:
            {
                typedHandler.HandleButtonChanged(Event.KeyButtonChanged);
                break;
            }
            case InputEventType.JoystickButtonChangedEvent
                when handler is IButtonInputHandler<JoystickButton> typedHandler:
            {
                typedHandler.HandleButtonChanged(Event.JoystickButtonChanged);
                break;
            }
            case InputEventType.GamepadThumbstickMoveEvent
                when handler is IGamepadInputHandler typedHandler:
            {
                typedHandler.HandleThumbstickMove(Event.GamepadThumbstickMove);
                break;
            }
            case InputEventType.GamepadTriggerMoveEvent
                when handler is IGamepadInputHandler typedHandler:
            {
                typedHandler.HandleTriggerMove(Event.GamepadTriggerMove);
                break;
            }
            case InputEventType.JoystickAxisMoveEvent
                when handler is IJoystickInputHandler typedHandler:
            {
                typedHandler.HandleAxisMove(Event.JoystickAxisMove);
                break;
            }
            case InputEventType.JoystickHatMoveEvent
                when handler is IJoystickInputHandler typedHandler:
            {
                typedHandler.HandleHatMove(Event.JoystickHatMove);
                break;
            }
            case InputEventType.KeyChangedEvent when handler is IKeyboardInputHandler typedHandler:
            {
                typedHandler.HandleKeyChanged(Event.KeyChanged);
                break;
            }
            case InputEventType.KeyCharEvent when handler is IKeyboardInputHandler typedHandler:
            {
                typedHandler.HandleKeyChar(Event.KeyChar);
                break;
            }
            case InputEventType.MouseScrollEvent when handler is IMouseInputHandler typedHandler:
            {
                typedHandler.HandleScroll(Event.MouseScroll);
                break;
            }
            case InputEventType.PointChangedEvent when handler is IPointerInputHandler typedHandler:
            {
                typedHandler.HandlePointChanged(Event.PointChanged);
                break;
            }
            case InputEventType.PointerGripChangedEvent
                when handler is IPointerInputHandler typedHandler:
            {
                typedHandler.HandleGripChanged(Event.PointerGripChanged);
                break;
            }
            case InputEventType.PointerTargetChangedEvent
                when handler is IPointerInputHandler typedHandler:
            {
                typedHandler.HandleTargetChanged(Event.PointerTargetChanged);
                break;
            }
            default:
            {
                Throw();
                break;

                static void Throw() => throw new ArgumentOutOfRangeException(nameof(Type));
            }
        }
    }
}
