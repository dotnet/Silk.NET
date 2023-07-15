// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D12_RESOURCE_DIMENSION"]/*'/>
public enum D3D12_RESOURCE_DIMENSION
{
    /// <include file='D3D12_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D12_RESOURCE_DIMENSION.D3D12_RESOURCE_DIMENSION_UNKNOWN"]/*'/>
    D3D12_RESOURCE_DIMENSION_UNKNOWN = 0,
    /// <include file='D3D12_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D12_RESOURCE_DIMENSION.D3D12_RESOURCE_DIMENSION_BUFFER"]/*'/>
    D3D12_RESOURCE_DIMENSION_BUFFER = 1,
    /// <include file='D3D12_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D12_RESOURCE_DIMENSION.D3D12_RESOURCE_DIMENSION_TEXTURE1D"]/*'/>
    D3D12_RESOURCE_DIMENSION_TEXTURE1D = 2,
    /// <include file='D3D12_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D12_RESOURCE_DIMENSION.D3D12_RESOURCE_DIMENSION_TEXTURE2D"]/*'/>
    D3D12_RESOURCE_DIMENSION_TEXTURE2D = 3,
    /// <include file='D3D12_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D12_RESOURCE_DIMENSION.D3D12_RESOURCE_DIMENSION_TEXTURE3D"]/*'/>
    D3D12_RESOURCE_DIMENSION_TEXTURE3D = 4,
}