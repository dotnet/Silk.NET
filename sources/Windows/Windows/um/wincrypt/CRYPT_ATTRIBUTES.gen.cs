// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_ATTRIBUTES.xml' path='doc/member[@name="CRYPT_ATTRIBUTES"]/*'/>
public unsafe partial struct CRYPT_ATTRIBUTES
{
    /// <include file='CRYPT_ATTRIBUTES.xml' path='doc/member[@name="CRYPT_ATTRIBUTES.cAttr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cAttr;
    /// <include file='CRYPT_ATTRIBUTES.xml' path='doc/member[@name="CRYPT_ATTRIBUTES.rgAttr"]/*'/>
    [NativeTypeName("PCRYPT_ATTRIBUTE")]
    public CRYPT_ATTRIBUTE* rgAttr;
}