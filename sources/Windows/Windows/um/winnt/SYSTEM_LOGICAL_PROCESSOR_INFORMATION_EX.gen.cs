// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX"]/*' />
public partial struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX
{
    /// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.Relationship"]/*' />
    public LOGICAL_PROCESSOR_RELATIONSHIP Relationship;

    /// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L13548_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Processor"]/*' />
    [UnscopedRef]
    public ref PROCESSOR_RELATIONSHIP Processor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Processor;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumaNode"]/*' />
    [UnscopedRef]
    public ref NUMA_NODE_RELATIONSHIP NumaNode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.NumaNode;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Cache"]/*' />
    [UnscopedRef]
    public ref CACHE_RELATIONSHIP Cache
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Cache;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Group"]/*' />
    [UnscopedRef]
    public ref GROUP_RELATIONSHIP Group
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Group;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Processor"]/*' />
        [FieldOffset(0)]
        public PROCESSOR_RELATIONSHIP Processor;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumaNode"]/*' />
        [FieldOffset(0)]
        public NUMA_NODE_RELATIONSHIP NumaNode;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Cache"]/*' />
        [FieldOffset(0)]
        public CACHE_RELATIONSHIP Cache;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Group"]/*' />
        [FieldOffset(0)]
        public GROUP_RELATIONSHIP Group;
    }
}
