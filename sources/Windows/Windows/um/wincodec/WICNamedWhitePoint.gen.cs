// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WICNamedWhitePoint.xml' path='doc/member[@name="WICNamedWhitePoint"]/*'/>
public enum WICNamedWhitePoint
{
    /// <include file='WICNamedWhitePoint.xml' path='doc/member[@name="WICNamedWhitePoint.WICWhitePointDefault"]/*'/>
    WICWhitePointDefault = 0x1,
    /// <include file='WICNamedWhitePoint.xml' path='doc/member[@name="WICNamedWhitePoint.WICWhitePointDaylight"]/*'/>
    WICWhitePointDaylight = 0x2,
    /// <include file='WICNamedWhitePoint.xml' path='doc/member[@name="WICNamedWhitePoint.WICWhitePointCloudy"]/*'/>
    WICWhitePointCloudy = 0x4,
    /// <include file='WICNamedWhitePoint.xml' path='doc/member[@name="WICNamedWhitePoint.WICWhitePointShade"]/*'/>
    WICWhitePointShade = 0x8,
    /// <include file='WICNamedWhitePoint.xml' path='doc/member[@name="WICNamedWhitePoint.WICWhitePointTungsten"]/*'/>
    WICWhitePointTungsten = 0x10,
    /// <include file='WICNamedWhitePoint.xml' path='doc/member[@name="WICNamedWhitePoint.WICWhitePointFluorescent"]/*'/>
    WICWhitePointFluorescent = 0x20,
    /// <include file='WICNamedWhitePoint.xml' path='doc/member[@name="WICNamedWhitePoint.WICWhitePointFlash"]/*'/>
    WICWhitePointFlash = 0x40,
    /// <include file='WICNamedWhitePoint.xml' path='doc/member[@name="WICNamedWhitePoint.WICWhitePointUnderwater"]/*'/>
    WICWhitePointUnderwater = 0x80,
    /// <include file='WICNamedWhitePoint.xml' path='doc/member[@name="WICNamedWhitePoint.WICWhitePointCustom"]/*'/>
    WICWhitePointCustom = 0x100,
    /// <include file='WICNamedWhitePoint.xml' path='doc/member[@name="WICNamedWhitePoint.WICWhitePointAutoWhiteBalance"]/*'/>
    WICWhitePointAutoWhiteBalance = 0x200,
    /// <include file='WICNamedWhitePoint.xml' path='doc/member[@name="WICNamedWhitePoint.WICWhitePointAsShot"]/*'/>
    WICWhitePointAsShot = WICWhitePointDefault,
    /// <include file='WICNamedWhitePoint.xml' path='doc/member[@name="WICNamedWhitePoint.WICNAMEDWHITEPOINT_FORCE_DWORD"]/*'/>
    WICNAMEDWHITEPOINT_FORCE_DWORD = 0x7fffffff,
}