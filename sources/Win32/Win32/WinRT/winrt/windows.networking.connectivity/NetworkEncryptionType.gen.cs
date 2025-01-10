// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum NetworkEncryptionType
{
    NetworkEncryptionType_None = 0,
    NetworkEncryptionType_Unknown = 1,
    NetworkEncryptionType_Wep = 2,
    NetworkEncryptionType_Wep40 = 3,
    NetworkEncryptionType_Wep104 = 4,
    NetworkEncryptionType_Tkip = 5,
    NetworkEncryptionType_Ccmp = 6,
    NetworkEncryptionType_WpaUseGroup = 7,
    NetworkEncryptionType_RsnUseGroup = 8,
    NetworkEncryptionType_Ihv = 9,
    NetworkEncryptionType_Gcmp = 10,
    NetworkEncryptionType_Gcmp256 = 11,
}
