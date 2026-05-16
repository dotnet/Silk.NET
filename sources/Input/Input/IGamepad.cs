namespace Silk.NET.Input;

/// <summary>
/// Represents a gamepad that follows a typical layout.
/// </summary>
public interface IGamepad : IButtonDevice<JoystickButton>
{
    /// <summary>
    /// Gets the device state.
    /// </summary>
    /// <remarks>
    /// Only updated when <see cref="IInputBackend.Update"/> is called.
    /// </remarks>
    new GamepadState State { get; }
    ButtonReadOnlyList<JoystickButton> IButtonDevice<JoystickButton>.State => State.Buttons;
    /// <summary>
    /// Gets a collection enumerating the vibration motors available to the application to enable haptics.
    /// </summary>
    IReadOnlyList<IMotor> VibrationMotors { get; }
}