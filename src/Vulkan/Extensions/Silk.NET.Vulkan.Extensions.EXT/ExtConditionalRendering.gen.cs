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
    [Extension("VK_EXT_conditional_rendering")]
    public unsafe partial class ExtConditionalRendering : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_conditional_rendering";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginConditionalRenderingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBeginConditionalRendering([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginConditionalRenderingEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdBeginConditionalRendering([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ConditionalRenderingBeginInfoEXT pConditionalRenderingBegin);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndConditionalRenderingEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdEndConditionalRendering([Count(Count = 0)] CommandBuffer commandBuffer);

        public ExtConditionalRendering(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

