using Silk.NET.Maths;

namespace Silk.NET.Input;

/// <summary>
/// Represents a target at which the user can point using their pointer device.
/// </summary>
public interface IPointerTarget
{
    /// <summary>
    /// The boundary in which positions of points on this target shall fall. For <see cref="Box3D{T}.Min" />,
    /// <see cref="float.NegativeInfinity" /> shall represent the lack of a lower bound on a particular axis. For
    /// For <see cref="Box3D{T}.Max" />, <see cref="float.PositiveInfinity" /> shall represent the lack of a lower bound
    /// on a particular axis. <c>0</c> represents an unused axis that axis is <c>0</c> on both
    /// <see cref="Box3D{T}.Min" /> and <see cref="Box3D{T}.Max" />.
    /// </summary>
    Box3D<float> Bounds { get; }

    /// <summary>
    /// Gets the number of points with which the given pointer is pointing at this target.
    /// </summary>
    /// <returns>The number of points.</returns>
    /// <remarks>
    /// A single "logical" pointer device may have many points, and can optionally represent multiple physical pointers
    /// as a single logical device - this is the case where a backend supports multiple mice to control an
    /// cursor on its "raw mouse input" target, but combines these all to a single point on its "windowed" target. This
    /// is also true for touch input - a touch screen is represented as a single touch device,
    /// where each finger is its own point.
    /// </remarks>
    int GetPointCount(IPointerDevice pointer);

    /// <summary>
    /// Gets a point with which the given pointer is pointing at this target.
    /// </summary>
    /// <param name="pointer">The pointer device.</param>
    /// <param name="point">
    /// The index of the point, between <c>0</c> and the number sourced from <see cref="GetPointCount" />.
    /// </param>
    /// <returns>The point at the given index with which the given pointer device is pointing at the target.</returns>
    TargetPoint GetPoint(IPointerDevice pointer, int point);
}