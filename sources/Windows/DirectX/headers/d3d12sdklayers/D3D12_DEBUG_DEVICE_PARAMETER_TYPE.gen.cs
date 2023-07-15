// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_DEBUG_DEVICE_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_DEBUG_DEVICE_PARAMETER_TYPE"]/*'/>
public enum D3D12_DEBUG_DEVICE_PARAMETER_TYPE
{
    /// <include file='D3D12_DEBUG_DEVICE_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_DEBUG_DEVICE_PARAMETER_TYPE.D3D12_DEBUG_DEVICE_PARAMETER_FEATURE_FLAGS"]/*'/>
    D3D12_DEBUG_DEVICE_PARAMETER_FEATURE_FLAGS = 0,
    /// <include file='D3D12_DEBUG_DEVICE_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_DEBUG_DEVICE_PARAMETER_TYPE.D3D12_DEBUG_DEVICE_PARAMETER_GPU_BASED_VALIDATION_SETTINGS"]/*'/>
    D3D12_DEBUG_DEVICE_PARAMETER_GPU_BASED_VALIDATION_SETTINGS = (D3D12_DEBUG_DEVICE_PARAMETER_FEATURE_FLAGS + 1),
    /// <include file='D3D12_DEBUG_DEVICE_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_DEBUG_DEVICE_PARAMETER_TYPE.D3D12_DEBUG_DEVICE_PARAMETER_GPU_SLOWDOWN_PERFORMANCE_FACTOR"]/*'/>
    D3D12_DEBUG_DEVICE_PARAMETER_GPU_SLOWDOWN_PERFORMANCE_FACTOR = (D3D12_DEBUG_DEVICE_PARAMETER_GPU_BASED_VALIDATION_SETTINGS + 1),
}