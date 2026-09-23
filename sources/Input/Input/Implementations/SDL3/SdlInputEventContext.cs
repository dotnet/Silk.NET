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
        if (handlers is { Length: > 0 })
        {
            var genericEvents = System.Runtime.InteropServices.CollectionsMarshal.AsSpan(_orderedSdlEvents);
            for (var index = 0; index < genericEvents.Length; index++)
            {
                ref readonly var evt = ref genericEvents[index];

                try
                {
                    switch (evt.Type)
                    {
                        case SdlEventDiscriminator.PointChanged:
                            RaiseEvent(in handlers, in evt.Value<PointChangedEvent>());
                            break;

                        case SdlEventDiscriminator.PointerClick:
                            RaiseEvent(in handlers, in evt.Value<PointerClickEvent>());
                            break;

                        case SdlEventDiscriminator.PointerButtonChanged:
                            RaiseEvent(in handlers, in evt.Value<ButtonChangedEvent<PointerButton>>());
                            break;

                        case SdlEventDiscriminator.PointerGripChanged:
                            RaiseEvent(in handlers, in evt.Value<PointerGripChangedEvent>());
                            break;

                        case SdlEventDiscriminator.PointerTargetChanged:
                            RaiseEvent(in handlers, in evt.Value<PointerTargetChangedEvent>());
                            break;

                        case SdlEventDiscriminator.JoystickButtonChanged:
                            RaiseEvent(in handlers, in evt.Value<ButtonChangedEvent<JoystickButton>>());
                            break;

                        case SdlEventDiscriminator.KeyButtonChanged:
                            RaiseEvent(in handlers, in evt.Value<ButtonChangedEvent<KeyName>>());
                            break;

                        case SdlEventDiscriminator.KeyChanged:
                            RaiseEvent(in handlers, in evt.Value<KeyChangedEvent>());
                            break;

                        case SdlEventDiscriminator.GamepadThumbstickMove:
                            RaiseEvent(in handlers, in evt.Value<GamepadThumbstickMoveEvent>());
                            break;

                        case SdlEventDiscriminator.GamepadTriggerMove:
                            RaiseEvent(in handlers, in evt.Value<GamepadTriggerMoveEvent>());
                            break;

                        case SdlEventDiscriminator.JoystickAxisMove:
                            RaiseEvent(in handlers, in evt.Value<JoystickAxisMoveEvent>());
                            break;

                        case SdlEventDiscriminator.JoystickHatMove:
                            RaiseEvent(in handlers, in evt.Value<JoystickHatMoveEvent>());
                            break;

                        case SdlEventDiscriminator.KeyChar:
                            RaiseEvent(in handlers, in evt.Value<KeyCharEvent>());
                            break;

                        case SdlEventDiscriminator.MouseScroll:
                            RaiseEvent(in handlers, in evt.Value<MouseScrollEvent>());
                            break;

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

        return;

        static void RaiseEvent<TItem>(ref readonly Span<IInputHandler> handlers, ref readonly TItem evt)
            where TItem : struct
        {
            for (var index = 0; index < handlers.Length; ++index)
            {
                if (handlers[index] is IInputHandler<TItem> appropriateHandler)
                {
                    appropriateHandler.Handle(evt);
                }
#if DEBUG
                else
                {
                    InputLog.Debug($"Unhandled event type {typeof(TItem).Name} from {handlers[index].GetType().Name}.");
                }
#endif
            }
        }
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
