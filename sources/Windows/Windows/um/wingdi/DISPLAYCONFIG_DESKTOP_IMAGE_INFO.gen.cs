// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='DISPLAYCONFIG_DESKTOP_IMAGE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_DESKTOP_IMAGE_INFO"]/*'/>
[SupportedOSPlatform("windows10.0.17763.0")]
public partial struct DISPLAYCONFIG_DESKTOP_IMAGE_INFO
{
    /// <include file='DISPLAYCONFIG_DESKTOP_IMAGE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_DESKTOP_IMAGE_INFO.PathSourceSize"]/*'/>
    public POINTL PathSourceSize;
    /// <include file='DISPLAYCONFIG_DESKTOP_IMAGE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_DESKTOP_IMAGE_INFO.DesktopImageRegion"]/*'/>
    public RECTL DesktopImageRegion;
    /// <include file='DISPLAYCONFIG_DESKTOP_IMAGE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_DESKTOP_IMAGE_INFO.DesktopImageClip"]/*'/>
    public RECTL DesktopImageClip;
}