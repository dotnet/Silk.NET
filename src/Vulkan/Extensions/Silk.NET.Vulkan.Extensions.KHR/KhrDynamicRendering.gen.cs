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
    [Extension("VK_KHR_dynamic_rendering")]
    public unsafe partial class KhrDynamicRendering : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_dynamic_rendering";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderingKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBeginRendering([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderingInfo* pRenderingInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderingKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdBeginRendering([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderingInfo pRenderingInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderingKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdEndRendering([Count(Count = 0)] CommandBuffer commandBuffer);

        public KhrDynamicRendering(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

