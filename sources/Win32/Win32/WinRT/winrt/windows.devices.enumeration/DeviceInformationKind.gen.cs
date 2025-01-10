// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum DeviceInformationKind
{
    DeviceInformationKind_Unknown = 0,
    DeviceInformationKind_DeviceInterface = 1,
    DeviceInformationKind_DeviceContainer = 2,
    DeviceInformationKind_Device = 3,
    DeviceInformationKind_DeviceInterfaceClass = 4,
    DeviceInformationKind_AssociationEndpoint = 5,
    DeviceInformationKind_AssociationEndpointContainer = 6,
    DeviceInformationKind_AssociationEndpointService = 7,
    DeviceInformationKind_DevicePanel = 8,
    DeviceInformationKind_AssociationEndpointProtocol = 9,
}
