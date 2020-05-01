// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct FormatProperties
    {
        public FormatProperties
        (
            FormatFeatureFlags linearTilingFeatures = default,
            FormatFeatureFlags optimalTilingFeatures = default,
            FormatFeatureFlags bufferFeatures = default
        )
        {
           LinearTilingFeatures = linearTilingFeatures;
           OptimalTilingFeatures = optimalTilingFeatures;
           BufferFeatures = bufferFeatures;
        }

/// <summary></summary>
        public FormatFeatureFlags LinearTilingFeatures;
/// <summary></summary>
        public FormatFeatureFlags OptimalTilingFeatures;
/// <summary></summary>
        public FormatFeatureFlags BufferFeatures;
    }
}
