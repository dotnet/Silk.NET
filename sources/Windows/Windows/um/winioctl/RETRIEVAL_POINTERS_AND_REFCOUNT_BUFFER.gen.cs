// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='RETRIEVAL_POINTERS_AND_REFCOUNT_BUFFER.xml' path='doc/member[@name="RETRIEVAL_POINTERS_AND_REFCOUNT_BUFFER"]/*'/>
public partial struct RETRIEVAL_POINTERS_AND_REFCOUNT_BUFFER
{
    /// <include file='RETRIEVAL_POINTERS_AND_REFCOUNT_BUFFER.xml' path='doc/member[@name="RETRIEVAL_POINTERS_AND_REFCOUNT_BUFFER.ExtentCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExtentCount;
    /// <include file='RETRIEVAL_POINTERS_AND_REFCOUNT_BUFFER.xml' path='doc/member[@name="RETRIEVAL_POINTERS_AND_REFCOUNT_BUFFER.StartingVcn"]/*'/>
    public LARGE_INTEGER StartingVcn;
    /// <include file='RETRIEVAL_POINTERS_AND_REFCOUNT_BUFFER.xml' path='doc/member[@name="RETRIEVAL_POINTERS_AND_REFCOUNT_BUFFER.Extents"]/*'/>
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um/winioctl.h:11173:5)[1]")]
    public _Extents_e__FixedBuffer Extents;
    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
    public partial struct _Anonymous_e__Struct
    {
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.NextVcn"]/*'/>
        public LARGE_INTEGER NextVcn;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Lcn"]/*'/>
        public LARGE_INTEGER Lcn;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReferenceCount"]/*'/>
        [NativeTypeName("DWORD")]
        public uint ReferenceCount;
    }

    /// <include file='_Extents_e__FixedBuffer.xml' path='doc/member[@name="_Extents_e__FixedBuffer"]/*'/>
    public partial struct _Extents_e__FixedBuffer
    {
        public _Anonymous_e__Struct e0;
        [UnscopedRef]
        public ref _Anonymous_e__Struct this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<_Anonymous_e__Struct> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}