// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public enum SystemAllocationScope
    {
        Command = 0,
        Object = 1,
        Cache = 2,
        Device = 3,
        Instance = 4,
    }
}
