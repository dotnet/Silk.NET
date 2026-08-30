using System.Runtime.CompilerServices;

namespace Silk.NET.Input;

/// <summary>
/// An <see cref="IInputHandler"/> that also receives <see cref="IGamepad"/> input.
/// </summary>
public interface IGamepadInputHandler : IButtonInputHandler<JoystickButton>, IInputHandler<GamepadThumbstickMoveEvent>, IInputHandler<GamepadTriggerMoveEvent>
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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IInputHandler<GamepadThumbstickMoveEvent>.Handle(GamepadThumbstickMoveEvent @event) => HandleThumbstickMove(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IInputHandler<GamepadTriggerMoveEvent>.Handle(GamepadTriggerMoveEvent @event) => HandleTriggerMove(@event);
}
