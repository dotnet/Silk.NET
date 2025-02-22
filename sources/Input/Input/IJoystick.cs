namespace Silk.NET.Input;

/// <summary>
/// Represents a joystick with axes, buttons, and hats.
/// </summary>
public interface IJoystick : IButtonDevice<JoystickButton>
{
    /// <summary>
    /// Gets the device state.
    /// </summary>
    /// <remarks>
    /// Only updated when <see cref="IInputBackend.Update"/> is called.
    /// </remarks>
    new JoystickState State { get; }
    ButtonReadOnlyList<JoystickButton> IButtonDevice<JoystickButton>.State => State.Buttons;
}