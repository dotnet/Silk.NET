using System.Diagnostics;
using System.Numerics;

namespace Silk.NET.Input;

/// <summary>
/// Contains information pertaining to the movement of a joystick hat.
/// </summary>
/// <param name="Joystick">The joystick on which the hat being moved resides.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Value">The position of the hat after this event.</param>
/// <param name="Delta">The change in <see cref="Value"/> as a result of this event.</param>
public readonly record struct JoystickHatMoveEvent(IJoystick Joystick, long Timestamp, Vector2 Value, Vector2 Delta);