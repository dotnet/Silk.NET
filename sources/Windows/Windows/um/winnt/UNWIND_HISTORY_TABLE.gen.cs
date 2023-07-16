// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE"]/*'/>
public partial struct UNWIND_HISTORY_TABLE
{
    /// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE.Count"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Count;
    /// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE.LocalHint"]/*'/>
    public byte LocalHint;
    /// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE.GlobalHint"]/*'/>
    public byte GlobalHint;
    /// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE.Search"]/*'/>
    public byte Search;
    /// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE.Once"]/*'/>
    public byte Once;
    /// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE.LowAddress"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint LowAddress;
    /// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE.HighAddress"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint HighAddress;
    /// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE.Entry"]/*'/>
    [NativeTypeName("UNWIND_HISTORY_TABLE_ENTRY[12]")]
    public _Entry_e__FixedBuffer Entry;
    /// <include file='_Entry_e__FixedBuffer.xml' path='doc/member[@name="_Entry_e__FixedBuffer"]/*'/>
    public partial struct _Entry_e__FixedBuffer
    {
        public UNWIND_HISTORY_TABLE_ENTRY e0;
        public UNWIND_HISTORY_TABLE_ENTRY e1;
        public UNWIND_HISTORY_TABLE_ENTRY e2;
        public UNWIND_HISTORY_TABLE_ENTRY e3;
        public UNWIND_HISTORY_TABLE_ENTRY e4;
        public UNWIND_HISTORY_TABLE_ENTRY e5;
        public UNWIND_HISTORY_TABLE_ENTRY e6;
        public UNWIND_HISTORY_TABLE_ENTRY e7;
        public UNWIND_HISTORY_TABLE_ENTRY e8;
        public UNWIND_HISTORY_TABLE_ENTRY e9;
        public UNWIND_HISTORY_TABLE_ENTRY e10;
        public UNWIND_HISTORY_TABLE_ENTRY e11;
        [UnscopedRef]
        public ref UNWIND_HISTORY_TABLE_ENTRY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<UNWIND_HISTORY_TABLE_ENTRY> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 12);
    }
}