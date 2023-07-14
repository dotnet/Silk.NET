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
    public static class ExtDeviceFaultOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pFaultInfo = new(StructureType.DeviceFaultInfoExt);")]
        public static unsafe Result GetDeviceFaultInfo(this ExtDeviceFault thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeviceFaultCountsEXT* pFaultCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DeviceFaultInfoEXT> pFaultInfo)
        {
            // SpanOverloader
            return thisApi.GetDeviceFaultInfo(device, pFaultCounts, out pFaultInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDeviceFaultInfo(this ExtDeviceFault thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Span<DeviceFaultCountsEXT> pFaultCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DeviceFaultInfoEXT* pFaultInfo)
        {
            // SpanOverloader
            return thisApi.GetDeviceFaultInfo(device, ref pFaultCounts.GetPinnableReference(), pFaultInfo);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pFaultInfo = new(StructureType.DeviceFaultInfoExt);")]
        public static unsafe Result GetDeviceFaultInfo(this ExtDeviceFault thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Span<DeviceFaultCountsEXT> pFaultCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DeviceFaultInfoEXT> pFaultInfo)
        {
            // SpanOverloader
            return thisApi.GetDeviceFaultInfo(device, ref pFaultCounts.GetPinnableReference(), out pFaultInfo.GetPinnableReference());
        }

    }
}

