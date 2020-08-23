// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVClipSpaceWScalingOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe void CmdSetViewportWScaling(this NVClipSpaceWScaling thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] ReadOnlySpan<ViewportWScalingNV> pViewportWScalings)
        {
            // SpanOverloader
            thisApi.CmdSetViewportWScaling(commandBuffer, firstViewport, viewportCount, in pViewportWScalings.GetPinnableReference());
        }

    }
}

