namespace Silk.NET.Core;

/// <summary>
/// The WinRT platform-specific handles.
/// </summary>
/// <param name="Inspectable"><c>IInspectable</c>.</param>
/// <param name="Next">
/// Any handles relevant to the next layer down from this platform in cases where wrapper APIs are used.
/// </param>
public readonly record struct WinRTPlatformInfo(nint Inspectable, IPlatformInfo? Next = null)
    : IPlatformInfo;
