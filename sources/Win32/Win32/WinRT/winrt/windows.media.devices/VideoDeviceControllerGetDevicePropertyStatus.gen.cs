// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum VideoDeviceControllerGetDevicePropertyStatus
{
    VideoDeviceControllerGetDevicePropertyStatus_Success = 0,
    VideoDeviceControllerGetDevicePropertyStatus_UnknownFailure = 1,
    VideoDeviceControllerGetDevicePropertyStatus_BufferTooSmall = 2,
    VideoDeviceControllerGetDevicePropertyStatus_NotSupported = 3,
    VideoDeviceControllerGetDevicePropertyStatus_DeviceNotAvailable = 4,
    VideoDeviceControllerGetDevicePropertyStatus_MaxPropertyValueSizeTooSmall = 5,
    VideoDeviceControllerGetDevicePropertyStatus_MaxPropertyValueSizeRequired = 6,
}
