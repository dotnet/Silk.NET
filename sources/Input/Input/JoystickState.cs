using System.Numerics;

namespace Silk.NET.Input;

/// <summary>
/// Contains user input received from an <see cref="IJoystick"/>.
/// </summary>
public class JoystickState
{
    /// <summary>
    /// Gets the state of the joystick axes between <c>-1.0</c> and <c>1.0</c>
    /// </summary>
    public InputReadOnlyList<float> Axes { get; }

    /// <summary>
    /// Gets the joystick button state, denoting which buttons are pressed/depressed.
    /// </summary>
    public ButtonReadOnlyList<JoystickButton> Buttons { get; }

    /// <summary>
    /// Gets the state of the joystick hats as vectors between <c>-1.0</c> and <c>1.0</c>.
    /// </summary>
    public InputReadOnlyList<Vector2> Hats { get; }

    /// <summary>
    ///
    /// </summary>
    /// <param name="axes"></param>
    /// <param name="buttons"></param>
    /// <param name="hats"></param>
    public JoystickState(IReadOnlyList<float> axes, IReadOnlyList<Button<JoystickButton>> buttons, IReadOnlyList<Vector2> hats)
    {
        Axes = new InputReadOnlyList<float>(axes);
        Buttons = new ButtonReadOnlyList<JoystickButton>(buttons);
        Hats = new InputReadOnlyList<Vector2>(hats);

    }
}
