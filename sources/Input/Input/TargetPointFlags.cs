namespace Silk.NET.Input;

/// <summary>
/// Flags describing a <see cref="TargetPoint" /> state.
/// </summary>
[Flags]
public enum TargetPointFlags
{
    /// <summary>
    /// No flags are set, indicating that this <see cref="TargetPoint"/> does not point to its
    /// <see cref="TargetPoint.Target"/> and therefore may not be valid per typical user expectations.
    /// This value is used indicate that this point is a "remapped" point, e.g. "raw" mouse input,
    /// points mapped to other windows, etc
    /// </summary>
    NotPointingAtTarget = 0,

    /// <summary>
    /// Indicates that this <see cref="TargetPoint"/> is pointing at <see cref="TargetPoint.Target"/>
    /// </summary>
    PointingAtTarget = 1 << 0
}
