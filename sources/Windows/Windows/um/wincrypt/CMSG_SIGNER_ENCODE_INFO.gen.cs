// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='CMSG_SIGNER_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNER_ENCODE_INFO"]/*'/>
public unsafe partial struct CMSG_SIGNER_ENCODE_INFO
{
    /// <include file='CMSG_SIGNER_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNER_ENCODE_INFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CMSG_SIGNER_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNER_ENCODE_INFO.pCertInfo"]/*'/>
    [NativeTypeName("PCERT_INFO")]
    public CERT_INFO* pCertInfo;
    /// <include file='CMSG_SIGNER_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNER_ENCODE_INFO.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wincrypt_L6743_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='CMSG_SIGNER_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNER_ENCODE_INFO.dwKeySpec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwKeySpec;
    /// <include file='CMSG_SIGNER_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNER_ENCODE_INFO.HashAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;
    /// <include file='CMSG_SIGNER_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNER_ENCODE_INFO.pvHashAuxInfo"]/*'/>
    public void* pvHashAuxInfo;
    /// <include file='CMSG_SIGNER_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNER_ENCODE_INFO.cAuthAttr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cAuthAttr;
    /// <include file='CMSG_SIGNER_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNER_ENCODE_INFO.rgAuthAttr"]/*'/>
    [NativeTypeName("PCRYPT_ATTRIBUTE")]
    public CRYPT_ATTRIBUTE* rgAuthAttr;
    /// <include file='CMSG_SIGNER_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNER_ENCODE_INFO.cUnauthAttr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cUnauthAttr;
    /// <include file='CMSG_SIGNER_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNER_ENCODE_INFO.rgUnauthAttr"]/*'/>
    [NativeTypeName("PCRYPT_ATTRIBUTE")]
    public CRYPT_ATTRIBUTE* rgUnauthAttr;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hCryptProv"]/*'/>
    [UnscopedRef]
    public ref HCRYPTPROV hCryptProv
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.hCryptProv;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hNCryptKey"]/*'/>
    [UnscopedRef]
    public ref nuint hNCryptKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.hNCryptKey;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hCryptProv"]/*'/>
        [FieldOffset(0)]
        public HCRYPTPROV hCryptProv;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hNCryptKey"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("NCRYPT_KEY_HANDLE")]
        public nuint hNCryptKey;
    }
}