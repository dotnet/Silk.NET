namespace Silk.NET.Core;

/// <summary>
/// The X11 platform-specific handles.
/// </summary>
/// <param name="Display"><c>X11Display</c>.</param>
/// <param name="Window"><c>X11Window</c>.</param>
public readonly record struct X11PlatformInfo(nint Display, nint Window);
