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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtSampleLocationsOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetSampleLocation(this ExtSampleLocations thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SampleLocationsInfoEXT> pSampleLocationsInfo)
        {
            // SpanOverloader
            thisApi.CmdSetSampleLocation(commandBuffer, in pSampleLocationsInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMultisampleProperties = new(StructureType.MultisamplePropertiesExt);")]
        public static unsafe void GetPhysicalDeviceMultisampleProperties(this ExtSampleLocations thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MultisamplePropertiesEXT> pMultisampleProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceMultisampleProperties(physicalDevice, samples, out pMultisampleProperties.GetPinnableReference());
        }

    }
}

