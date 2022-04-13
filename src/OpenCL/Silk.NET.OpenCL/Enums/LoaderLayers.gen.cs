// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_loader_layers")]
    public enum LoaderLayers : int
    {
        [NativeName("Name", "CL_LAYER_API_VERSION_100")]
        LayerApiVersion100 = 0x100,
    }
}
