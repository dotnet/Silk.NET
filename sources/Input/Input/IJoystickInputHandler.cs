namespace Silk.NET.Input;

/// <summary>
/// An <see cref="IInputHandler"/> that also receives <see cref="IJoystick"/> input.
/// </summary>
public interface IJoystickInputHandler : IButtonInputHandler<JoystickButton>, IInputHandler<JoystickAxisMoveEvent>, IInputHandler<JoystickHatMoveEvent>
{
    /// <summary>
    /// Called when an axis on the joystick moves.
    /// </summary>
    /// <param name="event">The event details.</param>
    void HandleAxisMove(JoystickAxisMoveEvent @event);

    /// <summary>
    /// Called when a hat on the joystick moves.
    /// </summary>
    /// <param name="event">The event details.</param>
    void HandleHatMove(JoystickHatMoveEvent @event);

    void IInputHandler<JoystickAxisMoveEvent>.Handle(JoystickAxisMoveEvent @event) => HandleAxisMove(@event);
    void IInputHandler<JoystickHatMoveEvent>.Handle(JoystickHatMoveEvent @event) => HandleHatMove(@event);
}
