// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_SHADER_TRACKING_RESOURCE_TYPE")]
    public enum ShaderTrackingResourceType : int
    {
        [NativeName("Name", "D3D11_SHADER_TRACKING_RESOURCE_TYPE_NONE")]
        ShaderTrackingResourceTypeNone = 0x0,
        [NativeName("Name", "D3D11_SHADER_TRACKING_RESOURCE_TYPE_UAV_DEVICEMEMORY")]
        ShaderTrackingResourceTypeUavDevicememory = 0x1,
        [NativeName("Name", "D3D11_SHADER_TRACKING_RESOURCE_TYPE_NON_UAV_DEVICEMEMORY")]
        ShaderTrackingResourceTypeNonUavDevicememory = 0x2,
        [NativeName("Name", "D3D11_SHADER_TRACKING_RESOURCE_TYPE_ALL_DEVICEMEMORY")]
        ShaderTrackingResourceTypeAllDevicememory = 0x3,
        [NativeName("Name", "D3D11_SHADER_TRACKING_RESOURCE_TYPE_GROUPSHARED_MEMORY")]
        ShaderTrackingResourceTypeGroupsharedMemory = 0x4,
        [NativeName("Name", "D3D11_SHADER_TRACKING_RESOURCE_TYPE_ALL_SHARED_MEMORY")]
        ShaderTrackingResourceTypeAllSharedMemory = 0x5,
        [NativeName("Name", "D3D11_SHADER_TRACKING_RESOURCE_TYPE_GROUPSHARED_NON_UAV")]
        ShaderTrackingResourceTypeGroupsharedNonUav = 0x6,
        [NativeName("Name", "D3D11_SHADER_TRACKING_RESOURCE_TYPE_ALL")]
        ShaderTrackingResourceTypeAll = 0x7,
    }
}
