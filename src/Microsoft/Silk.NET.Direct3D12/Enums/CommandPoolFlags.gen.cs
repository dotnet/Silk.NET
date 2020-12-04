// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_COMMAND_POOL_FLAGS")]
    public enum CommandPoolFlags
    {
        [NativeName("Name", "D3D12_COMMAND_POOL_FLAG_NONE")]
        CommandPoolFlagNone = 0x0,
    }
}
