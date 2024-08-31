namespace Silk.NET.Core;

/// <summary>
/// The Win32 platform-specific handles.
/// </summary>
/// <param name="Hwnd"><c>HWND</c>.</param>
/// <param name="HDC"><c>HDC</c>.</param>
/// <param name="HInstance"><c>HInstance</c>.</param>
public readonly record struct Win32PlatformInfo(nint Hwnd, nint HDC, nint HInstance);
