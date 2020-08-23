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
    public static class NVScissorExclusiveOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe void CmdSetExclusiveScissor(this NVScissorExclusive thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstExclusiveScissor, [Count(Count = 0)] uint exclusiveScissorCount, [Count(Computed = "exclusiveScissorCount"), Flow(FlowDirection.In)] ReadOnlySpan<Rect2D> pExclusiveScissors)
        {
            // SpanOverloader
            thisApi.CmdSetExclusiveScissor(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, in pExclusiveScissors.GetPinnableReference());
        }

    }
}

