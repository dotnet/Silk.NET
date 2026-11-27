namespace Silk.NET.Input;

/// <summary>
/// Enumerates the modes in which a mouse cursor can operate.
/// </summary>
/// <remarks>
/// <see cref="IPointerDevice"/> implementations for <see cref="IMouse"/> implementations typically have two
/// <see cref="IPointerDevice.Targets"/>:
/// <list type="bullet">
/// <item>
/// <term>Bounded <see cref="IPointerTarget"/></term>
/// <description>
/// An <see cref="IPointerTarget"/> that is finite, e.g. the
/// <see cref="IPointerTarget.Bounds"/> reflect the window client area or some other bounded region defined by the
/// cursor backend.
/// This target is used for every cursor mode except <see cref="Unbounded"/>.
/// </description>
/// </item>
/// <item>
/// <term>Unbounded <see cref="IPointerTarget"/></term>
/// <description>
/// An <see cref="IPointerTarget"/> that is unbounded and operates in an arbitrary coordinate space. This target is used
/// for <b>raw mouse mode</b> and points on this target represent the net mouse movement from a mouse. This
/// target is used when the <see cref="Unbounded"/> cursor mode is enabled. <see cref="IPointerTarget.Bounds"/> will
/// represent an infinitely large unbounded target.
/// </description>
/// </item>
/// </list>
/// </remarks>
[Flags]
public enum CursorModes
{
    /// <summary>
    /// The cursor is visible to the user and operating within the bounds of the <b>desktop environment</b>. The
    /// coordinates received are in window space, relative to the window's client area.
    /// The window's <see cref="IPointerTarget"/> is used.
    /// </summary>
    Normal = 1 << 0,

    /// <summary>
    /// The cursor is visible to the user but is constrained to the <b>window's client area</b>. The coordinates
    /// received are in window space, relative to the window's client area.
    /// The window's <see cref="IPointerTarget"/> is used.
    /// </summary>
    Confined = 1 << 1,

    /// <summary>
    /// The cursor is invisible to the user and is <b>unconstrained/unbounded</b>. The coordinates received are
    /// arbitrary values that have no bounds representing the net mouse movement since entering into this cursor mode.
    /// The unbounded <see cref="IPointerTarget"/> is used. This is the equivalent of <b>raw mouse mode</b>.
    /// </summary>
    Unbounded = 1 << 2,
}
