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
    [NativeName("Name", "VkPastPresentationTimingEXT")]
    public unsafe partial struct PastPresentationTimingEXT : IChainable
    {
        public PastPresentationTimingEXT
        (
            StructureType? sType = StructureType.PastPresentationTimingExt,
            void* pNext = null,
            ulong? presentId = null,
            ulong? targetTime = null,
            uint? presentStageCount = null,
            PresentStageTimeEXT* pPresentStages = null,
            TimeDomainKHR? timeDomain = null,
            ulong? timeDomainId = null,
            Bool32? reportComplete = null
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

            if (presentId is not null)
            {
                PresentId = presentId.Value;
            }

            if (targetTime is not null)
            {
                TargetTime = targetTime.Value;
            }

            if (presentStageCount is not null)
            {
                PresentStageCount = presentStageCount.Value;
            }

            if (pPresentStages is not null)
            {
                PPresentStages = pPresentStages;
            }

            if (timeDomain is not null)
            {
                TimeDomain = timeDomain.Value;
            }

            if (timeDomainId is not null)
            {
                TimeDomainId = timeDomainId.Value;
            }

            if (reportComplete is not null)
            {
                ReportComplete = reportComplete.Value;
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
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "presentId")]
        public ulong PresentId;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "targetTime")]
        public ulong TargetTime;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "presentStageCount")]
        public uint PresentStageCount;
/// <summary></summary>
        [NativeName("Type", "VkPresentStageTimeEXT*")]
        [NativeName("Type.Name", "VkPresentStageTimeEXT")]
        [NativeName("Name", "pPresentStages")]
        public PresentStageTimeEXT* PPresentStages;
/// <summary></summary>
        [NativeName("Type", "VkTimeDomainKHR")]
        [NativeName("Type.Name", "VkTimeDomainKHR")]
        [NativeName("Name", "timeDomain")]
        public TimeDomainKHR TimeDomain;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "timeDomainId")]
        public ulong TimeDomainId;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "reportComplete")]
        public Bool32 ReportComplete;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PastPresentationTimingExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
