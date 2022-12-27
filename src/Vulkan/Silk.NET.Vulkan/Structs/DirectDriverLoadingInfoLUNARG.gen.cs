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
    [NativeName("Name", "VkDirectDriverLoadingInfoLUNARG")]
    public unsafe partial struct DirectDriverLoadingInfoLUNARG : IChainable
    {
        public DirectDriverLoadingInfoLUNARG
        (
            StructureType? sType = StructureType.DirectDriverLoadingInfoLunarg,
            void* pNext = null,
            uint? flags = null,
            PfnVoidFunction? pfnGetInstanceProcAddr = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (pfnGetInstanceProcAddr is not null)
            {
                PfnGetInstanceProcAddr = pfnGetInstanceProcAddr.Value;
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
        [NativeName("Type", "VkDirectDriverLoadingFlagsLUNARG")]
        [NativeName("Type.Name", "VkDirectDriverLoadingFlagsLUNARG")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "PFN_vkGetInstanceProcAddrLUNARG")]
        [NativeName("Type.Name", "PFN_vkGetInstanceProcAddrLUNARG")]
        [NativeName("Name", "pfnGetInstanceProcAddr")]
        public PfnVoidFunction PfnGetInstanceProcAddr;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DirectDriverLoadingInfoLunarg;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
