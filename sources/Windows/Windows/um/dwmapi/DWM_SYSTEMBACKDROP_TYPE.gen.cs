// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DWM_SYSTEMBACKDROP_TYPE.xml' path='doc/member[@name="DWM_SYSTEMBACKDROP_TYPE"]/*' />
public enum DWM_SYSTEMBACKDROP_TYPE
{
    /// <include file='DWM_SYSTEMBACKDROP_TYPE.xml' path='doc/member[@name="DWM_SYSTEMBACKDROP_TYPE.DWMSBT_AUTO"]/*' />
    DWMSBT_AUTO,

    /// <include file='DWM_SYSTEMBACKDROP_TYPE.xml' path='doc/member[@name="DWM_SYSTEMBACKDROP_TYPE.DWMSBT_NONE"]/*' />
    DWMSBT_NONE,

    /// <include file='DWM_SYSTEMBACKDROP_TYPE.xml' path='doc/member[@name="DWM_SYSTEMBACKDROP_TYPE.DWMSBT_MAINWINDOW"]/*' />
    DWMSBT_MAINWINDOW,

    /// <include file='DWM_SYSTEMBACKDROP_TYPE.xml' path='doc/member[@name="DWM_SYSTEMBACKDROP_TYPE.DWMSBT_TRANSIENTWINDOW"]/*' />
    DWMSBT_TRANSIENTWINDOW,

    /// <include file='DWM_SYSTEMBACKDROP_TYPE.xml' path='doc/member[@name="DWM_SYSTEMBACKDROP_TYPE.DWMSBT_TABBEDWINDOW"]/*' />
    DWMSBT_TABBEDWINDOW,
}
