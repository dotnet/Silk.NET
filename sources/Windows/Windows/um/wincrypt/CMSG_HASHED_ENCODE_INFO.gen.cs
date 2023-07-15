// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CMSG_HASHED_ENCODE_INFO.xml' path='doc/member[@name="CMSG_HASHED_ENCODE_INFO"]/*'/>
public unsafe partial struct CMSG_HASHED_ENCODE_INFO
{
    /// <include file='CMSG_HASHED_ENCODE_INFO.xml' path='doc/member[@name="CMSG_HASHED_ENCODE_INFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CMSG_HASHED_ENCODE_INFO.xml' path='doc/member[@name="CMSG_HASHED_ENCODE_INFO.hCryptProv"]/*'/>
    public HCRYPTPROV_LEGACY hCryptProv;
    /// <include file='CMSG_HASHED_ENCODE_INFO.xml' path='doc/member[@name="CMSG_HASHED_ENCODE_INFO.HashAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;
    /// <include file='CMSG_HASHED_ENCODE_INFO.xml' path='doc/member[@name="CMSG_HASHED_ENCODE_INFO.pvHashAuxInfo"]/*'/>
    public void* pvHashAuxInfo;
}