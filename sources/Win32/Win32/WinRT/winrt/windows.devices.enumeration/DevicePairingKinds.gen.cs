// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum DevicePairingKinds : uint
{
    DevicePairingKinds_None = 0,
    DevicePairingKinds_ConfirmOnly = 0x1,
    DevicePairingKinds_DisplayPin = 0x2,
    DevicePairingKinds_ProvidePin = 0x4,
    DevicePairingKinds_ConfirmPinMatch = 0x8,
    DevicePairingKinds_ProvidePasswordCredential = 0x10,
    DevicePairingKinds_ProvideAddress = 0x20,
}
