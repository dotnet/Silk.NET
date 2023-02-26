// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrEnvironmentBlendMode")]
    public enum EnvironmentBlendMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "XR_ENVIRONMENT_BLEND_MODE_OPAQUE")]
        Opaque = 1,
        [NativeName("Name", "XR_ENVIRONMENT_BLEND_MODE_ADDITIVE")]
        Additive = 2,
        [NativeName("Name", "XR_ENVIRONMENT_BLEND_MODE_ALPHA_BLEND")]
        AlphaBlend = 3,
    }
}
