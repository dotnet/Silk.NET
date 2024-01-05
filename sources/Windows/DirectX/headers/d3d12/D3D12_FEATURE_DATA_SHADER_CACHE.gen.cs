// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_SHADER_CACHE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_SHADER_CACHE"]/*'/>
public partial struct D3D12_FEATURE_DATA_SHADER_CACHE
{
    /// <include file='D3D12_FEATURE_DATA_SHADER_CACHE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_SHADER_CACHE.SupportFlags"]/*'/>

    public D3D12_SHADER_CACHE_SUPPORT_FLAGS SupportFlags;
}
