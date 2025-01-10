// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct PROPPRG
{
    [NativeTypeName("WORD")]
    public ushort flPrg;

    [NativeTypeName("WORD")]
    public ushort flPrgInit;

    [NativeTypeName("CHAR[30]")]
    public _achTitle_e__FixedBuffer achTitle;

    [NativeTypeName("CHAR[128]")]
    public _achCmdLine_e__FixedBuffer achCmdLine;

    [NativeTypeName("CHAR[64]")]
    public _achWorkDir_e__FixedBuffer achWorkDir;

    [NativeTypeName("WORD")]
    public ushort wHotKey;

    [NativeTypeName("CHAR[80]")]
    public _achIconFile_e__FixedBuffer achIconFile;

    [NativeTypeName("WORD")]
    public ushort wIconIndex;

    [NativeTypeName("DWORD")]
    public uint dwEnhModeFlags;

    [NativeTypeName("DWORD")]
    public uint dwRealModeFlags;

    [NativeTypeName("CHAR[80]")]
    public _achOtherFile_e__FixedBuffer achOtherFile;

    [NativeTypeName("CHAR[260]")]
    public _achPIFFile_e__FixedBuffer achPIFFile;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(30)]
    public partial struct _achTitle_e__FixedBuffer
    {
        public sbyte e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(128)]
    public partial struct _achCmdLine_e__FixedBuffer
    {
        public sbyte e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(64)]
    public partial struct _achWorkDir_e__FixedBuffer
    {
        public sbyte e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(80)]
    public partial struct _achIconFile_e__FixedBuffer
    {
        public sbyte e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(80)]
    public partial struct _achOtherFile_e__FixedBuffer
    {
        public sbyte e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(260)]
    public partial struct _achPIFFile_e__FixedBuffer
    {
        public sbyte e0;
    }
}
