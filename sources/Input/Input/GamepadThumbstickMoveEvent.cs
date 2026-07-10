using System.Diagnostics;
using System.Numerics;
using Silk.NET.Input.SDL3;

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
/// <remarks>
/// TODO: this should probably include a thumbstick/axis identifier, right? At least left/right?
///  see <see cref="GamepadTriggerMoveEvent"/>, which has an Axis field
/// </remarks>
public readonly record struct GamepadThumbstickMoveEvent(IGamepad Gamepad, long Timestamp, Vector2 Value, Vector2 Delta) : ITimestampedEvent;
