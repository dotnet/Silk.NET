// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fci.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CCAB
{
    [NativeTypeName("ULONG")]
    public uint cb;

    [NativeTypeName("ULONG")]
    public uint cbFolderThresh;
    public uint cbReserveCFHeader;
    public uint cbReserveCFFolder;
    public uint cbReserveCFData;
    public int iCab;
    public int iDisk;
    public int fFailOnIncompressible;
    public ushort setID;

    [NativeTypeName("char[256]")]
    public _szDisk_e__FixedBuffer szDisk;

    [NativeTypeName("char[256]")]
    public _szCab_e__FixedBuffer szCab;

    [NativeTypeName("char[256]")]
    public _szCabPath_e__FixedBuffer szCabPath;

    [InlineArray(256)]
    public partial struct _szDisk_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(256)]
    public partial struct _szCab_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(256)]
    public partial struct _szCabPath_e__FixedBuffer
    {
        public sbyte e0;
    }
}
