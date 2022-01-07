// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrTriangleMeshFlagsFB")]
    public enum TriangleMeshFlagsFB : long
    {
        [NativeName("Name", "XR_TRIANGLE_MESH_MUTABLE_BIT_FB")]
        TriangleMeshMutableBitFB = 1,
    }
}
