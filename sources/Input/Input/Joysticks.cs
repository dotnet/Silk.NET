namespace Silk.NET.Input;

/// <summary>
/// Represents a collection of <see cref="IJoystick"/>s from which input events can be received.
/// </summary>
public partial class Joysticks : IReadOnlyList<IJoystick>
{
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
}