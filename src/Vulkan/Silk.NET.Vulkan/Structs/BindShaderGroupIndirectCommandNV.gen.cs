// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkBindShaderGroupIndirectCommandNV")]
    public unsafe struct BindShaderGroupIndirectCommandNV
    {
        public BindShaderGroupIndirectCommandNV
        (
            uint groupIndex = default
        )
        {
           GroupIndex = groupIndex;
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "groupIndex")]
        public uint GroupIndex;
    }
}
