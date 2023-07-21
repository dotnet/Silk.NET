// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MIB_IPMCAST_MFE.xml' path='doc/member[@name="MIB_IPMCAST_MFE"]/*' />
public partial struct MIB_IPMCAST_MFE
{
    /// <include file='MIB_IPMCAST_MFE.xml' path='doc/member[@name="MIB_IPMCAST_MFE.dwGroup"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwGroup;

    /// <include file='MIB_IPMCAST_MFE.xml' path='doc/member[@name="MIB_IPMCAST_MFE.dwSource"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSource;

    /// <include file='MIB_IPMCAST_MFE.xml' path='doc/member[@name="MIB_IPMCAST_MFE.dwSrcMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSrcMask;

    /// <include file='MIB_IPMCAST_MFE.xml' path='doc/member[@name="MIB_IPMCAST_MFE.dwUpStrmNgbr"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwUpStrmNgbr;

    /// <include file='MIB_IPMCAST_MFE.xml' path='doc/member[@name="MIB_IPMCAST_MFE.dwInIfIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInIfIndex;

    /// <include file='MIB_IPMCAST_MFE.xml' path='doc/member[@name="MIB_IPMCAST_MFE.dwInIfProtocol"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInIfProtocol;

    /// <include file='MIB_IPMCAST_MFE.xml' path='doc/member[@name="MIB_IPMCAST_MFE.dwRouteProtocol"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRouteProtocol;

    /// <include file='MIB_IPMCAST_MFE.xml' path='doc/member[@name="MIB_IPMCAST_MFE.dwRouteNetwork"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRouteNetwork;

    /// <include file='MIB_IPMCAST_MFE.xml' path='doc/member[@name="MIB_IPMCAST_MFE.dwRouteMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRouteMask;

    /// <include file='MIB_IPMCAST_MFE.xml' path='doc/member[@name="MIB_IPMCAST_MFE.ulUpTime"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulUpTime;

    /// <include file='MIB_IPMCAST_MFE.xml' path='doc/member[@name="MIB_IPMCAST_MFE.ulExpiryTime"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulExpiryTime;

    /// <include file='MIB_IPMCAST_MFE.xml' path='doc/member[@name="MIB_IPMCAST_MFE.ulTimeOut"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulTimeOut;

    /// <include file='MIB_IPMCAST_MFE.xml' path='doc/member[@name="MIB_IPMCAST_MFE.ulNumOutIf"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulNumOutIf;

    /// <include file='MIB_IPMCAST_MFE.xml' path='doc/member[@name="MIB_IPMCAST_MFE.fFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint fFlags;

    /// <include file='MIB_IPMCAST_MFE.xml' path='doc/member[@name="MIB_IPMCAST_MFE.dwReserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved;

    /// <include file='MIB_IPMCAST_MFE.xml' path='doc/member[@name="MIB_IPMCAST_MFE.rgmioOutInfo"]/*' />
    [NativeTypeName("MIB_IPMCAST_OIF[1]")]
    public _rgmioOutInfo_e__FixedBuffer rgmioOutInfo;

    /// <include file='_rgmioOutInfo_e__FixedBuffer.xml' path='doc/member[@name="_rgmioOutInfo_e__FixedBuffer"]/*' />
    public partial struct _rgmioOutInfo_e__FixedBuffer
    {
        public MIB_IPMCAST_OIF_XP e0;

        [UnscopedRef]
        public ref MIB_IPMCAST_OIF_XP this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MIB_IPMCAST_OIF_XP> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
