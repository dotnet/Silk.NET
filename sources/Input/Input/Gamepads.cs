namespace Silk.NET.Input;

/// <summary>
/// Represents a collection of <see cref="IGamepad"/>s from which input events can be received.
/// </summary>
public sealed class Gamepads : InputContextDeviceList<IGamepad>, IGamepadInputHandler
{
    internal Gamepads(InputContext ctx)
        : base(ctx) { }

    /// <summary>
    /// Raised when state pertaining to a pushable button on the gamepad changes (e.g. button up, button down).
    /// </summary>
    public event Action<ButtonChangedEvent<JoystickButton>>? ButtonChanged;

    /// <summary>
    /// Raised when a thumbstick on the gamepad moves.
    /// </summary>
    public event Action<GamepadThumbstickMoveEvent>? ThumbstickMove;

    /// <summary>
    /// Raised when a trigger on the gamepad moves.
    /// </summary>
    public event Action<GamepadTriggerMoveEvent>? TriggerMove;

    internal void HandleButtonChanged(ButtonChangedEvent<JoystickButton> @event) =>
        ButtonChanged?.Invoke(@event);

    void IButtonInputHandler<JoystickButton>.HandleButtonChanged(
        ButtonChangedEvent<JoystickButton> @event
    ) => HandleButtonChanged(@event);

    internal void HandleThumbstickMove(GamepadThumbstickMoveEvent @event) =>
        ThumbstickMove?.Invoke(@event);

    void IGamepadInputHandler.HandleThumbstickMove(GamepadThumbstickMoveEvent @event) =>
        HandleThumbstickMove(@event);

    internal void HandleTriggerMove(GamepadTriggerMoveEvent @event) => TriggerMove?.Invoke(@event);

    void IGamepadInputHandler.HandleTriggerMove(GamepadTriggerMoveEvent @event) =>
        HandleTriggerMove(@event);
}
