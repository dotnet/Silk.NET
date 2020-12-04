// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE")]
    public enum RootParameterType
    {
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE")]
        RootParameterTypeDescriptorTable = 0x0,
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS")]
        RootParameterType32BitConstants = 0x1,
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_CBV")]
        RootParameterTypeCbv = 0x2,
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_SRV")]
        RootParameterTypeSrv = 0x3,
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_UAV")]
        RootParameterTypeUav = 0x4,
    }
}
