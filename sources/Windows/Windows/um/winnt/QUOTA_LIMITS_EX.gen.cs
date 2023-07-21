// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX"]/*' />
public partial struct QUOTA_LIMITS_EX
{
    /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.PagedPoolLimit"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint PagedPoolLimit;

    /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.NonPagedPoolLimit"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint NonPagedPoolLimit;

    /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.MinimumWorkingSetSize"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint MinimumWorkingSetSize;

    /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.MaximumWorkingSetSize"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint MaximumWorkingSetSize;

    /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.PagefileLimit"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint PagefileLimit;

    /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.TimeLimit"]/*' />
    public LARGE_INTEGER TimeLimit;

    /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.WorkingSetLimit"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint WorkingSetLimit;

    /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.Reserved2"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint Reserved2;

    /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.Reserved3"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint Reserved3;

    /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.Reserved4"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint Reserved4;

    /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.CpuRateLimit"]/*' />
    public RATE_QUOTA_LIMIT CpuRateLimit;
}
