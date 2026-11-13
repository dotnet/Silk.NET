// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Input.SDL3.DataStructures;

namespace Silk.NET.Input.SDL3;

/// <summary>
/// A class used to collect all of the input events from all of our input devices and execute them in the order
/// in which they occurred, to the best of our ability.
/// <br/><br/>
/// To use this class, create an instance of it and share its various event queues with SDL event producers
/// </summary>
internal sealed class SdlInputEventContext : IDisposable
{
    public SdlInputEventQueue<ButtonChangedEvent<JoystickButton>> JoyButtonChangedEvents { get; }
    public SdlInputEventQueue<ConnectionEvent> ConnectionEvents { get; }
    public SdlInputEventQueue<KeyChangedEvent> KeyChangedEvents { get; }
    public SdlInputEventQueue<GamepadThumbstickMoveEvent> GamepadThumbstickMoveEvents { get; }
    public SdlInputEventQueue<GamepadTriggerMoveEvent> GamepadTriggerMoveEvents { get; }
    public SdlInputEventQueue<JoystickAxisMoveEvent> JoystickAxisMoveEvents { get; }
    public SdlInputEventQueue<JoystickHatMoveEvent> JoystickHatMoveEvents { get; }
    public SdlInputEventQueue<KeyCharEvent> KeyCharEvents { get; }
    public SdlInputEventQueue<MouseScrollEvent> MouseScrollEvents { get; }
    public SdlInputEventQueue<PointChangedEvent> PointChangedEvents { get; }
    public SdlInputEventQueue<PointerClickEvent> PointerClickEvents { get; }
    public SdlInputEventQueue<PointerGripChangedEvent> PointerGripChangedEvents { get; }
    public SdlInputEventQueue<PointerTargetChangedEvent> PointerTargetChangedEvents { get; }
    public SdlInputEventQueue<ButtonChangedEvent<PointerButton>> PointerButtonEvents { get; }

    private readonly List<GenericEvent> _orderedSdlEvents;

    public SdlInputEventContext()
    {
        var events = _orderedSdlEvents = [];
        JoyButtonChangedEvents = new SdlInputEventQueue<ButtonChangedEvent<JoystickButton>>(events);
        ConnectionEvents = new SdlInputEventQueue<ConnectionEvent>(events);
        KeyChangedEvents = new SdlInputEventQueue<KeyChangedEvent>(events);
        GamepadThumbstickMoveEvents = new SdlInputEventQueue<GamepadThumbstickMoveEvent>(events);
        GamepadTriggerMoveEvents = new SdlInputEventQueue<GamepadTriggerMoveEvent>(events);
        JoystickAxisMoveEvents = new SdlInputEventQueue<JoystickAxisMoveEvent>(events);
        JoystickHatMoveEvents = new SdlInputEventQueue<JoystickHatMoveEvent>(events);
        KeyCharEvents = new SdlInputEventQueue<KeyCharEvent>(events);
        MouseScrollEvents = new SdlInputEventQueue<MouseScrollEvent>(events);
        PointChangedEvents = new SdlInputEventQueue<PointChangedEvent>(events);
        PointerClickEvents = new SdlInputEventQueue<PointerClickEvent>(events);
        PointerGripChangedEvents = new SdlInputEventQueue<PointerGripChangedEvent>(events);
        PointerTargetChangedEvents = new SdlInputEventQueue<PointerTargetChangedEvent>(events);
        PointerButtonEvents = new SdlInputEventQueue<ButtonChangedEvent<PointerButton>>(events);
    }

    public void RaiseEvents(params Span<IInputHandler> handlers)
    {
        var genericEvents = System.Runtime.InteropServices.CollectionsMarshal.AsSpan(_orderedSdlEvents);
        if(!handlers.IsEmpty)
        {
            RaiseEvents(in handlers, genericEvents);
        }

        _orderedSdlEvents.Clear();

        // clear all
        JoyButtonChangedEvents.ResetCount();
        ConnectionEvents.ResetCount();
        KeyChangedEvents.ResetCount();
        GamepadThumbstickMoveEvents.ResetCount();
        GamepadTriggerMoveEvents.ResetCount();
        JoystickAxisMoveEvents.ResetCount();
        JoystickHatMoveEvents.ResetCount();
        KeyCharEvents.ResetCount();
        MouseScrollEvents.ResetCount();
        PointChangedEvents.ResetCount();
        PointerClickEvents.ResetCount();
        PointerGripChangedEvents.ResetCount();
        PointerTargetChangedEvents.ResetCount();
        PointerButtonEvents.ResetCount();
    }

