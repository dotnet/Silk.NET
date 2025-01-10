// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MSV1_0_NTLM3_RESPONSE
{
    [NativeTypeName("UCHAR[16]")]
    public _Response_e__FixedBuffer Response;

    [NativeTypeName("UCHAR")]
    public byte RespType;

    [NativeTypeName("UCHAR")]
    public byte HiRespType;
    public ushort Flags;

    [NativeTypeName("ULONG")]
    public uint MsgWord;

    [NativeTypeName("ULONGLONG")]
    public ulong TimeStamp;

    [NativeTypeName("UCHAR[8]")]
    public _ChallengeFromClient_e__FixedBuffer ChallengeFromClient;

    [NativeTypeName("ULONG")]
    public uint AvPairsOff;

    [NativeTypeName("UCHAR[1]")]
    public _Buffer_e__FixedBuffer Buffer;

    [InlineArray(16)]
    public partial struct _Response_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(8)]
    public partial struct _ChallengeFromClient_e__FixedBuffer
    {
        public byte e0;
    }

    public partial struct _Buffer_e__FixedBuffer
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
