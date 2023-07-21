// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR"]/*' />
[SupportedOSPlatform("windows10.0")]
public partial struct STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR
{
    /// <include file='STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR.NodeCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint NodeCount;

    /// <include file='STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;

    /// <include file='STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR.Node"]/*' />
    [NativeTypeName("STORAGE_PHYSICAL_NODE_DATA[1]")]
    public _Node_e__FixedBuffer Node;

    /// <include file='_Node_e__FixedBuffer.xml' path='doc/member[@name="_Node_e__FixedBuffer"]/*' />
    public partial struct _Node_e__FixedBuffer
    {
        public STORAGE_PHYSICAL_NODE_DATA e0;

        [UnscopedRef]
        public ref STORAGE_PHYSICAL_NODE_DATA this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<STORAGE_PHYSICAL_NODE_DATA> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
