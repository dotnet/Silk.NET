// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_scissor_exclusive")]
    public abstract unsafe partial class NVScissorExclusive : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdSetExclusiveScissorNV")]
        public abstract unsafe void CmdSetExclusiveScissor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstExclusiveScissor, [Count(Count = 0)] uint exclusiveScissorCount, [Count(Computed = "exclusiveScissorCount"), Flow(FlowDirection.In)] Rect2D* pExclusiveScissors);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdSetExclusiveScissorNV")]
        public abstract void CmdSetExclusiveScissor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstExclusiveScissor, [Count(Count = 0)] uint exclusiveScissorCount, [Count(Computed = "exclusiveScissorCount"), Flow(FlowDirection.In)] ref Rect2D pExclusiveScissors);

        public NVScissorExclusive(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

