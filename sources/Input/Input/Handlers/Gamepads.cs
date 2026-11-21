using System.Runtime.CompilerServices;

namespace Silk.NET.Input;

/// <summary>
/// Represents a collection of <see cref="IGamepad"/>s from which input events can be received.
/// </summary>
public sealed class Gamepads : InputContextDeviceList<IGamepad>, IGamepadInputHandler
{
    internal Gamepads(InputContext ctx) : base(ctx)
    {
    }

    /// <summary>
    /// Raised when state pertaining to a pushable button on the gamepad changes (e.g. button up, button down).
    /// </summary>
    public event Action<ButtonChangedEvent<JoystickButton>>? ButtonChanged
    {
        add => _buttonChangedEventHandler.Add(value);
        remove => _buttonChangedEventHandler.Remove(value);
    }

    /// <summary>
    /// Raised when a thumbstick on the gamepad moves.
    /// </summary>
    public event Action<GamepadThumbstickMoveEvent>? ThumbstickMove
    {
        add => _thumbstickMoveEventHandler.Add(value);
        remove => _thumbstickMoveEventHandler.Remove(value);
    }

    /// <summary>
    /// Raised when a trigger on the gamepad moves.
    /// </summary>
    public event Action<GamepadTriggerMoveEvent>? TriggerMove
    {
        add => _triggerMoveEventHandler.Add(value);
        remove => _triggerMoveEventHandler.Remove(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IButtonInputHandler<JoystickButton>.HandleButtonChanged(
        ButtonChangedEvent<JoystickButton> @event
    ) => HandleButtonChanged(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal void HandleButtonChanged(ButtonChangedEvent<JoystickButton> @event)
    {
        if (@event.Device is IGamepad)
        {
            _buttonChangedEventHandler.Invoke(@event);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IGamepadInputHandler.HandleThumbstickMove(GamepadThumbstickMoveEvent @event) =>
        HandleThumbstickMove(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal void HandleThumbstickMove(GamepadThumbstickMoveEvent @event) =>
        _thumbstickMoveEventHandler.Invoke(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IGamepadInputHandler.HandleTriggerMove(GamepadTriggerMoveEvent @event) =>
        HandleTriggerMove(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal void HandleTriggerMove(GamepadTriggerMoveEvent @event) =>
        _triggerMoveEventHandler.Invoke(@event);

    private readonly InputContextEventHandler<ButtonChangedEvent<JoystickButton>> _buttonChangedEventHandler = new();
    private readonly InputContextEventHandler<GamepadThumbstickMoveEvent> _thumbstickMoveEventHandler = new();
    private readonly InputContextEventHandler<GamepadTriggerMoveEvent> _triggerMoveEventHandler = new();
}
