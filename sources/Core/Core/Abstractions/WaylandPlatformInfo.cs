namespace Silk.NET.Core;

/// <summary>
/// The Wayland platform-specific handles.
/// </summary>
/// <param name="Display"><c>wl_display</c>.</param>
/// <param name="Surface"><c>wl_surface</c>.</param>
/// <param name="Next">
/// Any handles relevant to the next layer down from this platform in cases where wrapper APIs are used.
/// </param>
public readonly record struct WaylandPlatformInfo(
    nint Display,
    nint Surface,
    IPlatformInfo? Next = null
) : IPlatformInfo;
