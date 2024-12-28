namespace Silk.NET.Core;

/// <summary>
/// The Wayland platform-specific handles.
/// </summary>
/// <param name="Display"><c>wl_display</c>.</param>
/// <param name="Surface"><c>wl_surface</c>.</param>
public readonly record struct WaylandPlatformInfo(nint Display, nint Surface);
