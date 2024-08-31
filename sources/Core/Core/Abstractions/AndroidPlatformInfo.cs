namespace Silk.NET.Core;

/// <summary>
/// The Android platform-specific handles.
/// </summary>
/// <param name="Window"><c>ANativeWindow*</c>.</param>
/// <param name="Surface"><c>EGLSurface</c>.</param>
public readonly record struct AndroidPlatformInfo(nint Window, nint Surface);
