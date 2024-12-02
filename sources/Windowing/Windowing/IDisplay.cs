using System.Numerics;

namespace Silk.NET.Windowing;

using Silk.NET.Maths;

/// <summary>
/// Represents a display on which a surface can be rendered.
/// </summary>
/// <remarks>
/// Each surface shall get its own <see cref="IDisplay" /> object for each display. This is primarily to ensure that
/// users get events dispatched with the surface they expect depending on which <see cref="ISurfaceDisplay" /> the
/// <see cref="IDisplay" /> was sourced from. However, display objects can be somewhat shared between all surfaces that
/// share a common ancestor (the "root surface"). Specifically, an object at a given index in
/// <see cref="ISurfaceDisplay.Available" /> on one surface shall be equatable to the object sourced from the same index
/// in <see cref="ISurfaceDisplay.Available" /> on another surface with the same root surface. Furthermore,
/// <see cref="ISurfaceDisplay.Current" /> on one surface shall be assignable to an <see cref="IDisplay" /> object
/// sourced from another surface with the same root surface, where <see cref="ISurfaceDisplay.Current" /> shall lookup
/// the equivalent <see cref="IDisplay" /> object from its <see cref="ISurfaceDisplay.Available" /> displays upon
/// assignment.
/// </remarks>
public interface IDisplay : IEquatable<IDisplay>
{
    /// <summary>
    /// Gets the position and resolution of the monitor in screen space.
    /// </summary>
    Rectangle<float> Bounds { get; }

    /// <summary>
    /// Gets the area within <see cref="Bounds" /> where surfaces are <i>intended</i> to be drawn.
    /// </summary>
    /// <remarks>
    /// This typically is the area left once you account for things like the menu bar and taskbar.
    /// </remarks>
    Rectangle<float> WorkArea { get; }

    /// <summary>
    /// Gets a list of video modes known to be available when this display is <see cref="ISurfaceDisplay.Current" />.
    /// It may be the case that a list of video modes can't be determined until that's the case.
    /// </summary>
    IReadOnlyList<VideoMode>? KnownVideoModes { get; }

    /// <summary>
    /// Gets a value indicating whether the user has designated this display their primary display.
    /// </summary>
    bool IsPrimary { get; }

    /// <summary>
    /// Gets a colloquial name for the display. This may change, but hopefully not to something the end user won't recognise.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// An event raised when <see cref="Bounds" /> and/or <see cref="WorkArea" /> changes.
    /// </summary>
    event Action<DisplayCoordinatesEvent>? CoordinatesChanged;

    /// <summary>
    /// An event raised when <see cref="KnownVideoModes" /> changes.
    /// </summary>
    event Action<DisplayVideoModeAvailabilityChangeEvent>? KnownVideoModesChanged;
}
