namespace Silk.NET.Core;

/// <summary>
/// The Cocoa platform-specific handles.
/// </summary>
/// <param name="Window"><c>NSWindow</c>.</param>
/// <param name="Next">
/// Any handles relevant to the next layer down from this platform in cases where wrapper APIs are used.
/// </param>
public readonly record struct CocoaPlatformInfo(nint Window, IPlatformInfo? Next = null)
    : IPlatformInfo;
