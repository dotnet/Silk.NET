// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrObjectType")]
    public enum ObjectType
    {
        [NativeName("Name", "XR_OBJECT_TYPE_UNKNOWN")]
        Unknown = 0,
        [NativeName("Name", "XR_OBJECT_TYPE_INSTANCE")]
        Instance = 1,
        [NativeName("Name", "XR_OBJECT_TYPE_SESSION")]
        Session = 2,
        [NativeName("Name", "XR_OBJECT_TYPE_SWAPCHAIN")]
        Swapchain = 3,
        [NativeName("Name", "XR_OBJECT_TYPE_SPACE")]
        Space = 4,
        [NativeName("Name", "XR_OBJECT_TYPE_ACTION_SET")]
        ActionSet = 5,
        [NativeName("Name", "XR_OBJECT_TYPE_ACTION")]
        Action = 6,
        [NativeName("Name", "XR_OBJECT_TYPE_DEBUG_UTILS_MESSENGER_EXT")]
        DebugUtilsMessengerExt = 1000019000,
        [NativeName("Name", "XR_OBJECT_TYPE_SPATIAL_ANCHOR_MSFT")]
        SpatialAnchorMsft = 1000039000,
        [NativeName("Name", "XR_OBJECT_TYPE_HAND_TRACKER_EXT")]
        HandTrackerExt = 1000051000,
    }
}
