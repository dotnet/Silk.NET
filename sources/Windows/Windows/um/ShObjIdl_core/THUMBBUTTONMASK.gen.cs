// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='THUMBBUTTONMASK.xml' path='doc/member[@name="THUMBBUTTONMASK"]/*' />
[Flags]
public enum THUMBBUTTONMASK
{
    /// <include file='THUMBBUTTONMASK.xml' path='doc/member[@name="THUMBBUTTONMASK.THB_BITMAP"]/*' />
    THB_BITMAP = 0x1,

    /// <include file='THUMBBUTTONMASK.xml' path='doc/member[@name="THUMBBUTTONMASK.THB_ICON"]/*' />
    THB_ICON = 0x2,

    /// <include file='THUMBBUTTONMASK.xml' path='doc/member[@name="THUMBBUTTONMASK.THB_TOOLTIP"]/*' />
    THB_TOOLTIP = 0x4,

    /// <include file='THUMBBUTTONMASK.xml' path='doc/member[@name="THUMBBUTTONMASK.THB_FLAGS"]/*' />
    THB_FLAGS = 0x8,
}
