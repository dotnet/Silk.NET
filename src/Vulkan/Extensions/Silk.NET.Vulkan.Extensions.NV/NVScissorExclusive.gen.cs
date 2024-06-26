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
    [Extension("VK_NV_scissor_exclusive")]
    public unsafe partial class NVScissorExclusive : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_scissor_exclusive";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetExclusiveScissorNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetExclusiveScissor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstExclusiveScissor, [Count(Count = 0)] uint exclusiveScissorCount, [Count(Parameter = "exclusiveScissorCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Rect2D* pExclusiveScissors);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetExclusiveScissorNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetExclusiveScissor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstExclusiveScissor, [Count(Count = 0)] uint exclusiveScissorCount, [Count(Parameter = "exclusiveScissorCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Rect2D pExclusiveScissors);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetExclusiveScissorEnableNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetExclusiveScissorEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstExclusiveScissor, [Count(Count = 0)] uint exclusiveScissorCount, [Count(Parameter = "exclusiveScissorCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Bool32* pExclusiveScissorEnables);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetExclusiveScissorEnableNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetExclusiveScissorEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstExclusiveScissor, [Count(Count = 0)] uint exclusiveScissorCount, [Count(Parameter = "exclusiveScissorCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Bool32 pExclusiveScissorEnables);

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetExclusiveScissor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstExclusiveScissor, [Count(Parameter = "exclusiveScissorCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Rect2D> pExclusiveScissors)
        {
            // ImplicitCountSpanOverloader
            CmdSetExclusiveScissor(commandBuffer, firstExclusiveScissor, (uint) pExclusiveScissors.Length, in pExclusiveScissors.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetExclusiveScissorEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstExclusiveScissor, [Count(Parameter = "exclusiveScissorCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Bool32> pExclusiveScissorEnables)
        {
            // ImplicitCountSpanOverloader
            CmdSetExclusiveScissorEnable(commandBuffer, firstExclusiveScissor, (uint) pExclusiveScissorEnables.Length, in pExclusiveScissorEnables.GetPinnableReference());
        }

        public NVScissorExclusive(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

