// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='PSAPI_WORKING_SET_INFORMATION.xml' path='doc/member[@name="PSAPI_WORKING_SET_INFORMATION"]/*' />
public partial struct PSAPI_WORKING_SET_INFORMATION
{
    /// <include file='PSAPI_WORKING_SET_INFORMATION.xml' path='doc/member[@name="PSAPI_WORKING_SET_INFORMATION.NumberOfEntries"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint NumberOfEntries;

    /// <include file='PSAPI_WORKING_SET_INFORMATION.xml' path='doc/member[@name="PSAPI_WORKING_SET_INFORMATION.WorkingSetInfo"]/*' />
    [NativeTypeName("PSAPI_WORKING_SET_BLOCK[1]")]
    public _WorkingSetInfo_e__FixedBuffer WorkingSetInfo;

    /// <include file='_WorkingSetInfo_e__FixedBuffer.xml' path='doc/member[@name="_WorkingSetInfo_e__FixedBuffer"]/*' />
    public partial struct _WorkingSetInfo_e__FixedBuffer
    {
        public PSAPI_WORKING_SET_BLOCK e0;

        [UnscopedRef]
        public ref PSAPI_WORKING_SET_BLOCK this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PSAPI_WORKING_SET_BLOCK> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
