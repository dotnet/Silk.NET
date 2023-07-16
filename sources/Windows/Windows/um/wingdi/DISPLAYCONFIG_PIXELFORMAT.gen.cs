// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPLAYCONFIG_PIXELFORMAT.xml' path='doc/member[@name="DISPLAYCONFIG_PIXELFORMAT"]/*'/>
public enum DISPLAYCONFIG_PIXELFORMAT
{
    /// <include file='DISPLAYCONFIG_PIXELFORMAT.xml' path='doc/member[@name="DISPLAYCONFIG_PIXELFORMAT.DISPLAYCONFIG_PIXELFORMAT_8BPP"]/*'/>
    DISPLAYCONFIG_PIXELFORMAT_8BPP = 1,
    /// <include file='DISPLAYCONFIG_PIXELFORMAT.xml' path='doc/member[@name="DISPLAYCONFIG_PIXELFORMAT.DISPLAYCONFIG_PIXELFORMAT_16BPP"]/*'/>
    DISPLAYCONFIG_PIXELFORMAT_16BPP = 2,
    /// <include file='DISPLAYCONFIG_PIXELFORMAT.xml' path='doc/member[@name="DISPLAYCONFIG_PIXELFORMAT.DISPLAYCONFIG_PIXELFORMAT_24BPP"]/*'/>
    DISPLAYCONFIG_PIXELFORMAT_24BPP = 3,
    /// <include file='DISPLAYCONFIG_PIXELFORMAT.xml' path='doc/member[@name="DISPLAYCONFIG_PIXELFORMAT.DISPLAYCONFIG_PIXELFORMAT_32BPP"]/*'/>
    DISPLAYCONFIG_PIXELFORMAT_32BPP = 4,
    /// <include file='DISPLAYCONFIG_PIXELFORMAT.xml' path='doc/member[@name="DISPLAYCONFIG_PIXELFORMAT.DISPLAYCONFIG_PIXELFORMAT_NONGDI"]/*'/>
    DISPLAYCONFIG_PIXELFORMAT_NONGDI = 5,
    /// <include file='DISPLAYCONFIG_PIXELFORMAT.xml' path='doc/member[@name="DISPLAYCONFIG_PIXELFORMAT.DISPLAYCONFIG_PIXELFORMAT_FORCE_UINT32"]/*'/>
    DISPLAYCONFIG_PIXELFORMAT_FORCE_UINT32 = unchecked((int)(0xffffffff)),
}