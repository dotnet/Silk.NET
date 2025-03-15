namespace Silk.NET.Input;

/// <summary>
/// Represents a collection of <see cref="IJoystick"/>s from which input events can be received.
/// </summary>
public sealed class Joysticks : InputContextDeviceList<IJoystick>, IJoystickInputHandler
{
    internal Joysticks(InputContext ctx)
        : base(ctx) { }

    /// <summary>
    /// Raised when state pertaining to a pushable button on the joystick changes (e.g. button up, button down).
    /// </summary>
    public event Action<ButtonChangedEvent<JoystickButton>>? ButtonChanged;

    /// <summary>
    /// Raised when a movable axis on the joystick changes position.
    /// </summary>
    public event Action<JoystickAxisMoveEvent>? AxisMove;

    /// <summary>
    /// Raised when a joystick hat moves.
    /// </summary>
    public event Action<JoystickHatMoveEvent>? HatMove;

    internal void HandleButtonChanged(ButtonChangedEvent<JoystickButton> @event) =>
        ButtonChanged?.Invoke(@event);

    void IButtonInputHandler<JoystickButton>.HandleButtonChanged(
        ButtonChangedEvent<JoystickButton> @event
    ) => HandleButtonChanged(@event);

    internal void HandleAxisMove(JoystickAxisMoveEvent @event) => AxisMove?.Invoke(@event);

    void IJoystickInputHandler.HandleAxisMove(JoystickAxisMoveEvent @event) =>
        HandleAxisMove(@event);

    internal void HandleHatMove(JoystickHatMoveEvent @event) => HatMove?.Invoke(@event);

    void IJoystickInputHandler.HandleHatMove(JoystickHatMoveEvent @event) => HandleHatMove(@event);
}
