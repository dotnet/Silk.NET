// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [System.Flags]
    [NativeName("Name", "cl_context_memory_initialize_khr")]
    public enum ContextMemoryInitialize : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_CONTEXT_MEMORY_INITIALIZE_LOCAL_KHR")]
        Local = 0x1,
        [NativeName("Name", "CL_CONTEXT_MEMORY_INITIALIZE_PRIVATE_KHR")]
        Private = 0x2,
    }
}
