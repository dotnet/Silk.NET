// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER"]/*'/>
public enum D3D12_VIDEO_PROCESS_FILTER
{
    /// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER.D3D12_VIDEO_PROCESS_FILTER_BRIGHTNESS"]/*'/>
    D3D12_VIDEO_PROCESS_FILTER_BRIGHTNESS = 0,
    /// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER.D3D12_VIDEO_PROCESS_FILTER_CONTRAST"]/*'/>
    D3D12_VIDEO_PROCESS_FILTER_CONTRAST = 1,
    /// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER.D3D12_VIDEO_PROCESS_FILTER_HUE"]/*'/>
    D3D12_VIDEO_PROCESS_FILTER_HUE = 2,
    /// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER.D3D12_VIDEO_PROCESS_FILTER_SATURATION"]/*'/>
    D3D12_VIDEO_PROCESS_FILTER_SATURATION = 3,
    /// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER.D3D12_VIDEO_PROCESS_FILTER_NOISE_REDUCTION"]/*'/>
    D3D12_VIDEO_PROCESS_FILTER_NOISE_REDUCTION = 4,
    /// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER.D3D12_VIDEO_PROCESS_FILTER_EDGE_ENHANCEMENT"]/*'/>
    D3D12_VIDEO_PROCESS_FILTER_EDGE_ENHANCEMENT = 5,
    /// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER.D3D12_VIDEO_PROCESS_FILTER_ANAMORPHIC_SCALING"]/*'/>
    D3D12_VIDEO_PROCESS_FILTER_ANAMORPHIC_SCALING = 6,
    /// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER.D3D12_VIDEO_PROCESS_FILTER_STEREO_ADJUSTMENT"]/*'/>
    D3D12_VIDEO_PROCESS_FILTER_STEREO_ADJUSTMENT = 7,
}