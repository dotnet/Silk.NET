// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='svgTransformType.xml' path='doc/member[@name="svgTransformType"]/*'/>
public enum svgTransformType
{
    /// <include file='svgTransformType.xml' path='doc/member[@name="svgTransformType.SVG_TRANSFORM_UNKNOWN"]/*'/>
    SVG_TRANSFORM_UNKNOWN = 0,
    /// <include file='svgTransformType.xml' path='doc/member[@name="svgTransformType.SVG_TRANSFORM_MATRIX"]/*'/>
    SVG_TRANSFORM_MATRIX = 1,
    /// <include file='svgTransformType.xml' path='doc/member[@name="svgTransformType.SVG_TRANSFORM_TRANSLATE"]/*'/>
    SVG_TRANSFORM_TRANSLATE = 2,
    /// <include file='svgTransformType.xml' path='doc/member[@name="svgTransformType.SVG_TRANSFORM_SCALE"]/*'/>
    SVG_TRANSFORM_SCALE = 3,
    /// <include file='svgTransformType.xml' path='doc/member[@name="svgTransformType.SVG_TRANSFORM_ROTATE"]/*'/>
    SVG_TRANSFORM_ROTATE = 4,
    /// <include file='svgTransformType.xml' path='doc/member[@name="svgTransformType.SVG_TRANSFORM_SKEWX"]/*'/>
    SVG_TRANSFORM_SKEWX = 5,
    /// <include file='svgTransformType.xml' path='doc/member[@name="svgTransformType.SVG_TRANSFORM_SKEWY"]/*'/>
    SVG_TRANSFORM_SKEWY = 6,
    /// <include file='svgTransformType.xml' path='doc/member[@name="svgTransformType.svgTransformType_Max"]/*'/>
    svgTransformType_Max = 2147483647,
}