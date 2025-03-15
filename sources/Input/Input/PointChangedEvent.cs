using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Silk.NET.Input;

/// <summary>
/// Contains information pertaining to a <see cref="TargetPoint"/> change on a <see cref="IPointerDevice"/>,
/// </summary>
/// <param name="Pointer">The pointer device with which the user is pointing.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="OldPoint">
/// The previous state for this <see cref="TargetPoint"/>. If this is a new point (e.g. a finger has only just touched a
/// touch screen), this shall be <c>null</c>.
/// </param>
/// <param name="NewPoint">
/// The new state for this <see cref="TargetPoint"/>. If the point is no longer valid (e.g. a finger is no longer
/// touching a touch screen), this shall be <c>null</c>.
/// </param>
public readonly record struct PointChangedEvent(
    IPointerDevice Pointer,
    long Timestamp,
    TargetPoint? OldPoint,
    TargetPoint? NewPoint
);
