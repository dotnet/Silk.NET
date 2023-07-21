// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PPM_IDLE_STATE_ACCOUNTING.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING"]/*' />
public unsafe partial struct PPM_IDLE_STATE_ACCOUNTING
{
    /// <include file='PPM_IDLE_STATE_ACCOUNTING.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING.IdleTransitions"]/*' />
    [NativeTypeName("DWORD")]
    public uint IdleTransitions;

    /// <include file='PPM_IDLE_STATE_ACCOUNTING.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING.FailedTransitions"]/*' />
    [NativeTypeName("DWORD")]
    public uint FailedTransitions;

    /// <include file='PPM_IDLE_STATE_ACCOUNTING.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING.InvalidBucketIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint InvalidBucketIndex;

    /// <include file='PPM_IDLE_STATE_ACCOUNTING.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING.TotalTime"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong TotalTime;

    /// <include file='PPM_IDLE_STATE_ACCOUNTING.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING.IdleTimeBuckets"]/*' />
    [NativeTypeName("DWORD[6]")]
    public fixed uint IdleTimeBuckets[6];
}
