// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WICPngTimeProperties.xml' path='doc/member[@name="WICPngTimeProperties"]/*'/>
public enum WICPngTimeProperties
{
    /// <include file='WICPngTimeProperties.xml' path='doc/member[@name="WICPngTimeProperties.WICPngTimeYear"]/*'/>
    WICPngTimeYear = 0x1,
    /// <include file='WICPngTimeProperties.xml' path='doc/member[@name="WICPngTimeProperties.WICPngTimeMonth"]/*'/>
    WICPngTimeMonth = 0x2,
    /// <include file='WICPngTimeProperties.xml' path='doc/member[@name="WICPngTimeProperties.WICPngTimeDay"]/*'/>
    WICPngTimeDay = 0x3,
    /// <include file='WICPngTimeProperties.xml' path='doc/member[@name="WICPngTimeProperties.WICPngTimeHour"]/*'/>
    WICPngTimeHour = 0x4,
    /// <include file='WICPngTimeProperties.xml' path='doc/member[@name="WICPngTimeProperties.WICPngTimeMinute"]/*'/>
    WICPngTimeMinute = 0x5,
    /// <include file='WICPngTimeProperties.xml' path='doc/member[@name="WICPngTimeProperties.WICPngTimeSecond"]/*'/>
    WICPngTimeSecond = 0x6,
    /// <include file='WICPngTimeProperties.xml' path='doc/member[@name="WICPngTimeProperties.WICPngTimeProperties_FORCE_DWORD"]/*'/>
    WICPngTimeProperties_FORCE_DWORD = 0x7fffffff,
}