// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='DEVICEDUMP_STORAGESTACK_PUBLIC_DUMP.xml' path='doc/member[@name="DEVICEDUMP_STORAGESTACK_PUBLIC_DUMP"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct DEVICEDUMP_STORAGESTACK_PUBLIC_DUMP
{
    /// <include file='DEVICEDUMP_STORAGESTACK_PUBLIC_DUMP.xml' path='doc/member[@name="DEVICEDUMP_STORAGESTACK_PUBLIC_DUMP.Descriptor"]/*'/>
    public DEVICEDUMP_STRUCTURE_VERSION Descriptor;
    /// <include file='DEVICEDUMP_STORAGESTACK_PUBLIC_DUMP.xml' path='doc/member[@name="DEVICEDUMP_STORAGESTACK_PUBLIC_DUMP.dwReasonForCollection"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReasonForCollection;
    /// <include file='DEVICEDUMP_STORAGESTACK_PUBLIC_DUMP.xml' path='doc/member[@name="DEVICEDUMP_STORAGESTACK_PUBLIC_DUMP.cDriverName"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte cDriverName[16];
    /// <include file='DEVICEDUMP_STORAGESTACK_PUBLIC_DUMP.xml' path='doc/member[@name="DEVICEDUMP_STORAGESTACK_PUBLIC_DUMP.uiNumRecords"]/*'/>
    [NativeTypeName("DWORD")]
    public uint uiNumRecords;
    /// <include file='DEVICEDUMP_STORAGESTACK_PUBLIC_DUMP.xml' path='doc/member[@name="DEVICEDUMP_STORAGESTACK_PUBLIC_DUMP.RecordArray"]/*'/>
    [NativeTypeName("DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD[1]")]
    public _RecordArray_e__FixedBuffer RecordArray;
    /// <include file='_RecordArray_e__FixedBuffer.xml' path='doc/member[@name="_RecordArray_e__FixedBuffer"]/*'/>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _RecordArray_e__FixedBuffer
    {
        public DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD e0;
        [UnscopedRef]
        public ref DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}