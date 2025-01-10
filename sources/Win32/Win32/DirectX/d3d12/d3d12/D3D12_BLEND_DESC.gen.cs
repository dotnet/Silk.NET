// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_BLEND_DESC
{
    public BOOL AlphaToCoverageEnable;
    public BOOL IndependentBlendEnable;

    [NativeTypeName("D3D12_RENDER_TARGET_BLEND_DESC[8]")]
    public _RenderTarget_e__FixedBuffer RenderTarget;

    [InlineArray(8)]
    public partial struct _RenderTarget_e__FixedBuffer
    {
        public D3D12_RENDER_TARGET_BLEND_DESC e0;
    }
}
