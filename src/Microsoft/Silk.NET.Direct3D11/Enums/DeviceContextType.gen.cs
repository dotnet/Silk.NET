// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_DEVICE_CONTEXT_TYPE")]
    public enum DeviceContextType : int
    {
        [Obsolete("Deprecated in favour of \"Immediate\"")]
        [NativeName("Name", "D3D11_DEVICE_CONTEXT_IMMEDIATE")]
        DeviceContextImmediate = 0x0,
        [Obsolete("Deprecated in favour of \"Deferred\"")]
        [NativeName("Name", "D3D11_DEVICE_CONTEXT_DEFERRED")]
        DeviceContextDeferred = 0x1,
        [NativeName("Name", "D3D11_DEVICE_CONTEXT_IMMEDIATE")]
        Immediate = 0x0,
        [NativeName("Name", "D3D11_DEVICE_CONTEXT_DEFERRED")]
        Deferred = 0x1,
    }
}
