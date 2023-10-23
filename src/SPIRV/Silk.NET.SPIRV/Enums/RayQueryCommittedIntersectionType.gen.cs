// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvRayQueryCommittedIntersectionType_")]
    public enum RayQueryCommittedIntersectionType : int
    {
        [NativeName("Name", "SpvRayQueryCommittedIntersectionTypeRayQueryCommittedIntersectionNoneKHR")]
        RayQueryCommittedIntersectionNoneKhr = 0x0,
        [NativeName("Name", "SpvRayQueryCommittedIntersectionTypeRayQueryCommittedIntersectionTriangleKHR")]
        RayQueryCommittedIntersectionTriangleKhr = 0x1,
        [NativeName("Name", "SpvRayQueryCommittedIntersectionTypeRayQueryCommittedIntersectionGeneratedKHR")]
        RayQueryCommittedIntersectionGeneratedKhr = 0x2,
        [NativeName("Name", "SpvRayQueryCommittedIntersectionTypeMax")]
        Max = 0x7FFFFFFF,
    }
}
