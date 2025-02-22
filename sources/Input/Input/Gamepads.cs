namespace Silk.NET.Input;

/// <summary>
/// Represents a collection of <see cref="IGamepad"/>s from which input events can be received.
/// </summary>
public partial class Gamepads : IReadOnlyList<IGamepad>
{
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
}