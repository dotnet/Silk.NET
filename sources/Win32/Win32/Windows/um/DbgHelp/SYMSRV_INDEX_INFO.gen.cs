// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SYMSRV_INDEX_INFO
{
    [NativeTypeName("DWORD")]
    public uint sizeofstruct;

    [NativeTypeName("char[261]")]
    public _file_e__FixedBuffer file;
    public BOOL stripped;

    [NativeTypeName("DWORD")]
    public uint timestamp;

    [NativeTypeName("DWORD")]
    public uint size;

    [NativeTypeName("char[261]")]
    public _dbgfile_e__FixedBuffer dbgfile;

    [NativeTypeName("char[261]")]
    public _pdbfile_e__FixedBuffer pdbfile;
    public Guid guid;

    [NativeTypeName("DWORD")]
    public uint sig;

    [NativeTypeName("DWORD")]
    public uint age;

    [InlineArray(261)]
    public partial struct _file_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(261)]
    public partial struct _dbgfile_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(261)]
    public partial struct _pdbfile_e__FixedBuffer
    {
        public sbyte e0;
    }
}
