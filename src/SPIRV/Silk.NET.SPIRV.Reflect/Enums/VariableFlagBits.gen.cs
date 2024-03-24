// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Reflect
{
    [NativeName("Name", "SpvReflectVariableFlagBits")]
    public enum VariableFlagBits : int
    {
        [NativeName("Name", "SPV_REFLECT_VARIABLE_FLAGS_NONE")]
        None = 0x0,
        [NativeName("Name", "SPV_REFLECT_VARIABLE_FLAGS_UNUSED")]
        Unused = 0x1,
        [NativeName("Name", "SPV_REFLECT_VARIABLE_FLAGS_PHYSICAL_POINTER_COPY")]
        PhysicalPointerCopy = 0x2,
    }
}
