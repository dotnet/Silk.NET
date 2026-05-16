namespace Silk.NET.Input;

/// <summary>
/// Configuration for the behaviour of a mouse cursor.
/// </summary>
public interface ICursorConfiguration
{
    /// <summary>
    /// Gets a bitmask denoting the supported values for <see cref="Mode"/>.
    /// </summary>
    CursorModes SupportedModes { get; }

    /// <summary>
    /// Gets or sets the current cursor mode. Only one bit shall be set at a time.
    /// </summary>
    /// <remarks>
    /// Note that this property affects the <see cref="IPointerDevice.Targets"/> in use, see the
    /// <see cref="CursorModes"/> documentation for more info.
    /// </remarks>
    CursorModes Mode { get; set; }

    /// <summary>
    /// Gets a bitmask denoting the supported values for <see cref="Style"/>.
    /// </summary>
    CursorStyles SupportedStyles { get; }

    /// <summary>
    /// Gets or sets the current cursor style. Only one bit shall be set at a time. <see cref="CursorStyles.Custom"/>
    /// shall use the <see cref="Image"/> provided.
    /// </summary>
    /// <remarks>
    /// When <see cref="CursorModes.Unbounded"/> is used, the cursor ceases to exist anyway. As such, while the
    /// <see cref="ICursorConfiguration.Style"/> property may not reflect this (as it is retained across changes to
    /// <see cref="ICursorConfiguration.Mode"/> and just ignored when <see cref="CursorModes.Unbounded"/> is used),
    /// <see cref="ICursorConfiguration.Style"/> can be implied as being <see cref="CursorStyles.Hidden"/> when
    /// <see cref="CursorModes.Unbounded"/> is used.
    /// </remarks>
    CursorStyles Style { get; set; }

    /// <summary>
    /// Gets or sets the current custom cursor image. This has no effect if <see cref="CursorStyles.Custom"/> is not
    /// used, but the value is stored nonetheless for use when that is the case.
    /// </summary>
    CustomCursor Image { get; set; }
}