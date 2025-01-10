// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX
{
    public LOGICAL_PROCESSOR_RELATIONSHIP Relationship;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("__AnonymousRecord_winnt_L14054_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref PROCESSOR_RELATIONSHIP Processor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Processor; }
    }

    [UnscopedRef]
    public ref NUMA_NODE_RELATIONSHIP NumaNode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.NumaNode; }
    }

    [UnscopedRef]
    public ref CACHE_RELATIONSHIP Cache
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Cache; }
    }

    [UnscopedRef]
    public ref GROUP_RELATIONSHIP Group
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Group; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public PROCESSOR_RELATIONSHIP Processor;

        [FieldOffset(0)]
        public NUMA_NODE_RELATIONSHIP NumaNode;

        [FieldOffset(0)]
        public CACHE_RELATIONSHIP Cache;

        [FieldOffset(0)]
        public GROUP_RELATIONSHIP Group;
    }
}
