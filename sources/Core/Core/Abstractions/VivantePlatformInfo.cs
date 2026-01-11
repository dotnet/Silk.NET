namespace Silk.NET.Core;

/// <summary>
/// The Vivante platform-specific handles.
/// </summary>
/// <param name="Display"><c>EglNativeDisplayType</c>.</param>
/// <param name="Window"><c>EglNativeWindowType</c>.</param>
public readonly record struct VivantePlatformInfo(nint Display, nint Window);
