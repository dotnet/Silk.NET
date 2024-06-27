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
    [Extension("VK_KHR_create_renderpass2")]
    public unsafe partial class KhrCreateRenderpass2 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_create_renderpass2";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBeginRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassBeginInfo* pRenderPassBegin, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBeginRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassBeginInfo* pRenderPassBegin, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SubpassBeginInfo pSubpassBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBeginRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderPassBeginInfo pRenderPassBegin, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdBeginRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderPassBeginInfo pRenderPassBegin, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SubpassBeginInfo pSubpassBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdEndRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdEndRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SubpassEndInfo pSubpassEndInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdNextSubpass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdNextSubpass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SubpassEndInfo pSubpassEndInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdNextSubpass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SubpassBeginInfo pSubpassBeginInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdNextSubpass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SubpassBeginInfo pSubpassBeginInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SubpassEndInfo pSubpassEndInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out RenderPass pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out RenderPass pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderPassCreateInfo2 pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderPassCreateInfo2 pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out RenderPass pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderPassCreateInfo2 pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2KHR", Convention = CallingConvention.Winapi)]
        public partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderPassCreateInfo2 pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out RenderPass pRenderPass);

        public KhrCreateRenderpass2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

