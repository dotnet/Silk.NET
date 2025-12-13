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
    [Extension("VK_KHR_swapchain_maintenance1")]
    public unsafe partial class KhrSwapchainMaintenance1 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_swapchain_maintenance1";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkReleaseSwapchainImagesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ReleaseSwapchainImages([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReleaseSwapchainImagesInfoKHR* pReleaseInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkReleaseSwapchainImagesKHR", Convention = CallingConvention.Winapi)]
        public partial Result ReleaseSwapchainImages([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ReleaseSwapchainImagesInfoKHR pReleaseInfo);

        public KhrSwapchainMaintenance1(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

