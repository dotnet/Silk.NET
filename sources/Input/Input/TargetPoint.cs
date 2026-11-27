using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using Silk.NET.Maths;

namespace Silk.NET.Input;

/// <summary>
/// Represents a point on a target at which a pointer is pointing.
/// </summary>
/// <param name="Id">
/// An integral identifier for the point. This point must be the only point for the device currently pointing at a
/// target with this identifier at any given time. If this point ceases to point at the target, then the identifier
/// becomes free for another device point. This means that this identifier can just be a counter, but may be globally
/// unique depending on the backend's capabilities. If an index is used, points with greater indices should not be
/// "moved" into this point's place should it no longer point at the target. This is to allow applications to track
/// distinct points.<br/>
/// </param>
/// <param name="Flags">Flags describing the state of the point. <br/></param>
/// <param name="Position">The target-relative position at which the pointer is pointing.<br/></param>
/// <param name="NormalizedPosition">
/// The normalized position on the target at which the pointer is pointing, if applicable. If this is not available
/// (e.g. due to the target being infinitely large a.k.a. "unbounded"), then this property shall have a value of
/// <c>default</c>.<br/>
/// </param>
/// <param name="Pointer">
/// A ray representing the <b>"world-space"</b> origin and angle at which the pointer is pointing at this point on the target.
/// A ray with an orientation equivalent to an identity quaternion shall be interpreted as the point directly
/// perpendicular to and facing towards the target, with this being the default value should such information be unavailable.
/// <br/>
/// The <b>"world-space"</b> <see cref="Ray3D{T}.Origin"/> is expressed in terms of the widest available coordinate space that
/// is supported by the <see cref="IPointerDevice"/> providing this point. For standard
/// mouse / pen <see cref="IPointerDevice"/>s with a window-based target (the default), this shall carry the desktop-
/// space position on platforms where such data is available. <br/>
/// </param>
/// <param name="Pressure">
/// The pressure applied to the point on the target by the pointer, between <c>0.0</c> representing the minimum amount
/// of pressure and <c>1.0</c> representing the maximum amount of pressure. This shall be <c>1.0</c> if such data is
/// unavailable but the point is otherwise valid.<br/>
/// </param>
/// <param name="Target">The pointer being pointed at.</param>
public readonly record struct TargetPoint(
    int Id,
    TargetPointFlags Flags,
    Vector3 Position,
    Vector3 NormalizedPosition,
    Ray3D<float> Pointer,
    float Pressure,
    IPointerTarget Target
)
{
    /// <summary>
    /// Gets a value indicating whether this <see cref="TargetPoint"/> is a valid instance of a point on a
    /// <see cref="Target"/> that the user is pointing at using their pointer device.
    /// </summary>
    [MemberNotNullWhen(true, nameof(Target))]
    public bool IsValid =>
        (Flags & TargetPointFlags.PointingAtTarget) != TargetPointFlags.NotPointingAtTarget;
}
