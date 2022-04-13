// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_arm_import_memory")]
    public enum ArmImportMemory : int
    {
        [NativeName("Name", "CL_IMPORT_MEMORY_WHOLE_ALLOCATION_ARM")]
        ImportMemoryWholeAllocationArm = unchecked((int) -1),
    }
}
