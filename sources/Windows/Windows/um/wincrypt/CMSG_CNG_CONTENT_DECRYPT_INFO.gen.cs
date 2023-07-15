// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CMSG_CNG_CONTENT_DECRYPT_INFO.xml' path='doc/member[@name="CMSG_CNG_CONTENT_DECRYPT_INFO"]/*'/>
public unsafe partial struct CMSG_CNG_CONTENT_DECRYPT_INFO
{
    /// <include file='CMSG_CNG_CONTENT_DECRYPT_INFO.xml' path='doc/member[@name="CMSG_CNG_CONTENT_DECRYPT_INFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CMSG_CNG_CONTENT_DECRYPT_INFO.xml' path='doc/member[@name="CMSG_CNG_CONTENT_DECRYPT_INFO.ContentEncryptionAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER ContentEncryptionAlgorithm;
    /// <include file='CMSG_CNG_CONTENT_DECRYPT_INFO.xml' path='doc/member[@name="CMSG_CNG_CONTENT_DECRYPT_INFO.pfnAlloc"]/*'/>
    [NativeTypeName("PFN_CMSG_ALLOC")]
    public delegate* unmanaged<nuint, void*> pfnAlloc;
    /// <include file='CMSG_CNG_CONTENT_DECRYPT_INFO.xml' path='doc/member[@name="CMSG_CNG_CONTENT_DECRYPT_INFO.pfnFree"]/*'/>
    [NativeTypeName("PFN_CMSG_FREE")]
    public delegate* unmanaged<void*, void> pfnFree;
    /// <include file='CMSG_CNG_CONTENT_DECRYPT_INFO.xml' path='doc/member[@name="CMSG_CNG_CONTENT_DECRYPT_INFO.hNCryptKey"]/*'/>
    [NativeTypeName("NCRYPT_KEY_HANDLE")]
    public nuint hNCryptKey;
    /// <include file='CMSG_CNG_CONTENT_DECRYPT_INFO.xml' path='doc/member[@name="CMSG_CNG_CONTENT_DECRYPT_INFO.pbContentEncryptKey"]/*'/>
    public byte* pbContentEncryptKey;
    /// <include file='CMSG_CNG_CONTENT_DECRYPT_INFO.xml' path='doc/member[@name="CMSG_CNG_CONTENT_DECRYPT_INFO.cbContentEncryptKey"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbContentEncryptKey;
    /// <include file='CMSG_CNG_CONTENT_DECRYPT_INFO.xml' path='doc/member[@name="CMSG_CNG_CONTENT_DECRYPT_INFO.hCNGContentEncryptKey"]/*'/>
    [NativeTypeName("BCRYPT_KEY_HANDLE")]
    public void* hCNGContentEncryptKey;
    /// <include file='CMSG_CNG_CONTENT_DECRYPT_INFO.xml' path='doc/member[@name="CMSG_CNG_CONTENT_DECRYPT_INFO.pbCNGContentEncryptKeyObject"]/*'/>
    public byte* pbCNGContentEncryptKeyObject;
}