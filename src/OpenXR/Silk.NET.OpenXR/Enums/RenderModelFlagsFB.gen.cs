// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrRenderModelFlagsFB")]
    public enum RenderModelFlagsFB : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Subset1BitFB\"")]
        [NativeName("Name", "XR_RENDER_MODEL_SUPPORTS_GLTF_2_0_SUBSET_1_BIT_FB")]
        RenderModelSupportsGltf20Subset1BitFB = 1,
        [Obsolete("Deprecated in favour of \"Subset2BitFB\"")]
        [NativeName("Name", "XR_RENDER_MODEL_SUPPORTS_GLTF_2_0_SUBSET_2_BIT_FB")]
        RenderModelSupportsGltf20Subset2BitFB = 2,
        [NativeName("Name", "XR_RENDER_MODEL_SUPPORTS_GLTF_2_0_SUBSET_1_BIT_FB")]
        Subset1BitFB = 1,
        [NativeName("Name", "XR_RENDER_MODEL_SUPPORTS_GLTF_2_0_SUBSET_2_BIT_FB")]
        Subset2BitFB = 2,
    }
}
