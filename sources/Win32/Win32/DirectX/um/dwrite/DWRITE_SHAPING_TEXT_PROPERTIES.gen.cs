// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DWRITE_SHAPING_TEXT_PROPERTIES
{
    public ushort _bitfield;

    [NativeTypeName("UINT16 : 1")]
    public ushort isShapedAlone
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (ushort)(_bitfield & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (ushort)((_bitfield & ~0x1u) | (value & 0x1u)); }
    }

    [NativeTypeName("UINT16 : 1")]
    public ushort reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (ushort)((_bitfield >> 1) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (ushort)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1)); }
    }

    [NativeTypeName("UINT16 : 1")]
    public ushort canBreakShapingAfter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (ushort)((_bitfield >> 2) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (ushort)((_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2)); }
    }

    [NativeTypeName("UINT16 : 13")]
    public ushort reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (ushort)((_bitfield >> 3) & 0x1FFFu); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (ushort)((_bitfield & ~(0x1FFFu << 3)) | ((value & 0x1FFFu) << 3)); }
    }
}
