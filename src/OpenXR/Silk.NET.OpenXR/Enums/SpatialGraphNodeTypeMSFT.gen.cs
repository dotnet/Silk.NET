// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialGraphNodeTypeMSFT")]
    public enum SpatialGraphNodeTypeMSFT : int
    {
        [NativeName("Name", "XR_SPATIAL_GRAPH_NODE_TYPE_STATIC_MSFT")]
        SpatialGraphNodeTypeStaticMsft = 1,
        [NativeName("Name", "XR_SPATIAL_GRAPH_NODE_TYPE_DYNAMIC_MSFT")]
        SpatialGraphNodeTypeDynamicMsft = 2,
    }
}
