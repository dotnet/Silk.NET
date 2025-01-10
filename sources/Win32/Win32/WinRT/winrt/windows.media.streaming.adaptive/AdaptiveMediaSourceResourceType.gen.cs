// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AdaptiveMediaSourceResourceType
{
    AdaptiveMediaSourceResourceType_Manifest = 0,
    AdaptiveMediaSourceResourceType_InitializationSegment = 1,
    AdaptiveMediaSourceResourceType_MediaSegment = 2,
    AdaptiveMediaSourceResourceType_Key = 3,
    AdaptiveMediaSourceResourceType_InitializationVector = 4,
    AdaptiveMediaSourceResourceType_MediaSegmentIndex = 5,
}
