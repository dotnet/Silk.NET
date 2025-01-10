// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIB_TCP6TABLE_OWNER_MODULE
{
    [NativeTypeName("DWORD")]
    public uint dwNumEntries;

    [NativeTypeName("MIB_TCP6ROW_OWNER_MODULE[1]")]
    public _table_e__FixedBuffer table;

    public partial struct _table_e__FixedBuffer
    {
        public MIB_TCP6ROW_OWNER_MODULE e0;

        [UnscopedRef]
        public ref MIB_TCP6ROW_OWNER_MODULE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MIB_TCP6ROW_OWNER_MODULE> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
