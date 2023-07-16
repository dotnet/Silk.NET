// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_PRINT_CONTROL_PROPERTIES.xml' path='doc/member[@name="D2D1_PRINT_CONTROL_PROPERTIES"]/*'/>
public partial struct D2D1_PRINT_CONTROL_PROPERTIES
{
    /// <include file='D2D1_PRINT_CONTROL_PROPERTIES.xml' path='doc/member[@name="D2D1_PRINT_CONTROL_PROPERTIES.fontSubset"]/*'/>
    public D2D1_PRINT_FONT_SUBSET_MODE fontSubset;
    /// <include file='D2D1_PRINT_CONTROL_PROPERTIES.xml' path='doc/member[@name="D2D1_PRINT_CONTROL_PROPERTIES.rasterDPI"]/*'/>
    public float rasterDPI;
    /// <include file='D2D1_PRINT_CONTROL_PROPERTIES.xml' path='doc/member[@name="D2D1_PRINT_CONTROL_PROPERTIES.colorSpace"]/*'/>
    public D2D1_COLOR_SPACE colorSpace;
}