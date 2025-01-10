// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SYMBOL_INFO
{
    [NativeTypeName("ULONG")]
    public uint SizeOfStruct;

    [NativeTypeName("ULONG")]
    public uint TypeIndex;

    [NativeTypeName("ULONG64[2]")]
    public _Reserved_e__FixedBuffer Reserved;

    [NativeTypeName("ULONG")]
    public uint Index;

    [NativeTypeName("ULONG")]
    public uint Size;

    [NativeTypeName("ULONG64")]
    public ulong ModBase;

    [NativeTypeName("ULONG")]
    public uint Flags;

    [NativeTypeName("ULONG64")]
    public ulong Value;

    [NativeTypeName("ULONG64")]
    public ulong Address;

    [NativeTypeName("ULONG")]
    public uint Register;

    [NativeTypeName("ULONG")]
    public uint Scope;

    [NativeTypeName("ULONG")]
    public uint Tag;

    [NativeTypeName("ULONG")]
    public uint NameLen;

    [NativeTypeName("ULONG")]
    public uint MaxNameLen;

    [NativeTypeName("CHAR[1]")]
    public _Name_e__FixedBuffer Name;

    [InlineArray(2)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public ulong e0;
    }

    public partial struct _Name_e__FixedBuffer
    {
        public sbyte e0;

        [UnscopedRef]
        public ref sbyte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<sbyte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
