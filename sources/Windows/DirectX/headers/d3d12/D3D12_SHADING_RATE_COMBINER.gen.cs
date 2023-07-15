// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_SHADING_RATE_COMBINER.xml' path='doc/member[@name="D3D12_SHADING_RATE_COMBINER"]/*'/>
public enum D3D12_SHADING_RATE_COMBINER
{
    /// <include file='D3D12_SHADING_RATE_COMBINER.xml' path='doc/member[@name="D3D12_SHADING_RATE_COMBINER.D3D12_SHADING_RATE_COMBINER_PASSTHROUGH"]/*'/>
    D3D12_SHADING_RATE_COMBINER_PASSTHROUGH = 0,
    /// <include file='D3D12_SHADING_RATE_COMBINER.xml' path='doc/member[@name="D3D12_SHADING_RATE_COMBINER.D3D12_SHADING_RATE_COMBINER_OVERRIDE"]/*'/>
    D3D12_SHADING_RATE_COMBINER_OVERRIDE = 1,
    /// <include file='D3D12_SHADING_RATE_COMBINER.xml' path='doc/member[@name="D3D12_SHADING_RATE_COMBINER.D3D12_SHADING_RATE_COMBINER_MIN"]/*'/>
    D3D12_SHADING_RATE_COMBINER_MIN = 2,
    /// <include file='D3D12_SHADING_RATE_COMBINER.xml' path='doc/member[@name="D3D12_SHADING_RATE_COMBINER.D3D12_SHADING_RATE_COMBINER_MAX"]/*'/>
    D3D12_SHADING_RATE_COMBINER_MAX = 3,
    /// <include file='D3D12_SHADING_RATE_COMBINER.xml' path='doc/member[@name="D3D12_SHADING_RATE_COMBINER.D3D12_SHADING_RATE_COMBINER_SUM"]/*'/>
    D3D12_SHADING_RATE_COMBINER_SUM = 4,
}