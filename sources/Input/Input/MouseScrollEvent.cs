using System.Diagnostics;
using System.Numerics;

namespace Silk.NET.Input;

/// <summary>
/// Contains information pertaining to the user scrolling using a mouse scroll wheel.
/// </summary>
/// <param name="Mouse">The mouse on which the scroll wheel resides.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Point">The mouse's active point when the scroll event occurred.</param>
/// <param name="WheelPosition">The <see cref="MouseState.WheelPosition"/> after the event occurred.</param>
/// <param name="Delta">
/// The change in <see cref="WheelPosition"/> as a result of this event represented as a number of ratchets.
/// </param>
public readonly record struct MouseScrollEvent(IMouse Mouse, long Timestamp, TargetPoint Point, Vector2 WheelPosition, Vector2 Delta);