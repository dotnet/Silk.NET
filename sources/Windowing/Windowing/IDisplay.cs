namespace Silk.NET.Windowing;

using Silk.NET.Maths;

/// <summary>
/// Represents a display on which a surface can be rendered.
/// </summary>
/// <remarks>
/// These objects may be shared with child windows created using <see cref="ISurfaceChildren" /> and vice versa i.e.
/// this object can be shared between all surfaces that share a common ancestor (the "root surface"). Beyond that, these
/// objects are not guaranteed to be valid across surfaces. This allows one event handler to enact changes on multiple
/// surfaces.
/// </remarks>
public interface IDisplay
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
