namespace Silk.NET.Input;

/// <summary>
/// Enumerates the buttons available on pointer devices.
/// </summary>
[OrderedIndexUsage]
public enum PointerButton
{
    /// <summary>
    /// An unrecognised button.
    /// </summary>
    Unknown = JoystickAxis.Unknown,

    /// <summary>
    /// The primary button e.g. left click.
    /// </summary>
    Primary,

    /// <summary>
    /// The secondary button e.g. right click.
    /// </summary>
    Secondary,

    /// <summary>
    /// The third button.
    /// </summary>
    Button3,

    /// <summary>
    /// The middle button i.e. clicking the scroll wheel down. This acts as the third button.
    /// </summary>
    MiddleButton = Button3,

    /// <summary>
    /// The fourth button.
    /// </summary>
    Button4,

    /// <summary>
    /// The fifth button.
    /// </summary>
    Button5,

    /// <summary>
    /// The sixth button.
    /// </summary>
    Button6,

    /// <summary>
    /// The seventh button.
    /// </summary>
    Button7,

    /// <summary>
    /// The eighth button.
    /// </summary>
    Button8,

    /// <summary>
    /// The ninth button.
    /// </summary>
    Button9,

    /// <summary>
    /// The tenth button.
    /// </summary>
    Button10,

    /// <summary>
    /// The eleventh button.
    /// </summary>
    Button11,

    /// <summary>
    /// The twelveth button.
    /// </summary>
    Button12,

    /// <summary>
    /// The thirteenth button.
    /// </summary>
    Button13,

    /// <summary>
    /// The fourteenth button.
    /// </summary>
    Button14,

    /// <summary>
    /// The fifteenth button.
    /// </summary>
    Button15,

    /// <summary>
    /// The sixteenth button.
    /// </summary>
    Button16,

    /// <summary>
    /// The seventeenth button.
    /// </summary>
    Button17,

    /// <summary>
    /// The eighteenth button.
    /// </summary>
    Button18,

    /// <summary>
    /// The nineteenth button.
    /// </summary>
    Button19,

    /// <summary>
    /// The twentieth button.
    /// </summary>
    Button20,

    /// <summary>
    /// The twenty-first button.
    /// </summary>
    Button21,

    /// <summary>
    /// The twenty-second button.
    /// </summary>
    Button22,

    /// <summary>
    /// The twenty-third button.
    /// </summary>
    Button23,

    /// <summary>
    /// The twenty-fourth button.
    /// </summary>
    Button24,

    /// <summary>
    /// The twenty-fifth button.
    /// </summary>
    Button25,

    /// <summary>
    /// The twenty-sixth button.
    /// </summary>
    Button26,

    /// <summary>
    /// The twenty-seventh button.
    /// </summary>
    Button27,

    /// <summary>
    /// The twenty-eighth button.
    /// </summary>
    Button28,

    /// <summary>
    /// The twenty-ninth button.
    /// </summary>
    Button29,

    /// <summary>
    /// The thirtieth button.
    /// </summary>
    Button30,

    /// <summary>
    /// The eraser tip of a pen pointer device. This acts as the thirtieth button.
    /// </summary>
    EraserTip = Button30,

    /// <summary>
    /// The thirty-first button.
    /// </summary>
    Button31,

    /// <summary>
    /// The thirty-second button.
    /// </summary>
    Button32,

    // BEFORE ADDING MORE BUTTONS, ENSURE YOU CHANGE InputMarshal TO ACCOUNT FOR THE NEW MAX
}
