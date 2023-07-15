// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CTL_ENTRY.xml' path='doc/member[@name="CTL_ENTRY"]/*'/>
public unsafe partial struct CTL_ENTRY
{
    /// <include file='CTL_ENTRY.xml' path='doc/member[@name="CTL_ENTRY.SubjectIdentifier"]/*'/>
    public CRYPT_DATA_BLOB SubjectIdentifier;
    /// <include file='CTL_ENTRY.xml' path='doc/member[@name="CTL_ENTRY.cAttribute"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cAttribute;
    /// <include file='CTL_ENTRY.xml' path='doc/member[@name="CTL_ENTRY.rgAttribute"]/*'/>
    [NativeTypeName("PCRYPT_ATTRIBUTE")]
    public CRYPT_ATTRIBUTE* rgAttribute;
}