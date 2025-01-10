// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum CaptureSceneMode
{
    CaptureSceneMode_Auto = 0,
    CaptureSceneMode_Manual = 1,
    CaptureSceneMode_Macro = 2,
    CaptureSceneMode_Portrait = 3,
    CaptureSceneMode_Sport = 4,
    CaptureSceneMode_Snow = 5,
    CaptureSceneMode_Night = 6,
    CaptureSceneMode_Beach = 7,
    CaptureSceneMode_Sunset = 8,
    CaptureSceneMode_Candlelight = 9,
    CaptureSceneMode_Landscape = 10,
    CaptureSceneMode_NightPortrait = 11,
    CaptureSceneMode_Backlit = 12,
}
