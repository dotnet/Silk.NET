// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AdaptiveMediaSourceDownloadBitrateChangedReason
{
    AdaptiveMediaSourceDownloadBitrateChangedReason_SufficientInboundBitsPerSecond = 0,
    AdaptiveMediaSourceDownloadBitrateChangedReason_InsufficientInboundBitsPerSecond = 1,
    AdaptiveMediaSourceDownloadBitrateChangedReason_LowBufferLevel = 2,
    AdaptiveMediaSourceDownloadBitrateChangedReason_PositionChanged = 3,
    AdaptiveMediaSourceDownloadBitrateChangedReason_TrackSelectionChanged = 4,
    AdaptiveMediaSourceDownloadBitrateChangedReason_DesiredBitratesChanged = 5,
    AdaptiveMediaSourceDownloadBitrateChangedReason_ErrorInPreviousBitrate = 6,
}
