// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Reflect
{
    [NativeName("Name", "SpvReflectArrayDimType")]
    public enum ArrayDimType : int
    {
        [NativeName("Name", "SPV_REFLECT_ARRAY_DIM_RUNTIME")]
        Runtime = 0x0,
    }
}
