// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='TRANSACTION_LIST_INFORMATION.xml' path='doc/member[@name="TRANSACTION_LIST_INFORMATION"]/*' />
public partial struct TRANSACTION_LIST_INFORMATION
{
    /// <include file='TRANSACTION_LIST_INFORMATION.xml' path='doc/member[@name="TRANSACTION_LIST_INFORMATION.NumberOfTransactions"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfTransactions;

    /// <include file='TRANSACTION_LIST_INFORMATION.xml' path='doc/member[@name="TRANSACTION_LIST_INFORMATION.TransactionInformation"]/*' />
    [NativeTypeName("TRANSACTION_LIST_ENTRY[1]")]
    public _TransactionInformation_e__FixedBuffer TransactionInformation;

    /// <include file='_TransactionInformation_e__FixedBuffer.xml' path='doc/member[@name="_TransactionInformation_e__FixedBuffer"]/*' />
    public partial struct _TransactionInformation_e__FixedBuffer
    {
        public TRANSACTION_LIST_ENTRY e0;

        [UnscopedRef]
        public ref TRANSACTION_LIST_ENTRY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<TRANSACTION_LIST_ENTRY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
