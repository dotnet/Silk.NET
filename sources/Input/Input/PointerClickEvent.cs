using System.Diagnostics;

namespace Silk.NET.Input;

/// <summary>
/// Contains information pertaining to a pointer button being pressed and released (i.e. clicked).
/// </summary>
/// <param name="Pointer">The pointer device on which the button being pressed and released resides.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Point">
/// A specific <see cref="TargetPoint"/> for which the button press occurred, check <see cref="TargetPoint.IsValid"/> to
/// validate if such a point was available.
/// </param>
/// <param name="Button">The button that was pressed and released in succession.</param>
public readonly record struct PointerClickEvent(IPointerDevice Pointer, long Timestamp, TargetPoint Point, PointerButton Button);