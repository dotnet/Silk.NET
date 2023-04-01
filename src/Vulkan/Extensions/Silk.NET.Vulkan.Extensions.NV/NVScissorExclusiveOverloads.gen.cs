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

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVScissorExclusiveOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetExclusiveScissor(this NVScissorExclusive thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstExclusiveScissor, [Count(Count = 0)] uint exclusiveScissorCount, [Count(Parameter = "exclusiveScissorCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Rect2D> pExclusiveScissors)
        {
            // SpanOverloader
            thisApi.CmdSetExclusiveScissor(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, in pExclusiveScissors.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetExclusiveScissorEnable(this NVScissorExclusive thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstExclusiveScissor, [Count(Count = 0)] uint exclusiveScissorCount, [Count(Parameter = "exclusiveScissorCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Bool32> pExclusiveScissorEnables)
        {
            // SpanOverloader
            thisApi.CmdSetExclusiveScissorEnable(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, in pExclusiveScissorEnables.GetPinnableReference());
        }

    }
}

