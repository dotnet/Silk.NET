// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Input.SDL3.Devices.Pointers;

namespace Silk.NET.Input.SDL3;

/// <summary>
/// A class used to collect all of the input events from all of our input dvices.
/// </summary>
internal class SilkEventContext
{
    public IInputEventQueue<ButtonChangedEvent<JoystickButton>> ButtonChangedInputEvents => _buttonChangedInputEvents;

    public IInputEventQueue<ConnectionEvent> ConnectionInputEvents => _connectionInputEvents;

    public IInputEventQueue<KeyChangedEvent> KeyChangedInputEvents => _keyChangedInputEvents;

    public IInputEventQueue<GamepadThumbstickMoveEvent> GamepadThumbstickMoveInputEvents =>
        _gamepadThumbstickMoveInputEvents;

    public IInputEventQueue<GamepadTriggerMoveEvent> GamepadTriggerMoveInputEvents => _gamepadTriggerMoveInputEvents;

    public IInputEventQueue<JoystickAxisMoveEvent> JoystickAxisMoveInputEvents => _joystickAxisMoveInputEvents;

    public IInputEventQueue<JoystickHatMoveEvent> JoystickHatMoveInputEvents => _joystickHatMoveInputEvents;

    public IInputEventQueue<KeyCharEvent> KeyCharInputEvents => _keyCharInputEvents;

    public IInputEventQueue<MouseScrollEvent> MouseScrollInputEvents => _mouseScrollInputEvents;

    public IInputEventQueue<PointChangedEvent> PointChangedInputEvents => _pointChangedInputEvents;

    public IInputEventQueue<PointerClickEvent> PointerClickInputEvents => _pointerClickInputEvents;

    public IInputEventQueue<PointerGripChangedEvent> PointerGripChangedInputEvents => _pointerGripChangedInputEvents;

    public IInputEventQueue<PointerTargetChangedEvent> PointerTargetChangedInputEvents =>
        _pointerTargetChangedInputEvents;

    public IInputEventQueue<ButtonChangedEvent<PointerButton>> PointerButtonInputEvents => _pointerButtonInputEvents;

    private readonly InputEventQueue<ButtonChangedEvent<JoystickButton>> _buttonChangedInputEvents = new();
    private readonly InputEventQueue<ConnectionEvent> _connectionInputEvents = new();
    private readonly InputEventQueue<KeyChangedEvent> _keyChangedInputEvents = new();
    private readonly InputEventQueue<GamepadThumbstickMoveEvent> _gamepadThumbstickMoveInputEvents = new();
    private readonly InputEventQueue<GamepadTriggerMoveEvent> _gamepadTriggerMoveInputEvents = new();
    private readonly InputEventQueue<JoystickAxisMoveEvent> _joystickAxisMoveInputEvents = new();
    private readonly InputEventQueue<JoystickHatMoveEvent> _joystickHatMoveInputEvents = new();
    private readonly InputEventQueue<KeyCharEvent> _keyCharInputEvents = new();
    private readonly InputEventQueue<MouseScrollEvent> _mouseScrollInputEvents = new();
    private readonly InputEventQueue<PointChangedEvent> _pointChangedInputEvents = new();
    private readonly InputEventQueue<PointerClickEvent> _pointerClickInputEvents = new();
    private readonly InputEventQueue<ButtonChangedEvent<PointerButton>> _pointerButtonInputEvents = new();
    private readonly InputEventQueue<PointerGripChangedEvent> _pointerGripChangedInputEvents = new();
    private readonly InputEventQueue<PointerTargetChangedEvent> _pointerTargetChangedInputEvents = new();
    private readonly GenericEventQueue _orderedSdlEvents;

    public SilkEventContext(SdlTimestampCalculator.TimeBasis basis) =>
        _orderedSdlEvents = new GenericEventQueue(basis);

    public void RaiseEvents(params Span<IInputHandler> handlers)
    {
        _orderedSdlEvents.ConsumeOther(_buttonChangedInputEvents);
        _orderedSdlEvents.ConsumeOther(_connectionInputEvents);
        _orderedSdlEvents.ConsumeOther(_keyChangedInputEvents);
        _orderedSdlEvents.ConsumeOther(_gamepadThumbstickMoveInputEvents);
        _orderedSdlEvents.ConsumeOther(_gamepadTriggerMoveInputEvents);
        _orderedSdlEvents.ConsumeOther(_joystickAxisMoveInputEvents);
        _orderedSdlEvents.ConsumeOther(_joystickHatMoveInputEvents);
        _orderedSdlEvents.ConsumeOther(_keyCharInputEvents);
        _orderedSdlEvents.ConsumeOther(_mouseScrollInputEvents);
        _orderedSdlEvents.ConsumeOther(_pointChangedInputEvents);
        _orderedSdlEvents.ConsumeOther(_pointerClickInputEvents);
        _orderedSdlEvents.ConsumeOther(_pointerGripChangedInputEvents);
        _orderedSdlEvents.ConsumeOther(_pointerTargetChangedInputEvents);
        _orderedSdlEvents.ConsumeOther(_pointerButtonInputEvents);

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
