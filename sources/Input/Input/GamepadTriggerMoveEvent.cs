using System.Diagnostics;

namespace Silk.NET.Input;

/// <summary>
/// Contains information pertaining to the movement of a trigger.
/// </summary>
/// <param name="Gamepad">The gamepad on which the trigger resides.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Axis">The index of the trigger that has moved.</param>
/// <param name="Value">
/// The new value of the trigger, between <c>0.0</c> (fully depressed) and <c>1.0</c> (fully pressed).
/// </param>
/// <param name="Delta">The change in <see cref="Value"/> as a result of this event.</param>
public readonly record struct GamepadTriggerMoveEvent(IGamepad Gamepad, long Timestamp, int Axis, float Value, float Delta);