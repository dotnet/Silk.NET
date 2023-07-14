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
    [NativeName("Name", "VkFaultCallbackInfo")]
    public unsafe partial struct FaultCallbackInfo : IExtendsChain<DeviceCreateInfo>
    {
        public FaultCallbackInfo
        (
            StructureType? sType = StructureType.FaultCallbackInfo,
            void* pNext = null,
            uint? faultCount = null,
            FaultData* pFaults = null,
            PfnFaultCallbackFunction? pfnFaultCallback = null
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

            if (faultCount is not null)
            {
                FaultCount = faultCount.Value;
            }

            if (pFaults is not null)
            {
                PFaults = pFaults;
            }

            if (pfnFaultCallback is not null)
            {
                PfnFaultCallback = pfnFaultCallback.Value;
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
        [NativeName("Name", "faultCount")]
        public uint FaultCount;
/// <summary></summary>
        [NativeName("Type", "VkFaultData*")]
        [NativeName("Type.Name", "VkFaultData")]
        [NativeName("Name", "pFaults")]
        public FaultData* PFaults;
/// <summary></summary>
        [NativeName("Type", "PFN_vkFaultCallbackFunction")]
        [NativeName("Type.Name", "PFN_vkFaultCallbackFunction")]
        [NativeName("Name", "pfnFaultCallback")]
        public PfnFaultCallbackFunction PfnFaultCallback;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.FaultCallbackInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
