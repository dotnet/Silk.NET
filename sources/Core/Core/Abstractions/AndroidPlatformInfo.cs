namespace Silk.NET.Core;

/// <summary>
/// The Android platform-specific handles.
/// </summary>
/// <param name="Window"><c>ANativeWindow*</c>.</param>
/// <param name="Surface"><c>EGLSurface</c>.</param>
/// <param name="Next">
/// Any handles relevant to the next layer down from this platform in cases where wrapper APIs are used.
/// </param>
public readonly record struct AndroidPlatformInfo(
    nint Window,
    nint Surface,
    IPlatformInfo? Next = null
) : IPlatformInfo;
