// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='FILE_REGION_OUTPUT.xml' path='doc/member[@name="FILE_REGION_OUTPUT"]/*' />
public partial struct FILE_REGION_OUTPUT
{
    /// <include file='FILE_REGION_OUTPUT.xml' path='doc/member[@name="FILE_REGION_OUTPUT.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='FILE_REGION_OUTPUT.xml' path='doc/member[@name="FILE_REGION_OUTPUT.TotalRegionEntryCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint TotalRegionEntryCount;

    /// <include file='FILE_REGION_OUTPUT.xml' path='doc/member[@name="FILE_REGION_OUTPUT.RegionEntryCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint RegionEntryCount;

    /// <include file='FILE_REGION_OUTPUT.xml' path='doc/member[@name="FILE_REGION_OUTPUT.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;

    /// <include file='FILE_REGION_OUTPUT.xml' path='doc/member[@name="FILE_REGION_OUTPUT.Region"]/*' />
    [NativeTypeName("FILE_REGION_INFO[1]")]
    public _Region_e__FixedBuffer Region;

    /// <include file='_Region_e__FixedBuffer.xml' path='doc/member[@name="_Region_e__FixedBuffer"]/*' />
    public partial struct _Region_e__FixedBuffer
    {
        public FILE_REGION_INFO e0;

        [UnscopedRef]
        public ref FILE_REGION_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<FILE_REGION_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
