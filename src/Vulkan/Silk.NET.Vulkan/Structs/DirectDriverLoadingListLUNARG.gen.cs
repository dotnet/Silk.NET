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
    [NativeName("Name", "VkDirectDriverLoadingListLUNARG")]
    public unsafe partial struct DirectDriverLoadingListLUNARG : IExtendsChain<InstanceCreateInfo>
    {
        public DirectDriverLoadingListLUNARG
        (
            StructureType? sType = StructureType.DirectDriverLoadingListLunarg,
            void* pNext = null,
            DirectDriverLoadingModeLUNARG? mode = null,
            uint? driverCount = null,
            DirectDriverLoadingInfoLUNARG* pDrivers = null
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

            if (mode is not null)
            {
                Mode = mode.Value;
            }

            if (driverCount is not null)
            {
                DriverCount = driverCount.Value;
            }

            if (pDrivers is not null)
            {
                PDrivers = pDrivers;
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
        [NativeName("Type", "VkDirectDriverLoadingModeLUNARG")]
        [NativeName("Type.Name", "VkDirectDriverLoadingModeLUNARG")]
        [NativeName("Name", "mode")]
        public DirectDriverLoadingModeLUNARG Mode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "driverCount")]
        public uint DriverCount;
/// <summary></summary>
        [NativeName("Type", "VkDirectDriverLoadingInfoLUNARG*")]
        [NativeName("Type.Name", "VkDirectDriverLoadingInfoLUNARG")]
        [NativeName("Name", "pDrivers")]
        public DirectDriverLoadingInfoLUNARG* PDrivers;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DirectDriverLoadingListLunarg;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
