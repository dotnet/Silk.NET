// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_DEVICE_CONTEXT_TYPE")]
    public enum DeviceContextType
    {
        [NativeName("Name", "D3D11_DEVICE_CONTEXT_IMMEDIATE")]
        DeviceContextImmediate = 0x0,
        [NativeName("Name", "D3D11_DEVICE_CONTEXT_DEFERRED")]
        DeviceContextDeferred = 0x1,
    }
}
