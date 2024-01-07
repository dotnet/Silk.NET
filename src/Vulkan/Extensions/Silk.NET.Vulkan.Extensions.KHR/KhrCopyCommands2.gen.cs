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
    [Extension("VK_KHR_copy_commands2")]
    public unsafe partial class KhrCopyCommands2 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_copy_commands2";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBlitImage2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBlitImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BlitImageInfo2* pBlitImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBlitImage2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdBlitImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlitImageInfo2 pBlitImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBuffer2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyBuffer2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyBufferInfo2* pCopyBufferInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBuffer2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdCopyBuffer2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyBufferInfo2 pCopyBufferInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBufferToImage2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyBufferToImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyBufferToImageInfo2* pCopyBufferToImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBufferToImage2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdCopyBufferToImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyBufferToImageInfo2 pCopyBufferToImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImage2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyImageInfo2* pCopyImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImage2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdCopyImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyImageInfo2 pCopyImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImageToBuffer2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyImageToBuffer2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyImageToBufferInfo2* pCopyImageToBufferInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImageToBuffer2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdCopyImageToBuffer2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyImageToBufferInfo2 pCopyImageToBufferInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdResolveImage2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdResolveImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ResolveImageInfo2* pResolveImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdResolveImage2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdResolveImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResolveImageInfo2 pResolveImageInfo);

        public KhrCopyCommands2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

