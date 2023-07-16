// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SYSTEM_THREAD_INFORMATION.xml' path='doc/member[@name="SYSTEM_THREAD_INFORMATION"]/*'/>
public unsafe partial struct SYSTEM_THREAD_INFORMATION
{
    /// <include file='SYSTEM_THREAD_INFORMATION.xml' path='doc/member[@name="SYSTEM_THREAD_INFORMATION.Reserved1"]/*'/>
    [NativeTypeName("LARGE_INTEGER[3]")]
    public _Reserved1_e__FixedBuffer Reserved1;
    /// <include file='SYSTEM_THREAD_INFORMATION.xml' path='doc/member[@name="SYSTEM_THREAD_INFORMATION.Reserved2"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Reserved2;
    /// <include file='SYSTEM_THREAD_INFORMATION.xml' path='doc/member[@name="SYSTEM_THREAD_INFORMATION.StartAddress"]/*'/>
    [NativeTypeName("PVOID")]
    public void* StartAddress;
    /// <include file='SYSTEM_THREAD_INFORMATION.xml' path='doc/member[@name="SYSTEM_THREAD_INFORMATION.ClientId"]/*'/>
    public CLIENT_ID ClientId;
    /// <include file='SYSTEM_THREAD_INFORMATION.xml' path='doc/member[@name="SYSTEM_THREAD_INFORMATION.Priority"]/*'/>
    [NativeTypeName("KPRIORITY")]
    public int Priority;
    /// <include file='SYSTEM_THREAD_INFORMATION.xml' path='doc/member[@name="SYSTEM_THREAD_INFORMATION.BasePriority"]/*'/>
    [NativeTypeName("LONG")]
    public int BasePriority;
    /// <include file='SYSTEM_THREAD_INFORMATION.xml' path='doc/member[@name="SYSTEM_THREAD_INFORMATION.Reserved3"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Reserved3;
    /// <include file='SYSTEM_THREAD_INFORMATION.xml' path='doc/member[@name="SYSTEM_THREAD_INFORMATION.ThreadState"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ThreadState;
    /// <include file='SYSTEM_THREAD_INFORMATION.xml' path='doc/member[@name="SYSTEM_THREAD_INFORMATION.WaitReason"]/*'/>
    [NativeTypeName("ULONG")]
    public uint WaitReason;
    /// <include file='_Reserved1_e__FixedBuffer.xml' path='doc/member[@name="_Reserved1_e__FixedBuffer"]/*'/>
    public partial struct _Reserved1_e__FixedBuffer
    {
        public LARGE_INTEGER e0;
        public LARGE_INTEGER e1;
        public LARGE_INTEGER e2;
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
        public Span<LARGE_INTEGER> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 3);
    }
}