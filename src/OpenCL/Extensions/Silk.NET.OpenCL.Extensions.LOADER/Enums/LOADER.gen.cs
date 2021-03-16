// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.LOADER
{
    [NativeName("Name", "GLenum")]
    public enum LOADER : int
    {
        [NativeName("Name", "CL_LAYER_API_VERSION")]
        LayerApiVersion = 0x4240,
        [NativeName("Name", "CL_LAYER_API_VERSION_100")]
        LayerApiVersion100 = 0x100,
    }
}
