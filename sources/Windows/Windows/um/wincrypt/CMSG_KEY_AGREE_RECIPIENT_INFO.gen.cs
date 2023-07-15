// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='CMSG_KEY_AGREE_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_INFO"]/*'/>
public unsafe partial struct CMSG_KEY_AGREE_RECIPIENT_INFO
{
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_INFO.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_INFO.dwOriginatorChoice"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOriginatorChoice;
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_INFO.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wincrypt_L7810_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_INFO.UserKeyingMaterial"]/*'/>
    public CRYPT_DATA_BLOB UserKeyingMaterial;
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_INFO.KeyEncryptionAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_INFO.cRecipientEncryptedKeys"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cRecipientEncryptedKeys;
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_INFO.rgpRecipientEncryptedKeys"]/*'/>
    [NativeTypeName("PCMSG_RECIPIENT_ENCRYPTED_KEY_INFO *")]
    public CMSG_RECIPIENT_ENCRYPTED_KEY_INFO** rgpRecipientEncryptedKeys;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.OriginatorCertId"]/*'/>
    [UnscopedRef]
    public ref CERT_ID OriginatorCertId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.OriginatorCertId;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.OriginatorPublicKeyInfo"]/*'/>
    [UnscopedRef]
    public ref CERT_PUBLIC_KEY_INFO OriginatorPublicKeyInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.OriginatorPublicKeyInfo;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.OriginatorCertId"]/*'/>
        [FieldOffset(0)]
        public CERT_ID OriginatorCertId;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.OriginatorPublicKeyInfo"]/*'/>
        [FieldOffset(0)]
        public CERT_PUBLIC_KEY_INFO OriginatorPublicKeyInfo;
    }
}