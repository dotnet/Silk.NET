// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3DLIGHT9
{
    public D3DLIGHTTYPE Type;

    [NativeTypeName("D3DCOLORVALUE")]
    public DXGI_RGBA Diffuse;

    [NativeTypeName("D3DCOLORVALUE")]
    public DXGI_RGBA Specular;

    [NativeTypeName("D3DCOLORVALUE")]
    public DXGI_RGBA Ambient;
    public D3DVECTOR Position;
    public D3DVECTOR Direction;
    public float Range;
    public float Falloff;
    public float Attenuation0;
    public float Attenuation1;
    public float Attenuation2;
    public float Theta;
    public float Phi;
}
