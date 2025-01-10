// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGE_ARCHIVE_MEMBER_HEADER
{
    [NativeTypeName("BYTE[16]")]
    public _Name_e__FixedBuffer Name;

    [NativeTypeName("BYTE[12]")]
    public _Date_e__FixedBuffer Date;

    [NativeTypeName("BYTE[6]")]
    public _UserID_e__FixedBuffer UserID;

    [NativeTypeName("BYTE[6]")]
    public _GroupID_e__FixedBuffer GroupID;

    [NativeTypeName("BYTE[8]")]
    public _Mode_e__FixedBuffer Mode;

    [NativeTypeName("BYTE[10]")]
    public _Size_e__FixedBuffer Size;

    [NativeTypeName("BYTE[2]")]
    public _EndHeader_e__FixedBuffer EndHeader;

    [InlineArray(16)]
    public partial struct _Name_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(12)]
    public partial struct _Date_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(6)]
    public partial struct _UserID_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(6)]
    public partial struct _GroupID_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(8)]
    public partial struct _Mode_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(10)]
    public partial struct _Size_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _EndHeader_e__FixedBuffer
    {
        public byte e0;
    }
}
