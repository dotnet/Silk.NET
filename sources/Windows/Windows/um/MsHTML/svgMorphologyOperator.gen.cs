// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='svgMorphologyOperator.xml' path='doc/member[@name="svgMorphologyOperator"]/*'/>
public enum svgMorphologyOperator
{
    /// <include file='svgMorphologyOperator.xml' path='doc/member[@name="svgMorphologyOperator.SVG_MORPHOLOGY_OPERATOR_UNKNOWN"]/*'/>
    SVG_MORPHOLOGY_OPERATOR_UNKNOWN = 0,
    /// <include file='svgMorphologyOperator.xml' path='doc/member[@name="svgMorphologyOperator.SVG_MORPHOLOGY_OPERATOR_ERODE"]/*'/>
    SVG_MORPHOLOGY_OPERATOR_ERODE = 1,
    /// <include file='svgMorphologyOperator.xml' path='doc/member[@name="svgMorphologyOperator.SVG_MORPHOLOGY_OPERATOR_DILATE"]/*'/>
    SVG_MORPHOLOGY_OPERATOR_DILATE = 2,
    /// <include file='svgMorphologyOperator.xml' path='doc/member[@name="svgMorphologyOperator.svgMorphologyOperator_Max"]/*'/>
    svgMorphologyOperator_Max = 2147483647,
}