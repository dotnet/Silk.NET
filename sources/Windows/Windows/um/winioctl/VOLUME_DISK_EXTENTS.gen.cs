// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='VOLUME_DISK_EXTENTS.xml' path='doc/member[@name="VOLUME_DISK_EXTENTS"]/*' />
public partial struct VOLUME_DISK_EXTENTS
{
    /// <include file='VOLUME_DISK_EXTENTS.xml' path='doc/member[@name="VOLUME_DISK_EXTENTS.NumberOfDiskExtents"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfDiskExtents;

    /// <include file='VOLUME_DISK_EXTENTS.xml' path='doc/member[@name="VOLUME_DISK_EXTENTS.Extents"]/*' />
    [NativeTypeName("DISK_EXTENT[1]")]
    public _Extents_e__FixedBuffer Extents;

    /// <include file='_Extents_e__FixedBuffer.xml' path='doc/member[@name="_Extents_e__FixedBuffer"]/*' />
    public partial struct _Extents_e__FixedBuffer
    {
        public DISK_EXTENT e0;

        [UnscopedRef]
        public ref DISK_EXTENT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<DISK_EXTENT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
