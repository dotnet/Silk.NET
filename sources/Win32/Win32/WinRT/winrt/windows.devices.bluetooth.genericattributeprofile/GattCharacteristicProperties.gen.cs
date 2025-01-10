// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum GattCharacteristicProperties : uint
{
    GattCharacteristicProperties_None = 0,
    GattCharacteristicProperties_Broadcast = 0x1,
    GattCharacteristicProperties_Read = 0x2,
    GattCharacteristicProperties_WriteWithoutResponse = 0x4,
    GattCharacteristicProperties_Write = 0x8,
    GattCharacteristicProperties_Notify = 0x10,
    GattCharacteristicProperties_Indicate = 0x20,
    GattCharacteristicProperties_AuthenticatedSignedWrites = 0x40,
    GattCharacteristicProperties_ExtendedProperties = 0x80,
    GattCharacteristicProperties_ReliableWrites = 0x100,
    GattCharacteristicProperties_WritableAuxiliaries = 0x200,
}
