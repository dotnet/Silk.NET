// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_INK_BEZIER_SEGMENT.xml' path='doc/member[@name="D2D1_INK_BEZIER_SEGMENT"]/*'/>
public partial struct D2D1_INK_BEZIER_SEGMENT
{
    /// <include file='D2D1_INK_BEZIER_SEGMENT.xml' path='doc/member[@name="D2D1_INK_BEZIER_SEGMENT.point1"]/*'/>
    public D2D1_INK_POINT point1;
    /// <include file='D2D1_INK_BEZIER_SEGMENT.xml' path='doc/member[@name="D2D1_INK_BEZIER_SEGMENT.point2"]/*'/>
    public D2D1_INK_POINT point2;
    /// <include file='D2D1_INK_BEZIER_SEGMENT.xml' path='doc/member[@name="D2D1_INK_BEZIER_SEGMENT.point3"]/*'/>
    public D2D1_INK_POINT point3;
}