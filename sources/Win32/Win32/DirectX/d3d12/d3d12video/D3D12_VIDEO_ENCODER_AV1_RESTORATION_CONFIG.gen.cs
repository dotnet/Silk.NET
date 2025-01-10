// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_ENCODER_AV1_RESTORATION_CONFIG
{
    [NativeTypeName("D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE[3]")]
    public _FrameRestorationType_e__FixedBuffer FrameRestorationType;

    [NativeTypeName("D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE[3]")]
    public _LoopRestorationPixelSize_e__FixedBuffer LoopRestorationPixelSize;

    [InlineArray(3)]
    public partial struct _FrameRestorationType_e__FixedBuffer
    {
        public D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE e0;
    }

    [InlineArray(3)]
    public partial struct _LoopRestorationPixelSize_e__FixedBuffer
    {
        public D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE e0;
    }
}
