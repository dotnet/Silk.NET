// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Reflect
{
    [Flags]
    [NativeName("Name", "__AnonymousEnum_spirv_reflect_L281_C1")]
    public enum Constants : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "SPV_REFLECT_MAX_ARRAY_DIMS")]
        MaxArrayDims = 0x20,
        [NativeName("Name", "SPV_REFLECT_MAX_DESCRIPTOR_SETS")]
        MaxDescriptorSets = 0x40,
        [NativeName("Name", "SPV_REFLECT_BINDING_NUMBER_DONT_CHANGE")]
        BindingNumberDontChange = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "SPV_REFLECT_SET_NUMBER_DONT_CHANGE")]
        SetNumberDontChange = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
