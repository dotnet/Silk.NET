// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum GattProtectionLevel
{
    GattProtectionLevel_Plain = 0,
    GattProtectionLevel_AuthenticationRequired = 1,
    GattProtectionLevel_EncryptionRequired = 2,
    GattProtectionLevel_EncryptionAndAuthenticationRequired = 3,
}
