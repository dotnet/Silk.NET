// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_ARC_SEGMENT.xml' path='doc/member[@name="D2D1_ARC_SEGMENT"]/*'/>
public partial struct D2D1_ARC_SEGMENT
{
    /// <include file='D2D1_ARC_SEGMENT.xml' path='doc/member[@name="D2D1_ARC_SEGMENT.point"]/*'/>
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point;
    /// <include file='D2D1_ARC_SEGMENT.xml' path='doc/member[@name="D2D1_ARC_SEGMENT.size"]/*'/>
    [NativeTypeName("D2D1_SIZE_F")]
    public D2D_SIZE_F size;
    /// <include file='D2D1_ARC_SEGMENT.xml' path='doc/member[@name="D2D1_ARC_SEGMENT.rotationAngle"]/*'/>
    public float rotationAngle;
    /// <include file='D2D1_ARC_SEGMENT.xml' path='doc/member[@name="D2D1_ARC_SEGMENT.sweepDirection"]/*'/>
    public D2D1_SWEEP_DIRECTION sweepDirection;
    /// <include file='D2D1_ARC_SEGMENT.xml' path='doc/member[@name="D2D1_ARC_SEGMENT.arcSize"]/*'/>
    public D2D1_ARC_SIZE arcSize;
}