// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace Silk.NET.DirectX;

/// <include file='DWRITE_LINE_BREAKPOINT.xml' path='doc/member[@name="DWRITE_LINE_BREAKPOINT"]/*' />
public partial struct DWRITE_LINE_BREAKPOINT
{
    public byte _bitfield;

    /// <include file='DWRITE_LINE_BREAKPOINT.xml' path='doc/member[@name="DWRITE_LINE_BREAKPOINT.breakConditionBefore"]/*' />
    [NativeTypeName("UINT8 : 2")]
    public byte breakConditionBefore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)(_bitfield & 0x3u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (byte)((_bitfield & ~0x3u) | (value & 0x3u));
        }
    }

    /// <include file='DWRITE_LINE_BREAKPOINT.xml' path='doc/member[@name="DWRITE_LINE_BREAKPOINT.breakConditionAfter"]/*' />
    [NativeTypeName("UINT8 : 2")]
    public byte breakConditionAfter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield >> 2) & 0x3u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (byte)((_bitfield & ~(0x3u << 2)) | ((value & 0x3u) << 2));
        }
    }

    /// <include file='DWRITE_LINE_BREAKPOINT.xml' path='doc/member[@name="DWRITE_LINE_BREAKPOINT.isWhitespace"]/*' />
    [NativeTypeName("UINT8 : 1")]
    public byte isWhitespace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield >> 4) & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (byte)((_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4));
        }
    }

    /// <include file='DWRITE_LINE_BREAKPOINT.xml' path='doc/member[@name="DWRITE_LINE_BREAKPOINT.isSoftHyphen"]/*' />
    [NativeTypeName("UINT8 : 1")]
    public byte isSoftHyphen
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield >> 5) & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (byte)((_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5));
        }
    }

    /// <include file='DWRITE_LINE_BREAKPOINT.xml' path='doc/member[@name="DWRITE_LINE_BREAKPOINT.padding"]/*' />
    [NativeTypeName("UINT8 : 2")]
    public byte padding
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield >> 6) & 0x3u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (byte)((_bitfield & ~(0x3u << 6)) | ((value & 0x3u) << 6));
        }
    }
}
