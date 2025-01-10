// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CMSG_CTRL_KEY_AGREE_DECRYPT_PARA
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("__AnonymousRecord_wincrypt_L8132_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD")]
    public uint dwKeySpec;

    [NativeTypeName("PCMSG_KEY_AGREE_RECIPIENT_INFO")]
    public CMSG_KEY_AGREE_RECIPIENT_INFO* pKeyAgree;

    [NativeTypeName("DWORD")]
    public uint dwRecipientIndex;

    [NativeTypeName("DWORD")]
    public uint dwRecipientEncryptedKeyIndex;
    public CRYPT_BIT_BLOB OriginatorPublicKey;

    [UnscopedRef]
    public ref HCRYPTPROV hCryptProv
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.hCryptProv; }
    }

    [UnscopedRef]
    public ref nuint hNCryptKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.hNCryptKey; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public HCRYPTPROV hCryptProv;

        [FieldOffset(0)]
        [NativeTypeName("NCRYPT_KEY_HANDLE")]
        public nuint hNCryptKey;
    }
}
