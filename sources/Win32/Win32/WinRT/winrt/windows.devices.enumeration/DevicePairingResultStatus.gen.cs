// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum DevicePairingResultStatus
{
    DevicePairingResultStatus_Paired = 0,
    DevicePairingResultStatus_NotReadyToPair = 1,
    DevicePairingResultStatus_NotPaired = 2,
    DevicePairingResultStatus_AlreadyPaired = 3,
    DevicePairingResultStatus_ConnectionRejected = 4,
    DevicePairingResultStatus_TooManyConnections = 5,
    DevicePairingResultStatus_HardwareFailure = 6,
    DevicePairingResultStatus_AuthenticationTimeout = 7,
    DevicePairingResultStatus_AuthenticationNotAllowed = 8,
    DevicePairingResultStatus_AuthenticationFailure = 9,
    DevicePairingResultStatus_NoSupportedProfiles = 10,
    DevicePairingResultStatus_ProtectionLevelCouldNotBeMet = 11,
    DevicePairingResultStatus_AccessDenied = 12,
    DevicePairingResultStatus_InvalidCeremonyData = 13,
    DevicePairingResultStatus_PairingCanceled = 14,
    DevicePairingResultStatus_OperationAlreadyInProgress = 15,
    DevicePairingResultStatus_RequiredHandlerNotRegistered = 16,
    DevicePairingResultStatus_RejectedByHandler = 17,
    DevicePairingResultStatus_RemoteDeviceHasAssociation = 18,
    DevicePairingResultStatus_Failed = 19,
}
