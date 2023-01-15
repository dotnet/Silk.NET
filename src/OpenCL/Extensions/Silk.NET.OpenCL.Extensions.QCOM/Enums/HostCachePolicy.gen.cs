// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.QCOM
{
    [NativeName("Name", "cl_uint host_cache_policy")]
    public enum HostCachePolicy : int
    {
        [NativeName("Name", "CL_MEM_HOST_UNCACHED_QCOM")]
        Uncached = 0x40A4,
        [NativeName("Name", "CL_MEM_HOST_WRITEBACK_QCOM")]
        Writeback = 0x40A5,
        [NativeName("Name", "CL_MEM_HOST_WRITETHROUGH_QCOM")]
        Writethrough = 0x40A6,
        [NativeName("Name", "CL_MEM_HOST_WRITE_COMBINING_QCOM")]
        WriteCombining = 0x40A7,
        [NativeName("Name", "CL_MEM_HOST_IOCOHERENT_QCOM")]
        Iocoherent = 0x40A9,
    }
}
