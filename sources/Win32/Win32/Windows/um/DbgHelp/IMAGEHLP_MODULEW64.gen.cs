// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGEHLP_MODULEW64
{
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;

    [NativeTypeName("DWORD64")]
    public ulong BaseOfImage;

    [NativeTypeName("DWORD")]
    public uint ImageSize;

    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    [NativeTypeName("DWORD")]
    public uint CheckSum;

    [NativeTypeName("DWORD")]
    public uint NumSyms;
    public SYM_TYPE SymType;

    [NativeTypeName("WCHAR[32]")]
    public _ModuleName_e__FixedBuffer ModuleName;

    [NativeTypeName("WCHAR[256]")]
    public _ImageName_e__FixedBuffer ImageName;

    [NativeTypeName("WCHAR[256]")]
    public _LoadedImageName_e__FixedBuffer LoadedImageName;

    [NativeTypeName("WCHAR[256]")]
    public _LoadedPdbName_e__FixedBuffer LoadedPdbName;

    [NativeTypeName("DWORD")]
    public uint CVSig;

    [NativeTypeName("WCHAR[780]")]
    public _CVData_e__FixedBuffer CVData;

    [NativeTypeName("DWORD")]
    public uint PdbSig;
    public Guid PdbSig70;

    [NativeTypeName("DWORD")]
    public uint PdbAge;
    public BOOL PdbUnmatched;
    public BOOL DbgUnmatched;
    public BOOL LineNumbers;
    public BOOL GlobalSymbols;
    public BOOL TypeInfo;
    public BOOL SourceIndexed;
    public BOOL Publics;

    [NativeTypeName("DWORD")]
    public uint MachineType;

    [NativeTypeName("DWORD")]
    public uint Reserved;

    [InlineArray(32)]
    public partial struct _ModuleName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(256)]
    public partial struct _ImageName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(256)]
    public partial struct _LoadedImageName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(256)]
    public partial struct _LoadedPdbName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(780)]
    public partial struct _CVData_e__FixedBuffer
    {
        public ushort e0;
    }
}
