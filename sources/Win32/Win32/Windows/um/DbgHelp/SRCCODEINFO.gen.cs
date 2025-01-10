// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SRCCODEINFO
{
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;

    [NativeTypeName("PVOID")]
    public void* Key;

    [NativeTypeName("DWORD64")]
    public ulong ModBase;

    [NativeTypeName("CHAR[261]")]
    public _Obj_e__FixedBuffer Obj;

    [NativeTypeName("CHAR[261]")]
    public _FileName_e__FixedBuffer FileName;

    [NativeTypeName("DWORD")]
    public uint LineNumber;

    [NativeTypeName("DWORD64")]
    public ulong Address;

    [InlineArray(261)]
    public partial struct _Obj_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(261)]
    public partial struct _FileName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
