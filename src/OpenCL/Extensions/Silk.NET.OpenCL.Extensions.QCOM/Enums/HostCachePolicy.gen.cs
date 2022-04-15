// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.QCOM
{
    [NativeName("Name", "host_cache_policy")]
    public enum HostCachePolicy : int
    {
        [NativeName("Name", "CL_MEM_HOST_UNCACHED_QCOM")]
        MemHostUncachedQCom = 0x40A4,
        [NativeName("Name", "CL_MEM_HOST_WRITEBACK_QCOM")]
        MemHostWritebackQCom = 0x40A5,
        [NativeName("Name", "CL_MEM_HOST_WRITETHROUGH_QCOM")]
        MemHostWritethroughQCom = 0x40A6,
        [NativeName("Name", "CL_MEM_HOST_WRITE_COMBINING_QCOM")]
        MemHostWriteCombiningQCom = 0x40A7,
        [NativeName("Name", "CL_MEM_HOST_IOCOHERENT_QCOM")]
        MemHostIocoherentQCom = 0x40A9,
    }
}
