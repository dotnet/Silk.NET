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
    [NativeName("Name", "VkShaderResourceUsageAMD")]
    public unsafe struct ShaderResourceUsageAMD
    {
        public ShaderResourceUsageAMD
        (
            uint numUsedVgprs = default,
            uint numUsedSgprs = default,
            uint ldsSizePerLocalWorkGroup = default,
            UIntPtr ldsUsageSizeInBytes = default,
            UIntPtr scratchMemUsageInBytes = default
        )
        {
           NumUsedVgprs = numUsedVgprs;
           NumUsedSgprs = numUsedSgprs;
           LdsSizePerLocalWorkGroup = ldsSizePerLocalWorkGroup;
           LdsUsageSizeInBytes = ldsUsageSizeInBytes;
           ScratchMemUsageInBytes = scratchMemUsageInBytes;
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "numUsedVgprs")]
        public uint NumUsedVgprs;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "numUsedSgprs")]
        public uint NumUsedSgprs;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "ldsSizePerLocalWorkGroup")]
        public uint LdsSizePerLocalWorkGroup;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "ldsUsageSizeInBytes")]
        public UIntPtr LdsUsageSizeInBytes;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "scratchMemUsageInBytes")]
        public UIntPtr ScratchMemUsageInBytes;
    }
}
