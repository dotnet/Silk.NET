namespace Silk.NET.Input;

/// <summary>
/// Flags describing a <see cref="TargetPoint" /> state.
/// </summary>
[Flags]
public enum TargetPointFlags
{
    /// <summary>
    /// No flags are set, indicating that the point is not being pointed at and therefore may not be valid.
    /// </summary>
    NotPointingAtTarget = 0,

    /// <summary>
    /// Indicates that the point has been resolved as a valid point at which the pointer is pointing.
    /// </summary>
    PointingAtTarget = 1 << 0
}