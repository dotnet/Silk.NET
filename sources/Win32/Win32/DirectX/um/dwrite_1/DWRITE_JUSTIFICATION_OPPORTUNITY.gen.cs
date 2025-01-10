// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DWRITE_JUSTIFICATION_OPPORTUNITY
{
    public float expansionMinimum;
    public float expansionMaximum;
    public float compressionMaximum;
    public uint _bitfield;

    [NativeTypeName("UINT32 : 8")]
    public uint expansionPriority
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return _bitfield & 0xFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~0xFFu) | (value & 0xFFu); }
    }

    [NativeTypeName("UINT32 : 8")]
    public uint compressionPriority
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 8) & 0xFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0xFFu << 8)) | ((value & 0xFFu) << 8); }
    }

    [NativeTypeName("UINT32 : 1")]
    public uint allowResidualExpansion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 16) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1u << 16)) | ((value & 0x1u) << 16); }
    }

    [NativeTypeName("UINT32 : 1")]
    public uint allowResidualCompression
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 17) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1u << 17)) | ((value & 0x1u) << 17); }
    }

    [NativeTypeName("UINT32 : 1")]
    public uint applyToLeadingEdge
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 18) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1u << 18)) | ((value & 0x1u) << 18); }
    }

    [NativeTypeName("UINT32 : 1")]
    public uint applyToTrailingEdge
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 19) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1u << 19)) | ((value & 0x1u) << 19); }
    }

    [NativeTypeName("UINT32 : 12")]
    public uint reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 20) & 0xFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0xFFFu << 20)) | ((value & 0xFFFu) << 20); }
    }
}
