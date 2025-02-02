namespace Silk.NET.Core;

/// <summary>
/// The Vivante platform-specific handles.
/// </summary>
/// <param name="Display"><c>EGLNativeDisplayType</c>.</param>
/// <param name="Window"><c>EGLNativeWindowType</c>.</param>
public readonly record struct VivantePlatformInfo(nint Display, nint Window);
