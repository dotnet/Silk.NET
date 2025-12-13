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
    [Extension("VK_KHR_copy_memory_indirect")]
    public unsafe partial class KhrCopyMemoryIndirect : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_copy_memory_indirect";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyMemoryIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMemoryIndirectInfoKHR* pCopyMemoryIndirectInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryIndirectKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdCopyMemoryIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyMemoryIndirectInfoKHR pCopyMemoryIndirectInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToImageIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyMemoryToImageIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMemoryToImageIndirectInfoKHR* pCopyMemoryToImageIndirectInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToImageIndirectKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdCopyMemoryToImageIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyMemoryToImageIndirectInfoKHR pCopyMemoryToImageIndirectInfo);

        public KhrCopyMemoryIndirect(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

