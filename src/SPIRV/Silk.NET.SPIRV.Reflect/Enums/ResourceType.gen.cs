// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Reflect
{
    [Flags]
    [NativeName("Name", "SpvReflectResourceType")]
    public enum ResourceType : int
    {
        [NativeName("Name", "SPV_REFLECT_RESOURCE_FLAG_UNDEFINED")]
        Undefined = 0x0,
        [NativeName("Name", "SPV_REFLECT_RESOURCE_FLAG_SAMPLER")]
        Sampler = 0x1,
        [NativeName("Name", "SPV_REFLECT_RESOURCE_FLAG_CBV")]
        Cbv = 0x2,
        [NativeName("Name", "SPV_REFLECT_RESOURCE_FLAG_SRV")]
        Srv = 0x4,
        [NativeName("Name", "SPV_REFLECT_RESOURCE_FLAG_UAV")]
        Uav = 0x8,
    }
}
