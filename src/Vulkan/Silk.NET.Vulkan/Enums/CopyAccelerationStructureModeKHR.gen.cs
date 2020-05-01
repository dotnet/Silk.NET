// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public enum CopyAccelerationStructureModeKHR
    {
        CopyAccelerationStructureModeCloneKhr = 0,
        CopyAccelerationStructureModeCompactKhr = 1,
        CopyAccelerationStructureModeSerializeKhr = 2,
        CopyAccelerationStructureModeDeserializeKhr = 3,
    }
}
