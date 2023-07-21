// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SHRINK_VOLUME_REQUEST_TYPES.xml' path='doc/member[@name="SHRINK_VOLUME_REQUEST_TYPES"]/*' />
public enum SHRINK_VOLUME_REQUEST_TYPES
{
    /// <include file='SHRINK_VOLUME_REQUEST_TYPES.xml' path='doc/member[@name="SHRINK_VOLUME_REQUEST_TYPES.ShrinkPrepare"]/*' />
    ShrinkPrepare = 1,

    /// <include file='SHRINK_VOLUME_REQUEST_TYPES.xml' path='doc/member[@name="SHRINK_VOLUME_REQUEST_TYPES.ShrinkCommit"]/*' />
    ShrinkCommit,

    /// <include file='SHRINK_VOLUME_REQUEST_TYPES.xml' path='doc/member[@name="SHRINK_VOLUME_REQUEST_TYPES.ShrinkAbort"]/*' />
    ShrinkAbort,
}
