// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows10.0")]
public partial struct D2D1_GRADIENT_MESH_PATCH
{
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point00;

    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point01;

    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point02;

    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point03;

    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point10;

    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point11;

    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point12;

    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point13;

    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point20;

    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point21;

    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point22;

    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point23;

    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point30;

    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point31;

    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point32;

    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point33;

    [NativeTypeName("D2D1_COLOR_F")]
    public DXGI_RGBA color00;

    [NativeTypeName("D2D1_COLOR_F")]
    public DXGI_RGBA color03;

    [NativeTypeName("D2D1_COLOR_F")]
    public DXGI_RGBA color30;

    [NativeTypeName("D2D1_COLOR_F")]
    public DXGI_RGBA color33;
    public D2D1_PATCH_EDGE_MODE topEdgeMode;
    public D2D1_PATCH_EDGE_MODE leftEdgeMode;
    public D2D1_PATCH_EDGE_MODE bottomEdgeMode;
    public D2D1_PATCH_EDGE_MODE rightEdgeMode;
}
