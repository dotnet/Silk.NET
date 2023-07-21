// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE"]/*' />
public partial struct STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE
{
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE.ResponseLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint ResponseLevel;

    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE.NumberEntries"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberEntries;

    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winioctl_L13983_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Lev1Depends"]/*' />
    [UnscopedRef]
    public Span<STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY> Lev1Depends
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Lev1Depends.AsSpan();
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Lev2Depends"]/*' />
    [UnscopedRef]
    public Span<STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY> Lev2Depends
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Lev2Depends.AsSpan();
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Lev1Depends"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY[]")]
        public _Lev1Depends_e__FixedBuffer Lev1Depends;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Lev2Depends"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY[]")]
        public _Lev2Depends_e__FixedBuffer Lev2Depends;

        /// <include file='_Lev1Depends_e__FixedBuffer.xml' path='doc/member[@name="_Lev1Depends_e__FixedBuffer"]/*' />
        public partial struct _Lev1Depends_e__FixedBuffer
        {
            public STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY e0;

            [UnscopedRef]
            public ref STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }

        /// <include file='_Lev2Depends_e__FixedBuffer.xml' path='doc/member[@name="_Lev2Depends_e__FixedBuffer"]/*' />
        public partial struct _Lev2Depends_e__FixedBuffer
        {
            public STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY e0;

            [UnscopedRef]
            public ref STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
