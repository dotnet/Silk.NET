// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO"]/*'/>
public unsafe partial struct CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO
{
    /// <include file='CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.KeyEncryptionAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;
    /// <include file='CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.pvKeyEncryptionAuxInfo"]/*'/>
    public void* pvKeyEncryptionAuxInfo;
    /// <include file='CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.hCryptProv"]/*'/>
    public HCRYPTPROV hCryptProv;
    /// <include file='CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.dwKeyChoice"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwKeyChoice;
    /// <include file='CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wincrypt_L7002_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.KeyId"]/*'/>
    public CRYPT_DATA_BLOB KeyId;
    /// <include file='CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.Date"]/*'/>
    public FILETIME Date;
    /// <include file='CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO.pOtherAttr"]/*'/>
    [NativeTypeName("PCRYPT_ATTRIBUTE_TYPE_VALUE")]
    public CRYPT_ATTRIBUTE_TYPE_VALUE* pOtherAttr;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hKeyEncryptionKey"]/*'/>
    [UnscopedRef]
    public ref HCRYPTKEY hKeyEncryptionKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.hKeyEncryptionKey;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pvKeyEncryptionKey"]/*'/>
    [UnscopedRef]
    public ref void* pvKeyEncryptionKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pvKeyEncryptionKey;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hKeyEncryptionKey"]/*'/>
        [FieldOffset(0)]
        public HCRYPTKEY hKeyEncryptionKey;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pvKeyEncryptionKey"]/*'/>
        [FieldOffset(0)]
        public void* pvKeyEncryptionKey;
    }
}