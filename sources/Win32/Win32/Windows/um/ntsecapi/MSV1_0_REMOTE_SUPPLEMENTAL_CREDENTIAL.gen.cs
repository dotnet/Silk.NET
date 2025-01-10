// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MSV1_0_REMOTE_SUPPLEMENTAL_CREDENTIAL
{
    [NativeTypeName("ULONG")]
    public uint Version;

    [NativeTypeName("ULONG")]
    public uint Flags;
    public MSV1_0_CREDENTIAL_KEY CredentialKey;
    public MSV1_0_CREDENTIAL_KEY_TYPE CredentialKeyType;

    [NativeTypeName("ULONG")]
    public uint EncryptedCredsSize;

    [NativeTypeName("UCHAR[1]")]
    public _EncryptedCreds_e__FixedBuffer EncryptedCreds;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _EncryptedCreds_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
