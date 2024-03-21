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
    [Extension("VK_NV_optical_flow")]
    public unsafe partial class NVOpticalFlow : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_optical_flow";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindOpticalFlowSessionImageNV", Convention = CallingConvention.Winapi)]
        public partial Result BindOpticalFlowSessionImage([Count(Count = 0)] Device device, [Count(Count = 0)] OpticalFlowSessionNV session, [Count(Count = 0)] OpticalFlowSessionBindingPointNV bindingPoint, [Count(Count = 0)] ImageView view, [Count(Count = 0)] ImageLayout layout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdOpticalFlowExecuteNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdOpticalFlowExecute([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] OpticalFlowSessionNV session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] OpticalFlowExecuteInfoNV* pExecuteInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdOpticalFlowExecuteNV", Convention = CallingConvention.Winapi)]
        public partial void CmdOpticalFlowExecute([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] OpticalFlowSessionNV session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in OpticalFlowExecuteInfoNV pExecuteInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateOpticalFlowSessionNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateOpticalFlowSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] OpticalFlowSessionCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] OpticalFlowSessionNV* pSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateOpticalFlowSessionNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateOpticalFlowSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] OpticalFlowSessionCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out OpticalFlowSessionNV pSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateOpticalFlowSessionNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateOpticalFlowSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] OpticalFlowSessionCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] OpticalFlowSessionNV* pSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateOpticalFlowSessionNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateOpticalFlowSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] OpticalFlowSessionCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out OpticalFlowSessionNV pSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateOpticalFlowSessionNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateOpticalFlowSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in OpticalFlowSessionCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] OpticalFlowSessionNV* pSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateOpticalFlowSessionNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateOpticalFlowSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in OpticalFlowSessionCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out OpticalFlowSessionNV pSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateOpticalFlowSessionNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateOpticalFlowSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in OpticalFlowSessionCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] OpticalFlowSessionNV* pSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateOpticalFlowSessionNV", Convention = CallingConvention.Winapi)]
        public partial Result CreateOpticalFlowSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in OpticalFlowSessionCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out OpticalFlowSessionNV pSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyOpticalFlowSessionNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyOpticalFlowSession([Count(Count = 0)] Device device, [Count(Count = 0)] OpticalFlowSessionNV session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyOpticalFlowSessionNV", Convention = CallingConvention.Winapi)]
        public partial void DestroyOpticalFlowSession([Count(Count = 0)] Device device, [Count(Count = 0)] OpticalFlowSessionNV session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceOpticalFlowImageFormatsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceOpticalFlowImageFormats([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] OpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, [Count(Count = 0)] uint* pFormatCount, [Count(Parameter = "pFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] OpticalFlowImageFormatPropertiesNV* pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pImageFormatProperties = new(StructureType.OpticalFlowImageFormatPropertiesNV);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceOpticalFlowImageFormatsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceOpticalFlowImageFormats([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] OpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, [Count(Count = 0)] uint* pFormatCount, [Count(Parameter = "pFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out OpticalFlowImageFormatPropertiesNV pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceOpticalFlowImageFormatsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceOpticalFlowImageFormats([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] OpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, [Count(Count = 0)] ref uint pFormatCount, [Count(Parameter = "pFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] OpticalFlowImageFormatPropertiesNV* pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pImageFormatProperties = new(StructureType.OpticalFlowImageFormatPropertiesNV);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceOpticalFlowImageFormatsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceOpticalFlowImageFormats([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] OpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, [Count(Count = 0)] ref uint pFormatCount, [Count(Parameter = "pFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out OpticalFlowImageFormatPropertiesNV pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceOpticalFlowImageFormatsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceOpticalFlowImageFormats([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in OpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, [Count(Count = 0)] uint* pFormatCount, [Count(Parameter = "pFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] OpticalFlowImageFormatPropertiesNV* pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pImageFormatProperties = new(StructureType.OpticalFlowImageFormatPropertiesNV);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceOpticalFlowImageFormatsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceOpticalFlowImageFormats([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in OpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, [Count(Count = 0)] uint* pFormatCount, [Count(Parameter = "pFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out OpticalFlowImageFormatPropertiesNV pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceOpticalFlowImageFormatsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceOpticalFlowImageFormats([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in OpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, [Count(Count = 0)] ref uint pFormatCount, [Count(Parameter = "pFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] OpticalFlowImageFormatPropertiesNV* pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pImageFormatProperties = new(StructureType.OpticalFlowImageFormatPropertiesNV);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceOpticalFlowImageFormatsNV", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceOpticalFlowImageFormats([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in OpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, [Count(Count = 0)] ref uint pFormatCount, [Count(Parameter = "pFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out OpticalFlowImageFormatPropertiesNV pImageFormatProperties);

        public NVOpticalFlow(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

