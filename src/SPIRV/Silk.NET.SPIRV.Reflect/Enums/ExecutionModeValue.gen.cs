// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Reflect
{
    [NativeName("Name", "SpvReflectExecutionModeValue")]
    public enum ExecutionModeValue : int
    {
        [NativeName("Name", "SPV_REFLECT_EXECUTION_MODE_SPEC_CONSTANT")]
        SpecConstant = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
