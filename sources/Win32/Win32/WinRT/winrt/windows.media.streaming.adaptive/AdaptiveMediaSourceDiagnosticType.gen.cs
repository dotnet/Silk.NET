// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AdaptiveMediaSourceDiagnosticType
{
    AdaptiveMediaSourceDiagnosticType_ManifestUnchangedUponReload = 0,
    AdaptiveMediaSourceDiagnosticType_ManifestMismatchUponReload = 1,
    AdaptiveMediaSourceDiagnosticType_ManifestSignaledEndOfLiveEventUponReload = 2,
    AdaptiveMediaSourceDiagnosticType_MediaSegmentSkipped = 3,
    AdaptiveMediaSourceDiagnosticType_ResourceNotFound = 4,
    AdaptiveMediaSourceDiagnosticType_ResourceTimedOut = 5,
    AdaptiveMediaSourceDiagnosticType_ResourceParsingError = 6,
    AdaptiveMediaSourceDiagnosticType_BitrateDisabled = 7,
    AdaptiveMediaSourceDiagnosticType_FatalMediaSourceError = 8,
}
