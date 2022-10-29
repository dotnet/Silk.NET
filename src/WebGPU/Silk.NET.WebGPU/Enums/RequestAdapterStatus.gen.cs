// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPURequestAdapterStatus")]
    public enum RequestAdapterStatus : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Success\"")]
        [NativeName("Name", "WGPURequestAdapterStatus_Success")]
        RequestAdapterStatusSuccess = 0x0,
        [Obsolete("Deprecated in favour of \"Unavailable\"")]
        [NativeName("Name", "WGPURequestAdapterStatus_Unavailable")]
        RequestAdapterStatusUnavailable = 0x1,
        [Obsolete("Deprecated in favour of \"Error\"")]
        [NativeName("Name", "WGPURequestAdapterStatus_Error")]
        RequestAdapterStatusError = 0x2,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "WGPURequestAdapterStatus_Unknown")]
        RequestAdapterStatusUnknown = 0x3,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPURequestAdapterStatus_Force32")]
        RequestAdapterStatusForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPURequestAdapterStatus_Success")]
        Success = 0x0,
        [NativeName("Name", "WGPURequestAdapterStatus_Unavailable")]
        Unavailable = 0x1,
        [NativeName("Name", "WGPURequestAdapterStatus_Error")]
        Error = 0x2,
        [NativeName("Name", "WGPURequestAdapterStatus_Unknown")]
        Unknown = 0x3,
        [NativeName("Name", "WGPURequestAdapterStatus_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
