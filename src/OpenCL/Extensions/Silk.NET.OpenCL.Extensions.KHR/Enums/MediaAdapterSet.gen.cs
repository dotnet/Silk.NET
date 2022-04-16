// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_media_adapter_set_khr")]
    public enum MediaAdapterSet : int
    {
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_DX9_MEDIA_ADAPTER_KHR")]
        PreferredDevicesForDX9MediaAdapter = 0x2023,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_DX9_MEDIA_ADAPTER_KHR")]
        AllDevicesForDX9MediaAdapter = 0x2024,
    }
}
