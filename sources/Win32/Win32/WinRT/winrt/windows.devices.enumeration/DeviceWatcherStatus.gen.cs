// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum DeviceWatcherStatus
{
    DeviceWatcherStatus_Created = 0,
    DeviceWatcherStatus_Started = 1,
    DeviceWatcherStatus_EnumerationCompleted = 2,
    DeviceWatcherStatus_Stopping = 3,
    DeviceWatcherStatus_Stopped = 4,
    DeviceWatcherStatus_Aborted = 5,
}
