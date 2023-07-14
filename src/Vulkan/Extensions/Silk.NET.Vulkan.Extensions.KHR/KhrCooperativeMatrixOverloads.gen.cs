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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrCooperativeMatrixOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.CooperativeMatrixPropertiesKhr);")]
        public static unsafe Result GetPhysicalDeviceCooperativeMatrixProperties(this KhrCooperativeMatrix thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CooperativeMatrixPropertiesKHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceCooperativeMatrixProperties(physicalDevice, pPropertyCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceCooperativeMatrixProperties(this KhrCooperativeMatrix thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CooperativeMatrixPropertiesKHR* pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceCooperativeMatrixProperties(physicalDevice, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.CooperativeMatrixPropertiesKhr);")]
        public static unsafe Result GetPhysicalDeviceCooperativeMatrixProperties(this KhrCooperativeMatrix thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CooperativeMatrixPropertiesKHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceCooperativeMatrixProperties(physicalDevice, ref pPropertyCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

    }
}

