// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DWRITE_LINE_BREAKPOINT
{
    public byte _bitfield;

    [NativeTypeName("UINT8 : 2")]
    public byte breakConditionBefore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)(_bitfield & 0x3u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~0x3u) | (value & 0x3u)); }
    }

    [NativeTypeName("UINT8 : 2")]
    public byte breakConditionAfter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield >> 2) & 0x3u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~(0x3u << 2)) | ((value & 0x3u) << 2)); }
    }

    [NativeTypeName("UINT8 : 1")]
    public byte isWhitespace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield >> 4) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4)); }
    }

    [NativeTypeName("UINT8 : 1")]
    public byte isSoftHyphen
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield >> 5) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5)); }
    }

    [NativeTypeName("UINT8 : 2")]
    public byte padding
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield >> 6) & 0x3u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~(0x3u << 6)) | ((value & 0x3u) << 6)); }
    }
}
