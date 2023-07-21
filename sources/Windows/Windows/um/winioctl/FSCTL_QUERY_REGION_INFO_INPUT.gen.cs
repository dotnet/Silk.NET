// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='FSCTL_QUERY_REGION_INFO_INPUT.xml' path='doc/member[@name="FSCTL_QUERY_REGION_INFO_INPUT"]/*' />
public partial struct FSCTL_QUERY_REGION_INFO_INPUT
{
    /// <include file='FSCTL_QUERY_REGION_INFO_INPUT.xml' path='doc/member[@name="FSCTL_QUERY_REGION_INFO_INPUT.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='FSCTL_QUERY_REGION_INFO_INPUT.xml' path='doc/member[@name="FSCTL_QUERY_REGION_INFO_INPUT.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='FSCTL_QUERY_REGION_INFO_INPUT.xml' path='doc/member[@name="FSCTL_QUERY_REGION_INFO_INPUT.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='FSCTL_QUERY_REGION_INFO_INPUT.xml' path='doc/member[@name="FSCTL_QUERY_REGION_INFO_INPUT.NumberOfTierIds"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfTierIds;

    /// <include file='FSCTL_QUERY_REGION_INFO_INPUT.xml' path='doc/member[@name="FSCTL_QUERY_REGION_INFO_INPUT.TierIds"]/*' />
    [NativeTypeName("GUID[1]")]
    public _TierIds_e__FixedBuffer TierIds;

    /// <include file='_TierIds_e__FixedBuffer.xml' path='doc/member[@name="_TierIds_e__FixedBuffer"]/*' />
    public partial struct _TierIds_e__FixedBuffer
    {
        public Guid e0;

        [UnscopedRef]
        public ref Guid this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<Guid> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
