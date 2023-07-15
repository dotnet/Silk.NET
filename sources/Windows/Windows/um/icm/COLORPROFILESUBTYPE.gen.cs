// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='COLORPROFILESUBTYPE.xml' path='doc/member[@name="COLORPROFILESUBTYPE"]/*'/>
public enum COLORPROFILESUBTYPE
{
    /// <include file='COLORPROFILESUBTYPE.xml' path='doc/member[@name="COLORPROFILESUBTYPE.CPST_PERCEPTUAL"]/*'/>
    CPST_PERCEPTUAL = 0,
    /// <include file='COLORPROFILESUBTYPE.xml' path='doc/member[@name="COLORPROFILESUBTYPE.CPST_RELATIVE_COLORIMETRIC"]/*'/>
    CPST_RELATIVE_COLORIMETRIC = 1,
    /// <include file='COLORPROFILESUBTYPE.xml' path='doc/member[@name="COLORPROFILESUBTYPE.CPST_SATURATION"]/*'/>
    CPST_SATURATION = 2,
    /// <include file='COLORPROFILESUBTYPE.xml' path='doc/member[@name="COLORPROFILESUBTYPE.CPST_ABSOLUTE_COLORIMETRIC"]/*'/>
    CPST_ABSOLUTE_COLORIMETRIC = 3,
    /// <include file='COLORPROFILESUBTYPE.xml' path='doc/member[@name="COLORPROFILESUBTYPE.CPST_NONE"]/*'/>
    CPST_NONE,
    /// <include file='COLORPROFILESUBTYPE.xml' path='doc/member[@name="COLORPROFILESUBTYPE.CPST_RGB_WORKING_SPACE"]/*'/>
    CPST_RGB_WORKING_SPACE,
    /// <include file='COLORPROFILESUBTYPE.xml' path='doc/member[@name="COLORPROFILESUBTYPE.CPST_CUSTOM_WORKING_SPACE"]/*'/>
    CPST_CUSTOM_WORKING_SPACE,
    /// <include file='COLORPROFILESUBTYPE.xml' path='doc/member[@name="COLORPROFILESUBTYPE.CPST_STANDARD_DISPLAY_COLOR_MODE"]/*'/>
    CPST_STANDARD_DISPLAY_COLOR_MODE,
    /// <include file='COLORPROFILESUBTYPE.xml' path='doc/member[@name="COLORPROFILESUBTYPE.CPST_EXTENDED_DISPLAY_COLOR_MODE"]/*'/>
    CPST_EXTENDED_DISPLAY_COLOR_MODE,
}