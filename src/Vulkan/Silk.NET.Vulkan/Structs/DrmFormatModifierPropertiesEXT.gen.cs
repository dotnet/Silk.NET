// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct DrmFormatModifierPropertiesEXT
    {
        public DrmFormatModifierPropertiesEXT
        (
            ulong drmFormatModifier = default,
            uint drmFormatModifierPlaneCount = default,
            FormatFeatureFlags drmFormatModifierTilingFeatures = default
        )
        {
           DrmFormatModifier = drmFormatModifier;
           DrmFormatModifierPlaneCount = drmFormatModifierPlaneCount;
           DrmFormatModifierTilingFeatures = drmFormatModifierTilingFeatures;
        }

/// <summary></summary>
        public ulong DrmFormatModifier;
/// <summary></summary>
        public uint DrmFormatModifierPlaneCount;
/// <summary></summary>
        public FormatFeatureFlags DrmFormatModifierTilingFeatures;
    }
}
