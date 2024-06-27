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
    [Extension("VK_NV_copy_memory_indirect")]
    public unsafe partial class NVCopyMemoryIndirect : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_copy_memory_indirect";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryIndirectNV", Convention = CallingConvention.Winapi)]
        public partial void CmdCopyMemoryIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ulong copyBufferAddress, [Count(Count = 0)] uint copyCount, [Count(Count = 0)] uint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToImageIndirectNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyMemoryToImageIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ulong copyBufferAddress, [Count(Count = 0)] uint copyCount, [Count(Count = 0)] uint stride, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Parameter = "copyCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresourceLayers* pImageSubresources);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToImageIndirectNV", Convention = CallingConvention.Winapi)]
        public partial void CmdCopyMemoryToImageIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ulong copyBufferAddress, [Count(Count = 0)] uint copyCount, [Count(Count = 0)] uint stride, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Parameter = "copyCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageSubresourceLayers pImageSubresources);

        /// <summary>To be documented.</summary>
        public unsafe void CmdCopyMemoryToImageIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ulong copyBufferAddress, [Count(Count = 0)] uint stride, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Parameter = "copyCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSubresourceLayers> pImageSubresources)
        {
            // ImplicitCountSpanOverloader
            CmdCopyMemoryToImageIndirect(commandBuffer, copyBufferAddress, (uint) pImageSubresources.Length, stride, dstImage, dstImageLayout, in pImageSubresources.GetPinnableReference());
        }

        public NVCopyMemoryIndirect(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

