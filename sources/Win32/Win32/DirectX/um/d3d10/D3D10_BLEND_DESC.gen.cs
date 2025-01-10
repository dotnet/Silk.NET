// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D10_BLEND_DESC
{
    public BOOL AlphaToCoverageEnable;

    [NativeTypeName("BOOL[8]")]
    public _BlendEnable_e__FixedBuffer BlendEnable;
    public D3D10_BLEND SrcBlend;
    public D3D10_BLEND DestBlend;
    public D3D10_BLEND_OP BlendOp;
    public D3D10_BLEND SrcBlendAlpha;
    public D3D10_BLEND DestBlendAlpha;
    public D3D10_BLEND_OP BlendOpAlpha;

    [NativeTypeName("UINT8[8]")]
    public _RenderTargetWriteMask_e__FixedBuffer RenderTargetWriteMask;

    [InlineArray(8)]
    public partial struct _BlendEnable_e__FixedBuffer
    {
        public BOOL e0;
    }

    [InlineArray(8)]
    public partial struct _RenderTargetWriteMask_e__FixedBuffer
    {
        public byte e0;
    }
}
