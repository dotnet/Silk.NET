// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_DEVICE_CONFIGURATION_DESC.xml' path='doc/member[@name="D3D12_DEVICE_CONFIGURATION_DESC"]/*'/>
public partial struct D3D12_DEVICE_CONFIGURATION_DESC
{
    /// <include file='D3D12_DEVICE_CONFIGURATION_DESC.xml' path='doc/member[@name="D3D12_DEVICE_CONFIGURATION_DESC.Flags"]/*'/>

    public D3D12_DEVICE_FLAGS Flags;

    /// <include file='D3D12_DEVICE_CONFIGURATION_DESC.xml' path='doc/member[@name="D3D12_DEVICE_CONFIGURATION_DESC.GpuBasedValidationFlags"]/*'/>

    public uint GpuBasedValidationFlags;

    /// <include file='D3D12_DEVICE_CONFIGURATION_DESC.xml' path='doc/member[@name="D3D12_DEVICE_CONFIGURATION_DESC.SDKVersion"]/*'/>

    public uint SDKVersion;

    /// <include file='D3D12_DEVICE_CONFIGURATION_DESC.xml' path='doc/member[@name="D3D12_DEVICE_CONFIGURATION_DESC.NumEnabledExperimentalFeatures"]/*'/>

    public uint NumEnabledExperimentalFeatures;
}
