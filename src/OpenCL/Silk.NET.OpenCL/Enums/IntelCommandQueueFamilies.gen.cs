// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_intel_command_queue_families")]
    public enum IntelCommandQueueFamilies : int
    {
        [NativeName("Name", "CL_QUEUE_FAMILY_MAX_NAME_SIZE_INTEL")]
        QueueFamilyMaxNameSizeIntel = 0x64,
        [NativeName("Name", "CL_QUEUE_DEFAULT_CAPABILITIES_INTEL")]
        QueueDefaultCapabilitiesIntel = 0x0,
    }
}
