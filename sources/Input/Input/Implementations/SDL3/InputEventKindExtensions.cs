// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;

namespace Silk.NET.Input.SDL3;

/// <summary>
/// A class to provide an extension method to ensure that the type of an <see cref="SdlEventDiscriminator"/> is correct.
/// </summary>
internal static class InputEventKindExtensions
{
    [Conditional("DEBUG")]
    public static void EnsureTypeCorrectness(this SdlEventDiscriminator discriminator, Type type)
    {
        switch (discriminator)
        {
            case SdlEventDiscriminator.PointChanged:
                Debug.Assert(type == typeof(PointChangedEvent));
                break;

            case SdlEventDiscriminator.PointerClick:
                Debug.Assert(type == typeof(PointerClickEvent));
                break;
            case SdlEventDiscriminator.PointerButtonChanged:
                Debug.Assert(type == typeof(ButtonChangedEvent<PointerButton>));
                break;
            case SdlEventDiscriminator.PointerGripChanged:
                Debug.Assert(type == typeof(PointerGripChangedEvent));
                break;
            case SdlEventDiscriminator.PointerTargetChanged:
                Debug.Assert(type == typeof(PointerTargetChangedEvent));
                break;
            case SdlEventDiscriminator.JoystickButtonChanged:
                Debug.Assert(type == typeof(ButtonChangedEvent<JoystickButton>));
                break;
            case SdlEventDiscriminator.KeyButtonChanged:
                Debug.Assert(type == typeof(ButtonChangedEvent<KeyName>));
                break;
            case SdlEventDiscriminator.Connection:
                Debug.Assert(type == typeof(ConnectionEvent));
                break;
            case SdlEventDiscriminator.KeyChanged:
                Debug.Assert(type == typeof(KeyChangedEvent));
                break;
            case SdlEventDiscriminator.GamepadThumbstickMove:
                Debug.Assert(type == typeof(GamepadThumbstickMoveEvent));
                break;
            case SdlEventDiscriminator.GamepadTriggerMove:
                Debug.Assert(type == typeof(GamepadTriggerMoveEvent));
                break;
            case SdlEventDiscriminator.JoystickAxisMove:
                Debug.Assert(type == typeof(JoystickAxisMoveEvent));
                break;
            case SdlEventDiscriminator.JoystickHatMove:
                Debug.Assert(type == typeof(JoystickHatMoveEvent));
                break;
            case SdlEventDiscriminator.KeyChar:
                Debug.Assert(type == typeof(KeyCharEvent));
                break;
            case SdlEventDiscriminator.MouseScroll:
                Debug.Assert(type == typeof(MouseScrollEvent));
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(discriminator), discriminator,
                    $"Unknown {nameof(SdlEventDiscriminator)} provided");
        }
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
