// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DESKTOP_WALLPAPER_POSITION.xml' path='doc/member[@name="DESKTOP_WALLPAPER_POSITION"]/*'/>
public enum DESKTOP_WALLPAPER_POSITION
{
    /// <include file='DESKTOP_WALLPAPER_POSITION.xml' path='doc/member[@name="DESKTOP_WALLPAPER_POSITION.DWPOS_CENTER"]/*'/>
    DWPOS_CENTER = 0,
    /// <include file='DESKTOP_WALLPAPER_POSITION.xml' path='doc/member[@name="DESKTOP_WALLPAPER_POSITION.DWPOS_TILE"]/*'/>
    DWPOS_TILE = 1,
    /// <include file='DESKTOP_WALLPAPER_POSITION.xml' path='doc/member[@name="DESKTOP_WALLPAPER_POSITION.DWPOS_STRETCH"]/*'/>
    DWPOS_STRETCH = 2,
    /// <include file='DESKTOP_WALLPAPER_POSITION.xml' path='doc/member[@name="DESKTOP_WALLPAPER_POSITION.DWPOS_FIT"]/*'/>
    DWPOS_FIT = 3,
    /// <include file='DESKTOP_WALLPAPER_POSITION.xml' path='doc/member[@name="DESKTOP_WALLPAPER_POSITION.DWPOS_FILL"]/*'/>
    DWPOS_FILL = 4,
    /// <include file='DESKTOP_WALLPAPER_POSITION.xml' path='doc/member[@name="DESKTOP_WALLPAPER_POSITION.DWPOS_SPAN"]/*'/>
    DWPOS_SPAN = 5,
}