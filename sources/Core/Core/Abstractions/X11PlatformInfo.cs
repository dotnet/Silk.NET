namespace Silk.NET.Core;

/// <summary>
/// The X11 platform-specific handles.
/// </summary>
/// <param name="Display"><c>X11Display</c>.</param>
/// <param name="Window"><c>X11Window</c>.</param>
/// <param name="Next">
/// Any handles relevant to the next layer down from this platform in cases where wrapper APIs are used.
/// </param>
public readonly record struct X11PlatformInfo(nint Display, nint Window, IPlatformInfo? Next = null)
    : IPlatformInfo;
