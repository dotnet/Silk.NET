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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_low_latency2")]
    public unsafe partial class NVLowLatency2 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_low_latency2";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetLatencyTimingsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLatencyTiming([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] GetLatencyMarkerInfoNV* pLatencyMarkerInfo);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLatencyMarkerInfo = new(StructureType.GetLatencyMarkerInfoNV);")]
        [NativeApi(EntryPoint = "vkGetLatencyTimingsNV", Convention = CallingConvention.Winapi)]
        public partial void GetLatencyTiming([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out GetLatencyMarkerInfoNV pLatencyMarkerInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkLatencySleepNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LatencySleep([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] LatencySleepInfoNV* pSleepInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkLatencySleepNV", Convention = CallingConvention.Winapi)]
        public partial Result LatencySleep([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in LatencySleepInfoNV pSleepInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueNotifyOutOfBandNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void QueueNotifyOutOfBan([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] OutOfBandQueueTypeInfoNV* pQueueTypeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueNotifyOutOfBandNV", Convention = CallingConvention.Winapi)]
        public partial void QueueNotifyOutOfBan([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in OutOfBandQueueTypeInfoNV pQueueTypeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetLatencyMarkerNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetLatencyMarker([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SetLatencyMarkerInfoNV* pLatencyMarkerInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetLatencyMarkerNV", Convention = CallingConvention.Winapi)]
        public partial void SetLatencyMarker([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SetLatencyMarkerInfoNV pLatencyMarkerInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetLatencySleepModeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SetLatencySleepMode([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] LatencySleepModeInfoNV* pSleepModeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetLatencySleepModeNV", Convention = CallingConvention.Winapi)]
        public partial Result SetLatencySleepMode([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in LatencySleepModeInfoNV pSleepModeInfo);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLatencyMarkerInfo = new(StructureType.GetLatencyMarkerInfoNV);")]
        public unsafe GetLatencyMarkerInfoNV GetLatencyTiming([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain)
        {
            // NonKhrReturnTypeOverloader
            GetLatencyTiming(device, swapchain, out GetLatencyMarkerInfoNV silkRet);
            return silkRet;
        }

        public NVLowLatency2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

