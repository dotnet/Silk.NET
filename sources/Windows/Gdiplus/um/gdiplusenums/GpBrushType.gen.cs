// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Gdiplus;
/// <include file='GpBrushType.xml' path='doc/member[@name="GpBrushType"]/*'/>
public enum GpBrushType
{
    /// <include file='GpBrushType.xml' path='doc/member[@name="GpBrushType.BrushTypeSolidColor"]/*'/>
    BrushTypeSolidColor = 0,
    /// <include file='GpBrushType.xml' path='doc/member[@name="GpBrushType.BrushTypeHatchFill"]/*'/>
    BrushTypeHatchFill = 1,
    /// <include file='GpBrushType.xml' path='doc/member[@name="GpBrushType.BrushTypeTextureFill"]/*'/>
    BrushTypeTextureFill = 2,
    /// <include file='GpBrushType.xml' path='doc/member[@name="GpBrushType.BrushTypePathGradient"]/*'/>
    BrushTypePathGradient = 3,
    /// <include file='GpBrushType.xml' path='doc/member[@name="GpBrushType.BrushTypeLinearGradient"]/*'/>
    BrushTypeLinearGradient = 4,
}