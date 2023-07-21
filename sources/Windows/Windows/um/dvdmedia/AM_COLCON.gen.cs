// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace Silk.NET.Windows;

/// <include file='AM_COLCON.xml' path='doc/member[@name="AM_COLCON"]/*' />
public partial struct AM_COLCON
{
    public byte _bitfield1;

    /// <include file='AM_COLCON.xml' path='doc/member[@name="AM_COLCON.emph1col"]/*' />
    [NativeTypeName("UCHAR : 4")]
    public byte emph1col
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)(_bitfield1 & 0xFu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (byte)((_bitfield1 & ~0xFu) | (value & 0xFu));
        }
    }

    /// <include file='AM_COLCON.xml' path='doc/member[@name="AM_COLCON.emph2col"]/*' />
    [NativeTypeName("UCHAR : 4")]
    public byte emph2col
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield1 >> 4) & 0xFu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (byte)((_bitfield1 & ~(0xFu << 4)) | ((value & 0xFu) << 4));
        }
    }

    public byte _bitfield2;

    /// <include file='AM_COLCON.xml' path='doc/member[@name="AM_COLCON.backcol"]/*' />
    [NativeTypeName("UCHAR : 4")]
    public byte backcol
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)(_bitfield2 & 0xFu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (byte)((_bitfield2 & ~0xFu) | (value & 0xFu));
        }
    }

    /// <include file='AM_COLCON.xml' path='doc/member[@name="AM_COLCON.patcol"]/*' />
    [NativeTypeName("UCHAR : 4")]
    public byte patcol
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield2 >> 4) & 0xFu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (byte)((_bitfield2 & ~(0xFu << 4)) | ((value & 0xFu) << 4));
        }
    }

    public byte _bitfield3;

    /// <include file='AM_COLCON.xml' path='doc/member[@name="AM_COLCON.emph1con"]/*' />
    [NativeTypeName("UCHAR : 4")]
    public byte emph1con
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)(_bitfield3 & 0xFu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield3 = (byte)((_bitfield3 & ~0xFu) | (value & 0xFu));
        }
    }

    /// <include file='AM_COLCON.xml' path='doc/member[@name="AM_COLCON.emph2con"]/*' />
    [NativeTypeName("UCHAR : 4")]
    public byte emph2con
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield3 >> 4) & 0xFu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield3 = (byte)((_bitfield3 & ~(0xFu << 4)) | ((value & 0xFu) << 4));
        }
    }

    public byte _bitfield4;

    /// <include file='AM_COLCON.xml' path='doc/member[@name="AM_COLCON.backcon"]/*' />
    [NativeTypeName("UCHAR : 4")]
    public byte backcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)(_bitfield4 & 0xFu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield4 = (byte)((_bitfield4 & ~0xFu) | (value & 0xFu));
        }
    }

    /// <include file='AM_COLCON.xml' path='doc/member[@name="AM_COLCON.patcon"]/*' />
    [NativeTypeName("UCHAR : 4")]
    public byte patcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield4 >> 4) & 0xFu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield4 = (byte)((_bitfield4 & ~(0xFu << 4)) | ((value & 0xFu) << 4));
        }
    }
}
