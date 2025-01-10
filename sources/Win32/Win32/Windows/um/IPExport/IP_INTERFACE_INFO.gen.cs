// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IP_INTERFACE_INFO
{
    [NativeTypeName("LONG")]
    public int NumAdapters;

    [NativeTypeName("IP_ADAPTER_INDEX_MAP[1]")]
    public _Adapter_e__FixedBuffer Adapter;

    public partial struct _Adapter_e__FixedBuffer
    {
        public IP_ADAPTER_INDEX_MAP e0;

        [UnscopedRef]
        public ref IP_ADAPTER_INDEX_MAP this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<IP_ADAPTER_INDEX_MAP> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
