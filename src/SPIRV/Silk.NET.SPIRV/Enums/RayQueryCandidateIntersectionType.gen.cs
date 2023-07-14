// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvRayQueryCandidateIntersectionType_")]
    public enum RayQueryCandidateIntersectionType : int
    {
        [NativeName("Name", "SpvRayQueryCandidateIntersectionTypeRayQueryCandidateIntersectionTriangleKHR")]
        RayQueryCandidateIntersectionTriangleKhr = 0x0,
        [NativeName("Name", "SpvRayQueryCandidateIntersectionTypeRayQueryCandidateIntersectionAABBKHR")]
        RayQueryCandidateIntersectionAabbkhr = 0x1,
        [NativeName("Name", "SpvRayQueryCandidateIntersectionTypeMax")]
        Max = 0x7FFFFFFF,
    }
}
