namespace Silk.NET.Core;

/// <summary>
/// The EGL platform-specific handles.
/// </summary>
/// <param name="Display"><c>EGLDisplay</c>.</param>
/// <param name="Surface"><c>EGLSurface</c>.</param>
/// <param name="Next">
/// Any handles relevant to the next layer down from this platform in cases where wrapper APIs are used.
/// </param>
public readonly record struct EGLPlatformInfo(
    nint Display,
    nint Surface,
    IPlatformInfo? Next = null
) : IPlatformInfo;
