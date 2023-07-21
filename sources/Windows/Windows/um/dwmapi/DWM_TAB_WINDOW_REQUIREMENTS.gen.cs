// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='DWM_TAB_WINDOW_REQUIREMENTS.xml' path='doc/member[@name="DWM_TAB_WINDOW_REQUIREMENTS"]/*' />
[Flags]
[SupportedOSPlatform("windows10.0.17134.0")]
public enum DWM_TAB_WINDOW_REQUIREMENTS
{
    /// <include file='DWM_TAB_WINDOW_REQUIREMENTS.xml' path='doc/member[@name="DWM_TAB_WINDOW_REQUIREMENTS.DWMTWR_NONE"]/*' />
    DWMTWR_NONE = 0x0000,

    /// <include file='DWM_TAB_WINDOW_REQUIREMENTS.xml' path='doc/member[@name="DWM_TAB_WINDOW_REQUIREMENTS.DWMTWR_IMPLEMENTED_BY_SYSTEM"]/*' />
    DWMTWR_IMPLEMENTED_BY_SYSTEM = 0x0001,

    /// <include file='DWM_TAB_WINDOW_REQUIREMENTS.xml' path='doc/member[@name="DWM_TAB_WINDOW_REQUIREMENTS.DWMTWR_WINDOW_RELATIONSHIP"]/*' />
    DWMTWR_WINDOW_RELATIONSHIP = 0x0002,

    /// <include file='DWM_TAB_WINDOW_REQUIREMENTS.xml' path='doc/member[@name="DWM_TAB_WINDOW_REQUIREMENTS.DWMTWR_WINDOW_STYLES"]/*' />
    DWMTWR_WINDOW_STYLES = 0x0004,

    /// <include file='DWM_TAB_WINDOW_REQUIREMENTS.xml' path='doc/member[@name="DWM_TAB_WINDOW_REQUIREMENTS.DWMTWR_WINDOW_REGION"]/*' />
    DWMTWR_WINDOW_REGION = 0x0008,

    /// <include file='DWM_TAB_WINDOW_REQUIREMENTS.xml' path='doc/member[@name="DWM_TAB_WINDOW_REQUIREMENTS.DWMTWR_WINDOW_DWM_ATTRIBUTES"]/*' />
    DWMTWR_WINDOW_DWM_ATTRIBUTES = 0x0010,

    /// <include file='DWM_TAB_WINDOW_REQUIREMENTS.xml' path='doc/member[@name="DWM_TAB_WINDOW_REQUIREMENTS.DWMTWR_WINDOW_MARGINS"]/*' />
    DWMTWR_WINDOW_MARGINS = 0x0020,

    /// <include file='DWM_TAB_WINDOW_REQUIREMENTS.xml' path='doc/member[@name="DWM_TAB_WINDOW_REQUIREMENTS.DWMTWR_TABBING_ENABLED"]/*' />
    DWMTWR_TABBING_ENABLED = 0x0040,

    /// <include file='DWM_TAB_WINDOW_REQUIREMENTS.xml' path='doc/member[@name="DWM_TAB_WINDOW_REQUIREMENTS.DWMTWR_USER_POLICY"]/*' />
    DWMTWR_USER_POLICY = 0x0080,

    /// <include file='DWM_TAB_WINDOW_REQUIREMENTS.xml' path='doc/member[@name="DWM_TAB_WINDOW_REQUIREMENTS.DWMTWR_GROUP_POLICY"]/*' />
    DWMTWR_GROUP_POLICY = 0x0100,

    /// <include file='DWM_TAB_WINDOW_REQUIREMENTS.xml' path='doc/member[@name="DWM_TAB_WINDOW_REQUIREMENTS.DWMTWR_APP_COMPAT"]/*' />
    DWMTWR_APP_COMPAT = 0x0200,
}
