namespace Silk.NET.Input;

/// <summary>
/// An <see cref="IInputHandler"/> that also receives <see cref="IGamepad"/> input.
/// </summary>
public interface IGamepadInputHandler : IButtonInputHandler<JoystickButton>
{
    /// <summary>
    /// Called when one of the twin sticks moves.
    /// </summary>
    /// <param name="event">The event details.</param>
    void HandleThumbstickMove(GamepadThumbstickMoveEvent @event);

    /// <summary>
    /// Called when one of the two triggers moves.
    /// </summary>
    /// <param name="event">The event details.</param>
    void HandleTriggerMove(GamepadTriggerMoveEvent @event);
}