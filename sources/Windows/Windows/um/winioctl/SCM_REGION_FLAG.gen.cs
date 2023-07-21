// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SCM_REGION_FLAG.xml' path='doc/member[@name="SCM_REGION_FLAG"]/*' />
public enum SCM_REGION_FLAG
{
    /// <include file='SCM_REGION_FLAG.xml' path='doc/member[@name="SCM_REGION_FLAG.ScmRegionFlagNone"]/*' />
    ScmRegionFlagNone = 0x0,

    /// <include file='SCM_REGION_FLAG.xml' path='doc/member[@name="SCM_REGION_FLAG.ScmRegionFlagLabel"]/*' />
    ScmRegionFlagLabel = 0x1,
}
