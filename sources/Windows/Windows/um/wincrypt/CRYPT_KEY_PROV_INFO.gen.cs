// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_KEY_PROV_INFO.xml' path='doc/member[@name="CRYPT_KEY_PROV_INFO"]/*'/>
public unsafe partial struct CRYPT_KEY_PROV_INFO
{
    /// <include file='CRYPT_KEY_PROV_INFO.xml' path='doc/member[@name="CRYPT_KEY_PROV_INFO.pwszContainerName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pwszContainerName;
    /// <include file='CRYPT_KEY_PROV_INFO.xml' path='doc/member[@name="CRYPT_KEY_PROV_INFO.pwszProvName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pwszProvName;
    /// <include file='CRYPT_KEY_PROV_INFO.xml' path='doc/member[@name="CRYPT_KEY_PROV_INFO.dwProvType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwProvType;
    /// <include file='CRYPT_KEY_PROV_INFO.xml' path='doc/member[@name="CRYPT_KEY_PROV_INFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='CRYPT_KEY_PROV_INFO.xml' path='doc/member[@name="CRYPT_KEY_PROV_INFO.cProvParam"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cProvParam;
    /// <include file='CRYPT_KEY_PROV_INFO.xml' path='doc/member[@name="CRYPT_KEY_PROV_INFO.rgProvParam"]/*'/>
    [NativeTypeName("PCRYPT_KEY_PROV_PARAM")]
    public CRYPT_KEY_PROV_PARAM* rgProvParam;
    /// <include file='CRYPT_KEY_PROV_INFO.xml' path='doc/member[@name="CRYPT_KEY_PROV_INFO.dwKeySpec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwKeySpec;
}