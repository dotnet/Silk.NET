// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='SD_ENUM_SDS_OUTPUT.xml' path='doc/member[@name="SD_ENUM_SDS_OUTPUT"]/*' />
public partial struct SD_ENUM_SDS_OUTPUT
{
    /// <include file='SD_ENUM_SDS_OUTPUT.xml' path='doc/member[@name="SD_ENUM_SDS_OUTPUT.NextOffset"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong NextOffset;

    /// <include file='SD_ENUM_SDS_OUTPUT.xml' path='doc/member[@name="SD_ENUM_SDS_OUTPUT.NumSDEntriesReturned"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong NumSDEntriesReturned;

    /// <include file='SD_ENUM_SDS_OUTPUT.xml' path='doc/member[@name="SD_ENUM_SDS_OUTPUT.NumSDBytesReturned"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong NumSDBytesReturned;

    /// <include file='SD_ENUM_SDS_OUTPUT.xml' path='doc/member[@name="SD_ENUM_SDS_OUTPUT.SDEntry"]/*' />
    [NativeTypeName("SD_ENUM_SDS_ENTRY[1]")]
    public _SDEntry_e__FixedBuffer SDEntry;

    /// <include file='_SDEntry_e__FixedBuffer.xml' path='doc/member[@name="_SDEntry_e__FixedBuffer"]/*' />
    public partial struct _SDEntry_e__FixedBuffer
    {
        public SD_ENUM_SDS_ENTRY e0;

        [UnscopedRef]
        public ref SD_ENUM_SDS_ENTRY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SD_ENUM_SDS_ENTRY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
