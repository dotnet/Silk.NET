// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_YCBCR_PROP.xml' path='doc/member[@name="D2D1_YCBCR_PROP"]/*'/>
public enum D2D1_YCBCR_PROP
{
    /// <include file='D2D1_YCBCR_PROP.xml' path='doc/member[@name="D2D1_YCBCR_PROP.D2D1_YCBCR_PROP_CHROMA_SUBSAMPLING"]/*'/>
    D2D1_YCBCR_PROP_CHROMA_SUBSAMPLING = 0,
    /// <include file='D2D1_YCBCR_PROP.xml' path='doc/member[@name="D2D1_YCBCR_PROP.D2D1_YCBCR_PROP_TRANSFORM_MATRIX"]/*'/>
    D2D1_YCBCR_PROP_TRANSFORM_MATRIX = 1,
    /// <include file='D2D1_YCBCR_PROP.xml' path='doc/member[@name="D2D1_YCBCR_PROP.D2D1_YCBCR_PROP_INTERPOLATION_MODE"]/*'/>
    D2D1_YCBCR_PROP_INTERPOLATION_MODE = 2,
    /// <include file='D2D1_YCBCR_PROP.xml' path='doc/member[@name="D2D1_YCBCR_PROP.D2D1_YCBCR_PROP_FORCE_DWORD"]/*'/>
    D2D1_YCBCR_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}