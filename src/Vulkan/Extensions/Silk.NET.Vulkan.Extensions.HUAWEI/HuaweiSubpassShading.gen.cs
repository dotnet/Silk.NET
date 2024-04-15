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

namespace Silk.NET.Vulkan.Extensions.HUAWEI
{
    [Extension("VK_HUAWEI_subpass_shading")]
    public unsafe partial class HuaweiSubpassShading : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_HUAWEI_subpass_shading";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSubpassShadingHUAWEI", Convention = CallingConvention.Winapi)]
        public partial void CmdSubpassShadingHuawei([Count(Count = 0)] CommandBuffer commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDeviceSubpassShadingMaxWorkgroupSizeHuawei([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderpass, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Extent2D* pMaxWorkgroupSize);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI", Convention = CallingConvention.Winapi)]
        public partial Result GetDeviceSubpassShadingMaxWorkgroupSizeHuawei([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderpass, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Extent2D pMaxWorkgroupSize);

        public HuaweiSubpassShading(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

