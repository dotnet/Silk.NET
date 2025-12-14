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
    [NativeName("Name", "VkPastPresentationTimingPropertiesEXT")]
    public unsafe partial struct PastPresentationTimingPropertiesEXT : IChainable
    {
        public PastPresentationTimingPropertiesEXT
        (
            StructureType? sType = StructureType.PastPresentationTimingPropertiesExt,
            void* pNext = null,
            ulong? timingPropertiesCounter = null,
            ulong? timeDomainsCounter = null,
            uint? presentationTimingCount = null,
            PastPresentationTimingEXT* pPresentationTimings = null
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

            if (timingPropertiesCounter is not null)
            {
                TimingPropertiesCounter = timingPropertiesCounter.Value;
            }

            if (timeDomainsCounter is not null)
            {
                TimeDomainsCounter = timeDomainsCounter.Value;
            }

            if (presentationTimingCount is not null)
            {
                PresentationTimingCount = presentationTimingCount.Value;
            }

            if (pPresentationTimings is not null)
            {
                PPresentationTimings = pPresentationTimings;
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
        [NativeName("Name", "timingPropertiesCounter")]
        public ulong TimingPropertiesCounter;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "timeDomainsCounter")]
        public ulong TimeDomainsCounter;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "presentationTimingCount")]
        public uint PresentationTimingCount;
/// <summary></summary>
        [NativeName("Type", "VkPastPresentationTimingEXT*")]
        [NativeName("Type.Name", "VkPastPresentationTimingEXT")]
        [NativeName("Name", "pPresentationTimings")]
        public PastPresentationTimingEXT* PPresentationTimings;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PastPresentationTimingPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
