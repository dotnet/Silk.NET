// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
