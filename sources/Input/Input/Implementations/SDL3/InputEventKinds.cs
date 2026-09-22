// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3;

/// <summary>
/// A class to provide an extension method to ensure that the type of an <see cref="SdlEventDiscriminator"/> is correct.
/// </summary>
internal static class InputEventKinds
{
    public static SdlEventDiscriminator Get(Type eventType)
    {
        if (eventType == typeof(PointChangedEvent))
        {
            return SdlEventDiscriminator.PointChanged;
        }

        if (eventType == typeof(PointerClickEvent))
        {
            return SdlEventDiscriminator.PointerClick;
        }

        if (eventType == typeof(ButtonChangedEvent<PointerButton>))
        {
            return SdlEventDiscriminator.PointerButtonChanged;
        }

        if (eventType == typeof(PointerGripChangedEvent))
        {
            return SdlEventDiscriminator.PointerGripChanged;
        }

        if (eventType == typeof(PointerTargetChangedEvent))
        {
            return SdlEventDiscriminator.PointerTargetChanged;
        }

        if (eventType == typeof(ButtonChangedEvent<JoystickButton>))
        {
            return SdlEventDiscriminator.JoystickButtonChanged;
        }

        if (eventType == typeof(ButtonChangedEvent<KeyName>))
        {
            return SdlEventDiscriminator.KeyButtonChanged;
        }

        if (eventType == typeof(ConnectionEvent))
        {
            return SdlEventDiscriminator.Connection;
        }

        if (eventType == typeof(KeyChangedEvent))
        {
            return SdlEventDiscriminator.KeyChanged;
        }

        if (eventType == typeof(GamepadThumbstickMoveEvent))
        {
            return SdlEventDiscriminator.GamepadThumbstickMove;
        }

        if (eventType == typeof(GamepadTriggerMoveEvent))
        {
            return SdlEventDiscriminator.GamepadTriggerMove;
        }

        if (eventType == typeof(JoystickAxisMoveEvent))
        {
            return SdlEventDiscriminator.JoystickAxisMove;
        }

        if (eventType == typeof(JoystickHatMoveEvent))
        {
            return SdlEventDiscriminator.JoystickHatMove;
        }

        if (eventType == typeof(KeyCharEvent))
        {
            return SdlEventDiscriminator.KeyChar;
        }

        if (eventType == typeof(MouseScrollEvent))
        {
            return SdlEventDiscriminator.MouseScroll;
        }

        throw new ArgumentException($"Unhandled event type: {eventType}", nameof(eventType));
    }
}

/// <summary>
/// An enum to avoid large if-else chains of type comparisons in <see cref="SdlInputEventContext"/>
/// </summary>
internal enum SdlEventDiscriminator : byte
{
    PointChanged,
    PointerClick,
    PointerButtonChanged,
    PointerGripChanged,
    PointerTargetChanged,
    JoystickButtonChanged,
    KeyButtonChanged,
    Connection,
    KeyChanged,
    GamepadThumbstickMove,
    GamepadTriggerMove,
    JoystickAxisMove,
    JoystickHatMove,
    KeyChar,
    MouseScroll
}
