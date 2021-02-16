// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
        [NativeApi(EntryPoint = "vkCmdBlitImage2KHR")]
        public unsafe partial void CmdBlitImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] BlitImageInfo2KHR* pBlitImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBlitImage2KHR")]
        public partial void CmdBlitImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in BlitImageInfo2KHR pBlitImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBuffer2KHR")]
        public unsafe partial void CmdCopyBuffer2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CopyBufferInfo2KHR* pCopyBufferInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBuffer2KHR")]
        public partial void CmdCopyBuffer2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in CopyBufferInfo2KHR pCopyBufferInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBufferToImage2KHR")]
        public unsafe partial void CmdCopyBufferToImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CopyBufferToImageInfo2KHR* pCopyBufferToImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBufferToImage2KHR")]
        public partial void CmdCopyBufferToImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in CopyBufferToImageInfo2KHR pCopyBufferToImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImage2KHR")]
        public unsafe partial void CmdCopyImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CopyImageInfo2KHR* pCopyImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImage2KHR")]
        public partial void CmdCopyImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in CopyImageInfo2KHR pCopyImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImageToBuffer2KHR")]
        public unsafe partial void CmdCopyImageToBuffer2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CopyImageToBufferInfo2KHR* pCopyImageToBufferInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImageToBuffer2KHR")]
        public partial void CmdCopyImageToBuffer2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in CopyImageToBufferInfo2KHR pCopyImageToBufferInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdResolveImage2KHR")]
        public unsafe partial void CmdResolveImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ResolveImageInfo2KHR* pResolveImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdResolveImage2KHR")]
        public partial void CmdResolveImage2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in ResolveImageInfo2KHR pResolveImageInfo);

        public KhrCopyCommands2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

