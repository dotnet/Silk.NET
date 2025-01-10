// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CMSG_CONTENT_ENCRYPT_INFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;
    public HCRYPTPROV_LEGACY hCryptProv;
    public CRYPT_ALGORITHM_IDENTIFIER ContentEncryptionAlgorithm;
    public void* pvEncryptionAuxInfo;

    [NativeTypeName("DWORD")]
    public uint cRecipients;

    [NativeTypeName("PCMSG_RECIPIENT_ENCODE_INFO")]
    public CMSG_RECIPIENT_ENCODE_INFO* rgCmsRecipients;

    [NativeTypeName("PFN_CMSG_ALLOC")]
    public delegate* unmanaged<nuint, void*> pfnAlloc;

    [NativeTypeName("PFN_CMSG_FREE")]
    public delegate* unmanaged<void*, void> pfnFree;

    [NativeTypeName("DWORD")]
    public uint dwEncryptFlags;

    [NativeTypeName("__AnonymousRecord_wincrypt_L8485_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD")]
    public uint dwFlags;
    public BOOL fCNG;
    public byte* pbCNGContentEncryptKeyObject;
    public byte* pbContentEncryptKey;

    [NativeTypeName("DWORD")]
    public uint cbContentEncryptKey;

    [UnscopedRef]
    public ref HCRYPTKEY hContentEncryptKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.hContentEncryptKey; }
    }

    [UnscopedRef]
    public ref void* hCNGContentEncryptKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.hCNGContentEncryptKey; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public HCRYPTKEY hContentEncryptKey;

        [FieldOffset(0)]
        [NativeTypeName("BCRYPT_KEY_HANDLE")]
        public void* hCNGContentEncryptKey;
    }
}
