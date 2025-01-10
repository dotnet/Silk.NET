// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_VIDEO_ENCODER_PROFILE_DESC
{
    public uint DataSize;

    [NativeTypeName("__AnonymousRecord_d3d12video_L6981_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_PROFILE_H264* pH264Profile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pH264Profile; }
    }

    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_PROFILE_HEVC* pHEVCProfile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pHEVCProfile; }
    }

    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_AV1_PROFILE* pAV1Profile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pAV1Profile; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_PROFILE_H264* pH264Profile;

        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_PROFILE_HEVC* pHEVCProfile;

        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_AV1_PROFILE* pAV1Profile;
    }
}
