// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrVisibilityMaskTypeKHR")]
    public enum VisibilityMaskTypeKHR : int
    {
        [NativeName("Name", "XR_VISIBILITY_MASK_TYPE_HIDDEN_TRIANGLE_MESH_KHR")]
        VisibilityMaskTypeHiddenTriangleMeshKhr = 1,
        [NativeName("Name", "XR_VISIBILITY_MASK_TYPE_VISIBLE_TRIANGLE_MESH_KHR")]
        VisibilityMaskTypeVisibleTriangleMeshKhr = 2,
        [NativeName("Name", "XR_VISIBILITY_MASK_TYPE_LINE_LOOP_KHR")]
        VisibilityMaskTypeLineLoopKhr = 3,
    }
}
