// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE"]/*'/>
public partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE
{
    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE.OutputIndex"]/*'/>
    public uint OutputIndex;
    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE.InputFrameOrField"]/*'/>
    public uint InputFrameOrField;
}