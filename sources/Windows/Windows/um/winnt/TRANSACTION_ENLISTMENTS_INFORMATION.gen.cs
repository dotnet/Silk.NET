// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='TRANSACTION_ENLISTMENTS_INFORMATION.xml' path='doc/member[@name="TRANSACTION_ENLISTMENTS_INFORMATION"]/*'/>
public partial struct TRANSACTION_ENLISTMENTS_INFORMATION
{
    /// <include file='TRANSACTION_ENLISTMENTS_INFORMATION.xml' path='doc/member[@name="TRANSACTION_ENLISTMENTS_INFORMATION.NumberOfEnlistments"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfEnlistments;
    /// <include file='TRANSACTION_ENLISTMENTS_INFORMATION.xml' path='doc/member[@name="TRANSACTION_ENLISTMENTS_INFORMATION.EnlistmentPair"]/*'/>
    [NativeTypeName("TRANSACTION_ENLISTMENT_PAIR[1]")]
    public _EnlistmentPair_e__FixedBuffer EnlistmentPair;
    /// <include file='_EnlistmentPair_e__FixedBuffer.xml' path='doc/member[@name="_EnlistmentPair_e__FixedBuffer"]/*'/>
    public partial struct _EnlistmentPair_e__FixedBuffer
    {
        public TRANSACTION_ENLISTMENT_PAIR e0;
        [UnscopedRef]
        public ref TRANSACTION_ENLISTMENT_PAIR this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<TRANSACTION_ENLISTMENT_PAIR> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}