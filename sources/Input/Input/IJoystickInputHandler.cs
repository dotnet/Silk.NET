namespace Silk.NET.Input;

/// <summary>
/// An <see cref="IInputHandler"/> that also receives <see cref="IJoystick"/> input.
/// </summary>
public interface IJoystickInputHandler : IButtonInputHandler<JoystickButton>
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
}