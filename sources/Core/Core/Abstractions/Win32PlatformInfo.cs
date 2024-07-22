namespace Silk.NET.Core;

/// <summary>
/// The Win32 platform-specific handles.
/// </summary>
/// <param name="Hwnd"><c>HWND</c>.</param>
/// <param name="HDC"><c>HDC</c>.</param>
/// <param name="HInstance"><c>HInstance</c>.</param>
/// <param name="Next">
/// Any handles relevant to the next layer down from this platform in cases where wrapper APIs are used.
/// </param>
public readonly record struct Win32PlatformInfo(
    nint Hwnd,
    nint HDC,
    nint HInstance,
    IPlatformInfo? Next = null
) : IPlatformInfo;
