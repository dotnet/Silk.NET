namespace Silk.NET.Input;

/// <summary>
/// Enumerates the buttons of a joystick.
/// </summary>
public enum JoystickButton
{
    /// <summary>
    /// The button was not recognised.
    /// </summary>
    Unknown,

    /// <summary>
    /// The down-most button of the primary button cluster.
    /// </summary>
    ButtonDown,

    /// <summary>
    /// The "A" button on Xbox (and similar) controllers. Equivalent to <see cref="ButtonDown"/>.
    /// </summary>
    A = ButtonDown,

    /// <summary>
    /// The rightmost button of the primary button cluster.
    /// </summary>
    ButtonRight,

    /// <summary>
    /// The "B" button on Xbox (and similar) controllers. Equivalent to <see cref="ButtonRight"/>.
    /// </summary>
    B = ButtonRight,

    /// <summary>
    /// The leftmost button of the primary button cluster.
    /// </summary>
    ButtonLeft,

    /// <summary>
    /// The "X" button on Xbox (and similar) controllers. Equivalent to <see cref="ButtonLeft"/>.
    /// </summary>
    X = ButtonLeft,

    /// <summary>
    /// The upmost button of the primary button cluster.
    /// </summary>
    ButtonUp,

    /// <summary>
    /// The "Y" button on Xbox (and similar) controllers. Equivalent to <see cref="ButtonUp"/>.
    /// </summary>
    Y = ButtonUp,

    /// <summary>
    /// The leftmost bumper/shoulder button.
    /// </summary>
    LeftBumper,

    /// <summary>
    /// The rightmost bumper/shoulder button.
    /// </summary>
    RightBumper,

    /// <summary>
    /// The "back" button.
    /// </summary>
    Back,

    /// <summary>
    /// The "start" button.
    /// </summary>
    Start,

    /// <summary>
    /// The "home" button.
    /// </summary>
    Home,

    /// <summary>
    /// The leftmost thumbstick. This button represents the stick being pressed down.
    /// </summary>
    LeftStick,

    /// <summary>
    /// The rightmost thumbstick. This button represents the stick being pressed down.
    /// </summary>
    RightStick,

    /// <summary>
    /// The upmost button of the D-Pad button cluster.
    /// </summary>
    DPadUp,

    /// <summary>
    /// The rightmost button of the D-Pad button cluster.
    /// </summary>
    DPadRight,

    /// <summary>
    /// The down-most button of the D-Pad button cluster.
    /// </summary>
    DPadDown,

    /// <summary>
    /// The leftmost button of the D-Pad button cluster.
    /// </summary>
    DPadLeft
}