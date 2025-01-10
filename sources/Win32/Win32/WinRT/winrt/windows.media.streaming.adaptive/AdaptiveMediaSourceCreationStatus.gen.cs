// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AdaptiveMediaSourceCreationStatus
{
    AdaptiveMediaSourceCreationStatus_Success = 0,
    AdaptiveMediaSourceCreationStatus_ManifestDownloadFailure = 1,
    AdaptiveMediaSourceCreationStatus_ManifestParseFailure = 2,
    AdaptiveMediaSourceCreationStatus_UnsupportedManifestContentType = 3,
    AdaptiveMediaSourceCreationStatus_UnsupportedManifestVersion = 4,
    AdaptiveMediaSourceCreationStatus_UnsupportedManifestProfile = 5,
    AdaptiveMediaSourceCreationStatus_UnknownFailure = 6,
}
