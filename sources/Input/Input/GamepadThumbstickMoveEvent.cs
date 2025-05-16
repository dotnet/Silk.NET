using System.Diagnostics;
using System.Numerics;

namespace Silk.NET.Input;

/// <summary>
/// Contains information pertaining to the movement of a thumbstick.
/// </summary>
/// <param name="Gamepad">The gamepad on which the thumbstick resides.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Value">
/// The new position of the thumbstick, where each axis is between <c>-1.0</c> and <c>1.0</c>.
/// </param>
/// <param name="Delta">The change in <see cref="Value"/> as a result of this event.</param>
public readonly record struct GamepadThumbstickMoveEvent(IGamepad Gamepad, long Timestamp, Vector2 Value, Vector2 Delta);