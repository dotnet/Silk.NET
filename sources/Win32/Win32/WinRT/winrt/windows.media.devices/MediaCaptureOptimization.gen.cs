// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum MediaCaptureOptimization
{
    MediaCaptureOptimization_Default = 0,
    MediaCaptureOptimization_Quality = 1,
    MediaCaptureOptimization_Latency = 2,
    MediaCaptureOptimization_Power = 3,
    MediaCaptureOptimization_LatencyThenQuality = 4,
    MediaCaptureOptimization_LatencyThenPower = 5,
    MediaCaptureOptimization_PowerAndQuality = 6,
}
