using System.Numerics;
using Silk.NET.Input.SDL3.Devices.Joysticks;

namespace Silk.NET.Input;

/// <summary>
/// Contains user input received from an <see cref="IGamepad"/>.
/// </summary>
public class GamepadState
{
    private static readonly int _leftTriggerIndex = JoystickAxis.LeftTrigger.Index();
    private static readonly int _rightTriggerIndex = JoystickAxis.RightTrigger.Index();
    private static readonly int _stickLeftXIndex =  JoystickAxis.LeftX.Index();
    private static readonly int _stickLeftYIndex =  JoystickAxis.LeftY.Index();
    private static readonly int _stickRightXIndex =  JoystickAxis.RightX.Index();
    private static readonly int _stickRightYIndex =  JoystickAxis.RightY.Index();

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
            getLeft: () => _axisStates[_leftTriggerIndex],
            getRight: () => _axisStates[_rightTriggerIndex]);
        Thumbsticks = new DualReadOnlyList<Vector2>(
            getLeft: () => GamepadAxes.JoystickAxesToThumbstick(
                new Vector2(_axisStates[_stickLeftXIndex], _axisStates[_stickLeftYIndex])
            ),
            getRight: () => GamepadAxes.JoystickAxesToThumbstick(
                new Vector2(_axisStates[_stickRightXIndex], _axisStates[_stickRightYIndex])
            )
        );
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
