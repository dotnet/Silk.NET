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
internal sealed class SdlInputEventContext : IDisposable
{
    public ISdlInputEventQueue<ButtonChangedEvent<JoystickButton>> JoyButtonChangedEvents => _joyButtonChangedEvents;

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

    private readonly SdlInputEventQueue<ButtonChangedEvent<JoystickButton>> _joyButtonChangedEvents = new();
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
        _orderedSdlEvents.StoreReferencesTo(_joyButtonChangedEvents, SdlEventDiscriminator.JoystickButtonChanged);
        _orderedSdlEvents.StoreReferencesTo(_connectionEvents, SdlEventDiscriminator.Connection);
        _orderedSdlEvents.StoreReferencesTo(_keyChangedEvents, SdlEventDiscriminator.KeyChanged);
        _orderedSdlEvents.StoreReferencesTo(_gamepadThumbstickMoveEvents, SdlEventDiscriminator.GamepadThumbstickMove);
        _orderedSdlEvents.StoreReferencesTo(_gamepadTriggerMoveEvents, SdlEventDiscriminator.GamepadTriggerMove);
        _orderedSdlEvents.StoreReferencesTo(_joystickAxisMoveEvents, SdlEventDiscriminator.JoystickAxisMove);
        _orderedSdlEvents.StoreReferencesTo(_joystickHatMoveEvents, SdlEventDiscriminator.JoystickHatMove);
        _orderedSdlEvents.StoreReferencesTo(_keyCharEvents, SdlEventDiscriminator.KeyChar);
        _orderedSdlEvents.StoreReferencesTo(_mouseScrollEvents, SdlEventDiscriminator.MouseScroll);
        _orderedSdlEvents.StoreReferencesTo(_pointChangedEvents, SdlEventDiscriminator.PointChanged);
        _orderedSdlEvents.StoreReferencesTo(_pointerClickEvents, SdlEventDiscriminator.PointerClick);
        _orderedSdlEvents.StoreReferencesTo(_pointerGripChangedEvents, SdlEventDiscriminator.PointerGripChanged);
        _orderedSdlEvents.StoreReferencesTo(_pointerTargetChangedEvents, SdlEventDiscriminator.PointerTargetChanged);
        _orderedSdlEvents.StoreReferencesTo(_pointerButtonEvents, SdlEventDiscriminator.PointerButtonChanged);

        var genericEvents = _orderedSdlEvents.ConsumeAndSortSelf();

        if (handlers is not { Length: > 0 })
        {
            return;
        }

        for (var index = 0; index < genericEvents.Length; index++)
        {
            ref readonly var evt = ref genericEvents[index];
            switch (evt.Type)
            {
                case SdlEventDiscriminator.PointChanged:
                    RaiseEvent(handlers, evt.Value<PointChangedEvent>());
                    break;

                case SdlEventDiscriminator.PointerClick:
                    RaiseEvent(handlers, evt.Value<PointerClickEvent>());
                    break;

                case SdlEventDiscriminator.PointerButtonChanged:
                    RaiseEvent(handlers, evt.Value<ButtonChangedEvent<PointerButton>>());
                    break;

                case SdlEventDiscriminator.PointerGripChanged:
                    RaiseEvent(handlers, evt.Value<PointerGripChangedEvent>());
                    break;

                case SdlEventDiscriminator.PointerTargetChanged:
                    RaiseEvent(handlers, evt.Value<PointerTargetChangedEvent>());
                    break;

                case SdlEventDiscriminator.JoystickButtonChanged:
                    RaiseEvent(handlers, evt.Value<ButtonChangedEvent<JoystickButton>>());
                    break;

                case SdlEventDiscriminator.KeyButtonChanged:
                    RaiseEvent(handlers, evt.Value<ButtonChangedEvent<KeyName>>());
                    break;

                case SdlEventDiscriminator.KeyChanged:
                    RaiseEvent(handlers, evt.Value<KeyChangedEvent>());
                    break;

                case SdlEventDiscriminator.GamepadThumbstickMove:
                    RaiseEvent(handlers, evt.Value<GamepadThumbstickMoveEvent>());
                    break;

                case SdlEventDiscriminator.GamepadTriggerMove:
                    RaiseEvent(handlers, evt.Value<GamepadTriggerMoveEvent>());
                    break;

                case SdlEventDiscriminator.JoystickAxisMove:
                    RaiseEvent(handlers, evt.Value<JoystickAxisMoveEvent>());
                    break;

                case SdlEventDiscriminator.JoystickHatMove:
                    RaiseEvent(handlers, evt.Value<JoystickHatMoveEvent>());
                    break;

                case SdlEventDiscriminator.KeyChar:
                    RaiseEvent(handlers, evt.Value<KeyCharEvent>());
                    break;

                case SdlEventDiscriminator.MouseScroll:
                    RaiseEvent(handlers, evt.Value<MouseScrollEvent>());
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

        return;

        static void RaiseEvent<TItem>(in Span<IInputHandler> handlers, in TItem evt) where TItem : struct
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
        _joyButtonChangedEvents.Dispose();
        _connectionEvents.Dispose();
        _keyChangedEvents.Dispose();
        _gamepadThumbstickMoveEvents.Dispose();
        _gamepadTriggerMoveEvents.Dispose();
        _joystickAxisMoveEvents.Dispose();
        _joystickHatMoveEvents.Dispose();
        _keyCharEvents.Dispose();
        _mouseScrollEvents.Dispose();
        _pointChangedEvents.Dispose();
        _pointerClickEvents.Dispose();
        _pointerButtonEvents.Dispose();
        _pointerGripChangedEvents.Dispose();
        _pointerTargetChangedEvents.Dispose();
        _orderedSdlEvents.Dispose();
    }
}
