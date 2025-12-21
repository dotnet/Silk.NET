using System.Diagnostics;

namespace Silk.NET.Input;

/// <summary>
/// Contains information pertaining to the movement of a joystick axis.
/// </summary>
/// <param name="Joystick">The joystick on which the axis being moved resides.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Axis">The index of the axis being moved.</param>
/// <param name="Value">The new value of the axis, typically between <c>0.0</c> and <c>1.0</c>.</param>
/// <param name="Delta">The change in <see cref="Value"/> as a result of this event.</param>
public readonly record struct JoystickAxisMoveEvent(IJoystick Joystick, long Timestamp, int Axis, float Value, float Delta);