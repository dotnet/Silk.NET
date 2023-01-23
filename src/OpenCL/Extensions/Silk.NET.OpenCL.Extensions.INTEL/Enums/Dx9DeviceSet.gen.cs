// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_dx9_device_set_intel")]
    public enum Dx9DeviceSet : int
    {
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_DX9_INTEL")]
        PreferredDevicesForDX9 = 0x4024,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_DX9_INTEL")]
        AllDevicesForDX9 = 0x4025,
    }
}
