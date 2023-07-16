// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE"]/*'/>
public enum DWMWINDOWATTRIBUTE
{
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_NCRENDERING_ENABLED"]/*'/>
    DWMWA_NCRENDERING_ENABLED = 1,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_NCRENDERING_POLICY"]/*'/>
    DWMWA_NCRENDERING_POLICY,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_TRANSITIONS_FORCEDISABLED"]/*'/>
    DWMWA_TRANSITIONS_FORCEDISABLED,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_ALLOW_NCPAINT"]/*'/>
    DWMWA_ALLOW_NCPAINT,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_CAPTION_BUTTON_BOUNDS"]/*'/>
    DWMWA_CAPTION_BUTTON_BOUNDS,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_NONCLIENT_RTL_LAYOUT"]/*'/>
    DWMWA_NONCLIENT_RTL_LAYOUT,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_FORCE_ICONIC_REPRESENTATION"]/*'/>
    DWMWA_FORCE_ICONIC_REPRESENTATION,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_FLIP3D_POLICY"]/*'/>
    DWMWA_FLIP3D_POLICY,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_EXTENDED_FRAME_BOUNDS"]/*'/>
    DWMWA_EXTENDED_FRAME_BOUNDS,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_HAS_ICONIC_BITMAP"]/*'/>
    DWMWA_HAS_ICONIC_BITMAP,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_DISALLOW_PEEK"]/*'/>
    DWMWA_DISALLOW_PEEK,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_EXCLUDED_FROM_PEEK"]/*'/>
    DWMWA_EXCLUDED_FROM_PEEK,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_CLOAK"]/*'/>
    DWMWA_CLOAK,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_CLOAKED"]/*'/>
    DWMWA_CLOAKED,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_FREEZE_REPRESENTATION"]/*'/>
    DWMWA_FREEZE_REPRESENTATION,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_PASSIVE_UPDATE_MODE"]/*'/>
    DWMWA_PASSIVE_UPDATE_MODE,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_USE_HOSTBACKDROPBRUSH"]/*'/>
    DWMWA_USE_HOSTBACKDROPBRUSH,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE"]/*'/>
    DWMWA_USE_IMMERSIVE_DARK_MODE = 20,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE"]/*'/>
    DWMWA_WINDOW_CORNER_PREFERENCE = 33,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_BORDER_COLOR"]/*'/>
    DWMWA_BORDER_COLOR,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_CAPTION_COLOR"]/*'/>
    DWMWA_CAPTION_COLOR,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_TEXT_COLOR"]/*'/>
    DWMWA_TEXT_COLOR,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_VISIBLE_FRAME_BORDER_THICKNESS"]/*'/>
    DWMWA_VISIBLE_FRAME_BORDER_THICKNESS,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_SYSTEMBACKDROP_TYPE"]/*'/>
    DWMWA_SYSTEMBACKDROP_TYPE,
    /// <include file='DWMWINDOWATTRIBUTE.xml' path='doc/member[@name="DWMWINDOWATTRIBUTE.DWMWA_LAST"]/*'/>
    DWMWA_LAST,
}