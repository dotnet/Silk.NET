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
    [Extension("VK_KHR_get_surface_capabilities2")]
    public unsafe partial class KhrGetSurfaceCapabilities2 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_get_surface_capabilities2";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfaceCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceCapabilities2KHR* pSurfaceCapabilities);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSurfaceCapabilities = new(StructureType.SurfaceCapabilities2Khr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfaceCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceCapabilities2KHR pSurfaceCapabilities);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfaceCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceCapabilities2KHR* pSurfaceCapabilities);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSurfaceCapabilities = new(StructureType.SurfaceCapabilities2Khr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2KHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceSurfaceCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceCapabilities2KHR pSurfaceCapabilities);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfaceFormats2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] uint* pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceFormat2KHR* pSurfaceFormats);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSurfaceFormats = new(StructureType.SurfaceFormat2Khr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfaceFormats2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] uint* pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceFormat2KHR pSurfaceFormats);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfaceFormats2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] ref uint pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceFormat2KHR* pSurfaceFormats);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSurfaceFormats = new(StructureType.SurfaceFormat2Khr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfaceFormats2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] ref uint pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceFormat2KHR pSurfaceFormats);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfaceFormats2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0)] uint* pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceFormat2KHR* pSurfaceFormats);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSurfaceFormats = new(StructureType.SurfaceFormat2Khr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfaceFormats2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0)] uint* pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceFormat2KHR pSurfaceFormats);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfaceFormats2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0)] ref uint pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceFormat2KHR* pSurfaceFormats);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSurfaceFormats = new(StructureType.SurfaceFormat2Khr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceSurfaceFormats2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0)] ref uint pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceFormat2KHR pSurfaceFormats);

        public KhrGetSurfaceCapabilities2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

