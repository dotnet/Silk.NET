// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum DeviceUnpairingResultStatus
{
    DeviceUnpairingResultStatus_Unpaired = 0,
    DeviceUnpairingResultStatus_AlreadyUnpaired = 1,
    DeviceUnpairingResultStatus_OperationAlreadyInProgress = 2,
    DeviceUnpairingResultStatus_AccessDenied = 3,
    DeviceUnpairingResultStatus_Failed = 4,
}
