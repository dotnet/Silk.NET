// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AppBroadcastCameraOverlayLocation
{
    AppBroadcastCameraOverlayLocation_TopLeft = 0,
    AppBroadcastCameraOverlayLocation_TopCenter = 1,
    AppBroadcastCameraOverlayLocation_TopRight = 2,
    AppBroadcastCameraOverlayLocation_MiddleLeft = 3,
    AppBroadcastCameraOverlayLocation_MiddleCenter = 4,
    AppBroadcastCameraOverlayLocation_MiddleRight = 5,
    AppBroadcastCameraOverlayLocation_BottomLeft = 6,
    AppBroadcastCameraOverlayLocation_BottomCenter = 7,
    AppBroadcastCameraOverlayLocation_BottomRight = 8,
}
