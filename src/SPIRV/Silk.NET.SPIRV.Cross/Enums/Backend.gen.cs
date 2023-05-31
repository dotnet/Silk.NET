// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_backend")]
    public enum Backend : int
    {
        [NativeName("Name", "SPVC_BACKEND_NONE")]
        None = 0x0,
        [NativeName("Name", "SPVC_BACKEND_GLSL")]
        Glsl = 0x1,
        [NativeName("Name", "SPVC_BACKEND_HLSL")]
        Hlsl = 0x2,
        [NativeName("Name", "SPVC_BACKEND_MSL")]
        Msl = 0x3,
        [NativeName("Name", "SPVC_BACKEND_CPP")]
        Cpp = 0x4,
        [NativeName("Name", "SPVC_BACKEND_JSON")]
        Json = 0x5,
        [NativeName("Name", "SPVC_BACKEND_INT_MAX")]
        IntMax = 0x7FFFFFFF,
    }
}
