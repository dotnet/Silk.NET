// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO"]/*'/>
public unsafe partial struct CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO
{
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.KeyEncryptionAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.pvKeyEncryptionAuxInfo"]/*'/>
    public void* pvKeyEncryptionAuxInfo;
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.KeyWrapAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER KeyWrapAlgorithm;
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.pvKeyWrapAuxInfo"]/*'/>
    public void* pvKeyWrapAuxInfo;
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.hCryptProv"]/*'/>
    public HCRYPTPROV_LEGACY hCryptProv;
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.dwKeySpec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwKeySpec;
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.dwKeyChoice"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwKeyChoice;
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wincrypt_L6957_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.UserKeyingMaterial"]/*'/>
    public CRYPT_DATA_BLOB UserKeyingMaterial;
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.cRecipientEncryptedKeys"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cRecipientEncryptedKeys;
    /// <include file='CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO.rgpRecipientEncryptedKeys"]/*'/>
    [NativeTypeName("PCMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO *")]
    public CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO** rgpRecipientEncryptedKeys;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pEphemeralAlgorithm"]/*'/>
    [UnscopedRef]
    public ref CRYPT_ALGORITHM_IDENTIFIER* pEphemeralAlgorithm
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pEphemeralAlgorithm;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSenderId"]/*'/>
    [UnscopedRef]
    public ref CERT_ID* pSenderId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pSenderId;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pEphemeralAlgorithm"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PCRYPT_ALGORITHM_IDENTIFIER")]
        public CRYPT_ALGORITHM_IDENTIFIER* pEphemeralAlgorithm;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSenderId"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PCERT_ID")]
        public CERT_ID* pSenderId;
    }
}