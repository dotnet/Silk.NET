// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM"]/*'/>
public unsafe partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM
{
    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM.pTexture2D"]/*'/>
    public ID3D12Resource* pTexture2D;
    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM.Subresource"]/*'/>
    public uint Subresource;
    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM.ReferenceSet"]/*'/>
    public D3D12_VIDEO_PROCESS_REFERENCE_SET ReferenceSet;
}