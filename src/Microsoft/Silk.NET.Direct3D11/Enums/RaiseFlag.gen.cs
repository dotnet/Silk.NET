// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_RAISE_FLAG")]
    public enum RaiseFlag : int
    {
        [Obsolete("Deprecated in favour of \"DriverInternalError\"")]
        [NativeName("Name", "D3D11_RAISE_FLAG_DRIVER_INTERNAL_ERROR")]
        RaiseFlagDriverInternalError = 0x1,
        [NativeName("Name", "D3D11_RAISE_FLAG_DRIVER_INTERNAL_ERROR")]
        DriverInternalError = 0x1,
    }
}
