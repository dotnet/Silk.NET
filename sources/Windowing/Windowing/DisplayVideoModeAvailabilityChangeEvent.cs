namespace Silk.NET.Windowing;

/// <summary>
/// Contains properties pertaining to a change in the available video modes for a display.
/// </summary>
/// <param name="Surface">The surface owning the display.</param>
/// <param name="Display">The display for which the video mode availability changed.</param>
// I don't think we need to have a diff here either, why would old video modes be relevant?
public readonly record struct DisplayVideoModeAvailabilityChangeEvent(
    Surface Surface,
    IDisplay Display
);
