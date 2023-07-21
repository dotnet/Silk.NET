// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='CMSG_KEY_AGREE_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_ENCRYPT_INFO"]/*' />
public unsafe partial struct CMSG_KEY_AGREE_ENCRYPT_INFO
{
    /// <include file='CMSG_KEY_AGREE_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_ENCRYPT_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CMSG_KEY_AGREE_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_ENCRYPT_INFO.dwRecipientIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRecipientIndex;

    /// <include file='CMSG_KEY_AGREE_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_ENCRYPT_INFO.KeyEncryptionAlgorithm"]/*' />
    public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

    /// <include file='CMSG_KEY_AGREE_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_ENCRYPT_INFO.UserKeyingMaterial"]/*' />
    public CRYPT_DATA_BLOB UserKeyingMaterial;

    /// <include file='CMSG_KEY_AGREE_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_ENCRYPT_INFO.dwOriginatorChoice"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOriginatorChoice;

    /// <include file='CMSG_KEY_AGREE_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_ENCRYPT_INFO.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_wincrypt_L8626_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='CMSG_KEY_AGREE_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_ENCRYPT_INFO.cKeyAgreeKeyEncryptInfo"]/*' />
    [NativeTypeName("DWORD")]
    public uint cKeyAgreeKeyEncryptInfo;

    /// <include file='CMSG_KEY_AGREE_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_ENCRYPT_INFO.rgpKeyAgreeKeyEncryptInfo"]/*' />
    [NativeTypeName("PCMSG_KEY_AGREE_KEY_ENCRYPT_INFO *")]
    public CMSG_KEY_AGREE_KEY_ENCRYPT_INFO** rgpKeyAgreeKeyEncryptInfo;

    /// <include file='CMSG_KEY_AGREE_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_ENCRYPT_INFO.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.OriginatorCertId"]/*' />
    [UnscopedRef]
    public ref CERT_ID OriginatorCertId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.OriginatorCertId;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.OriginatorPublicKeyInfo"]/*' />
    [UnscopedRef]
    public ref CERT_PUBLIC_KEY_INFO OriginatorPublicKeyInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.OriginatorPublicKeyInfo;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.OriginatorCertId"]/*' />
        [FieldOffset(0)]
        public CERT_ID OriginatorCertId;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.OriginatorPublicKeyInfo"]/*' />
        [FieldOffset(0)]
        public CERT_PUBLIC_KEY_INFO OriginatorPublicKeyInfo;
    }
}
