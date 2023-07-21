// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='QUOTA_LIMITS.xml' path='doc/member[@name="QUOTA_LIMITS"]/*' />
public partial struct QUOTA_LIMITS
{
    /// <include file='QUOTA_LIMITS.xml' path='doc/member[@name="QUOTA_LIMITS.PagedPoolLimit"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint PagedPoolLimit;

    /// <include file='QUOTA_LIMITS.xml' path='doc/member[@name="QUOTA_LIMITS.NonPagedPoolLimit"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint NonPagedPoolLimit;

    /// <include file='QUOTA_LIMITS.xml' path='doc/member[@name="QUOTA_LIMITS.MinimumWorkingSetSize"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint MinimumWorkingSetSize;

    /// <include file='QUOTA_LIMITS.xml' path='doc/member[@name="QUOTA_LIMITS.MaximumWorkingSetSize"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint MaximumWorkingSetSize;

    /// <include file='QUOTA_LIMITS.xml' path='doc/member[@name="QUOTA_LIMITS.PagefileLimit"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint PagefileLimit;

    /// <include file='QUOTA_LIMITS.xml' path='doc/member[@name="QUOTA_LIMITS.TimeLimit"]/*' />
    public LARGE_INTEGER TimeLimit;
}
