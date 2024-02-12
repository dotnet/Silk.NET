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
    [NativeName("Name", "VkGetLatencyMarkerInfoNV")]
    public unsafe partial struct GetLatencyMarkerInfoNV : IChainable
    {
        public GetLatencyMarkerInfoNV
        (
            StructureType? sType = StructureType.GetLatencyMarkerInfoNV,
            void* pNext = null,
            uint? timingCount = null,
            LatencyTimingsFrameReportNV* pTimings = null
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

            if (timingCount is not null)
            {
                TimingCount = timingCount.Value;
            }

            if (pTimings is not null)
            {
                PTimings = pTimings;
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
        [NativeName("Name", "timingCount")]
        public uint TimingCount;
/// <summary></summary>
        [NativeName("Type", "VkLatencyTimingsFrameReportNV*")]
        [NativeName("Type.Name", "VkLatencyTimingsFrameReportNV")]
        [NativeName("Name", "pTimings")]
        public LatencyTimingsFrameReportNV* PTimings;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.GetLatencyMarkerInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
