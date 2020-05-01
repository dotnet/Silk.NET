// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum ToolPurposeFlagsEXT
    {
        ToolPurposeValidationBitExt = 1,
        ToolPurposeProfilingBitExt = 2,
        ToolPurposeTracingBitExt = 4,
        ToolPurposeAdditionalFeaturesBitExt = 8,
        ToolPurposeModifyingFeaturesBitExt = 16,
        ToolPurposeDebugReportingBitExt = 32,
        ToolPurposeDebugMarkersBitExt = 64,
    }
}
