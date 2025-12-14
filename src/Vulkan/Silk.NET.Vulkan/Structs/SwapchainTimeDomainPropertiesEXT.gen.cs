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
    [NativeName("Name", "VkSwapchainTimeDomainPropertiesEXT")]
    public unsafe partial struct SwapchainTimeDomainPropertiesEXT : IChainable
    {
        public SwapchainTimeDomainPropertiesEXT
        (
            StructureType? sType = StructureType.SwapchainTimeDomainPropertiesExt,
            void* pNext = null,
            uint? timeDomainCount = null,
            TimeDomainKHR* pTimeDomains = null,
            ulong* pTimeDomainIds = null
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

            if (timeDomainCount is not null)
            {
                TimeDomainCount = timeDomainCount.Value;
            }

            if (pTimeDomains is not null)
            {
                PTimeDomains = pTimeDomains;
            }

            if (pTimeDomainIds is not null)
            {
                PTimeDomainIds = pTimeDomainIds;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "timeDomainCount")]
        public uint TimeDomainCount;
/// <summary></summary>
        [NativeName("Type", "VkTimeDomainKHR*")]
        [NativeName("Type.Name", "VkTimeDomainKHR")]
        [NativeName("Name", "pTimeDomains")]
        public TimeDomainKHR* PTimeDomains;
/// <summary></summary>
        [NativeName("Type", "uint64_t*")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "pTimeDomainIds")]
        public ulong* PTimeDomainIds;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SwapchainTimeDomainPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
