namespace Silk.NET.Input;

/// <summary>
/// Represents a vibration motor.
/// </summary>
public interface IMotor
{
    /// <summary>
    /// Gets or sets the speed at which the motor is operating, where <c>0.0</c> represents no vibration and <c>1.0</c>
    /// represents the maximum amount of vibration.
    /// </summary>
    float Speed { get; set; }
}