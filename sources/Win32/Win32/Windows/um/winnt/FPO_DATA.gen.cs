// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FPO_DATA
{
    [NativeTypeName("DWORD")]
    public uint ulOffStart;

    [NativeTypeName("DWORD")]
    public uint cbProcSize;

    [NativeTypeName("DWORD")]
    public uint cdwLocals;

    [NativeTypeName("WORD")]
    public ushort cdwParams;
    public ushort _bitfield;

    [NativeTypeName("WORD : 8")]
    public ushort cbProlog
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (ushort)(_bitfield & 0xFFu); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (ushort)((_bitfield & ~0xFFu) | (value & 0xFFu)); }
    }

    [NativeTypeName("WORD : 3")]
    public ushort cbRegs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (ushort)((_bitfield >> 8) & 0x7u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (ushort)((_bitfield & ~(0x7u << 8)) | ((value & 0x7u) << 8)); }
    }

    [NativeTypeName("WORD : 1")]
    public ushort fHasSEH
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (ushort)((_bitfield >> 11) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (ushort)((_bitfield & ~(0x1u << 11)) | ((value & 0x1u) << 11)); }
    }

    [NativeTypeName("WORD : 1")]
    public ushort fUseBP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (ushort)((_bitfield >> 12) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (ushort)((_bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12)); }
    }

    [NativeTypeName("WORD : 1")]
    public ushort reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (ushort)((_bitfield >> 13) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (ushort)((_bitfield & ~(0x1u << 13)) | ((value & 0x1u) << 13)); }
    }

    [NativeTypeName("WORD : 2")]
    public ushort cbFrame
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (ushort)((_bitfield >> 14) & 0x3u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (ushort)((_bitfield & ~(0x3u << 14)) | ((value & 0x3u) << 14)); }
    }
}
