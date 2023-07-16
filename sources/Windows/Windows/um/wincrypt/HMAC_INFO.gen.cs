// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HMAC_INFO.xml' path='doc/member[@name="HMAC_INFO"]/*'/>
public unsafe partial struct HMAC_INFO
{
    /// <include file='HMAC_INFO.xml' path='doc/member[@name="HMAC_INFO.HashAlgid"]/*'/>
    [NativeTypeName("ALG_ID")]
    public uint HashAlgid;
    /// <include file='HMAC_INFO.xml' path='doc/member[@name="HMAC_INFO.pbInnerString"]/*'/>
    public byte* pbInnerString;
    /// <include file='HMAC_INFO.xml' path='doc/member[@name="HMAC_INFO.cbInnerString"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbInnerString;
    /// <include file='HMAC_INFO.xml' path='doc/member[@name="HMAC_INFO.pbOuterString"]/*'/>
    public byte* pbOuterString;
    /// <include file='HMAC_INFO.xml' path='doc/member[@name="HMAC_INFO.cbOuterString"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbOuterString;
}