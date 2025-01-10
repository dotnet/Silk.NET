// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct AM_COLCON
{
    public byte _bitfield1;

    [NativeTypeName("UCHAR : 4")]
    public byte emph1col
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)(_bitfield1 & 0xFu); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield1 = (byte)((_bitfield1 & ~0xFu) | (value & 0xFu)); }
    }

    [NativeTypeName("UCHAR : 4")]
    public byte emph2col
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield1 >> 4) & 0xFu); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield1 = (byte)((_bitfield1 & ~(0xFu << 4)) | ((value & 0xFu) << 4)); }
    }
    public byte _bitfield2;

    [NativeTypeName("UCHAR : 4")]
    public byte backcol
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)(_bitfield2 & 0xFu); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (byte)((_bitfield2 & ~0xFu) | (value & 0xFu)); }
    }

    [NativeTypeName("UCHAR : 4")]
    public byte patcol
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield2 >> 4) & 0xFu); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (byte)((_bitfield2 & ~(0xFu << 4)) | ((value & 0xFu) << 4)); }
    }
    public byte _bitfield3;

    [NativeTypeName("UCHAR : 4")]
    public byte emph1con
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)(_bitfield3 & 0xFu); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield3 = (byte)((_bitfield3 & ~0xFu) | (value & 0xFu)); }
    }

    [NativeTypeName("UCHAR : 4")]
    public byte emph2con
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield3 >> 4) & 0xFu); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield3 = (byte)((_bitfield3 & ~(0xFu << 4)) | ((value & 0xFu) << 4)); }
    }
    public byte _bitfield4;

    [NativeTypeName("UCHAR : 4")]
    public byte backcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)(_bitfield4 & 0xFu); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield4 = (byte)((_bitfield4 & ~0xFu) | (value & 0xFu)); }
    }

    [NativeTypeName("UCHAR : 4")]
    public byte patcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield4 >> 4) & 0xFu); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield4 = (byte)((_bitfield4 & ~(0xFu << 4)) | ((value & 0xFu) << 4)); }
    }
}
