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

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_scissor_exclusive")]
    public unsafe partial class NVScissorExclusive : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_scissor_exclusive";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetExclusiveScissorNV")]
        public unsafe partial void CmdSetExclusiveScissor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstExclusiveScissor, [Count(Count = 0)] uint exclusiveScissorCount, [Count(Computed = "exclusiveScissorCount"), Flow(FlowDirection.In)] Rect2D* pExclusiveScissors);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetExclusiveScissorNV")]
        public partial void CmdSetExclusiveScissor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstExclusiveScissor, [Count(Count = 0)] uint exclusiveScissorCount, [Count(Computed = "exclusiveScissorCount"), Flow(FlowDirection.In)] in Rect2D pExclusiveScissors);

        public NVScissorExclusive(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

