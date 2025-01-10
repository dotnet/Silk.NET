// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION
{
    [NativeTypeName("ULONG_PTR")]
    public nuint ProcessorMask;
    public LOGICAL_PROCESSOR_RELATIONSHIP Relationship;

    [NativeTypeName("__AnonymousRecord_winnt_L13991_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref _Anonymous_e__Union._ProcessorCore_e__Struct ProcessorCore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ProcessorCore; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._NumaNode_e__Struct NumaNode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.NumaNode; }
    }

    [UnscopedRef]
    public ref CACHE_DESCRIPTOR Cache
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Cache; }
    }

    [UnscopedRef]
    public Span<ulong> Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.Reserved; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L13992_C9")]
        public _ProcessorCore_e__Struct ProcessorCore;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L13995_C9")]
        public _NumaNode_e__Struct NumaNode;

        [FieldOffset(0)]
        public CACHE_DESCRIPTOR Cache;

        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG[2]")]
        public _Reserved_e__FixedBuffer Reserved;

        public partial struct _ProcessorCore_e__Struct
        {
            public byte Flags;
        }

        public partial struct _NumaNode_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint NodeNumber;
        }

        [InlineArray(2)]
        public partial struct _Reserved_e__FixedBuffer
        {
            public ulong e0;
        }
    }
}
