// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D11_SAMPLER_DESC
{
    public D3D11_FILTER Filter;
    public D3D11_TEXTURE_ADDRESS_MODE AddressU;
    public D3D11_TEXTURE_ADDRESS_MODE AddressV;
    public D3D11_TEXTURE_ADDRESS_MODE AddressW;
    public float MipLODBias;
    public uint MaxAnisotropy;
    public D3D11_COMPARISON_FUNC ComparisonFunc;

    [NativeTypeName("FLOAT[4]")]
    public _BorderColor_e__FixedBuffer BorderColor;
    public float MinLOD;
    public float MaxLOD;

    [InlineArray(4)]
    public partial struct _BorderColor_e__FixedBuffer
    {
        public float e0;
    }
}
