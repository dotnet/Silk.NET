// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH"]/*' />
[SupportedOSPlatform("windows10.0")]
public partial struct D2D1_GRADIENT_MESH_PATCH
{
    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.point00"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point00;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.point01"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point01;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.point02"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point02;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.point03"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point03;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.point10"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point10;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.point11"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point11;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.point12"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point12;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.point13"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point13;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.point20"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point20;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.point21"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point21;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.point22"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point22;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.point23"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point23;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.point30"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point30;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.point31"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point31;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.point32"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point32;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.point33"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point33;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.color00"]/*' />
    [NativeTypeName("D2D1_COLOR_F")]
    public DXGI_RGBA color00;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.color03"]/*' />
    [NativeTypeName("D2D1_COLOR_F")]
    public DXGI_RGBA color03;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.color30"]/*' />
    [NativeTypeName("D2D1_COLOR_F")]
    public DXGI_RGBA color30;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.color33"]/*' />
    [NativeTypeName("D2D1_COLOR_F")]
    public DXGI_RGBA color33;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.topEdgeMode"]/*' />
    public D2D1_PATCH_EDGE_MODE topEdgeMode;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.leftEdgeMode"]/*' />
    public D2D1_PATCH_EDGE_MODE leftEdgeMode;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.bottomEdgeMode"]/*' />
    public D2D1_PATCH_EDGE_MODE bottomEdgeMode;

    /// <include file='D2D1_GRADIENT_MESH_PATCH.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH.rightEdgeMode"]/*' />
    public D2D1_PATCH_EDGE_MODE rightEdgeMode;
}
