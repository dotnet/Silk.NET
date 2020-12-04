// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_COUNTER")]
    public enum Counter
    {
        [NativeName("Name", "D3D11_COUNTER_DEVICE_DEPENDENT_0")]
        CounterDeviceDependent0 = 0x40000000,
    }
}
