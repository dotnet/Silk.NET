// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE"]/*' />
public enum D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE
{
    /// <include file='D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_OPAQUE"]/*' />
    D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_OPAQUE = 0,

    /// <include file='D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_BACKGROUND"]/*' />
    D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_BACKGROUND = 1,

    /// <include file='D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_DESTINATION"]/*' />
    D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_DESTINATION = 2,

    /// <include file='D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_SOURCE_STREAM"]/*' />
    D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_SOURCE_STREAM = 3,
}
