// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_PROCESS_FILTER_RANGE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_RANGE"]/*'/>
public partial struct D3D12_VIDEO_PROCESS_FILTER_RANGE
{
    /// <include file='D3D12_VIDEO_PROCESS_FILTER_RANGE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_RANGE.Minimum"]/*'/>
    public int Minimum;
    /// <include file='D3D12_VIDEO_PROCESS_FILTER_RANGE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_RANGE.Maximum"]/*'/>
    public int Maximum;
    /// <include file='D3D12_VIDEO_PROCESS_FILTER_RANGE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_RANGE.Default"]/*'/>
    public int Default;
    /// <include file='D3D12_VIDEO_PROCESS_FILTER_RANGE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_RANGE.Multiplier"]/*'/>
    public float Multiplier;
}