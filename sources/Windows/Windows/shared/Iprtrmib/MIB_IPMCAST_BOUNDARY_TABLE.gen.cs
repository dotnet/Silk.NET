// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='MIB_IPMCAST_BOUNDARY_TABLE.xml' path='doc/member[@name="MIB_IPMCAST_BOUNDARY_TABLE"]/*'/>
public partial struct MIB_IPMCAST_BOUNDARY_TABLE
{
    /// <include file='MIB_IPMCAST_BOUNDARY_TABLE.xml' path='doc/member[@name="MIB_IPMCAST_BOUNDARY_TABLE.dwNumEntries"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumEntries;
    /// <include file='MIB_IPMCAST_BOUNDARY_TABLE.xml' path='doc/member[@name="MIB_IPMCAST_BOUNDARY_TABLE.table"]/*'/>
    [NativeTypeName("MIB_IPMCAST_BOUNDARY[1]")]
    public _table_e__FixedBuffer table;
    /// <include file='_table_e__FixedBuffer.xml' path='doc/member[@name="_table_e__FixedBuffer"]/*'/>
    public partial struct _table_e__FixedBuffer
    {
        public MIB_IPMCAST_BOUNDARY e0;
        [UnscopedRef]
        public ref MIB_IPMCAST_BOUNDARY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MIB_IPMCAST_BOUNDARY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}