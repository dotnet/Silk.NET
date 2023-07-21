// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STORAGE_ALLOCATE_BC_STREAM_OUTPUT.xml' path='doc/member[@name="STORAGE_ALLOCATE_BC_STREAM_OUTPUT"]/*' />
public partial struct STORAGE_ALLOCATE_BC_STREAM_OUTPUT
{
    /// <include file='STORAGE_ALLOCATE_BC_STREAM_OUTPUT.xml' path='doc/member[@name="STORAGE_ALLOCATE_BC_STREAM_OUTPUT.RequestSize"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong RequestSize;

    /// <include file='STORAGE_ALLOCATE_BC_STREAM_OUTPUT.xml' path='doc/member[@name="STORAGE_ALLOCATE_BC_STREAM_OUTPUT.NumOutStandingRequests"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumOutStandingRequests;
}
