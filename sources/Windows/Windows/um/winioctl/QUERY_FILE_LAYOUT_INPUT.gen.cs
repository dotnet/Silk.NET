// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='QUERY_FILE_LAYOUT_INPUT.xml' path='doc/member[@name="QUERY_FILE_LAYOUT_INPUT"]/*'/>
public partial struct QUERY_FILE_LAYOUT_INPUT
{
    /// <include file='QUERY_FILE_LAYOUT_INPUT.xml' path='doc/member[@name="QUERY_FILE_LAYOUT_INPUT.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L14958_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='QUERY_FILE_LAYOUT_INPUT.xml' path='doc/member[@name="QUERY_FILE_LAYOUT_INPUT.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='QUERY_FILE_LAYOUT_INPUT.xml' path='doc/member[@name="QUERY_FILE_LAYOUT_INPUT.FilterType"]/*'/>
    public QUERY_FILE_LAYOUT_FILTER_TYPE FilterType;
    /// <include file='QUERY_FILE_LAYOUT_INPUT.xml' path='doc/member[@name="QUERY_FILE_LAYOUT_INPUT.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
    /// <include file='QUERY_FILE_LAYOUT_INPUT.xml' path='doc/member[@name="QUERY_FILE_LAYOUT_INPUT.Filter"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L14985_C5")]
    public _Filter_e__Union Filter;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FilterEntryCount"]/*'/>
    [UnscopedRef]
    public ref uint FilterEntryCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.FilterEntryCount;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumberOfPairs"]/*'/>
    [UnscopedRef]
    public ref uint NumberOfPairs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.NumberOfPairs;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FilterEntryCount"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint FilterEntryCount;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumberOfPairs"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint NumberOfPairs;
    }

    /// <include file='_Filter_e__Union.xml' path='doc/member[@name="_Filter_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Filter_e__Union
    {
        /// <include file='_Filter_e__Union.xml' path='doc/member[@name="_Filter_e__Union.ClusterRanges"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("CLUSTER_RANGE[1]")]
        public _ClusterRanges_e__FixedBuffer ClusterRanges;
        /// <include file='_Filter_e__Union.xml' path='doc/member[@name="_Filter_e__Union.FileReferenceRanges"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("FILE_REFERENCE_RANGE[1]")]
        public _FileReferenceRanges_e__FixedBuffer FileReferenceRanges;
        /// <include file='_Filter_e__Union.xml' path='doc/member[@name="_Filter_e__Union.StorageReserveIds"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("STORAGE_RESERVE_ID[1]")]
        public _StorageReserveIds_e__FixedBuffer StorageReserveIds;
        /// <include file='_ClusterRanges_e__FixedBuffer.xml' path='doc/member[@name="_ClusterRanges_e__FixedBuffer"]/*'/>
        public partial struct _ClusterRanges_e__FixedBuffer
        {
            public CLUSTER_RANGE e0;
            [UnscopedRef]
            public ref CLUSTER_RANGE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<CLUSTER_RANGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }

        /// <include file='_FileReferenceRanges_e__FixedBuffer.xml' path='doc/member[@name="_FileReferenceRanges_e__FixedBuffer"]/*'/>
        public partial struct _FileReferenceRanges_e__FixedBuffer
        {
            public FILE_REFERENCE_RANGE e0;
            [UnscopedRef]
            public ref FILE_REFERENCE_RANGE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<FILE_REFERENCE_RANGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }

        /// <include file='_StorageReserveIds_e__FixedBuffer.xml' path='doc/member[@name="_StorageReserveIds_e__FixedBuffer"]/*'/>
        public partial struct _StorageReserveIds_e__FixedBuffer
        {
            public STORAGE_RESERVE_ID e0;
            [UnscopedRef]
            public ref STORAGE_RESERVE_ID this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<STORAGE_RESERVE_ID> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}