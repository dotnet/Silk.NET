// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_1_CREATE_DEVICE_CONTEXT_STATE_FLAG")]
    public enum D3D111CreateDeviceContextStateFlag
    {
        [NativeName("Name", "D3D11_1_CREATE_DEVICE_CONTEXT_STATE_SINGLETHREADED")]
        D3D111CreateDeviceContextStateSinglethreaded = 0x1,
    }
}
