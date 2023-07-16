// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPLAYCONFIG_COLOR_ENCODING.xml' path='doc/member[@name="DISPLAYCONFIG_COLOR_ENCODING"]/*'/>
public enum DISPLAYCONFIG_COLOR_ENCODING
{
    /// <include file='DISPLAYCONFIG_COLOR_ENCODING.xml' path='doc/member[@name="DISPLAYCONFIG_COLOR_ENCODING.DISPLAYCONFIG_COLOR_ENCODING_RGB"]/*'/>
    DISPLAYCONFIG_COLOR_ENCODING_RGB = 0,
    /// <include file='DISPLAYCONFIG_COLOR_ENCODING.xml' path='doc/member[@name="DISPLAYCONFIG_COLOR_ENCODING.DISPLAYCONFIG_COLOR_ENCODING_YCBCR444"]/*'/>
    DISPLAYCONFIG_COLOR_ENCODING_YCBCR444 = 1,
    /// <include file='DISPLAYCONFIG_COLOR_ENCODING.xml' path='doc/member[@name="DISPLAYCONFIG_COLOR_ENCODING.DISPLAYCONFIG_COLOR_ENCODING_YCBCR422"]/*'/>
    DISPLAYCONFIG_COLOR_ENCODING_YCBCR422 = 2,
    /// <include file='DISPLAYCONFIG_COLOR_ENCODING.xml' path='doc/member[@name="DISPLAYCONFIG_COLOR_ENCODING.DISPLAYCONFIG_COLOR_ENCODING_YCBCR420"]/*'/>
    DISPLAYCONFIG_COLOR_ENCODING_YCBCR420 = 3,
    /// <include file='DISPLAYCONFIG_COLOR_ENCODING.xml' path='doc/member[@name="DISPLAYCONFIG_COLOR_ENCODING.DISPLAYCONFIG_COLOR_ENCODING_INTENSITY"]/*'/>
    DISPLAYCONFIG_COLOR_ENCODING_INTENSITY = 4,
    /// <include file='DISPLAYCONFIG_COLOR_ENCODING.xml' path='doc/member[@name="DISPLAYCONFIG_COLOR_ENCODING.DISPLAYCONFIG_COLOR_ENCODING_FORCE_UINT32"]/*'/>
    DISPLAYCONFIG_COLOR_ENCODING_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
}