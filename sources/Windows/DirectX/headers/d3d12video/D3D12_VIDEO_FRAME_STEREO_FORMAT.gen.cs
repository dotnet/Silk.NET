// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_FRAME_STEREO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_STEREO_FORMAT"]/*'/>
public enum D3D12_VIDEO_FRAME_STEREO_FORMAT
{
    /// <include file='D3D12_VIDEO_FRAME_STEREO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_STEREO_FORMAT.D3D12_VIDEO_FRAME_STEREO_FORMAT_NONE"]/*'/>
    D3D12_VIDEO_FRAME_STEREO_FORMAT_NONE = 0,
    /// <include file='D3D12_VIDEO_FRAME_STEREO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_STEREO_FORMAT.D3D12_VIDEO_FRAME_STEREO_FORMAT_MONO"]/*'/>
    D3D12_VIDEO_FRAME_STEREO_FORMAT_MONO = 1,
    /// <include file='D3D12_VIDEO_FRAME_STEREO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_STEREO_FORMAT.D3D12_VIDEO_FRAME_STEREO_FORMAT_HORIZONTAL"]/*'/>
    D3D12_VIDEO_FRAME_STEREO_FORMAT_HORIZONTAL = 2,
    /// <include file='D3D12_VIDEO_FRAME_STEREO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_STEREO_FORMAT.D3D12_VIDEO_FRAME_STEREO_FORMAT_VERTICAL"]/*'/>
    D3D12_VIDEO_FRAME_STEREO_FORMAT_VERTICAL = 3,
    /// <include file='D3D12_VIDEO_FRAME_STEREO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_STEREO_FORMAT.D3D12_VIDEO_FRAME_STEREO_FORMAT_SEPARATE"]/*'/>
    D3D12_VIDEO_FRAME_STEREO_FORMAT_SEPARATE = 4,
}