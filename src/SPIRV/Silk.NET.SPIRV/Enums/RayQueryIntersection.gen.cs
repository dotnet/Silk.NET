// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvRayQueryIntersection_")]
    public enum RayQueryIntersection : int
    {
        [NativeName("Name", "SpvRayQueryIntersectionRayQueryCandidateIntersectionKHR")]
        RayQueryCandidateIntersectionKhr = 0x0,
        [NativeName("Name", "SpvRayQueryIntersectionRayQueryCommittedIntersectionKHR")]
        RayQueryCommittedIntersectionKhr = 0x1,
        [NativeName("Name", "SpvRayQueryIntersectionMax")]
        Max = 0x7FFFFFFF,
    }
}
