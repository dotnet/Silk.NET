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
    [Extension("VK_NV_clip_space_w_scaling")]
    public abstract unsafe partial class NVClipSpaceWScaling : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdSetViewportWScalingNV")]
        public abstract unsafe void CmdSetViewportWScaling([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] ViewportWScalingNV* pViewportWScalings);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdSetViewportWScalingNV")]
        public abstract void CmdSetViewportWScaling([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] ref ViewportWScalingNV pViewportWScalings);

        public NVClipSpaceWScaling(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

