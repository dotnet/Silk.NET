using System.Diagnostics;

namespace Silk.NET.Input;

/// <summary>
/// Contains information pertaining to the user changing the pressure with which they're applying their grip on the
/// given pointer device.
/// </summary>
/// <param name="Pointer">The pointer device the user is gripping.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="GripPressure">
/// The grip pressure being applied to the device, where <c>0.0</c> is the lowest amount of pressure measurable by the
/// device and <c>1.0</c> is the maximum amount of pressure measurable by the device.
/// </param>
/// <param name="Delta">The change in <see cref="GripPressure"/> from its previous value.</param>
public readonly record struct PointerGripChangedEvent(IPointerDevice Pointer, long Timestamp, float GripPressure, float Delta);