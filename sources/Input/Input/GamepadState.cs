using System.Numerics;

namespace Silk.NET.Input;

/// <summary>
/// Contains user input received from an <see cref="IGamepad"/>.
/// </summary>
public class GamepadState
{
    /// <summary>
    /// Gets the gamepad button state denoting the buttons being pressed or depressed.
    /// </summary>
    public ButtonReadOnlyList<JoystickButton> Buttons { get; }

    /// <summary>
    /// Gets the state of the twin sticks on the gamepad.
    /// </summary>
    public DualReadOnlyList<Vector2> Thumbsticks { get; }

    /// <summary>
    /// Gets the state of the triggers on the gamepad.
    /// </summary>
    public DualReadOnlyList<float> Triggers { get; }
}