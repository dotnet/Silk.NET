// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='SCM_REGIONS.xml' path='doc/member[@name="SCM_REGIONS"]/*' />
public partial struct SCM_REGIONS
{
    /// <include file='SCM_REGIONS.xml' path='doc/member[@name="SCM_REGIONS.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='SCM_REGIONS.xml' path='doc/member[@name="SCM_REGIONS.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SCM_REGIONS.xml' path='doc/member[@name="SCM_REGIONS.RegionCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint RegionCount;

    /// <include file='SCM_REGIONS.xml' path='doc/member[@name="SCM_REGIONS.Regions"]/*' />
    [NativeTypeName("SCM_REGION[1]")]
    public _Regions_e__FixedBuffer Regions;

    /// <include file='_Regions_e__FixedBuffer.xml' path='doc/member[@name="_Regions_e__FixedBuffer"]/*' />
    public partial struct _Regions_e__FixedBuffer
    {
        public SCM_REGION e0;

        [UnscopedRef]
        public ref SCM_REGION this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SCM_REGION> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
