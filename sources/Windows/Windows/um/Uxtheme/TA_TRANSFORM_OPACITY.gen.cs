// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TA_TRANSFORM_OPACITY.xml' path='doc/member[@name="TA_TRANSFORM_OPACITY"]/*'/>
public partial struct TA_TRANSFORM_OPACITY
{
    /// <include file='TA_TRANSFORM_OPACITY.xml' path='doc/member[@name="TA_TRANSFORM_OPACITY.header"]/*'/>
    public TA_TRANSFORM header;
    /// <include file='TA_TRANSFORM_OPACITY.xml' path='doc/member[@name="TA_TRANSFORM_OPACITY.rOpacity"]/*'/>
    public float rOpacity;
    /// <include file='TA_TRANSFORM_OPACITY.xml' path='doc/member[@name="TA_TRANSFORM_OPACITY.rInitialOpacity"]/*'/>
    public float rInitialOpacity;
}