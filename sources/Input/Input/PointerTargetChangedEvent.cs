using System.Diagnostics;
using Silk.NET.Maths;

namespace Silk.NET.Input;

/// <summary>
/// Contains information pertaining to changes to a "target" at which the user can point using a pointer device.
/// </summary>
/// <param name="Pointer">The pointer with which the user can point at the given target.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Target">The target at which the user can point.</param>
/// <param name="IsAdded">
/// <c>true</c> if this is a newly-added target to <see cref="IPointerDevice.Targets"/>,
/// <c>false</c> if this target has been removed from the list of available <see cref="IPointerDevice.Targets"/>,
/// <c>null</c> if there has been no change to the target's validity.
/// </param>
/// <param name="OldBounds">
/// The old <see cref="IPointerTarget.Bounds"/> of the target. This may be the same as <see cref="NewBounds"/> if there
/// has been no change.
/// </param>
/// <param name="NewBounds">
/// The new <see cref="IPointerTarget.Bounds"/> of the target. This may be the same as <see cref="OldBounds"/> if there
/// has been no change.
/// </param>
public readonly record struct PointerTargetChangedEvent(IPointerDevice Pointer, long Timestamp, IPointerTarget Target, bool? IsAdded, Box3D<float> OldBounds, Box3D<float> NewBounds);