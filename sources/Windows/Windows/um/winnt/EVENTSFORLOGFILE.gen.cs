// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='EVENTSFORLOGFILE.xml' path='doc/member[@name="EVENTSFORLOGFILE"]/*'/>
public unsafe partial struct EVENTSFORLOGFILE
{
    /// <include file='EVENTSFORLOGFILE.xml' path='doc/member[@name="EVENTSFORLOGFILE.ulSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ulSize;
    /// <include file='EVENTSFORLOGFILE.xml' path='doc/member[@name="EVENTSFORLOGFILE.szLogicalLogFile"]/*'/>
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort szLogicalLogFile[256];
    /// <include file='EVENTSFORLOGFILE.xml' path='doc/member[@name="EVENTSFORLOGFILE.ulNumRecords"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ulNumRecords;
    /// <include file='EVENTSFORLOGFILE.xml' path='doc/member[@name="EVENTSFORLOGFILE.pEventLogRecords"]/*'/>
    [NativeTypeName("EVENTLOGRECORD[]")]
    public _pEventLogRecords_e__FixedBuffer pEventLogRecords;
    /// <include file='_pEventLogRecords_e__FixedBuffer.xml' path='doc/member[@name="_pEventLogRecords_e__FixedBuffer"]/*'/>
    public partial struct _pEventLogRecords_e__FixedBuffer
    {
        public EVENTLOGRECORD e0;
        [UnscopedRef]
        public ref EVENTLOGRECORD this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<EVENTLOGRECORD> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}