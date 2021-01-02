// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkShaderResourceUsageAMD")]
    public unsafe partial struct ShaderResourceUsageAMD
    {
        public ShaderResourceUsageAMD
        (
            uint? numUsedVgprs = null,
            uint? numUsedSgprs = null,
            uint? ldsSizePerLocalWorkGroup = null,
            nuint? ldsUsageSizeInBytes = null,
            nuint? scratchMemUsageInBytes = null
        ) : this()
        {
            if (numUsedVgprs is not null)
            {
                NumUsedVgprs = numUsedVgprs.Value;
            }

            if (numUsedSgprs is not null)
            {
                NumUsedSgprs = numUsedSgprs.Value;
            }

            if (ldsSizePerLocalWorkGroup is not null)
            {
                LdsSizePerLocalWorkGroup = ldsSizePerLocalWorkGroup.Value;
            }

            if (ldsUsageSizeInBytes is not null)
            {
                LdsUsageSizeInBytes = ldsUsageSizeInBytes.Value;
            }

            if (scratchMemUsageInBytes is not null)
            {
                ScratchMemUsageInBytes = scratchMemUsageInBytes.Value;
            }
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
        public nuint LdsUsageSizeInBytes;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "scratchMemUsageInBytes")]
        public nuint ScratchMemUsageInBytes;
    }
}
