// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum SampleCountFlags
    {
        SampleCount1Bit = 1,
        SampleCount2Bit = 2,
        SampleCount4Bit = 4,
        SampleCount8Bit = 8,
        SampleCount16Bit = 16,
        SampleCount32Bit = 32,
        SampleCount64Bit = 64,
    }
}
