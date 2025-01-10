// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA
{
    [NativeTypeName("UINT64")]
    public ulong EnabledFeatures;

    [NativeTypeName("INT64[8]")]
    public _FeatureValue_e__FixedBuffer FeatureValue;

    [InlineArray(8)]
    public partial struct _FeatureValue_e__FixedBuffer
    {
        public long e0;
    }
}
