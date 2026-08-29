// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Input.SDL3.DataStructures;
using Silk.NET.Input.SDL3.Devices.Pointers;

namespace Silk.NET.Input.SDL3;

/// <summary>
/// A class used to collect all of the input events from all of our input devices and execute them in the order
/// in which they occurred, to the best of our ability.
/// <br/><br/>
/// To use this class, create an instance of it and share its various event queues with SDL event producers
/// </summary>
internal class SdlInputEventContext
{
    public ISdlInputEventQueue<ButtonChangedEvent<JoystickButton>> ButtonChangedEvents => _buttonChangedEvents;

    public ISdlInputEventQueue<ConnectionEvent> ConnectionEvents => _connectionEvents;

    public ISdlInputEventQueue<KeyChangedEvent> KeyChangedEvents => _keyChangedEvents;

    public ISdlInputEventQueue<GamepadThumbstickMoveEvent> GamepadThumbstickMoveEvents =>
        _gamepadThumbstickMoveEvents;

    public ISdlInputEventQueue<GamepadTriggerMoveEvent> GamepadTriggerMoveEvents => _gamepadTriggerMoveEvents;

    public ISdlInputEventQueue<JoystickAxisMoveEvent> JoystickAxisMoveEvents => _joystickAxisMoveEvents;

    public ISdlInputEventQueue<JoystickHatMoveEvent> JoystickHatMoveEvents => _joystickHatMoveEvents;

    public ISdlInputEventQueue<KeyCharEvent> KeyCharEvents => _keyCharEvents;

    public ISdlInputEventQueue<MouseScrollEvent> MouseScrollEvents => _mouseScrollEvents;

    public ISdlInputEventQueue<PointChangedEvent> PointChangedEvents => _pointChangedEvents;

    public ISdlInputEventQueue<PointerClickEvent> PointerClickEvents => _pointerClickEvents;

    public ISdlInputEventQueue<PointerGripChangedEvent> PointerGripChangedEvents => _pointerGripChangedEvents;

    public ISdlInputEventQueue<PointerTargetChangedEvent> PointerTargetChangedEvents =>
        _pointerTargetChangedEvents;

    public ISdlInputEventQueue<ButtonChangedEvent<PointerButton>> PointerButtonEvents => _pointerButtonEvents;

    private readonly SdlInputEventQueue<ButtonChangedEvent<JoystickButton>> _buttonChangedEvents = new();
    private readonly SdlInputEventQueue<ConnectionEvent> _connectionEvents = new();
    private readonly SdlInputEventQueue<KeyChangedEvent> _keyChangedEvents = new();
    private readonly SdlInputEventQueue<GamepadThumbstickMoveEvent> _gamepadThumbstickMoveEvents = new();
    private readonly SdlInputEventQueue<GamepadTriggerMoveEvent> _gamepadTriggerMoveEvents = new();
    private readonly SdlInputEventQueue<JoystickAxisMoveEvent> _joystickAxisMoveEvents = new();
    private readonly SdlInputEventQueue<JoystickHatMoveEvent> _joystickHatMoveEvents = new();
    private readonly SdlInputEventQueue<KeyCharEvent> _keyCharEvents = new();
    private readonly SdlInputEventQueue<MouseScrollEvent> _mouseScrollEvents = new();
    private readonly SdlInputEventQueue<PointChangedEvent> _pointChangedEvents = new();
    private readonly SdlInputEventQueue<PointerClickEvent> _pointerClickEvents = new();
    private readonly SdlInputEventQueue<ButtonChangedEvent<PointerButton>> _pointerButtonEvents = new();
    private readonly SdlInputEventQueue<PointerGripChangedEvent> _pointerGripChangedEvents = new();
    private readonly SdlInputEventQueue<PointerTargetChangedEvent> _pointerTargetChangedEvents = new();
    private readonly GenericEventQueueSdl _orderedSdlEvents;

    public SdlInputEventContext(SdlTimestampCalculator.TimeBasis basis) =>
        _orderedSdlEvents = new GenericEventQueueSdl(basis);

