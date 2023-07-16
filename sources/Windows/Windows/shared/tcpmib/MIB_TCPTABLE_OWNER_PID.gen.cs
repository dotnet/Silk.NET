// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='MIB_TCPTABLE_OWNER_PID.xml' path='doc/member[@name="MIB_TCPTABLE_OWNER_PID"]/*'/>
public partial struct MIB_TCPTABLE_OWNER_PID
{
    /// <include file='MIB_TCPTABLE_OWNER_PID.xml' path='doc/member[@name="MIB_TCPTABLE_OWNER_PID.dwNumEntries"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumEntries;
    /// <include file='MIB_TCPTABLE_OWNER_PID.xml' path='doc/member[@name="MIB_TCPTABLE_OWNER_PID.table"]/*'/>
    [NativeTypeName("MIB_TCPROW_OWNER_PID[1]")]
    public _table_e__FixedBuffer table;
    /// <include file='_table_e__FixedBuffer.xml' path='doc/member[@name="_table_e__FixedBuffer"]/*'/>
    public partial struct _table_e__FixedBuffer
    {
        public MIB_TCPROW_OWNER_PID e0;
        [UnscopedRef]
        public ref MIB_TCPROW_OWNER_PID this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MIB_TCPROW_OWNER_PID> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}