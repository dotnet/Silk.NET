// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_COUNTERS.xml' path='doc/member[@name="STORAGE_COUNTERS"]/*'/>
public partial struct STORAGE_COUNTERS
{
    /// <include file='STORAGE_COUNTERS.xml' path='doc/member[@name="STORAGE_COUNTERS.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_COUNTERS.xml' path='doc/member[@name="STORAGE_COUNTERS.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_COUNTERS.xml' path='doc/member[@name="STORAGE_COUNTERS.NumberOfCounters"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfCounters;
    /// <include file='STORAGE_COUNTERS.xml' path='doc/member[@name="STORAGE_COUNTERS.Counters"]/*'/>
    [NativeTypeName("STORAGE_COUNTER[1]")]
    public _Counters_e__FixedBuffer Counters;
    /// <include file='_Counters_e__FixedBuffer.xml' path='doc/member[@name="_Counters_e__FixedBuffer"]/*'/>
    public partial struct _Counters_e__FixedBuffer
    {
        public STORAGE_COUNTER e0;
        [UnscopedRef]
        public ref STORAGE_COUNTER this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<STORAGE_COUNTER> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}