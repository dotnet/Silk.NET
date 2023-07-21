// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DEVICE_DSM_LOST_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_LOST_QUERY_OUTPUT"]/*' />
public unsafe partial struct DEVICE_DSM_LOST_QUERY_OUTPUT
{
    /// <include file='DEVICE_DSM_LOST_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_LOST_QUERY_OUTPUT.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='DEVICE_DSM_LOST_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_LOST_QUERY_OUTPUT.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='DEVICE_DSM_LOST_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_LOST_QUERY_OUTPUT.Alignment"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong Alignment;

    /// <include file='DEVICE_DSM_LOST_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_LOST_QUERY_OUTPUT.NumberOfBits"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfBits;

    /// <include file='DEVICE_DSM_LOST_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_LOST_QUERY_OUTPUT.BitMap"]/*' />
    [NativeTypeName("DWORD[1]")]
    public fixed uint BitMap[1];
}
