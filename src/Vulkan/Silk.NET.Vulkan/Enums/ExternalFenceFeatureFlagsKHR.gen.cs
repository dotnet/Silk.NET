// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum ExternalFenceFeatureFlagsKHR
    {
        ExternalFenceFeatureExportableBit = 1,
        ExternalFenceFeatureImportableBit = 2,
    }
}
