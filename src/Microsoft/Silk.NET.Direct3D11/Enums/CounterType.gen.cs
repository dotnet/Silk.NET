// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_COUNTER_TYPE")]
    public enum CounterType : int
    {
        [NativeName("Name", "D3D11_COUNTER_TYPE_FLOAT32")]
        CounterTypeFloat32 = 0x0,
        [NativeName("Name", "D3D11_COUNTER_TYPE_UINT16")]
        CounterTypeUint16 = 0x1,
        [NativeName("Name", "D3D11_COUNTER_TYPE_UINT32")]
        CounterTypeUint32 = 0x2,
        [NativeName("Name", "D3D11_COUNTER_TYPE_UINT64")]
        CounterTypeUint64 = 0x3,
    }
}
