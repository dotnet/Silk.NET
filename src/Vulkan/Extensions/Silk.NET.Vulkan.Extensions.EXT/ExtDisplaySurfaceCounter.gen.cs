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
    [Extension("VK_EXT_display_surface_counter")]
    public unsafe partial class ExtDisplaySurfaceCounter : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_display_surface_counter";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfaceCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceCapabilities2EXT* pSurfaceCapabilities);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSurfaceCapabilities = new(StructureType.SurfaceCapabilities2Ext);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2EXT", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceSurfaceCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceCapabilities2EXT pSurfaceCapabilities);

        public ExtDisplaySurfaceCounter(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

