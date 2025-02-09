namespace Silk.NET.Core;

/// <summary>
/// The EGL platform-specific handles.
/// </summary>
/// <param name="Display"><c>EGLDisplay</c>.</param>
/// <param name="Surface"><c>EGLSurface</c>.</param>
public readonly record struct EGLPlatformInfo(nint Display, nint Surface);
