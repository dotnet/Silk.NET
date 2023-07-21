// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DUPLICATE_EXTENTS_STATE.xml' path='doc/member[@name="DUPLICATE_EXTENTS_STATE"]/*' />
public enum DUPLICATE_EXTENTS_STATE
{
    /// <include file='DUPLICATE_EXTENTS_STATE.xml' path='doc/member[@name="DUPLICATE_EXTENTS_STATE.FileSnapStateInactive"]/*' />
    FileSnapStateInactive = 0,

    /// <include file='DUPLICATE_EXTENTS_STATE.xml' path='doc/member[@name="DUPLICATE_EXTENTS_STATE.FileSnapStateSource"]/*' />
    FileSnapStateSource,

    /// <include file='DUPLICATE_EXTENTS_STATE.xml' path='doc/member[@name="DUPLICATE_EXTENTS_STATE.FileSnapStateTarget"]/*' />
    FileSnapStateTarget,
}
