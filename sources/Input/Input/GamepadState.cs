using System.Numerics;

namespace Silk.NET.Input;

/// <summary>
/// Contains user input received from an <see cref="IGamepad"/>.
/// </summary>
public class GamepadState
{
    ///  <summary>
    ///  The constructor for a new GamepadState object
    ///  </summary>
    ///  <param name="buttons">The list of buttons</param>
    ///  <param name="axisStates">The list of states of the controllers axes that the triggers and joysticks will
    ///  be read from via their specific indices in this array</param>
    ///  <remarks>
    ///  </remarks>
    ///  <exception cref="ArgumentException"></exception>
    ///  <exception cref="ArgumentOutOfRangeException"></exception>
    public GamepadState(IReadOnlyList<Button<JoystickButton>> buttons, IReadOnlyList<float> axisStates)
    {
        _axisStates = axisStates;
        Buttons = new ButtonReadOnlyList<JoystickButton>(buttons);
        Triggers = new DualReadOnlyList<float>(
            getLeft: () => _axisStates[JoystickAxis.LeftTrigger.Index()],
            getRight: () =>_axisStates[JoystickAxis.RightTrigger.Index()]);
        Thumbsticks = new DualReadOnlyList<Vector2>(
            getLeft: () => new Vector2(_axisStates[JoystickAxis.LeftX.Index()], _axisStates[JoystickAxis.LeftY.Index()]),
            getRight: () => new Vector2(_axisStates[JoystickAxis.RightX.Index()], _axisStates[JoystickAxis.RightY.Index()]));
    }

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

    // ReSharper disable PrivateFieldCanBeConvertedToLocalVariable <- keeps closures consistent
    private readonly IReadOnlyList<float> _axisStates;
}
