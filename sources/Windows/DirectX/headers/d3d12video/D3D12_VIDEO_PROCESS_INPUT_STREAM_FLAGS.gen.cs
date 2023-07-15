// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS"]/*'/>
[Flags]
public enum D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS
{
    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS.D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_NONE"]/*'/>
    D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_NONE = 0,
    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS.D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_FRAME_DISCONTINUITY"]/*'/>
    D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_FRAME_DISCONTINUITY = 0x1,
    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS.D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_FRAME_REPEAT"]/*'/>
    D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_FRAME_REPEAT = 0x2,
}