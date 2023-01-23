// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
    [NativeName("Name", "VkPipelineTessellationDomainOriginStateCreateInfoKHR")]
    [NativeName("AliasOf", "VkPipelineTessellationDomainOriginStateCreateInfo")]
    public unsafe partial struct PipelineTessellationDomainOriginStateCreateInfoKHR : IExtendsChain<PipelineTessellationStateCreateInfo>
    {
        public PipelineTessellationDomainOriginStateCreateInfoKHR
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineTessellationDomainOriginStateCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
