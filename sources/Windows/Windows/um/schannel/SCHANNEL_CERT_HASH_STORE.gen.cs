// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SCHANNEL_CERT_HASH_STORE.xml' path='doc/member[@name="SCHANNEL_CERT_HASH_STORE"]/*'/>
public unsafe partial struct SCHANNEL_CERT_HASH_STORE
{
    /// <include file='SCHANNEL_CERT_HASH_STORE.xml' path='doc/member[@name="SCHANNEL_CERT_HASH_STORE.dwLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLength;
    /// <include file='SCHANNEL_CERT_HASH_STORE.xml' path='doc/member[@name="SCHANNEL_CERT_HASH_STORE.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='SCHANNEL_CERT_HASH_STORE.xml' path='doc/member[@name="SCHANNEL_CERT_HASH_STORE.hProv"]/*'/>
    public HCRYPTPROV hProv;
    /// <include file='SCHANNEL_CERT_HASH_STORE.xml' path='doc/member[@name="SCHANNEL_CERT_HASH_STORE.ShaHash"]/*'/>
    [NativeTypeName("BYTE[20]")]
    public fixed byte ShaHash[20];
    /// <include file='SCHANNEL_CERT_HASH_STORE.xml' path='doc/member[@name="SCHANNEL_CERT_HASH_STORE.pwszStoreName"]/*'/>
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort pwszStoreName[128];
}