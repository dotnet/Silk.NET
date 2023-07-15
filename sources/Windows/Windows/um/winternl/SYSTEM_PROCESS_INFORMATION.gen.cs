// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION"]/*'/>
public unsafe partial struct SYSTEM_PROCESS_INFORMATION
{
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.NextEntryOffset"]/*'/>
    [NativeTypeName("ULONG")]
    public uint NextEntryOffset;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.NumberOfThreads"]/*'/>
    [NativeTypeName("ULONG")]
    public uint NumberOfThreads;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.Reserved1"]/*'/>
    [NativeTypeName("BYTE[48]")]
    public fixed byte Reserved1[48];
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.ImageName"]/*'/>
    public UNICODE_STRING ImageName;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.BasePriority"]/*'/>
    [NativeTypeName("KPRIORITY")]
    public int BasePriority;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.UniqueProcessId"]/*'/>
    public HANDLE UniqueProcessId;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.Reserved2"]/*'/>
    [NativeTypeName("PVOID")]
    public void* Reserved2;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.HandleCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint HandleCount;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.SessionId"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SessionId;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.Reserved3"]/*'/>
    [NativeTypeName("PVOID")]
    public void* Reserved3;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.PeakVirtualSize"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint PeakVirtualSize;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.VirtualSize"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint VirtualSize;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.Reserved4"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Reserved4;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.PeakWorkingSetSize"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint PeakWorkingSetSize;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.WorkingSetSize"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint WorkingSetSize;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.Reserved5"]/*'/>
    [NativeTypeName("PVOID")]
    public void* Reserved5;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.QuotaPagedPoolUsage"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint QuotaPagedPoolUsage;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.Reserved6"]/*'/>
    [NativeTypeName("PVOID")]
    public void* Reserved6;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.QuotaNonPagedPoolUsage"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint QuotaNonPagedPoolUsage;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.PagefileUsage"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint PagefileUsage;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.PeakPagefileUsage"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint PeakPagefileUsage;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.PrivatePageCount"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint PrivatePageCount;
    /// <include file='SYSTEM_PROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESS_INFORMATION.Reserved7"]/*'/>
    [NativeTypeName("LARGE_INTEGER[6]")]
    public _Reserved7_e__FixedBuffer Reserved7;
    /// <include file='_Reserved7_e__FixedBuffer.xml' path='doc/member[@name="_Reserved7_e__FixedBuffer"]/*'/>
    public partial struct _Reserved7_e__FixedBuffer
    {
        public LARGE_INTEGER e0;
        public LARGE_INTEGER e1;
        public LARGE_INTEGER e2;
        public LARGE_INTEGER e3;
        public LARGE_INTEGER e4;
        public LARGE_INTEGER e5;
        [UnscopedRef]
        public ref LARGE_INTEGER this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<LARGE_INTEGER> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 6);
    }
}