// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRVReflect
{
    [Flags]
    [NativeName("Name", "__AnonymousEnum_spirv_reflect_L261_C1")]
    public enum AnonymousEnumSpirvReflectL261C1 : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "SPV_REFLECT_MAX_ARRAY_DIMS")]
        ArrayDims = 0x20,
        [NativeName("Name", "SPV_REFLECT_MAX_DESCRIPTOR_SETS")]
        DescriptorSets = 0x40,
    }
}
