// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT"]/*'/>
public partial struct D3D12_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT
{
    /// <include file='D3D12_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT.MaxGPUVirtualAddressBitsPerResource"]/*'/>
    public uint MaxGPUVirtualAddressBitsPerResource;
    /// <include file='D3D12_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT.MaxGPUVirtualAddressBitsPerProcess"]/*'/>
    public uint MaxGPUVirtualAddressBitsPerProcess;
}