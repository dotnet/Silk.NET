// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkFormatProperties")]
    public unsafe partial struct FormatProperties
    {
        public FormatProperties
        (
            FormatFeatureFlags? linearTilingFeatures = null,
            FormatFeatureFlags? optimalTilingFeatures = null,
            FormatFeatureFlags? bufferFeatures = null
        ) : this()
        {
            if (linearTilingFeatures is not null)
            {
                LinearTilingFeatures = linearTilingFeatures.Value;
            }

            if (optimalTilingFeatures is not null)
            {
                OptimalTilingFeatures = optimalTilingFeatures.Value;
            }

            if (bufferFeatures is not null)
            {
                BufferFeatures = bufferFeatures.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkFormatFeatureFlags")]
        [NativeName("Type.Name", "VkFormatFeatureFlags")]
        [NativeName("Name", "linearTilingFeatures")]
        public FormatFeatureFlags LinearTilingFeatures;
/// <summary></summary>
        [NativeName("Type", "VkFormatFeatureFlags")]
        [NativeName("Type.Name", "VkFormatFeatureFlags")]
        [NativeName("Name", "optimalTilingFeatures")]
        public FormatFeatureFlags OptimalTilingFeatures;
/// <summary></summary>
        [NativeName("Type", "VkFormatFeatureFlags")]
        [NativeName("Type.Name", "VkFormatFeatureFlags")]
        [NativeName("Name", "bufferFeatures")]
        public FormatFeatureFlags BufferFeatures;
    }
}
