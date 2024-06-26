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
    [Extension("VK_EXT_swapchain_maintenance1")]
    public unsafe partial class ExtSwapchainMaintenance1 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_swapchain_maintenance1";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkReleaseSwapchainImagesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ReleaseSwapchainImages([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReleaseSwapchainImagesInfoEXT* pReleaseInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkReleaseSwapchainImagesEXT", Convention = CallingConvention.Winapi)]
        public partial Result ReleaseSwapchainImages([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReleaseSwapchainImagesInfoEXT pReleaseInfo);

        public ExtSwapchainMaintenance1(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

