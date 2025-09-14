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

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVCooperativeVectorOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdConvertCooperativeVectorMatrix(this NVCooperativeVector thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ConvertCooperativeVectorMatrixInfoNV> pInfos)
        {
            // SpanOverloader
            thisApi.CmdConvertCooperativeVectorMatrix(commandBuffer, infoCount, in pInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ConvertCooperativeVectorMatrix(this NVCooperativeVector thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ConvertCooperativeVectorMatrixInfoNV> pInfo)
        {
            // SpanOverloader
            return thisApi.ConvertCooperativeVectorMatrix(device, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.CooperativeVectorPropertiesNV);")]
        public static unsafe Result GetPhysicalDeviceCooperativeVectorProperties(this NVCooperativeVector thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CooperativeVectorPropertiesNV> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceCooperativeVectorProperties(physicalDevice, pPropertyCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceCooperativeVectorProperties(this NVCooperativeVector thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CooperativeVectorPropertiesNV* pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceCooperativeVectorProperties(physicalDevice, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.CooperativeVectorPropertiesNV);")]
        public static unsafe Result GetPhysicalDeviceCooperativeVectorProperties(this NVCooperativeVector thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CooperativeVectorPropertiesNV> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceCooperativeVectorProperties(physicalDevice, ref pPropertyCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

    }
}

