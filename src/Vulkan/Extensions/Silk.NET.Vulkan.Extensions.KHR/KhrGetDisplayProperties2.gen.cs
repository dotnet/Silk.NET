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
    [Extension("VK_KHR_get_display_properties2")]
    public unsafe partial class KhrGetDisplayProperties2 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_get_display_properties2";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayModeProperties2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDisplayModeProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayModeProperties2KHR* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DisplayModeProperties2Khr);")]
        [NativeApi(EntryPoint = "vkGetDisplayModeProperties2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDisplayModeProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayModeProperties2KHR pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayModeProperties2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDisplayModeProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayModeProperties2KHR* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DisplayModeProperties2Khr);")]
        [NativeApi(EntryPoint = "vkGetDisplayModeProperties2KHR", Convention = CallingConvention.Winapi)]
        public partial Result GetDisplayModeProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayModeProperties2KHR pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayPlaneCapabilities2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDisplayPlaneCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayPlaneInfo2KHR* pDisplayPlaneInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayPlaneCapabilities2KHR* pCapabilities);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCapabilities = new(StructureType.DisplayPlaneCapabilities2Khr);")]
        [NativeApi(EntryPoint = "vkGetDisplayPlaneCapabilities2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDisplayPlaneCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayPlaneInfo2KHR* pDisplayPlaneInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayPlaneCapabilities2KHR pCapabilities);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayPlaneCapabilities2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDisplayPlaneCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DisplayPlaneInfo2KHR pDisplayPlaneInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayPlaneCapabilities2KHR* pCapabilities);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCapabilities = new(StructureType.DisplayPlaneCapabilities2Khr);")]
        [NativeApi(EntryPoint = "vkGetDisplayPlaneCapabilities2KHR", Convention = CallingConvention.Winapi)]
        public partial Result GetDisplayPlaneCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DisplayPlaneInfo2KHR pDisplayPlaneInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayPlaneCapabilities2KHR pCapabilities);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPlaneProperties2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceDisplayPlaneProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayPlaneProperties2KHR* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DisplayPlaneProperties2Khr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPlaneProperties2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceDisplayPlaneProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayPlaneProperties2KHR pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPlaneProperties2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceDisplayPlaneProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayPlaneProperties2KHR* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DisplayPlaneProperties2Khr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPlaneProperties2KHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceDisplayPlaneProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayPlaneProperties2KHR pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayProperties2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceDisplayProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayProperties2KHR* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DisplayProperties2Khr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayProperties2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceDisplayProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayProperties2KHR pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayProperties2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceDisplayProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayProperties2KHR* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DisplayProperties2Khr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayProperties2KHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceDisplayProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayProperties2KHR pProperties);

        public KhrGetDisplayProperties2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