    public void RaiseEvents(params Span<IInputHandler> handlers)
    {
        _orderedSdlEvents.StoreReferencesTo(_buttonChangedEvents);
        _orderedSdlEvents.StoreReferencesTo(_connectionEvents);
        _orderedSdlEvents.StoreReferencesTo(_keyChangedEvents);
        _orderedSdlEvents.StoreReferencesTo(_gamepadThumbstickMoveEvents);
        _orderedSdlEvents.StoreReferencesTo(_gamepadTriggerMoveEvents);
        _orderedSdlEvents.StoreReferencesTo(_joystickAxisMoveEvents);
        _orderedSdlEvents.StoreReferencesTo(_joystickHatMoveEvents);
        _orderedSdlEvents.StoreReferencesTo(_keyCharEvents);
        _orderedSdlEvents.StoreReferencesTo(_mouseScrollEvents);
        _orderedSdlEvents.StoreReferencesTo(_pointChangedEvents);
        _orderedSdlEvents.StoreReferencesTo(_pointerClickEvents);
        _orderedSdlEvents.StoreReferencesTo(_pointerGripChangedEvents);
        _orderedSdlEvents.StoreReferencesTo(_pointerTargetChangedEvents);
        _orderedSdlEvents.StoreReferencesTo(_pointerButtonEvents);

        var genericEvents = _orderedSdlEvents.ConsumeAndSortSelf();

        if (handlers is not { Length: > 0 })
        {
            return;
        }

        // todo (low prio) - surely there could be a better way to do this...
        for (var index = 0; index < genericEvents.Length; index++)
        {
            ref readonly var evt = ref genericEvents[index];
            if (evt.Type == typeof(PointChangedEvent))
            {
                RaiseEvent(handlers, evt.Value<PointChangedEvent>());
            }
            else if (evt.Type == typeof(PointerClickEvent))
            {
                RaiseEvent(handlers, evt.Value<PointerClickEvent>());
            }
            else if (evt.Type == typeof(ButtonChangedEvent<PointerButton>))
            {
                RaiseEvent(handlers, evt.Value<ButtonChangedEvent<PointerButton>>());
            }
            else if (evt.Type == typeof(PointerGripChangedEvent))
            {
                RaiseEvent(handlers, evt.Value<PointerGripChangedEvent>());
            }
            else if (evt.Type == typeof(PointerTargetChangedEvent))
            {
                RaiseEvent(handlers, evt.Value<PointerTargetChangedEvent>());
            }
            else if (evt.Type == typeof(ButtonChangedEvent<JoystickButton>))
            {
                RaiseEvent(handlers, evt.Value<ButtonChangedEvent<JoystickButton>>());
            }
            else if (evt.Type == typeof(ButtonChangedEvent<KeyName>))
            {
                RaiseEvent(handlers, evt.Value<ButtonChangedEvent<KeyName>>());
            }
            else if (evt.Type == typeof(ConnectionEvent))
            {
                RaiseEvent(handlers, evt.Value<ConnectionEvent>());
            }
            else if (evt.Type == typeof(KeyChangedEvent))
            {
                RaiseEvent(handlers, evt.Value<KeyChangedEvent>());
            }
            else if (evt.Type == typeof(GamepadThumbstickMoveEvent))
            {
                RaiseEvent(handlers, evt.Value<GamepadThumbstickMoveEvent>());
            }
            else if (evt.Type == typeof(GamepadTriggerMoveEvent))
            {
                RaiseEvent(handlers, evt.Value<GamepadTriggerMoveEvent>());
            }
            else if (evt.Type == typeof(JoystickAxisMoveEvent))
            {
                RaiseEvent(handlers, evt.Value<JoystickAxisMoveEvent>());
            }
            else if (evt.Type == typeof(JoystickHatMoveEvent))
            {
                RaiseEvent(handlers, evt.Value<JoystickHatMoveEvent>());
            }
            else if (evt.Type == typeof(KeyCharEvent))
            {
                RaiseEvent(handlers, evt.Value<KeyCharEvent>());
            }
            else if (evt.Type == typeof(MouseScrollEvent))
            {
                RaiseEvent(handlers, evt.Value<MouseScrollEvent>());
            }
            else
            {
                throw new InvalidOperationException("Invalid type: " + evt.Type);
            }
        }

        return;

        static void RaiseEvent<TItem>(Span<IInputHandler> handlers, in TItem evt)
            where TItem : struct
        {
            for (var index = 0; index < handlers.Length; index++)
            {
                var handler = handlers[index];
                if (handler is IInputHandler<TItem> appropriateHandler)
                {
                    appropriateHandler.Handle(evt);
                }
                else
                {
                    InputLog.Debug($"Unhandled event type {typeof(TItem).Name} from {handler.GetType().Name}.");
                }
            }
        }
    }
}
