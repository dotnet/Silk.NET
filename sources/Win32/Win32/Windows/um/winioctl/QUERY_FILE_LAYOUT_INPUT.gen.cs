// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct QUERY_FILE_LAYOUT_INPUT
{
    [NativeTypeName("__AnonymousRecord_winioctl_L15312_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD")]
    public uint Flags;
    public QUERY_FILE_LAYOUT_FILTER_TYPE FilterType;

    [NativeTypeName("DWORD")]
    public uint Reserved;

    [NativeTypeName("__AnonymousRecord_winioctl_L15339_C5")]
    public _Filter_e__Union Filter;

    [UnscopedRef]
    public ref uint FilterEntryCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.FilterEntryCount; }
    }

    [UnscopedRef]
    public ref uint NumberOfPairs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.NumberOfPairs; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint FilterEntryCount;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint NumberOfPairs;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Filter_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("CLUSTER_RANGE[1]")]
        public _ClusterRanges_e__FixedBuffer ClusterRanges;

        [FieldOffset(0)]
        [NativeTypeName("FILE_REFERENCE_RANGE[1]")]
        public _FileReferenceRanges_e__FixedBuffer FileReferenceRanges;

        [FieldOffset(0)]
        [NativeTypeName("STORAGE_RESERVE_ID[1]")]
        public _StorageReserveIds_e__FixedBuffer StorageReserveIds;

        public partial struct _ClusterRanges_e__FixedBuffer
        {
            public CLUSTER_RANGE e0;

            [UnscopedRef]
            public ref CLUSTER_RANGE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return ref Unsafe.Add(ref e0, index); }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<CLUSTER_RANGE> AsSpan(int length) =>
                MemoryMarshal.CreateSpan(ref e0, length);
        }

        public partial struct _FileReferenceRanges_e__FixedBuffer
        {
            public FILE_REFERENCE_RANGE e0;

            [UnscopedRef]
            public ref FILE_REFERENCE_RANGE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return ref Unsafe.Add(ref e0, index); }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<FILE_REFERENCE_RANGE> AsSpan(int length) =>
                MemoryMarshal.CreateSpan(ref e0, length);
        }

        public partial struct _StorageReserveIds_e__FixedBuffer
        {
            public STORAGE_RESERVE_ID e0;

            [UnscopedRef]
            public ref STORAGE_RESERVE_ID this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return ref Unsafe.Add(ref e0, index); }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<STORAGE_RESERVE_ID> AsSpan(int length) =>
                MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
