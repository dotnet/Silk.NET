// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='STORAGE_TIER_REGION.xml' path='doc/member[@name="STORAGE_TIER_REGION"]/*' />
public partial struct STORAGE_TIER_REGION
{
    /// <include file='STORAGE_TIER_REGION.xml' path='doc/member[@name="STORAGE_TIER_REGION.TierId"]/*' />
    public Guid TierId;

    /// <include file='STORAGE_TIER_REGION.xml' path='doc/member[@name="STORAGE_TIER_REGION.Offset"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong Offset;

    /// <include file='STORAGE_TIER_REGION.xml' path='doc/member[@name="STORAGE_TIER_REGION.Length"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong Length;
}
