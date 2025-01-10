// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1
{
    [NativeTypeName("D3D12_VIDEO_PROCESS_INPUT_STREAM[2]")]
    public _InputStream_e__FixedBuffer InputStream;
    public D3D12_VIDEO_PROCESS_TRANSFORM Transform;
    public D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS Flags;
    public D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE RateInfo;

    [NativeTypeName("INT[32]")]
    public _FilterLevels_e__FixedBuffer FilterLevels;
    public D3D12_VIDEO_PROCESS_ALPHA_BLENDING AlphaBlending;
    public D3D12_VIDEO_FIELD_TYPE FieldType;

    [InlineArray(2)]
    public partial struct _InputStream_e__FixedBuffer
    {
        public D3D12_VIDEO_PROCESS_INPUT_STREAM e0;
    }

    [InlineArray(32)]
    public partial struct _FilterLevels_e__FixedBuffer
    {
        public int e0;
    }
}
