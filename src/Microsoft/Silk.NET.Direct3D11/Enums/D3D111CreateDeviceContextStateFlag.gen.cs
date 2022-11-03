// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_1_CREATE_DEVICE_CONTEXT_STATE_FLAG")]
    public enum D3D111CreateDeviceContextStateFlag : int
    {
        [Obsolete("Deprecated in favour of \"Singlethreaded\"")]
        [NativeName("Name", "D3D11_1_CREATE_DEVICE_CONTEXT_STATE_SINGLETHREADED")]
        D3D111CreateDeviceContextStateSinglethreaded = 0x1,
        [NativeName("Name", "D3D11_1_CREATE_DEVICE_CONTEXT_STATE_SINGLETHREADED")]
        Singlethreaded = 0x1,
    }
}
