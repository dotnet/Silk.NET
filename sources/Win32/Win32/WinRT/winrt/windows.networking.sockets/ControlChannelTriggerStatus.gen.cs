// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum ControlChannelTriggerStatus
{
    ControlChannelTriggerStatus_HardwareSlotRequested = 0,
    ControlChannelTriggerStatus_SoftwareSlotAllocated = 1,
    ControlChannelTriggerStatus_HardwareSlotAllocated = 2,
    ControlChannelTriggerStatus_PolicyError = 3,
    ControlChannelTriggerStatus_SystemError = 4,
    ControlChannelTriggerStatus_TransportDisconnected = 5,
    ControlChannelTriggerStatus_ServiceUnavailable = 6,
}
