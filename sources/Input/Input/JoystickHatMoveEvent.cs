using System.Diagnostics;
using System.Numerics;
using Silk.NET.Input.SDL3;

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
// todo: hats are not class objects in and of themselves, and a joystick could have > 1 hat. we should include a hat index here.
// and so I am for now - though this should not be accepted without review since it goes against the initial design of the API.
public readonly record struct JoystickHatMoveEvent(IJoystick Joystick, long Timestamp, int WhichHat, Vector2 Value, Vector2 Delta) : ITimestampedEvent;
