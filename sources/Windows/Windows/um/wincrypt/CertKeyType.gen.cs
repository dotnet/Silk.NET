// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CertKeyType.xml' path='doc/member[@name="CertKeyType"]/*'/>
[NativeTypeName("DWORD")]
public enum CertKeyType : uint
{
    /// <include file='CertKeyType.xml' path='doc/member[@name="CertKeyType.KeyTypeOther"]/*'/>
    KeyTypeOther = 0,
    /// <include file='CertKeyType.xml' path='doc/member[@name="CertKeyType.KeyTypeVirtualSmartCard"]/*'/>
    KeyTypeVirtualSmartCard = 1,
    /// <include file='CertKeyType.xml' path='doc/member[@name="CertKeyType.KeyTypePhysicalSmartCard"]/*'/>
    KeyTypePhysicalSmartCard = 2,
    /// <include file='CertKeyType.xml' path='doc/member[@name="CertKeyType.KeyTypePassport"]/*'/>
    KeyTypePassport = 3,
    /// <include file='CertKeyType.xml' path='doc/member[@name="CertKeyType.KeyTypePassportRemote"]/*'/>
    KeyTypePassportRemote = 4,
    /// <include file='CertKeyType.xml' path='doc/member[@name="CertKeyType.KeyTypePassportSmartCard"]/*'/>
    KeyTypePassportSmartCard = 5,
    /// <include file='CertKeyType.xml' path='doc/member[@name="CertKeyType.KeyTypeHardware"]/*'/>
    KeyTypeHardware = 6,
    /// <include file='CertKeyType.xml' path='doc/member[@name="CertKeyType.KeyTypeSoftware"]/*'/>
    KeyTypeSoftware = 7,
    /// <include file='CertKeyType.xml' path='doc/member[@name="CertKeyType.KeyTypeSelfSigned"]/*'/>
    KeyTypeSelfSigned = 8,
}