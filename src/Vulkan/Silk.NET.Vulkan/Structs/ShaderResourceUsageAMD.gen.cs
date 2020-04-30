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
        public uint NumUsedVgprs;
/// <summary></summary>
        public uint NumUsedSgprs;
/// <summary></summary>
        public uint LdsSizePerLocalWorkGroup;
/// <summary></summary>
        public UIntPtr LdsUsageSizeInBytes;
/// <summary></summary>
        public UIntPtr ScratchMemUsageInBytes;
    }
}
