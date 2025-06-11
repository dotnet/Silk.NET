namespace Silk.NET.Input;

/// <summary>
/// Enumerates the cursor styles with which the desktop environment should render the cursor.
/// </summary>
[Flags]
public enum CursorStyles
{
    /// <summary>
    /// The cursor should be rendered using its default image.
    /// </summary>
    Default,

    /// <summary>
    /// The cursor should be rendered using an arrow cursor image.
    /// </summary>
    Arrow = 1 << 0,

    /// <summary>
    /// The cursor should be rendered using an I-beam cursor image, which is used to show where the text cursor appears
    /// when the mouse is clicked.
    /// </summary>
    IBeam = 1 << 1,

    /// <summary>
    /// The cursor should be rendered using a crosshair cursor image.
    /// </summary>
    Crosshair = 1 << 2,

    /// <summary>
    /// The cursor should be rendered using a hand cursor image, typically used when hovering over a web link.
    /// </summary>
    Hand = 1 << 3,

    /// <summary>
    /// The cursor should be rendered using a two-headed horizontal sizing cursor image.
    /// </summary>
    HResize = 1 << 4,

    /// <summary>
    /// The cursor should be rendered using a two-headed vertical sizing cursor image.
    /// </summary>
    VResize = 1 << 5,

    /// <summary>
    /// The cursor should not be rendered.
    /// </summary>
    /// <remarks>
    /// When <see cref="CursorModes.Unbounded"/> is used, the cursor ceases to exist anyway. As such, while the
    /// <see cref="ICursorConfiguration.Style"/> property may not reflect this (as it is retained across changes to
    /// <see cref="ICursorConfiguration.Mode"/> and just ignored when <see cref="CursorModes.Unbounded"/> is used),
    /// <see cref="ICursorConfiguration.Style"/> can be implied as being <see cref="CursorStyles.Hidden"/> when
    /// <see cref="CursorModes.Unbounded"/> is used.
    /// </remarks>
    Hidden = 1 << 6,

    /// <summary>
    /// The cursor should be rendered using a custom application-provided image.
    /// </summary>
    Custom = 1 << 7,
}