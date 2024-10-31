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
    [NativeName("Name", "VkLatencyTimingsFrameReportNV")]
    public unsafe partial struct LatencyTimingsFrameReportNV : IChainable
    {
        public LatencyTimingsFrameReportNV
        (
            StructureType? sType = StructureType.LatencyTimingsFrameReportNV,
            void* pNext = null,
            ulong? presentID = null,
            ulong? inputSampleTimeUs = null,
            ulong? simStartTimeUs = null,
            ulong? simEndTimeUs = null,
            ulong? renderSubmitStartTimeUs = null,
            ulong? renderSubmitEndTimeUs = null,
            ulong? presentStartTimeUs = null,
            ulong? presentEndTimeUs = null,
            ulong? driverStartTimeUs = null,
            ulong? driverEndTimeUs = null,
            ulong? osRenderQueueStartTimeUs = null,
            ulong? osRenderQueueEndTimeUs = null,
            ulong? gpuRenderStartTimeUs = null,
            ulong? gpuRenderEndTimeUs = null
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

            if (presentID is not null)
            {
                PresentID = presentID.Value;
            }

            if (inputSampleTimeUs is not null)
            {
                InputSampleTimeUs = inputSampleTimeUs.Value;
            }

            if (simStartTimeUs is not null)
            {
                SimStartTimeUs = simStartTimeUs.Value;
            }

            if (simEndTimeUs is not null)
            {
                SimEndTimeUs = simEndTimeUs.Value;
            }

            if (renderSubmitStartTimeUs is not null)
            {
                RenderSubmitStartTimeUs = renderSubmitStartTimeUs.Value;
            }

            if (renderSubmitEndTimeUs is not null)
            {
                RenderSubmitEndTimeUs = renderSubmitEndTimeUs.Value;
            }

            if (presentStartTimeUs is not null)
            {
                PresentStartTimeUs = presentStartTimeUs.Value;
            }

            if (presentEndTimeUs is not null)
            {
                PresentEndTimeUs = presentEndTimeUs.Value;
            }

            if (driverStartTimeUs is not null)
            {
                DriverStartTimeUs = driverStartTimeUs.Value;
            }

            if (driverEndTimeUs is not null)
            {
                DriverEndTimeUs = driverEndTimeUs.Value;
            }

            if (osRenderQueueStartTimeUs is not null)
            {
                OsRenderQueueStartTimeUs = osRenderQueueStartTimeUs.Value;
            }

            if (osRenderQueueEndTimeUs is not null)
            {
                OsRenderQueueEndTimeUs = osRenderQueueEndTimeUs.Value;
            }

            if (gpuRenderStartTimeUs is not null)
            {
                GpuRenderStartTimeUs = gpuRenderStartTimeUs.Value;
            }

            if (gpuRenderEndTimeUs is not null)
            {
                GpuRenderEndTimeUs = gpuRenderEndTimeUs.Value;
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
        [NativeName("Name", "presentID")]
        public ulong PresentID;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "inputSampleTimeUs")]
        public ulong InputSampleTimeUs;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "simStartTimeUs")]
        public ulong SimStartTimeUs;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "simEndTimeUs")]
        public ulong SimEndTimeUs;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "renderSubmitStartTimeUs")]
        public ulong RenderSubmitStartTimeUs;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "renderSubmitEndTimeUs")]
        public ulong RenderSubmitEndTimeUs;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "presentStartTimeUs")]
        public ulong PresentStartTimeUs;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "presentEndTimeUs")]
        public ulong PresentEndTimeUs;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "driverStartTimeUs")]
        public ulong DriverStartTimeUs;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "driverEndTimeUs")]
        public ulong DriverEndTimeUs;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "osRenderQueueStartTimeUs")]
        public ulong OsRenderQueueStartTimeUs;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "osRenderQueueEndTimeUs")]
        public ulong OsRenderQueueEndTimeUs;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "gpuRenderStartTimeUs")]
        public ulong GpuRenderStartTimeUs;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "gpuRenderEndTimeUs")]
        public ulong GpuRenderEndTimeUs;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.LatencyTimingsFrameReportNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
