namespace Silk.NET.Windowing;

/// <summary>
/// Provides information pertaining to the surface's graphical scaling.
/// </summary>
/// <remarks>
/// <see cref="Content" /> is typically used to scale UI elements to the correct size for the end user.
/// <see cref="PixelDensity" /> on the other hand is used to scale the entire application to cover the entire client
/// area in cases where the window client size is smaller than the actual drawable size (i.e. it is high density).
/// If scaling content for legibility and scaling the application's rendering as a whole are not needed to be separated,
/// it is recommended to use <see cref="Draw" />. Implementations shall always request a high density surface if
/// given the choice, to account for the platforms where applications may not be able to opt-out of high density.
/// </remarks>
public interface ISurfaceScale
{
    /// <summary>
    /// Gets the factor with which the application should scale its content to make the content more legible for the
    /// user. This has no influence on <see cref="Surface.DrawableSize" />.
    /// </summary>
    /// <seealso cref="Draw" />
    float Content { get; }

    /// <summary>
    /// Gets the suggested amplification factor when drawing in terms of <see cref="Surface.DrawableSize" />. This
    /// represents the scale from the pixel resolution to the desired content size, and is typically the multiplication
    /// of <see cref="PixelDensity" /> and <see cref="Content" />.
    /// </summary>
    /// <remarks>
    /// For example, if <see cref="PixelDensity" /> is <c>2.0</c> (i.e. there are 2 pixels per screen coordinate)
    /// <i>and</i> the window manager requests that applications scale their content up by <c>2.0</c> to meet the user's
    /// settings as per <see cref="Content" />, this would be <c>4.0</c>. This is because we're scaling once to
    /// account for the fact that the application has twice the amount of pixels available to it for the given window
    /// size, and then scaling again so that what we are drawing appears zoomed in as per the user's request. Note that
    /// it is rarely the case that an operating system employs both dense pixels <i>and</i> content scale. macOS for
    /// instance, instead of setting <see cref="Content" />, opts to scale the resolution in the cases where the
    /// user wants magnified visuals instead of having the applications scale their content; whereas Windows sets
    /// <see cref="Content" /> and instead always keeps <see cref="PixelDensity" /> as <c>1.0</c>. This is down
    /// to philosophical differences between the window coordinate systems on platforms as to whether they prefer to
    /// deal in physical device pixels or physical content sizes.
    /// </remarks>
    float Draw { get; }

    /// <summary>
    /// Gets the ratio of pixels rendered to window size. This shall be equivalent to
    /// <see cref="Surface.DrawableSize" /> divided by <see cref="ISurfaceWindow.ClientSize" />.
    /// </summary>
    /// <seealso cref="Draw" />
    float PixelDensity { get; }

    /// <summary>
    /// An event raised when any scale factor changes.
    /// </summary>
    public event Action<ScaleChangedEvent>? Changed;
}
