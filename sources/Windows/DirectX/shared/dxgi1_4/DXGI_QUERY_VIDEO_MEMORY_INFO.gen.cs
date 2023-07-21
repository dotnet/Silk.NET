// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_4.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DXGI_QUERY_VIDEO_MEMORY_INFO.xml' path='doc/member[@name="DXGI_QUERY_VIDEO_MEMORY_INFO"]/*' />
public partial struct DXGI_QUERY_VIDEO_MEMORY_INFO
{
    /// <include file='DXGI_QUERY_VIDEO_MEMORY_INFO.xml' path='doc/member[@name="DXGI_QUERY_VIDEO_MEMORY_INFO.Budget"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Budget;

    /// <include file='DXGI_QUERY_VIDEO_MEMORY_INFO.xml' path='doc/member[@name="DXGI_QUERY_VIDEO_MEMORY_INFO.CurrentUsage"]/*' />
    [NativeTypeName("UINT64")]
    public ulong CurrentUsage;

    /// <include file='DXGI_QUERY_VIDEO_MEMORY_INFO.xml' path='doc/member[@name="DXGI_QUERY_VIDEO_MEMORY_INFO.AvailableForReservation"]/*' />
    [NativeTypeName("UINT64")]
    public ulong AvailableForReservation;

    /// <include file='DXGI_QUERY_VIDEO_MEMORY_INFO.xml' path='doc/member[@name="DXGI_QUERY_VIDEO_MEMORY_INFO.CurrentReservation"]/*' />
    [NativeTypeName("UINT64")]
    public ulong CurrentReservation;
}
