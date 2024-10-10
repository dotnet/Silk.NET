// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FORMAT"]/*'/>
public partial struct D3D12_VIDEO_FORMAT
{
    /// <include file='D3D12_VIDEO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FORMAT.Format"]/*'/>

    public DXGI_FORMAT Format;

    /// <include file='D3D12_VIDEO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FORMAT.ColorSpace"]/*'/>

    public DXGI_COLOR_SPACE_TYPE ColorSpace;
}
