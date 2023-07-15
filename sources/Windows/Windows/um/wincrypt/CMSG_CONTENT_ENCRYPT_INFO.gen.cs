// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='CMSG_CONTENT_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_CONTENT_ENCRYPT_INFO"]/*'/>
public unsafe partial struct CMSG_CONTENT_ENCRYPT_INFO
{
    /// <include file='CMSG_CONTENT_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_CONTENT_ENCRYPT_INFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CMSG_CONTENT_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_CONTENT_ENCRYPT_INFO.hCryptProv"]/*'/>
    public HCRYPTPROV_LEGACY hCryptProv;
    /// <include file='CMSG_CONTENT_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_CONTENT_ENCRYPT_INFO.ContentEncryptionAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER ContentEncryptionAlgorithm;
    /// <include file='CMSG_CONTENT_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_CONTENT_ENCRYPT_INFO.pvEncryptionAuxInfo"]/*'/>
    public void* pvEncryptionAuxInfo;
    /// <include file='CMSG_CONTENT_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_CONTENT_ENCRYPT_INFO.cRecipients"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cRecipients;
    /// <include file='CMSG_CONTENT_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_CONTENT_ENCRYPT_INFO.rgCmsRecipients"]/*'/>
    [NativeTypeName("PCMSG_RECIPIENT_ENCODE_INFO")]
    public CMSG_RECIPIENT_ENCODE_INFO* rgCmsRecipients;
    /// <include file='CMSG_CONTENT_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_CONTENT_ENCRYPT_INFO.pfnAlloc"]/*'/>
    [NativeTypeName("PFN_CMSG_ALLOC")]
    public delegate* unmanaged<nuint, void*> pfnAlloc;
    /// <include file='CMSG_CONTENT_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_CONTENT_ENCRYPT_INFO.pfnFree"]/*'/>
    [NativeTypeName("PFN_CMSG_FREE")]
    public delegate* unmanaged<void*, void> pfnFree;
    /// <include file='CMSG_CONTENT_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_CONTENT_ENCRYPT_INFO.dwEncryptFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwEncryptFlags;
    /// <include file='CMSG_CONTENT_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_CONTENT_ENCRYPT_INFO.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wincrypt_L8453_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='CMSG_CONTENT_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_CONTENT_ENCRYPT_INFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='CMSG_CONTENT_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_CONTENT_ENCRYPT_INFO.fCNG"]/*'/>
    public BOOL fCNG;
    /// <include file='CMSG_CONTENT_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_CONTENT_ENCRYPT_INFO.pbCNGContentEncryptKeyObject"]/*'/>
    public byte* pbCNGContentEncryptKeyObject;
    /// <include file='CMSG_CONTENT_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_CONTENT_ENCRYPT_INFO.pbContentEncryptKey"]/*'/>
    public byte* pbContentEncryptKey;
    /// <include file='CMSG_CONTENT_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_CONTENT_ENCRYPT_INFO.cbContentEncryptKey"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbContentEncryptKey;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hContentEncryptKey"]/*'/>
    [UnscopedRef]
    public ref HCRYPTKEY hContentEncryptKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.hContentEncryptKey;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hCNGContentEncryptKey"]/*'/>
    [UnscopedRef]
    public ref void* hCNGContentEncryptKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.hCNGContentEncryptKey;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hContentEncryptKey"]/*'/>
        [FieldOffset(0)]
        public HCRYPTKEY hContentEncryptKey;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hCNGContentEncryptKey"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("BCRYPT_KEY_HANDLE")]
        public void* hCNGContentEncryptKey;
    }
}