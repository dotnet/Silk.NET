namespace Silk.NET.Windowing;

/// <summary>
/// Provides the ability to configure displays on which the surface can render.
/// </summary>
public interface ISurfaceDisplay
{
    /// <summary>
    /// Gets or sets display on which the surface is currently rendering. If setting, <c>value</c> must be contained in
    /// <see cref="Available" />.
    /// </summary>
    IDisplay Current { get; set; }

    /// <summary>
    /// Gets a list of other displays that this surface can be moved to. If the surface cannot be programmatically moved
    /// to another display, it is expected that this shall return a single element list containing
    /// <see cref="Current" />.
    /// </summary>
    IReadOnlyList<IDisplay> Available { get; }

    /// <summary>
    /// Gets or sets the video mode with which the surface is being rendered to the display. If setting, <c>value</c>
    /// must be contained in <see cref="AvailableVideoModes" />.
    /// </summary>
    VideoMode VideoMode { get; set; }

    /// <summary>
    /// Gets a list of video modes with which the surface can be rendered. If the surface cannot programmatically change
    /// its video mode, it is expected that this shall return a single element list containing <see cref="VideoMode" />.
    /// </summary>
    IReadOnlyList<VideoMode> AvailableVideoModes { get; }

    /// <summary>
    /// An event raised when <see cref="Current" /> changes.
    /// </summary>
    event Action<DisplayChangeEvent>? CurrentDisplayChanged;

    /// <summary>
    /// An event raised when <see cref="Available" /> changes.
    /// </summary>
    event Action<DisplayAvailabilityChangeEvent>? AvailableChanged;

    /// <summary>
    /// An event raised when <see cref="AvailableVideoModes" /> changes.
    /// </summary>
    event Action<DisplayVideoModeAvailabilityChangeEvent>? AvailableVideoModesChanged;
}
