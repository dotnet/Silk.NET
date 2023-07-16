// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_POINT_DESCRIPTION.xml' path='doc/member[@name="D2D1_POINT_DESCRIPTION"]/*'/>
public partial struct D2D1_POINT_DESCRIPTION
{
    /// <include file='D2D1_POINT_DESCRIPTION.xml' path='doc/member[@name="D2D1_POINT_DESCRIPTION.point"]/*'/>
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point;
    /// <include file='D2D1_POINT_DESCRIPTION.xml' path='doc/member[@name="D2D1_POINT_DESCRIPTION.unitTangentVector"]/*'/>
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F unitTangentVector;
    /// <include file='D2D1_POINT_DESCRIPTION.xml' path='doc/member[@name="D2D1_POINT_DESCRIPTION.endSegment"]/*'/>
    [NativeTypeName("UINT32")]
    public uint endSegment;
    /// <include file='D2D1_POINT_DESCRIPTION.xml' path='doc/member[@name="D2D1_POINT_DESCRIPTION.endFigure"]/*'/>
    [NativeTypeName("UINT32")]
    public uint endFigure;
    /// <include file='D2D1_POINT_DESCRIPTION.xml' path='doc/member[@name="D2D1_POINT_DESCRIPTION.lengthToEndSegment"]/*'/>
    public float lengthToEndSegment;
}