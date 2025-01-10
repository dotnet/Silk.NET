// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CMSG_KEY_AGREE_ENCRYPT_INFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint dwRecipientIndex;
    public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;
    public CRYPT_DATA_BLOB UserKeyingMaterial;

    [NativeTypeName("DWORD")]
    public uint dwOriginatorChoice;

    [NativeTypeName("__AnonymousRecord_wincrypt_L8658_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD")]
    public uint cKeyAgreeKeyEncryptInfo;

    [NativeTypeName("PCMSG_KEY_AGREE_KEY_ENCRYPT_INFO *")]
    public CMSG_KEY_AGREE_KEY_ENCRYPT_INFO** rgpKeyAgreeKeyEncryptInfo;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [UnscopedRef]
    public ref CERT_ID OriginatorCertId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.OriginatorCertId; }
    }

    [UnscopedRef]
    public ref CERT_PUBLIC_KEY_INFO OriginatorPublicKeyInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.OriginatorPublicKeyInfo; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public CERT_ID OriginatorCertId;

        [FieldOffset(0)]
        public CERT_PUBLIC_KEY_INFO OriginatorPublicKeyInfo;
    }
}
