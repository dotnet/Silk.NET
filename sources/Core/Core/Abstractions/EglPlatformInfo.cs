namespace Silk.NET.Core;

/// <summary>
/// The EGL platform-specific handles.
/// </summary>
/// <param name="Display"><c>EglDisplay</c>.</param>
/// <param name="Surface"><c>EglSurface</c>.</param>
public readonly record struct EglPlatformInfo(nint Display, nint Surface);
