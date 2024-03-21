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
    [Extension("VK_NV_clip_space_w_scaling")]
    public unsafe partial class NVClipSpaceWScaling : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_clip_space_w_scaling";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportWScalingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetViewportWScaling([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewportWScalingNV* pViewportWScalings);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportWScalingNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetViewportWScaling([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ViewportWScalingNV pViewportWScalings);

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetViewportWScaling([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ViewportWScalingNV> pViewportWScalings)
        {
            // ImplicitCountSpanOverloader
            CmdSetViewportWScaling(commandBuffer, firstViewport, (uint) pViewportWScalings.Length, in pViewportWScalings.GetPinnableReference());
        }

        public NVClipSpaceWScaling(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

