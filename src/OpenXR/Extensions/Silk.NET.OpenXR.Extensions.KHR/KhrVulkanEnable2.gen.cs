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
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_vulkan_enable2")]
    public unsafe partial class KhrVulkanEnable2 : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_vulkan_enable2";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanDeviceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVulkanDevice([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VulkanDeviceCreateInfoKHR* createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanDevice, [Count(Count = 0)] uint* vulkanResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanDeviceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVulkanDevice([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VulkanDeviceCreateInfoKHR* createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanDevice, [Count(Count = 0)] ref uint vulkanResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanDeviceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVulkanDevice([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VulkanDeviceCreateInfoKHR* createInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanDevice, [Count(Count = 0)] uint* vulkanResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanDeviceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVulkanDevice([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VulkanDeviceCreateInfoKHR* createInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanDevice, [Count(Count = 0)] ref uint vulkanResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanDeviceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVulkanDevice([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VulkanDeviceCreateInfoKHR createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanDevice, [Count(Count = 0)] uint* vulkanResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanDeviceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVulkanDevice([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VulkanDeviceCreateInfoKHR createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanDevice, [Count(Count = 0)] ref uint vulkanResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanDeviceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVulkanDevice([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VulkanDeviceCreateInfoKHR createInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanDevice, [Count(Count = 0)] uint* vulkanResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanDeviceKHR", Convention = CallingConvention.Winapi)]
        public partial Result CreateVulkanDevice([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VulkanDeviceCreateInfoKHR createInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanDevice, [Count(Count = 0)] ref uint vulkanResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanInstanceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVulkanInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VulkanInstanceCreateInfoKHR* createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanInstance, [Count(Count = 0)] uint* vulkanResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanInstanceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVulkanInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VulkanInstanceCreateInfoKHR* createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanInstance, [Count(Count = 0)] ref uint vulkanResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanInstanceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVulkanInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VulkanInstanceCreateInfoKHR* createInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanInstance, [Count(Count = 0)] uint* vulkanResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanInstanceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVulkanInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VulkanInstanceCreateInfoKHR* createInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanInstance, [Count(Count = 0)] ref uint vulkanResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanInstanceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVulkanInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VulkanInstanceCreateInfoKHR createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanInstance, [Count(Count = 0)] uint* vulkanResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanInstanceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVulkanInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VulkanInstanceCreateInfoKHR createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanInstance, [Count(Count = 0)] ref uint vulkanResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanInstanceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVulkanInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VulkanInstanceCreateInfoKHR createInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanInstance, [Count(Count = 0)] uint* vulkanResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanInstanceKHR", Convention = CallingConvention.Winapi)]
        public partial Result CreateVulkanInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VulkanInstanceCreateInfoKHR createInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanInstance, [Count(Count = 0)] ref uint vulkanResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsDevice2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVulkanGraphicsDevice2([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VulkanGraphicsDeviceGetInfoKHR* getInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanPhysicalDevice);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsDevice2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVulkanGraphicsDevice2([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VulkanGraphicsDeviceGetInfoKHR* getInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanPhysicalDevice);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsDevice2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVulkanGraphicsDevice2([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VulkanGraphicsDeviceGetInfoKHR getInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanPhysicalDevice);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsDevice2KHR", Convention = CallingConvention.Winapi)]
        public partial Result GetVulkanGraphicsDevice2([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VulkanGraphicsDeviceGetInfoKHR getInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanPhysicalDevice);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsRequirements2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVulkanGraphicsRequirements2([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] GraphicsRequirementsVulkanKHR* graphicsRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsRequirements2KHR", Convention = CallingConvention.Winapi)]
        public partial Result GetVulkanGraphicsRequirements2([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref GraphicsRequirementsVulkanKHR graphicsRequirements);

        public KhrVulkanEnable2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

