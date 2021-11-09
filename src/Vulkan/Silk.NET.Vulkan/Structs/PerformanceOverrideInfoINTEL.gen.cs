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
    [NativeName("Name", "VkPerformanceOverrideInfoINTEL")]
    public unsafe partial struct PerformanceOverrideInfoINTEL : IChainable
    {
        public PerformanceOverrideInfoINTEL
        (
            StructureType? sType = StructureType.PerformanceOverrideInfoIntel,
            void* pNext = null,
            PerformanceOverrideTypeINTEL? type = null,
            Bool32? enable = null,
            ulong? parameter = null
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

            if (type is not null)
            {
                Type = type.Value;
            }

            if (enable is not null)
            {
                Enable = enable.Value;
            }

            if (parameter is not null)
            {
                Parameter = parameter.Value;
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
        [NativeName("Type", "VkPerformanceOverrideTypeINTEL")]
        [NativeName("Type.Name", "VkPerformanceOverrideTypeINTEL")]
        [NativeName("Name", "type")]
        public PerformanceOverrideTypeINTEL Type;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "enable")]
        public Bool32 Enable;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "parameter")]
        public ulong Parameter;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PerformanceOverrideInfoIntel;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
