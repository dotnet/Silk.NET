// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS7.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS7"]/*'/>
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS7
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS7.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS7.MeshShaderTier"]/*'/>
    public D3D12_MESH_SHADER_TIER MeshShaderTier;
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS7.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS7.SamplerFeedbackTier"]/*'/>
    public D3D12_SAMPLER_FEEDBACK_TIER SamplerFeedbackTier;
}