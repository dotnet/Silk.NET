// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace Silk.NET.DirectX;

/// <include file='DWRITE_SHAPING_TEXT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SHAPING_TEXT_PROPERTIES"]/*' />
public partial struct DWRITE_SHAPING_TEXT_PROPERTIES
{
    public ushort _bitfield;

    /// <include file='DWRITE_SHAPING_TEXT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SHAPING_TEXT_PROPERTIES.isShapedAlone"]/*' />
    [NativeTypeName("UINT16 : 1")]
    public ushort isShapedAlone
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)(_bitfield & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~0x1u) | (value & 0x1u));
        }
    }

    /// <include file='DWRITE_SHAPING_TEXT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SHAPING_TEXT_PROPERTIES.reserved1"]/*' />
    [NativeTypeName("UINT16 : 1")]
    public ushort reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)((_bitfield >> 1) & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
        }
    }

    /// <include file='DWRITE_SHAPING_TEXT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SHAPING_TEXT_PROPERTIES.canBreakShapingAfter"]/*' />
    [NativeTypeName("UINT16 : 1")]
    public ushort canBreakShapingAfter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)((_bitfield >> 2) & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2));
        }
    }

    /// <include file='DWRITE_SHAPING_TEXT_PROPERTIES.xml' path='doc/member[@name="DWRITE_SHAPING_TEXT_PROPERTIES.reserved"]/*' />
    [NativeTypeName("UINT16 : 13")]
    public ushort reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)((_bitfield >> 3) & 0x1FFFu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~(0x1FFFu << 3)) | ((value & 0x1FFFu) << 3));
        }
    }
}
