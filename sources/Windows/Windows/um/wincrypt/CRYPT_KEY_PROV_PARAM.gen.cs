// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_KEY_PROV_PARAM.xml' path='doc/member[@name="CRYPT_KEY_PROV_PARAM"]/*'/>
public unsafe partial struct CRYPT_KEY_PROV_PARAM
{
    /// <include file='CRYPT_KEY_PROV_PARAM.xml' path='doc/member[@name="CRYPT_KEY_PROV_PARAM.dwParam"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwParam;
    /// <include file='CRYPT_KEY_PROV_PARAM.xml' path='doc/member[@name="CRYPT_KEY_PROV_PARAM.pbData"]/*'/>
    public byte* pbData;
    /// <include file='CRYPT_KEY_PROV_PARAM.xml' path='doc/member[@name="CRYPT_KEY_PROV_PARAM.cbData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbData;
    /// <include file='CRYPT_KEY_PROV_PARAM.xml' path='doc/member[@name="CRYPT_KEY_PROV_PARAM.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}