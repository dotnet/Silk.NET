// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PPM_IDLE_STATE_BUCKET_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_BUCKET_EX"]/*' />
public partial struct PPM_IDLE_STATE_BUCKET_EX
{
    /// <include file='PPM_IDLE_STATE_BUCKET_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_BUCKET_EX.TotalTimeUs"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong TotalTimeUs;

    /// <include file='PPM_IDLE_STATE_BUCKET_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_BUCKET_EX.MinTimeUs"]/*' />
    [NativeTypeName("DWORD")]
    public uint MinTimeUs;

    /// <include file='PPM_IDLE_STATE_BUCKET_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_BUCKET_EX.MaxTimeUs"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxTimeUs;

    /// <include file='PPM_IDLE_STATE_BUCKET_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_BUCKET_EX.Count"]/*' />
    [NativeTypeName("DWORD")]
    public uint Count;
}
