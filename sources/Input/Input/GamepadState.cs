using System.Numerics;

namespace Silk.NET.Input;

/// <summary>
/// Contains user input received from an <see cref="IGamepad"/>.
/// </summary>
public class GamepadState(
    ButtonReadOnlyList<JoystickButton> buttons,
    DualReadOnlyList<Vector2> thumbsticks,
    DualReadOnlyList<float> triggers
)
{
    /// <summary>
    /// Clones the given state. This is useful for creating an immutable copy of state from a mutable one.
    /// </summary>
    /// <param name="other">The other state.</param>
    public GamepadState(GamepadState other)
        : this(
            new ButtonReadOnlyList<JoystickButton>(other.Buttons),
            new DualReadOnlyList<Vector2>(other.Thumbsticks),
            new DualReadOnlyList<float>(other.Triggers)
        ) { }

    /// <summary>
    /// Gets the gamepad button state denoting the buttons being pressed or depressed.
    /// </summary>
    public ButtonReadOnlyList<JoystickButton> Buttons { get; } = buttons;

    /// <summary>
    /// Gets the state of the twin sticks on the gamepad.
    /// </summary>
    public DualReadOnlyList<Vector2> Thumbsticks { get; internal set; } = thumbsticks;

    /// <summary>
    /// Gets the state of the triggers on the gamepad.
    /// </summary>
    public DualReadOnlyList<float> Triggers { get; internal set; } = triggers;
}
