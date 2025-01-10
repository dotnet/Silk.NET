// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;
    public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;
    public void* pvKeyEncryptionAuxInfo;
    public HCRYPTPROV hCryptProv;

    [NativeTypeName("DWORD")]
    public uint dwKeyChoice;

    [NativeTypeName("__AnonymousRecord_wincrypt_L7034_C5")]
    public _Anonymous_e__Union Anonymous;
    public CRYPT_DATA_BLOB KeyId;
    public FILETIME Date;

    [NativeTypeName("PCRYPT_ATTRIBUTE_TYPE_VALUE")]
    public CRYPT_ATTRIBUTE_TYPE_VALUE* pOtherAttr;

    [UnscopedRef]
    public ref HCRYPTKEY hKeyEncryptionKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.hKeyEncryptionKey; }
    }

    [UnscopedRef]
    public ref void* pvKeyEncryptionKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pvKeyEncryptionKey; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public HCRYPTKEY hKeyEncryptionKey;

        [FieldOffset(0)]
        public void* pvKeyEncryptionKey;
    }
}
