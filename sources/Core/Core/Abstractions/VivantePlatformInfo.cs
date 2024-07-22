namespace Silk.NET.Core;

/// <summary>
/// The Vivante platform-specific handles.
/// </summary>
/// <param name="Display"><c>EGLNativeDisplayType</c>.</param>
/// <param name="Window"><c>EGLNativeWindowType</c>.</param>
/// <param name="Next">
/// Any handles relevant to the next layer down from this platform in cases where wrapper APIs are used.
/// </param>
public readonly record struct VivantePlatformInfo(
    nint Display,
    nint Window,
    IPlatformInfo? Next = null
) : IPlatformInfo;
