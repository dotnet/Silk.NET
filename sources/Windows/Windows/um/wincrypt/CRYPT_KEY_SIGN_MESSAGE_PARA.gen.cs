// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_KEY_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_KEY_SIGN_MESSAGE_PARA"]/*'/>
public unsafe partial struct CRYPT_KEY_SIGN_MESSAGE_PARA
{
    /// <include file='CRYPT_KEY_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_KEY_SIGN_MESSAGE_PARA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CRYPT_KEY_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_KEY_SIGN_MESSAGE_PARA.dwMsgAndCertEncodingType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMsgAndCertEncodingType;
    /// <include file='CRYPT_KEY_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_KEY_SIGN_MESSAGE_PARA.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wincrypt_L16172_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='CRYPT_KEY_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_KEY_SIGN_MESSAGE_PARA.dwKeySpec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwKeySpec;
    /// <include file='CRYPT_KEY_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_KEY_SIGN_MESSAGE_PARA.HashAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;
    /// <include file='CRYPT_KEY_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_KEY_SIGN_MESSAGE_PARA.pvHashAuxInfo"]/*'/>
    public void* pvHashAuxInfo;
    /// <include file='CRYPT_KEY_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_KEY_SIGN_MESSAGE_PARA.PubKeyAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER PubKeyAlgorithm;
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