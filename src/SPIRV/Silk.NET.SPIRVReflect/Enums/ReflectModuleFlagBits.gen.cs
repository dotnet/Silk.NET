// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRVReflect
{
    [NativeName("Name", "SpvReflectModuleFlagBits")]
    public enum ReflectModuleFlagBits : int
    {
        [NativeName("Name", "SPV_REFLECT_MODULE_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "SPV_REFLECT_MODULE_FLAG_NO_COPY")]
        NoCopy = 0x1,
    }
}
