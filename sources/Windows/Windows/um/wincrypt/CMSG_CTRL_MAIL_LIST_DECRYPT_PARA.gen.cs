// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='CMSG_CTRL_MAIL_LIST_DECRYPT_PARA.xml' path='doc/member[@name="CMSG_CTRL_MAIL_LIST_DECRYPT_PARA"]/*' />
public unsafe partial struct CMSG_CTRL_MAIL_LIST_DECRYPT_PARA
{
    /// <include file='CMSG_CTRL_MAIL_LIST_DECRYPT_PARA.xml' path='doc/member[@name="CMSG_CTRL_MAIL_LIST_DECRYPT_PARA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CMSG_CTRL_MAIL_LIST_DECRYPT_PARA.xml' path='doc/member[@name="CMSG_CTRL_MAIL_LIST_DECRYPT_PARA.hCryptProv"]/*' />
    public HCRYPTPROV hCryptProv;

    /// <include file='CMSG_CTRL_MAIL_LIST_DECRYPT_PARA.xml' path='doc/member[@name="CMSG_CTRL_MAIL_LIST_DECRYPT_PARA.pMailList"]/*' />
    [NativeTypeName("PCMSG_MAIL_LIST_RECIPIENT_INFO")]
    public CMSG_MAIL_LIST_RECIPIENT_INFO* pMailList;

    /// <include file='CMSG_CTRL_MAIL_LIST_DECRYPT_PARA.xml' path='doc/member[@name="CMSG_CTRL_MAIL_LIST_DECRYPT_PARA.dwRecipientIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRecipientIndex;

    /// <include file='CMSG_CTRL_MAIL_LIST_DECRYPT_PARA.xml' path='doc/member[@name="CMSG_CTRL_MAIL_LIST_DECRYPT_PARA.dwKeyChoice"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwKeyChoice;

    /// <include file='CMSG_CTRL_MAIL_LIST_DECRYPT_PARA.xml' path='doc/member[@name="CMSG_CTRL_MAIL_LIST_DECRYPT_PARA.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_wincrypt_L8146_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hKeyEncryptionKey"]/*' />
    [UnscopedRef]
    public ref HCRYPTKEY hKeyEncryptionKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.hKeyEncryptionKey;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pvKeyEncryptionKey"]/*' />
    [UnscopedRef]
    public ref void* pvKeyEncryptionKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pvKeyEncryptionKey;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hKeyEncryptionKey"]/*' />
        [FieldOffset(0)]
        public HCRYPTKEY hKeyEncryptionKey;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pvKeyEncryptionKey"]/*' />
        [FieldOffset(0)]
        public void* pvKeyEncryptionKey;
    }
}
