// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG
{
    [NativeTypeName("UINT64[2]")]
    public _LoopFilterLevel_e__FixedBuffer LoopFilterLevel;

    [NativeTypeName("UINT64")]
    public ulong LoopFilterLevelU;

    [NativeTypeName("UINT64")]
    public ulong LoopFilterLevelV;

    [NativeTypeName("UINT64")]
    public ulong LoopFilterSharpnessLevel;

    [NativeTypeName("UINT64")]
    public ulong LoopFilterDeltaEnabled;

    [NativeTypeName("UINT64")]
    public ulong UpdateRefDelta;

    [NativeTypeName("INT64[8]")]
    public _RefDeltas_e__FixedBuffer RefDeltas;

    [NativeTypeName("UINT64")]
    public ulong UpdateModeDelta;

    [NativeTypeName("INT64[2]")]
    public _ModeDeltas_e__FixedBuffer ModeDeltas;

    [InlineArray(2)]
    public partial struct _LoopFilterLevel_e__FixedBuffer
    {
        public ulong e0;
    }

    [InlineArray(8)]
    public partial struct _RefDeltas_e__FixedBuffer
    {
        public long e0;
    }

    [InlineArray(2)]
    public partial struct _ModeDeltas_e__FixedBuffer
    {
        public long e0;
    }
}
