// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION
{
    public uint DataSize;

    [NativeTypeName("__AnonymousRecord_d3d12video_L7521_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264* pH264Config
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pH264Config; }
    }

    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC* pHEVCConfig
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pHEVCConfig; }
    }

    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION* pAV1Config
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pAV1Config; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264* pH264Config;

        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC* pHEVCConfig;

        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION* pAV1Config;
    }
}
