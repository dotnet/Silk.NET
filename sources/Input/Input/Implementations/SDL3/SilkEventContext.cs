// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Input.SDL3.Devices.Pointers;

namespace Silk.NET.Input.SDL3;

internal class SilkEventContext
{
    public ISdlEventQueue<ButtonChangedEvent<JoystickButton>> ButtonChangedSdlEvents => _buttonChangedSdlEvents;

    public ISdlEventQueue<ConnectionEvent> ConnectionSdlEvents => _connectionSdlEvents;

    public ISdlEventQueue<KeyChangedEvent> KeyChangedSdlEvents => _keyChangedSdlEvents;

    public ISdlEventQueue<GamepadThumbstickMoveEvent> GamepadThumbstickMoveSdlEvents =>
        _gamepadThumbstickMoveSdlEvents;

    public ISdlEventQueue<GamepadTriggerMoveEvent> GamepadTriggerMoveSdlEvents => _gamepadTriggerMoveSdlEvents;

    public ISdlEventQueue<JoystickAxisMoveEvent> JoystickAxisMoveSdlEvents => _joystickAxisMoveSdlEvents;

    public ISdlEventQueue<JoystickHatMoveEvent> JoystickHatMoveSdlEvents => _joystickHatMoveSdlEvents;

    public ISdlEventQueue<KeyCharEvent> KeyCharSdlEvents => _keyCharSdlEvents;

    public ISdlEventQueue<MouseScrollEvent> MouseScrollSdlEvents => _mouseScrollSdlEvents;

    public ISdlEventQueue<PointChangedEvent> PointChangedSdlEvents => _pointChangedSdlEvents;

    public ISdlEventQueue<PointerClickEvent> PointerClickSdlEvents => _pointerClickSdlEvents;

    public ISdlEventQueue<PointerGripChangedEvent> PointerGripChangedSdlEvents => _pointerGripChangedSdlEvents;

    public ISdlEventQueue<PointerTargetChangedEvent> PointerTargetChangedSdlEvents =>
        _pointerTargetChangedSdlEvents;

    public ISdlEventQueue<ButtonChangedEvent<PointerButton>> PointerButtonSdlEvents => _pointerButtonSdlEvents;

    private readonly SdlEventQueue<ButtonChangedEvent<JoystickButton>> _buttonChangedSdlEvents = new();
    private readonly SdlEventQueue<ConnectionEvent> _connectionSdlEvents = new();
    private readonly SdlEventQueue<KeyChangedEvent> _keyChangedSdlEvents = new();
    private readonly SdlEventQueue<GamepadThumbstickMoveEvent> _gamepadThumbstickMoveSdlEvents = new();
    private readonly SdlEventQueue<GamepadTriggerMoveEvent> _gamepadTriggerMoveSdlEvents = new();
    private readonly SdlEventQueue<JoystickAxisMoveEvent> _joystickAxisMoveSdlEvents = new();
    private readonly SdlEventQueue<JoystickHatMoveEvent> _joystickHatMoveSdlEvents = new();
    private readonly SdlEventQueue<KeyCharEvent> _keyCharSdlEvents = new();
    private readonly SdlEventQueue<MouseScrollEvent> _mouseScrollSdlEvents = new();
    private readonly SdlEventQueue<PointChangedEvent> _pointChangedSdlEvents = new();
    private readonly SdlEventQueue<PointerClickEvent> _pointerClickSdlEvents = new();
    private readonly SdlEventQueue<ButtonChangedEvent<PointerButton>> _pointerButtonSdlEvents = new();
    private readonly SdlEventQueue<PointerGripChangedEvent> _pointerGripChangedSdlEvents = new();
    private readonly SdlEventQueue<PointerTargetChangedEvent> _pointerTargetChangedSdlEvents = new();
    private readonly GenericEventQueue _orderedSdlEvents;

    public SilkEventContext(SdlTimestampCalculator.Basis basis) =>
        _orderedSdlEvents = new GenericEventQueue(basis);

    public void RaiseEvents(params Span<IInputHandler> handlers)
    {
        _orderedSdlEvents.ConsumeOther(_buttonChangedSdlEvents);
        _orderedSdlEvents.ConsumeOther(_connectionSdlEvents);
        _orderedSdlEvents.ConsumeOther(_keyChangedSdlEvents);
        _orderedSdlEvents.ConsumeOther(_gamepadThumbstickMoveSdlEvents);
        _orderedSdlEvents.ConsumeOther(_gamepadTriggerMoveSdlEvents);
        _orderedSdlEvents.ConsumeOther(_joystickAxisMoveSdlEvents);
        _orderedSdlEvents.ConsumeOther(_joystickHatMoveSdlEvents);
        _orderedSdlEvents.ConsumeOther(_keyCharSdlEvents);
        _orderedSdlEvents.ConsumeOther(_mouseScrollSdlEvents);
        _orderedSdlEvents.ConsumeOther(_pointChangedSdlEvents);
        _orderedSdlEvents.ConsumeOther(_pointerClickSdlEvents);
        _orderedSdlEvents.ConsumeOther(_pointerGripChangedSdlEvents);
        _orderedSdlEvents.ConsumeOther(_pointerTargetChangedSdlEvents);
        _orderedSdlEvents.ConsumeOther(_pointerButtonSdlEvents);

        var genericEvents = _orderedSdlEvents.ConsumeAndSortSelf();

        if (handlers is not { Length: > 0 })
        {
            return;
        }

        foreach (var evt in genericEvents)
        {
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
            where TItem : struct, ITimestampedEvent
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
