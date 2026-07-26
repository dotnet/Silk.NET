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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_present_timing")]
    public unsafe partial class ExtPresentTiming : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_present_timing";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPastPresentationTimingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPastPresentationTiming([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PastPresentationTimingInfoEXT* pPastPresentationTimingInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PastPresentationTimingPropertiesEXT* pPastPresentationTimingProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pPastPresentationTimingProperties = new(StructureType.PastPresentationTimingPropertiesExt);")]
        [NativeApi(EntryPoint = "vkGetPastPresentationTimingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPastPresentationTiming([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PastPresentationTimingInfoEXT* pPastPresentationTimingInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PastPresentationTimingPropertiesEXT pPastPresentationTimingProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPastPresentationTimingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPastPresentationTiming([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PastPresentationTimingInfoEXT pPastPresentationTimingInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PastPresentationTimingPropertiesEXT* pPastPresentationTimingProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pPastPresentationTimingProperties = new(StructureType.PastPresentationTimingPropertiesExt);")]
        [NativeApi(EntryPoint = "vkGetPastPresentationTimingEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetPastPresentationTiming([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PastPresentationTimingInfoEXT pPastPresentationTimingInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PastPresentationTimingPropertiesEXT pPastPresentationTimingProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainTimeDomainPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSwapchainTimeDomainProperties([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] SwapchainTimeDomainPropertiesEXT* pSwapchainTimeDomainProperties, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pTimeDomainsCounter);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainTimeDomainPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSwapchainTimeDomainProperties([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] SwapchainTimeDomainPropertiesEXT* pSwapchainTimeDomainProperties, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong pTimeDomainsCounter);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainTimeDomainPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSwapchainTimeDomainProperties([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ref SwapchainTimeDomainPropertiesEXT pSwapchainTimeDomainProperties, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pTimeDomainsCounter);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainTimeDomainPropertiesEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetSwapchainTimeDomainProperties([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ref SwapchainTimeDomainPropertiesEXT pSwapchainTimeDomainProperties, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong pTimeDomainsCounter);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainTimingPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSwapchainTimingProperties([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] SwapchainTimingPropertiesEXT* pSwapchainTimingProperties, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pSwapchainTimingPropertiesCounter);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainTimingPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSwapchainTimingProperties([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] SwapchainTimingPropertiesEXT* pSwapchainTimingProperties, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong pSwapchainTimingPropertiesCounter);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainTimingPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSwapchainTimingProperties([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ref SwapchainTimingPropertiesEXT pSwapchainTimingProperties, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pSwapchainTimingPropertiesCounter);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainTimingPropertiesEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetSwapchainTimingProperties([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ref SwapchainTimingPropertiesEXT pSwapchainTimingProperties, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong pSwapchainTimingPropertiesCounter);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetSwapchainPresentTimingQueueSizeEXT", Convention = CallingConvention.Winapi)]
        public partial Result SetSwapchainPresentTimingQueueSize([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] uint size);

        public ExtPresentTiming(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

