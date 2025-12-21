using System.Numerics;

namespace Silk.NET.Input;

/// <summary>
/// Contains user input received from an <see cref="IGamepad"/>.
/// </summary>
public class GamepadState
{
    /// <summary>
    /// The constructor for a new GamepadState object
    /// </summary>
    /// <param name="buttons">The list of buttons</param>
    /// <param name="axisStates">The list of states of the controllers axes that the triggers and joysticks will
    /// be read from via their specific indices in this array</param>
    /// <param name="joystickXAxisIndicesLR">The joystick X axes.</param>
    /// <param name="joystickYAxisIndicesDU">The Joystick Y axes. </param>
    /// <param name="joystickTriggerIndicesLR"></param>
    /// <remarks>
    /// For <see cref="joystickXAxisIndicesLR"/> and <see cref="joystickYAxisIndicesDU"/>, the must be either of length
    /// 2 or 4.
    ///
    /// If two are provided, the first is assumed to be the left stick, and the second is assumed to be the right stick
    ///
    /// if 4 are provided, it is assumed that the first two are - and + sides of the first axis, and so on.
    ///<example>[leftX, rightX] OR [-leftX, +leftX, -rightX, +rightX]</example>
    /// </remarks>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public GamepadState(IReadOnlyList<Button<JoystickButton>> buttons, IReadOnlyList<float> axisStates)
    {
        _axisStates = axisStates;
        Buttons = new ButtonReadOnlyList<JoystickButton>(buttons);
        Triggers = new DualReadOnlyList<float>(
            left: () => _axisStates[JoystickAxis.LeftTrigger.Index()],
            right: () =>_axisStates[JoystickAxis.RightTrigger.Index()]);
        Thumbsticks = new DualReadOnlyList<Vector2>(
            left: () => new Vector2(_axisStates[JoystickAxis.LeftX.Index()], _axisStates[JoystickAxis.LeftY.Index()]),
            right: () => new Vector2(_axisStates[JoystickAxis.RightX.Index()], _axisStates[JoystickAxis.RightY.Index()]));
    }

    /// <summary>
    /// Gets the gamepad button state denoting the buttons being pressed or depressed.
    /// </summary>
    public ButtonReadOnlyList<JoystickButton> Buttons { get; }

    /// <summary>
    /// Gets the state of the twin sticks on the gamepad.
    /// </summary>
    public DualReadOnlyList<Vector2> Thumbsticks { get; internal set; }

    /// <summary>
    /// Gets the state of the triggers on the gamepad.
    /// </summary>
    public DualReadOnlyList<float> Triggers { get; internal set; }

    // ReSharper disable PrivateFieldCanBeConvertedToLocalVariable <- keeps closures consistent
    private readonly IReadOnlyList<float> _axisStates;
}
