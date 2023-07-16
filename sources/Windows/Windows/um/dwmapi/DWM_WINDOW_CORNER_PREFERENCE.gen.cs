// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DWM_WINDOW_CORNER_PREFERENCE.xml' path='doc/member[@name="DWM_WINDOW_CORNER_PREFERENCE"]/*'/>
public enum DWM_WINDOW_CORNER_PREFERENCE
{
    /// <include file='DWM_WINDOW_CORNER_PREFERENCE.xml' path='doc/member[@name="DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_DEFAULT"]/*'/>
    DWMWCP_DEFAULT = 0,
    /// <include file='DWM_WINDOW_CORNER_PREFERENCE.xml' path='doc/member[@name="DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_DONOTROUND"]/*'/>
    DWMWCP_DONOTROUND = 1,
    /// <include file='DWM_WINDOW_CORNER_PREFERENCE.xml' path='doc/member[@name="DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND"]/*'/>
    DWMWCP_ROUND = 2,
    /// <include file='DWM_WINDOW_CORNER_PREFERENCE.xml' path='doc/member[@name="DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUNDSMALL"]/*'/>
    DWMWCP_ROUNDSMALL = 3,
}