// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_SAMPLE.xml' path='doc/member[@name="D3D12_VIDEO_SAMPLE"]/*'/>
public partial struct D3D12_VIDEO_SAMPLE
{
    /// <include file='D3D12_VIDEO_SAMPLE.xml' path='doc/member[@name="D3D12_VIDEO_SAMPLE.Width"]/*'/>

    public uint Width;

    /// <include file='D3D12_VIDEO_SAMPLE.xml' path='doc/member[@name="D3D12_VIDEO_SAMPLE.Height"]/*'/>

    public uint Height;

    /// <include file='D3D12_VIDEO_SAMPLE.xml' path='doc/member[@name="D3D12_VIDEO_SAMPLE.Format"]/*'/>

    public D3D12_VIDEO_FORMAT Format;
}
