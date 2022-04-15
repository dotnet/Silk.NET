// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_media_adapter_type_khr")]
    public enum MediaAdapterTypeKhr : int
    {
        [NativeName("Name", "CL_ADAPTER_D3D9_KHR")]
        AdapterD3D9Khr = 0x2020,
        [NativeName("Name", "CL_ADAPTER_D3D9EX_KHR")]
        AdapterD3D9EXKhr = 0x2021,
        [NativeName("Name", "CL_ADAPTER_DXVA_KHR")]
        AdapterDxvaKhr = 0x2022,
    }
}
