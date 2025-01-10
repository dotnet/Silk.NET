// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[NativeTypeName("DWORD")]
public enum CertKeyType : uint
{
    KeyTypeOther = 0,
    KeyTypeVirtualSmartCard = 1,
    KeyTypePhysicalSmartCard = 2,
    KeyTypePassport = 3,
    KeyTypePassportRemote = 4,
    KeyTypePassportSmartCard = 5,
    KeyTypeHardware = 6,
    KeyTypeSoftware = 7,
    KeyTypeSelfSigned = 8,
}
