// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Gdiplus.GpBrushType;

namespace Silk.NET.Gdiplus;
/// <include file='GpPenType.xml' path='doc/member[@name="GpPenType"]/*'/>
public enum GpPenType
{
    /// <include file='GpPenType.xml' path='doc/member[@name="GpPenType.PenTypeSolidColor"]/*'/>
    PenTypeSolidColor = BrushTypeSolidColor,
    /// <include file='GpPenType.xml' path='doc/member[@name="GpPenType.PenTypeHatchFill"]/*'/>
    PenTypeHatchFill = BrushTypeHatchFill,
    /// <include file='GpPenType.xml' path='doc/member[@name="GpPenType.PenTypeTextureFill"]/*'/>
    PenTypeTextureFill = BrushTypeTextureFill,
    /// <include file='GpPenType.xml' path='doc/member[@name="GpPenType.PenTypePathGradient"]/*'/>
    PenTypePathGradient = BrushTypePathGradient,
    /// <include file='GpPenType.xml' path='doc/member[@name="GpPenType.PenTypeLinearGradient"]/*'/>
    PenTypeLinearGradient = BrushTypeLinearGradient,
    /// <include file='GpPenType.xml' path='doc/member[@name="GpPenType.PenTypeUnknown"]/*'/>
    PenTypeUnknown = -1,
}