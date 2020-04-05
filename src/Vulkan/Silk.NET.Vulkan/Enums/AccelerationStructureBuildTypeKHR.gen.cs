// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    public enum AccelerationStructureBuildTypeKHR
    {
        AccelerationStructureBuildTypeHostKhr = 0,
        AccelerationStructureBuildTypeDeviceKhr = 1,
        AccelerationStructureBuildTypeHostOrDeviceKhr = 2,
    }
}
