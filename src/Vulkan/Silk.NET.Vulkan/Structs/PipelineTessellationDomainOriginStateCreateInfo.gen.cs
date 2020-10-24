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
    [NativeName("Name", "VkPipelineTessellationDomainOriginStateCreateInfo")]
    public unsafe partial struct PipelineTessellationDomainOriginStateCreateInfo
    {
        public PipelineTessellationDomainOriginStateCreateInfo
        (
            StructureType? sType = StructureType.PipelineTessellationDomainOriginStateCreateInfo,
            void* pNext = null,
            TessellationDomainOrigin? domainOrigin = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (domainOrigin is not null)
            {
                DomainOrigin = domainOrigin.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkTessellationDomainOrigin")]
        [NativeName("Type.Name", "VkTessellationDomainOrigin")]
        [NativeName("Name", "domainOrigin")]
        public TessellationDomainOrigin DomainOrigin;
    }
}
