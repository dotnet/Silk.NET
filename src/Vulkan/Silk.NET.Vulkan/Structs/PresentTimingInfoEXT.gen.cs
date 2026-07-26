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
    [NativeName("Name", "VkPresentTimingInfoEXT")]
    public unsafe partial struct PresentTimingInfoEXT : IChainable
    {
        public PresentTimingInfoEXT
        (
            StructureType? sType = StructureType.PresentTimingInfoExt,
            void* pNext = null,
            PresentTimingInfoFlagsEXT? flags = null,
            ulong? targetTime = null,
            ulong? timeDomainId = null,
            PresentStageFlagsEXT? presentStageQueries = null,
            PresentStageFlagsEXT? targetTimeDomainPresentStage = null
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

            if (targetTime is not null)
            {
                TargetTime = targetTime.Value;
            }

            if (timeDomainId is not null)
            {
                TimeDomainId = timeDomainId.Value;
            }

            if (presentStageQueries is not null)
            {
                PresentStageQueries = presentStageQueries.Value;
            }

            if (targetTimeDomainPresentStage is not null)
            {
                TargetTimeDomainPresentStage = targetTimeDomainPresentStage.Value;
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
        [NativeName("Type", "VkPresentTimingInfoFlagsEXT")]
        [NativeName("Type.Name", "VkPresentTimingInfoFlagsEXT")]
        [NativeName("Name", "flags")]
        public PresentTimingInfoFlagsEXT Flags;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "targetTime")]
        public ulong TargetTime;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "timeDomainId")]
        public ulong TimeDomainId;
/// <summary></summary>
        [NativeName("Type", "VkPresentStageFlagsEXT")]
        [NativeName("Type.Name", "VkPresentStageFlagsEXT")]
        [NativeName("Name", "presentStageQueries")]
        public PresentStageFlagsEXT PresentStageQueries;
/// <summary></summary>
        [NativeName("Type", "VkPresentStageFlagsEXT")]
        [NativeName("Type.Name", "VkPresentStageFlagsEXT")]
        [NativeName("Name", "targetTimeDomainPresentStage")]
        public PresentStageFlagsEXT TargetTimeDomainPresentStage;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PresentTimingInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
