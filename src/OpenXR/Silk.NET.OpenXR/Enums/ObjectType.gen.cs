// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public enum ObjectType
    {
        Unknown = 0,
        Instance = 1,
        Session = 2,
        Swapchain = 3,
        Space = 4,
        ActionSet = 5,
        Action = 6,
        DebugUtilsMessengerExt = 1000019000,
        SpatialAnchorMsft = 1000039000,
        HandTrackerExt = 1000051000,
    }
}
