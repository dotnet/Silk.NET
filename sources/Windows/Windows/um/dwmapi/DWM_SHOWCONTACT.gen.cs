// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='DWM_SHOWCONTACT.xml' path='doc/member[@name="DWM_SHOWCONTACT"]/*' />
[Flags]
public enum DWM_SHOWCONTACT
{
    /// <include file='DWM_SHOWCONTACT.xml' path='doc/member[@name="DWM_SHOWCONTACT.DWMSC_DOWN"]/*' />
    DWMSC_DOWN = 0x00000001,

    /// <include file='DWM_SHOWCONTACT.xml' path='doc/member[@name="DWM_SHOWCONTACT.DWMSC_UP"]/*' />
    DWMSC_UP = 0x00000002,

    /// <include file='DWM_SHOWCONTACT.xml' path='doc/member[@name="DWM_SHOWCONTACT.DWMSC_DRAG"]/*' />
    DWMSC_DRAG = 0x00000004,

    /// <include file='DWM_SHOWCONTACT.xml' path='doc/member[@name="DWM_SHOWCONTACT.DWMSC_HOLD"]/*' />
    DWMSC_HOLD = 0x00000008,

    /// <include file='DWM_SHOWCONTACT.xml' path='doc/member[@name="DWM_SHOWCONTACT.DWMSC_PENBARREL"]/*' />
    DWMSC_PENBARREL = 0x00000010,

    /// <include file='DWM_SHOWCONTACT.xml' path='doc/member[@name="DWM_SHOWCONTACT.DWMSC_NONE"]/*' />
    DWMSC_NONE = 0x00000000,

    /// <include file='DWM_SHOWCONTACT.xml' path='doc/member[@name="DWM_SHOWCONTACT.DWMSC_ALL"]/*' />
    DWMSC_ALL = unchecked((int)(0xFFFFFFFF)),
}
