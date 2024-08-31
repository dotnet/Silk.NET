namespace Silk.NET.Core;

/// <summary>
/// The Cocoa platform-specific handles.
/// </summary>
/// <param name="Window"><c>NSWindow</c>.</param>
public readonly record struct CocoaPlatformInfo(nint Window);