    private static void RaiseEvents(ref readonly Span<IInputHandler> handlers, Span<GenericEvent> genericEvents)
    {
        for (var index = 0; index < genericEvents.Length; index++)
        {
            ref readonly var evt = ref genericEvents[index];

            try
            {
                switch (evt.Type)
                {
                    case SdlEventDiscriminator.PointChanged:
                    {
                        ref readonly var e = ref evt.Value<PointChangedEvent>();
                        for (var i = 0; i < handlers.Length; ++i)
                        {
                            if (handlers[i] is IPointerInputHandler h)
                            {
                                try
                                {
                                    h.HandlePointChanged(e);
                                }
                                catch (Exception ex)
                                {
                                    InputLog.Error(ex.ToString());
                                }
                            }
                        }
                        break;
                    }

                    case SdlEventDiscriminator.PointerClick:
                        // No handler interface consumes PointerClickEvent; clicks are derived by Pointers.
                        break;

                    case SdlEventDiscriminator.PointerButtonChanged:
                    {
                        ref readonly var e = ref evt.Value<ButtonChangedEvent<PointerButton>>();
                        for (var i = 0; i < handlers.Length; ++i)
                        {
                            if (handlers[i] is IButtonInputHandler<PointerButton> h)
                            {
                                h.HandleButtonChanged(e);
                            }
                        }
                        break;
                    }

                    case SdlEventDiscriminator.PointerGripChanged:
                    {
                        ref readonly var e = ref evt.Value<PointerGripChangedEvent>();
                        for (var i = 0; i < handlers.Length; ++i)
                        {
                            if (handlers[i] is IPointerInputHandler h)
                            {
                                h.HandleGripChanged(e);
                            }
                        }
                        break;
                    }

                    case SdlEventDiscriminator.PointerTargetChanged:
                    {
                        ref readonly var e = ref evt.Value<PointerTargetChangedEvent>();
                        for (var i = 0; i < handlers.Length; ++i)
                        {
                            if (handlers[i] is IPointerInputHandler h)
                            {
                                h.HandleTargetChanged(e);
                            }
                        }
                        break;
                    }

                    case SdlEventDiscriminator.JoystickButtonChanged:
                    {
                        ref readonly var e = ref evt.Value<ButtonChangedEvent<JoystickButton>>();
                        for (var i = 0; i < handlers.Length; ++i)
                        {
                            if (handlers[i] is IButtonInputHandler<JoystickButton> h)
                            {
                                h.HandleButtonChanged(e);
                            }
                        }
                        break;
                    }

                    case SdlEventDiscriminator.KeyButtonChanged:
                    {
                        ref readonly var e = ref evt.Value<ButtonChangedEvent<KeyName>>();
                        for (var i = 0; i < handlers.Length; ++i)
                        {
                            if (handlers[i] is IButtonInputHandler<KeyName> h)
                            {
                                h.HandleButtonChanged(e);
                            }
                        }
                        break;
                    }

                    case SdlEventDiscriminator.KeyChanged:
                    {
                        ref readonly var e = ref evt.Value<KeyChangedEvent>();
                        for (var i = 0; i < handlers.Length; ++i)
                        {
                            if (handlers[i] is IKeyboardInputHandler h)
                            {
                                h.HandleKeyChanged(e);
                            }
                        }
                        break;
                    }

                    case SdlEventDiscriminator.GamepadThumbstickMove:
                    {
                        ref readonly var e = ref evt.Value<GamepadThumbstickMoveEvent>();
                        for (var i = 0; i < handlers.Length; ++i)
                        {
                            if (handlers[i] is IGamepadInputHandler h)
                            {
                                h.HandleThumbstickMove(e);
                            }
                        }
                        break;
                    }

                    case SdlEventDiscriminator.GamepadTriggerMove:
                    {
                        ref readonly var e = ref evt.Value<GamepadTriggerMoveEvent>();
                        for (var i = 0; i < handlers.Length; ++i)
                        {
                            if (handlers[i] is IGamepadInputHandler h)
                            {
                                h.HandleTriggerMove(e);
                            }
                        }
                        break;
                    }

                    case SdlEventDiscriminator.JoystickAxisMove:
                    {
                        ref readonly var e = ref evt.Value<JoystickAxisMoveEvent>();
                        for (var i = 0; i < handlers.Length; ++i)
                        {
                            if (handlers[i] is IJoystickInputHandler h)
                            {
                                h.HandleAxisMove(e);
                            }
                        }
                        break;
                    }

                    case SdlEventDiscriminator.JoystickHatMove:
                    {
                        ref readonly var e = ref evt.Value<JoystickHatMoveEvent>();
                        for (var i = 0; i < handlers.Length; ++i)
                        {
                            if (handlers[i] is IJoystickInputHandler h)
                            {
                                h.HandleHatMove(e);
                            }
                        }
                        break;
                    }

                    case SdlEventDiscriminator.KeyChar:
                    {
                        ref readonly var e = ref evt.Value<KeyCharEvent>();
                        for (var i = 0; i < handlers.Length; ++i)
                        {
                            if (handlers[i] is IKeyboardInputHandler h)
                            {
                                h.HandleKeyChar(e);
                            }
                        }
                        break;
                    }

                    case SdlEventDiscriminator.MouseScroll:
                    {
                        ref readonly var e = ref evt.Value<MouseScrollEvent>();
                        for (var i = 0; i < handlers.Length; ++i)
                        {
                            if (handlers[i] is IMouseInputHandler h)
                            {
                                h.HandleScroll(e);
                            }
                        }
                        break;
                    }

                    case SdlEventDiscriminator.Connection:
                    {
                        var value = evt.Value<ConnectionEvent>();
                        for (var i = 0; i < handlers.Length; ++i)
                        {
                            handlers[i].HandleDeviceConnectionChanged(value);
                        }

                        break;
                    }

                    default:
                        throw new InvalidOperationException("Invalid type: " + evt.Type);
                }
            }
            catch (Exception e)
            {
                InputLog.Error(e.ToString());
            }
        }

        return;
    }


    public void Dispose()
    {
        JoyButtonChangedEvents.Dispose();
        ConnectionEvents.Dispose();
        KeyChangedEvents.Dispose();
        GamepadThumbstickMoveEvents.Dispose();
        GamepadTriggerMoveEvents.Dispose();
        JoystickAxisMoveEvents.Dispose();
        JoystickHatMoveEvents.Dispose();
        KeyCharEvents.Dispose();
        MouseScrollEvents.Dispose();
        PointChangedEvents.Dispose();
        PointerClickEvents.Dispose();
        PointerButtonEvents.Dispose();
        PointerGripChangedEvents.Dispose();
        PointerTargetChangedEvents.Dispose();
        _orderedSdlEvents.Clear();
    }
}
