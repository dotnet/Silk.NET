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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_video_queue")]
    public unsafe partial class KhrVideoQueue : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_video_queue";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindVideoSessionMemoryKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result BindVideoSessionMemory([Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionKHR videoSession, [Count(Count = 0)] uint bindSessionMemoryInfoCount, [Count(Parameter = "bindSessionMemoryInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BindVideoSessionMemoryInfoKHR* pBindSessionMemoryInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindVideoSessionMemoryKHR", Convention = CallingConvention.Winapi)]
        public partial Result BindVideoSessionMemory([Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionKHR videoSession, [Count(Count = 0)] uint bindSessionMemoryInfoCount, [Count(Parameter = "bindSessionMemoryInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BindVideoSessionMemoryInfoKHR pBindSessionMemoryInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginVideoCodingKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBeginVideoCoding([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoBeginCodingInfoKHR* pBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginVideoCodingKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdBeginVideoCoding([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoBeginCodingInfoKHR pBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdControlVideoCodingKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdControlVideoCoding([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoCodingControlInfoKHR* pCodingControlInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdControlVideoCodingKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdControlVideoCoding([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoCodingControlInfoKHR pCodingControlInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndVideoCodingKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdEndVideoCoding([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEndCodingInfoKHR* pEndCodingInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndVideoCodingKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdEndVideoCoding([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEndCodingInfoKHR pEndCodingInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateVideoSessionKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVideoSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSessionCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoSessionKHR* pVideoSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateVideoSessionKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVideoSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSessionCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoSessionKHR pVideoSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateVideoSessionKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVideoSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSessionCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoSessionKHR* pVideoSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateVideoSessionKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVideoSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSessionCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoSessionKHR pVideoSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateVideoSessionKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVideoSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSessionCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoSessionKHR* pVideoSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateVideoSessionKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVideoSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSessionCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoSessionKHR pVideoSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateVideoSessionKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVideoSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSessionCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoSessionKHR* pVideoSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateVideoSessionKHR", Convention = CallingConvention.Winapi)]
        public partial Result CreateVideoSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSessionCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoSessionKHR pVideoSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSessionParametersCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoSessionParametersKHR* pVideoSessionParameters);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSessionParametersCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoSessionParametersKHR pVideoSessionParameters);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSessionParametersCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoSessionParametersKHR* pVideoSessionParameters);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSessionParametersCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoSessionParametersKHR pVideoSessionParameters);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSessionParametersCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoSessionParametersKHR* pVideoSessionParameters);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSessionParametersCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoSessionParametersKHR pVideoSessionParameters);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSessionParametersCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoSessionParametersKHR* pVideoSessionParameters);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public partial Result CreateVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSessionParametersCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoSessionParametersKHR pVideoSessionParameters);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyVideoSessionKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyVideoSession([Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionKHR videoSession, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyVideoSessionKHR", Convention = CallingConvention.Winapi)]
        public partial void DestroyVideoSession([Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionKHR videoSession, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionParametersKHR videoSessionParameters, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public partial void DestroyVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionParametersKHR videoSessionParameters, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceVideoCapabilitiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceVideoCapabilities([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProfileInfoKHR* pVideoProfile, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoCapabilitiesKHR* pCapabilities);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCapabilities = new(StructureType.VideoCapabilitiesKhr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceVideoCapabilitiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceVideoCapabilities([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProfileInfoKHR* pVideoProfile, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoCapabilitiesKHR pCapabilities);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceVideoCapabilitiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceVideoCapabilities([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProfileInfoKHR pVideoProfile, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoCapabilitiesKHR* pCapabilities);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCapabilities = new(StructureType.VideoCapabilitiesKhr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceVideoCapabilitiesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceVideoCapabilities([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProfileInfoKHR pVideoProfile, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoCapabilitiesKHR pCapabilities);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceVideoFormatPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceVideoFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, [Count(Count = 0)] uint* pVideoFormatPropertyCount, [Count(Parameter = "pVideoFormatPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoFormatPropertiesKHR* pVideoFormatProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pVideoFormatProperties = new(StructureType.VideoFormatPropertiesKhr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceVideoFormatPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceVideoFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, [Count(Count = 0)] uint* pVideoFormatPropertyCount, [Count(Parameter = "pVideoFormatPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoFormatPropertiesKHR pVideoFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceVideoFormatPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceVideoFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, [Count(Count = 0)] ref uint pVideoFormatPropertyCount, [Count(Parameter = "pVideoFormatPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoFormatPropertiesKHR* pVideoFormatProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pVideoFormatProperties = new(StructureType.VideoFormatPropertiesKhr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceVideoFormatPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceVideoFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, [Count(Count = 0)] ref uint pVideoFormatPropertyCount, [Count(Parameter = "pVideoFormatPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoFormatPropertiesKHR pVideoFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceVideoFormatPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceVideoFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo, [Count(Count = 0)] uint* pVideoFormatPropertyCount, [Count(Parameter = "pVideoFormatPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoFormatPropertiesKHR* pVideoFormatProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pVideoFormatProperties = new(StructureType.VideoFormatPropertiesKhr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceVideoFormatPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceVideoFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo, [Count(Count = 0)] uint* pVideoFormatPropertyCount, [Count(Parameter = "pVideoFormatPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoFormatPropertiesKHR pVideoFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceVideoFormatPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceVideoFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo, [Count(Count = 0)] ref uint pVideoFormatPropertyCount, [Count(Parameter = "pVideoFormatPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoFormatPropertiesKHR* pVideoFormatProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pVideoFormatProperties = new(StructureType.VideoFormatPropertiesKhr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceVideoFormatPropertiesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceVideoFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo, [Count(Count = 0)] ref uint pVideoFormatPropertyCount, [Count(Parameter = "pVideoFormatPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoFormatPropertiesKHR pVideoFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetVideoSessionMemoryRequirementsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVideoSessionMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionKHR videoSession, [Count(Count = 0)] uint* pMemoryRequirementsCount, [Count(Parameter = "pMemoryRequirementsCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoSessionMemoryRequirementsKHR* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.VideoSessionMemoryRequirementsKhr);")]
        [NativeApi(EntryPoint = "vkGetVideoSessionMemoryRequirementsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVideoSessionMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionKHR videoSession, [Count(Count = 0)] uint* pMemoryRequirementsCount, [Count(Parameter = "pMemoryRequirementsCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoSessionMemoryRequirementsKHR pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetVideoSessionMemoryRequirementsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVideoSessionMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionKHR videoSession, [Count(Count = 0)] ref uint pMemoryRequirementsCount, [Count(Parameter = "pMemoryRequirementsCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoSessionMemoryRequirementsKHR* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.VideoSessionMemoryRequirementsKhr);")]
        [NativeApi(EntryPoint = "vkGetVideoSessionMemoryRequirementsKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetVideoSessionMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionKHR videoSession, [Count(Count = 0)] ref uint pMemoryRequirementsCount, [Count(Parameter = "pMemoryRequirementsCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoSessionMemoryRequirementsKHR pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUpdateVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UpdateVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionParametersKHR videoSessionParameters, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSessionParametersUpdateInfoKHR* pUpdateInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUpdateVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public partial Result UpdateVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionParametersKHR videoSessionParameters, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSessionParametersUpdateInfoKHR pUpdateInfo);

        /// <summary>To be documented.</summary>
        public unsafe Result BindVideoSessionMemory([Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionKHR videoSession, [Count(Parameter = "bindSessionMemoryInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindVideoSessionMemoryInfoKHR> pBindSessionMemoryInfos)
        {
            // ImplicitCountSpanOverloader
            return BindVideoSessionMemory(device, videoSession, (uint) pBindSessionMemoryInfos.Length, in pBindSessionMemoryInfos.GetPinnableReference());
        }

        public KhrVideoQueue(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

