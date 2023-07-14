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
    [NativeName("Name", "VkFaultData")]
    public unsafe partial struct FaultData : IChainable
    {
        public FaultData
        (
            StructureType? sType = StructureType.FaultData,
            void* pNext = null,
            FaultLevel? faultLevel = null,
            FaultType? faultType = null
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

            if (faultLevel is not null)
            {
                FaultLevel = faultLevel.Value;
            }

            if (faultType is not null)
            {
                FaultType = faultType.Value;
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
        [NativeName("Type", "VkFaultLevel")]
        [NativeName("Type.Name", "VkFaultLevel")]
        [NativeName("Name", "faultLevel")]
        public FaultLevel FaultLevel;
/// <summary></summary>
        [NativeName("Type", "VkFaultType")]
        [NativeName("Type.Name", "VkFaultType")]
        [NativeName("Name", "faultType")]
        public FaultType FaultType;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.FaultData;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
