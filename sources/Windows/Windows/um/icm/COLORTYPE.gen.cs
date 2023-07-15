// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='COLORTYPE.xml' path='doc/member[@name="COLORTYPE"]/*'/>
public enum COLORTYPE
{
    /// <include file='COLORTYPE.xml' path='doc/member[@name="COLORTYPE.COLOR_GRAY"]/*'/>
    COLOR_GRAY = 1,
    /// <include file='COLORTYPE.xml' path='doc/member[@name="COLORTYPE.COLOR_RGB"]/*'/>
    COLOR_RGB,
    /// <include file='COLORTYPE.xml' path='doc/member[@name="COLORTYPE.COLOR_XYZ"]/*'/>
    COLOR_XYZ,
    /// <include file='COLORTYPE.xml' path='doc/member[@name="COLORTYPE.COLOR_Yxy"]/*'/>
    COLOR_Yxy,
    /// <include file='COLORTYPE.xml' path='doc/member[@name="COLORTYPE.COLOR_Lab"]/*'/>
    COLOR_Lab,
    /// <include file='COLORTYPE.xml' path='doc/member[@name="COLORTYPE.COLOR_3_CHANNEL"]/*'/>
    COLOR_3_CHANNEL,
    /// <include file='COLORTYPE.xml' path='doc/member[@name="COLORTYPE.COLOR_CMYK"]/*'/>
    COLOR_CMYK,
    /// <include file='COLORTYPE.xml' path='doc/member[@name="COLORTYPE.COLOR_5_CHANNEL"]/*'/>
    COLOR_5_CHANNEL,
    /// <include file='COLORTYPE.xml' path='doc/member[@name="COLORTYPE.COLOR_6_CHANNEL"]/*'/>
    COLOR_6_CHANNEL,
    /// <include file='COLORTYPE.xml' path='doc/member[@name="COLORTYPE.COLOR_7_CHANNEL"]/*'/>
    COLOR_7_CHANNEL,
    /// <include file='COLORTYPE.xml' path='doc/member[@name="COLORTYPE.COLOR_8_CHANNEL"]/*'/>
    COLOR_8_CHANNEL,
    /// <include file='COLORTYPE.xml' path='doc/member[@name="COLORTYPE.COLOR_NAMED"]/*'/>
    COLOR_NAMED,
}