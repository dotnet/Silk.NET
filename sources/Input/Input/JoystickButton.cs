namespace Silk.NET.Input;

/// <summary>
/// Enumerates the buttons of a joystick.
/// </summary>
[OrderedIndexUsage]
public enum JoystickButton // todo : should we include XInput, PSX, and Nintendo button names here?
{
    /// <summary>
    /// The button was not recognised.
    /// </summary>
    /// <remarks>This is defined as such a large number such that unknown buttons can still be a JoystickButton,
    /// and we can define up to <see cref="ushort.MaxValue"/> predefined unique joystick buttons.
    /// </remarks>
    Unknown = JoystickAxis.Unknown,

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
    DPadLeft,

    // BEFORE ADDING A NEW ITEM MAKE SURE YOU CHANGE LastJoystickButton IN InputMarshal
}

/// <summary>
/// Additional functions for making sense of <see cref="JoystickButton"/>s
/// </summary>
public static class JoystickButtonExtensions
{
    /// <summary>
    /// Returns true if we have identified this button as a known button
    /// </summary>
    /// <param name="button"></param>
    /// <returns></returns>
    public static bool IsIdentified(this JoystickButton button) => button > JoystickButton.Unknown;

    /// <inheritdoc cref="EnumInfo{T}.ValueIndexOfUnnamed"/>
    public static int Index<T>(this T value) where T : unmanaged, Enum => EnumInfo<T>.ValueIndexOfUnnamed(value);
}

