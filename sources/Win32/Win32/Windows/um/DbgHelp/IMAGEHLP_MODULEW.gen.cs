// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGEHLP_MODULEW
{
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;

    [NativeTypeName("DWORD")]
    public uint BaseOfImage;

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
}
