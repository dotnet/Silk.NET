// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_FONT_AXIS_VALUE.xml' path='doc/member[@name="DWRITE_FONT_AXIS_VALUE"]/*'/>
public partial struct DWRITE_FONT_AXIS_VALUE
{
    /// <include file='DWRITE_FONT_AXIS_VALUE.xml' path='doc/member[@name="DWRITE_FONT_AXIS_VALUE.axisTag"]/*'/>
    public DWRITE_FONT_AXIS_TAG axisTag;
    /// <include file='DWRITE_FONT_AXIS_VALUE.xml' path='doc/member[@name="DWRITE_FONT_AXIS_VALUE.value"]/*'/>
    public float value;
}