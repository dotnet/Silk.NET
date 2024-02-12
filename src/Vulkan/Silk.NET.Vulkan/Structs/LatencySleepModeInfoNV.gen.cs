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
    [NativeName("Name", "VkLatencySleepModeInfoNV")]
    public unsafe partial struct LatencySleepModeInfoNV : IChainable
    {
        public LatencySleepModeInfoNV
        (
            StructureType? sType = StructureType.LatencySleepModeInfoNV,
            void* pNext = null,
            Bool32? lowLatencyMode = null,
            Bool32? lowLatencyBoost = null,
            uint? minimumIntervalUs = null
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

            if (lowLatencyMode is not null)
            {
                LowLatencyMode = lowLatencyMode.Value;
            }

            if (lowLatencyBoost is not null)
            {
                LowLatencyBoost = lowLatencyBoost.Value;
            }

            if (minimumIntervalUs is not null)
            {
                MinimumIntervalUs = minimumIntervalUs.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "lowLatencyMode")]
        public Bool32 LowLatencyMode;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "lowLatencyBoost")]
        public Bool32 LowLatencyBoost;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minimumIntervalUs")]
        public uint MinimumIntervalUs;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.LatencySleepModeInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
